using System;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace SerialPortTest
{
    public partial class MainForm : Form
    {
        SerialPort serialPort = new SerialPort();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxPorts.Items.AddRange(SerialPort.GetPortNames());
            receiverPorts.Items.AddRange(SerialPort.GetPortNames());

            //comboBoxPorts.SelectedIndex = comboBoxPorts.Items.Count > 0 ? 0 : -1;
            //receiverPorts.SelectedIndex = receiverPorts.Items.Count > 0 ? 0 : -1;

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

                if (!serialPort.IsOpen)
                {
                    serialPort.PortName = comboBoxPorts.SelectedItem.ToString();
                    serialPort.DataReceived -= SerialPort_DataReceived;
                    serialPort.DataReceived += SerialPort_DataReceived;
                    serialPort.Open();
                    btnOpen.Text = "Close";
                    comboBoxPorts.Enabled = false;
                }
                else
                {
                    serialPort.Close();
                    btnOpen.Text = "Open";
                    comboBoxPorts.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening port: " + ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("Port is not open.");
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
                        serialPort.Write(text);
                        break;

                    case "WriteLine":
                        serialPort.WriteLine(text);
                        break;

                    case "WriteCharArray":
                        char[] chars = text.ToCharArray();
                        if (offset < 0 || count <= 0 || offset + count > chars.Length)
                        {
                            MessageBox.Show("Invalid offset or count for char array.");
                            return;
                        }
                        serialPort.Write(chars, offset, count);
                        break;

                    case "WriteByteArray":
                        byte[] bytes = Encoding.ASCII.GetBytes(text);
                        if (offset < 0 || count <= 0 || offset + count > bytes.Length)
                        {
                            MessageBox.Show("Invalid offset or count for byte array.");
                            return;
                        }
                        serialPort.Write(bytes, offset, count);
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

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
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
                                if (serialPort.BytesToRead > 0)
                                {
                                    int byteValue = serialPort.ReadByte();
                                    if (byteValue == 13 || byteValue == 10) return;
                                    data = $"[Byte] {byteValue} (char: {(char)byteValue})";
                                }
                                break;

                            case "ReadChar":
                                if (serialPort.BytesToRead > 0)
                                {
                                    int charValue = serialPort.ReadChar();
                                    if (charValue == 13 || charValue == 10) return;
                                    data = $"[Char] {(char)charValue}";
                                }
                                break;

                            case "ReadExisting":
                                data = "[Existing] " + serialPort.ReadExisting();
                                break;

                            case "ReadLine":
                                data = "[Line] " + serialPort.ReadLine();
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
            if (serialPort.IsOpen)
            {
                Settings settings = new Settings();
                if (settings.ShowDialog() == DialogResult.OK)
                {
                    serialPort.BaudRate = settings.SelectedBaudRate;
                    serialPort.DataBits = settings.SelectedDataBits;
                    serialPort.Parity = settings.SelectedParity;
                    serialPort.StopBits = settings.SelectedStopBits;
                    serialPort.Handshake = settings.SelectedHandshake;

                    MessageBox.Show("Settings applied.");
                }
            }
            else
            {
                MessageBox.Show("Open Sending Port.");
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

                if (!serialPort.IsOpen)
                {
                    serialPort.PortName = receiverPorts.SelectedItem.ToString();
                    serialPort.DataReceived -= SerialPort_DataReceived;
                    serialPort.DataReceived += SerialPort_DataReceived;
                    serialPort.Open();
                    btnOpenReceiver.Text = "Close";
                    receiverPorts.Enabled = false;
                }
                else
                {
                    serialPort.Close();
                    btnOpenReceiver.Text = "Open";
                    receiverPorts.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening port: " + ex.Message);
            }
        }
    }
}
