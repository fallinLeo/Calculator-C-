﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void setDOStatus()
        {
            if (!serialPort.IsOpen) return;

            setCommLamp(true);

            bool[] bits = new bool[8];
            bits[0] = chkDO0.Checked;
            bits[1] = chkDO1.Checked;
            bits[2] = chkDO2.Checked;
            bits[3] = chkDO3.Checked;
            bool success = TComm.SetDigitalOutput(serialPort, bits);
        }

        private void setAOStatus()
        {
            if (!serialPort.IsOpen) return;

            setCommLamp(true);

            int[] davals = new int[4];
            davals[0] = hscLED0.Value;
            davals[1] = hscLED1.Value;
            davals[2] = hscLED2.Value;
            davals[3] = hscLED3.Value;
            bool success = TComm.SetAnalogData(serialPort, davals);
        }

        private void setLEDStatus()
        {
            if (radDigital.Checked) setDOStatus();
            if (radAnalog.Checked) setAOStatus();
        }

        private void chkComm_CheckedChanged(object sender, EventArgs e)
        {
            if (chkComm.Checked)
            {
                bool success = SPort.OpenPorts(serialPort,
                                                Convert.ToInt32(txtPortNum.Text));
                if (!success)
                {
                    MessageBox.Show("시리얼포트를 열지 못했습니다", "오류");
                }
            }
            else
            {
                SPort.ClosePorts(serialPort);
            }
            setLEDStatus();
        }

        private void setCommLamp(bool isOn)
        {
            picComm.Image = (isOn) ? Properties.Resources.LampOn : Properties.Resources.LampOff;
        }
        private void timCommMon_Tick(object sender, EventArgs e)
        {

            if (!serialPort.IsOpen) return;

            //---------------------------------------------
            // Digital Input
            //---------------------------------------------
            setCommLamp(true);
            int adval;
            bool[] bits = new bool[8];
            bool success = TComm.AskAllData(serialPort, bits, out adval);
            if (success)
            {
                chkButton0.Checked = bits[0];
                chkButton1.Checked = bits[1];
                chkButton2.Checked = bits[2];
                chkButton3.Checked = bits[3];
                txtAD.Text = Convert.ToString(adval);
            }

        }

        private void timLampOff_Tick(object sender, EventArgs e)
        {
            setCommLamp(false);
        }

        private void chkDO0_CheckedChanged(object sender, EventArgs e)
        {
            setLEDStatus();
        }

        private void hscLED0_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void hscLED_Scroll(object sender, ScrollEventArgs e)
        {
            lblLED0.Text = hscLED0.Value.ToString();
            lblLED1.Text = hscLED1.Value.ToString();
            lblLED2.Text = hscLED2.Value.ToString();
            lblLED3.Text = hscLED3.Value.ToString();
            setLEDStatus();
        }

        private void radDigital_CheckedChanged(object sender, EventArgs e)
        {
            setLEDStatus();
        }

        private void radAnalog_CheckedChanged(object sender, EventArgs e)
        {
            setLEDStatus();
        }

        private void chkButton0_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
