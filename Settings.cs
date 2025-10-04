using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialPortTest
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        public int SelectedBaudRate { get; private set; }
        public int SelectedDataBits { get; private set; }
        public Parity SelectedParity { get; private set; }
        public StopBits SelectedStopBits { get; private set; }
        public Handshake SelectedHandshake { get; private set; }


        private void Settings_Load(object sender, EventArgs e)
        {
            comboBaud.Items.AddRange(new string[] { "9600", "19200", "38400", "57600", "115200" });
            comboDataBits.Items.AddRange(new string[] { "5", "6", "7", "8" });
            comboParity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            comboStopBits.Items.AddRange(Enum.GetNames(typeof(StopBits)));
            comboHandshake.Items.AddRange(Enum.GetNames(typeof(Handshake)));

            comboBaud.SelectedIndex = 0;
            comboDataBits.SelectedIndex = 3;
            comboParity.SelectedItem = "None";
            comboStopBits.SelectedItem = "One";
            comboHandshake.SelectedItem = "None";
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            SelectedBaudRate = int.Parse(comboBaud.SelectedItem.ToString());
            SelectedDataBits = int.Parse(comboDataBits.SelectedItem.ToString());
            SelectedBaudRate = int.Parse(comboBaud.SelectedItem.ToString());
            SelectedParity = (Parity)Enum.Parse(typeof(Parity), comboParity.SelectedItem.ToString());
            SelectedStopBits = (StopBits)Enum.Parse(typeof(StopBits), comboStopBits.SelectedItem.ToString());
            SelectedHandshake = (Handshake)Enum.Parse(typeof(Handshake), comboHandshake.SelectedItem.ToString());

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}