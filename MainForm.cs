using System;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SerialPortTest
{
    public partial class MainForm : Form
    {
        SerialPort senderPort = new SerialPort();
        SerialPort receiverPort = new SerialPort();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxPorts.Items.AddRange(SerialPort.GetPortNames());
            receiverPorts.Items.AddRange(SerialPort.GetPortNames());

            if (comboBoxPorts.Items.Count == 0 || receiverPorts.Items.Count == 0)
                MessageBox.Show("No serial ports found.");

            cmbReadMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReadMethod.Items.AddRange(new string[] { "ReadByte", "ReadChar", "ReadExisting", "ReadLine" });

            cmbWriteMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWriteMethod.Items.AddRange(new string[] { "Write", "WriteLine", "WriteCharArray", "WriteByteArray" });
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPorts.SelectedItem == null)
                {
                    MessageBox.Show("Please select a COM port.");
                    return;
                }

                if (!senderPort.IsOpen)
                {
                    senderPort.PortName = comboBoxPorts.SelectedItem.ToString();
                    senderPort.Open();
                    btnOpen.Text = "Close";
                    comboBoxPorts.Enabled = false;
                }
                else
                {
                    senderPort.Close();
                    btnOpen.Text = "Open";
                    comboBoxPorts.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening sender port: " + ex.Message);
            }
        }

        private void btnOpenReceiver_Click(object sender, EventArgs e)
        {
            try
            {
                if (receiverPorts.SelectedItem == null)
                {
                    MessageBox.Show("Please select a COM port.");
                    return;
                }

                if (!receiverPort.IsOpen)
                {
                    receiverPort.PortName = receiverPorts.SelectedItem.ToString();
                    receiverPort.DataReceived -= ReceiverPort_DataReceived;
                    receiverPort.DataReceived += ReceiverPort_DataReceived;
                    receiverPort.Open();
                    btnOpenReceiver.Text = "Close";
                    receiverPorts.Enabled = false;
                }
                else
                {
                    receiverPort.Close();
                    btnOpenReceiver.Text = "Open";
                    receiverPorts.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening receiver port: " + ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!senderPort.IsOpen)
            {
                MessageBox.Show("Sender port is not open.");
                return;
            }

            try
            {
                string text = txtSend.Text;
                int offset = int.TryParse(txtOffset.Text, out int o) ? o : 0;
                int count = int.TryParse(txtCount.Text, out int c) ? c : 0;

                switch (cmbWriteMethod.SelectedItem?.ToString())
                {
                    case "Write":
                        senderPort.Write(text);
                        break;

                    case "WriteLine":
                        senderPort.WriteLine(text);
                        break;

                    case "WriteCharArray":
                        char[] chars = text.ToCharArray();
                        if (offset < 0 || count <= 0 || offset + count > chars.Length)
                        {
                            MessageBox.Show("Invalid offset or count for char array.");
                            return;
                        }
                        senderPort.Write(chars, offset, count);
                        break;

                    case "WriteByteArray":
                        byte[] bytes = Encoding.ASCII.GetBytes(text);
                        if (offset < 0 || count <= 0 || offset + count > bytes.Length)
                        {
                            MessageBox.Show("Invalid offset or count for byte array.");
                            return;
                        }
                        senderPort.Write(bytes, offset, count);
                        break;

                    default:
                        MessageBox.Show("Please select a write method.");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending data: " + ex.Message);
            }
        }

        private void ReceiverPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                string data = "";

                if (cmbReadMethod.SelectedItem == null)
                {
                    data = "[Error] No read method selected.";
                }
                else
                {
                    try
                    {
                        switch (cmbReadMethod.SelectedItem.ToString())
                        {
                            case "ReadByte":
                                if (receiverPort.BytesToRead > 0)
                                {
                                    int byteValue = receiverPort.ReadByte();
                                    if (byteValue == 13 || byteValue == 10) return;
                                    data = $"[Byte] {byteValue} (char: {(char)byteValue})";
                                }
                                break;

                            case "ReadChar":
                                if (receiverPort.BytesToRead > 0)
                                {
                                    int charValue = receiverPort.ReadChar();
                                    if (charValue == 13 || charValue == 10) return;
                                    data = $"[Char] {(char)charValue}";
                                }
                                break;

                            case "ReadExisting":
                                data = "[Existing] " + receiverPort.ReadExisting();
                                break;

                            case "ReadLine":
                                data = "[Line] " + receiverPort.ReadLine();
                                break;
                        }

                        txtReceived.AppendText(data + Environment.NewLine);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error receiving data: " + ex.Message);
                    }
                }
            }));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtReceived.Clear();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (senderPort.IsOpen)
            {
                Settings settings = new Settings();
                if (settings.ShowDialog() == DialogResult.OK)
                {
                    senderPort.BaudRate = settings.SelectedBaudRate;
                    senderPort.DataBits = settings.SelectedDataBits;
                    senderPort.Parity = settings.SelectedParity;
                    senderPort.StopBits = settings.SelectedStopBits;
                    senderPort.Handshake = settings.SelectedHandshake;

                    MessageBox.Show("Settings applied.");
                }
            }
            else
            {
                MessageBox.Show("Open Sending Port.");
            }
        }
    }
}
