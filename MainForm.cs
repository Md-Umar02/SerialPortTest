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
        bool isLoopback = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            senderPorts.Items.AddRange(SerialPort.GetPortNames());
            receiverPorts.Items.AddRange(SerialPort.GetPortNames());

            if (senderPorts.Items.Count == 0 || receiverPorts.Items.Count == 0)
                MessageBox.Show("No serial ports found.");

            cmbReadMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReadMethod.Items.AddRange(new string[] { "ReadByte", "ReadChar", "ReadExisting", "ReadLine", "ReadTo" });

            cmbWriteMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWriteMethod.Items.AddRange(new string[] { "Write", "WriteLine", "WriteCharArray", "WriteByteArray" });
        }

        private void btnOpenSender_Click(object sender, EventArgs e)
        {
            try
            {
                if (senderPorts.SelectedItem == null)
                {
                    MessageBox.Show("Please select a COM port.");
                    return;
                }

                if (senderPorts.SelectedItem != null && receiverPorts.SelectedItem != null)
                {
                    isLoopback = senderPorts.SelectedItem.ToString() == receiverPorts.SelectedItem.ToString();
                }
                if (isLoopback)
                {
                    //receiverPort = null;
                    

                    if (!receiverPort.IsOpen)
                    {
                        receiverPort = senderPort;
                        senderPort.PortName = senderPorts.SelectedItem.ToString();
                        senderPort.Open();
                    }
                    if (btnOpenSender.Text == "Open")
                    {
                        senderPort.DataReceived -= ReceiverPort_DataReceived;
                        senderPort.DataReceived += ReceiverPort_DataReceived;
                        btnOpenSender.Text = "Close";
                        senderPorts.Enabled = false;
                    }
                    else
                    {
                        senderPort.Close();
                        btnOpenSender.Text = "Open";
                        senderPorts.Enabled = true;
                    }
                    
                }
                else
                {
                    if (!senderPort.IsOpen)
                    {
                        senderPort.PortName = senderPorts.SelectedItem.ToString();
                        senderPort.Open();
                        btnOpenSender.Text = "Close";
                        senderPorts.Enabled = false;
                    }
                    else
                    {
                        senderPort.Close();
                        btnOpenSender.Text = "Open";
                        senderPorts.Enabled = true;
                    }
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
                    MessageBox.Show("Please select both sender and receiver COM ports.");
                    return;
                }
                if (cmbReadMethod.SelectedItem == null)
                {
                    MessageBox.Show("Please select the method name first.");
                    return;
                }

                //string senderName = senderPorts.SelectedItem.ToString();
                //string receiverName = receiverPorts.SelectedItem.ToString();
                if (senderPorts.SelectedItem != null && receiverPorts.SelectedItem != null)
                {
                    isLoopback = senderPorts.SelectedItem.ToString() == receiverPorts.SelectedItem.ToString();
                }

                if (isLoopback)
                {
                    //receiverPort = null;
                    receiverPort = senderPort;
                    senderPort.DataReceived -= ReceiverPort_DataReceived;

                    //if (!senderPort.IsOpen)
                    //{
                    //    receiverPort.Open();
                    //}
                    if (btnOpenReceiver.Text == "Open")
                    {
                        btnOpenReceiver.Text = "Close";
                        senderPort.DataReceived += ReceiverPort_DataReceived;
                        receiverPorts.Enabled = false;
                    }
                    else
                    {
                        senderPort.DataReceived -= ReceiverPort_DataReceived;
                        receiverPort.Close();
                        btnOpenReceiver.Text = "Open";
                        receiverPorts.Enabled = true;
                    }
                    
                }
                //{
                //if (senderPort.IsOpen)
                //    {
                //        if (!senderPort.IsOpen)
                //        {
                //            MessageBox.Show("Please open the sender port first.");
                //            return;
                //        }

                //        senderPort.DataReceived += ReceiverPort_DataReceived;
                //        senderPort.DataReceived += ReceiverPort_DataReceived;

                //        btnOpenReceiver.Text = "Close";
                //        receiverPorts.Enabled = false;
                //    }
                //    else
                //    {
                //        senderPort.DataReceived -= ReceiverPort_DataReceived;
                //        btnOpenReceiver.Text = "Open";
                //        receiverPorts.Enabled = true;
                //    }
                //}
                else
                {
                    if (btnOpenReceiver.Text == "Open")
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
                        if (receiverPort.IsOpen)
                            receiverPort.Close();

                        btnOpenReceiver.Text = "Open";
                        receiverPorts.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening receiver port: " + ex.Message);
            }
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            if (senderPorts.SelectedItem == null)
            {
                MessageBox.Show("Sender port is not open.");
                return;
            }

            //else if (receiverPorts.SelectedItem == null)
            //{
            //    MessageBox.Show("Sender port is not open.");
            //    return;
            //}

            try
            {
                string text = txtSend.Text;
                int offset = int.TryParse(txtOffset.Text, out int o) ? o : 0;
                int count = int.TryParse(txtCount.Text, out int c) ? c : 0;
                switch (cmbWriteMethod.SelectedItem?.ToString())
                {
                    case "Write":
                        if (rdoSenderHex.Checked)
                        {
                            byte[] hexBytes = ParseHex(text);
                            if (hexBytes.Length > 0)
                            {
                                if (senderPort == receiverPort && !senderPort.IsOpen)
                                {
                                    senderPort.Write(hexBytes, 0, hexBytes.Length);
                                }
                                else
                                {
                                    receiverPort.Write(hexBytes, 0, hexBytes.Length);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid hex string.");
                            }
                        }
                        else
                        {
                            if (senderPorts.Text == receiverPorts.Text && !senderPort.IsOpen)
                            {
                                receiverPort.Write(text);
                            }
                            else
                            {
                                senderPort.Write(text);
                            }
                        }
                        break;

                    case "WriteLine":
                        if (rdoSenderHex.Checked)
                        {
                            byte[] hexBytes = ParseHex(text + "\r\n");
                            if (hexBytes.Length > 0)
                            {
                                if (senderPort == receiverPort && !senderPort.IsOpen)
                                {
                                    senderPort.Write(hexBytes, 0, hexBytes.Length);
                                }
                                else
                                {
                                    receiverPort.Write(hexBytes, 0, hexBytes.Length);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid hex string.");
                            }
                        }
                        else
                        {
                            if (senderPorts.Text == receiverPorts.Text && !senderPort.IsOpen)
                            {
                                receiverPort.WriteLine(text);
                            }
                            else
                            {
                                senderPort.WriteLine(text);
                            }
                        }
                        
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
                        byte[] bytes = rdoSenderHex.Checked ? ParseHex(text) : Encoding.ASCII.GetBytes(text);
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
            SerialPort port = (SerialPort)sender;

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
                        switch (cmbReadMethod.SelectedItem?.ToString())
                        {
                            case "ReadByte":
                                if (port.BytesToRead > 0)
                                {
                                    int byteValue = port.ReadByte();

                                    if (rdoReceiverHex.Checked)
                                        data = $"[Byte-Hex] {byteValue:X2}";
                                    else
                                        data = $"[Byte] {byteValue} (char: {(char)byteValue})";
                                }
                                break;

                            case "ReadChar":
                                if (port.BytesToRead > 0)
                                {
                                    int charValue = port.ReadChar();
                                    if (charValue == 13 || charValue == 10) return;
                                    if (rdoReceiverHex.Checked)
                                        data = $"[Char-Hex] {charValue:X2}";
                                    else
                                        data = $"[Char] {(char)charValue}";
                                }
                                break;

                            case "ReadExisting":
                                if (rdoReceiverHex.Checked)
                                {
                                    byte[] buffer = new byte[port.BytesToRead];
                                    port.Read(buffer, 0, buffer.Length);
                                    string hex = BitConverter.ToString(buffer).Replace("-", " ");
                                    data = hex;
                                }
                                else
                                {
                                    data = "[Existing] " + port.ReadExisting();
                                }
                                break;

                            case "ReadLine":
                                if (rdoReceiverHex.Checked)
                                {
                                    string line = port.ReadLine();
                                    byte[] lineBytes = Encoding.ASCII.GetBytes(line);
                                    string hex = BitConverter.ToString(lineBytes).Replace("-", " ");
                                    data = hex;
                                }
                                else
                                {
                                    data = "[Line] " + port.ReadLine();
                                }       
                                break;
                            case "ReadTo":
                                if (txtEOT.Text.Length == 0)
                                {
                                    MessageBox.Show("Please specify an EOT character.");
                                    return;
                                }
                                else if (txtEOT.Text.Length > 1)
                                {
                                    MessageBox.Show("EOT must be a single character.");
                                    return;
                                }
                                else
                                {
                                    if (rdoReceiverHex.Checked)
                                    {
                                        string toText = port.ReadTo(txtEOT.Text);
                                        byte[] toBytes = Encoding.ASCII.GetBytes(toText);
                                        string hex = BitConverter.ToString(toBytes).Replace("-", " ");
                                        data = hex;
                                    }
                                    else
                                    {
                                        data = "[To] " + port.ReadTo(txtEOT.Text) + "\r\n";
                                    }
                                    port.DiscardInBuffer();
                                    break;
                                } 
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

        private void btnReceiverSettings_Click(object sender, EventArgs e)
        {
            if (isLoopback)
            {
                MessageBox.Show("Receiver settings are managed by sender port in loopback mode.");
                return;
            }

            if (receiverPort.IsOpen)
            {
                Settings settings = new Settings();
                if (settings.ShowDialog() == DialogResult.OK)
                {
                    receiverPort.BaudRate = settings.SelectedBaudRate;
                    receiverPort.DataBits = settings.SelectedDataBits;
                    receiverPort.Parity = settings.SelectedParity;
                    receiverPort.StopBits = settings.SelectedStopBits;
                    receiverPort.Handshake = settings.SelectedHandshake;

                    MessageBox.Show("Settings applied.");
                }
            }
            else
            {
                MessageBox.Show("Open Receiving Port.");
            }
        }
        private byte[] ParseHex(string hex)
        {
            hex = hex.Replace(" ", "").Replace("-", "");
            if (hex.Length % 2 != 0)
                throw new FormatException("Hex string must have even length.");

            return Enumerable.Range(0, hex.Length / 2)
                             .Select(i => Convert.ToByte(hex.Substring(i * 2, 2), 16))
                             .ToArray();
        }
    }
}