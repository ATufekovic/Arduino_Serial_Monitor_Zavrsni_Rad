using System;
using System.Windows.Forms;
using System.IO.Ports;  // biblioteka za serijsku komunikaciju
using System.IO;
using System.Text.RegularExpressions;

namespace Arduino_Serial_Monitor_Zavrsni_Rad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SerialPort myPort = new SerialPort();
        private string[] ports;
        private string comPort = "";
        private ushort[] dataBuffer = new ushort[8];

        private bool isFirstCommand = true; //watches if the very first move command was sent with a G21 for milimeters

        private void SearchPorts()
        {
            ports = SerialPort.GetPortNames();
            comboBox_ports.Items.Clear();
            foreach (string port in ports)
            {
                comboBox_ports.Items.Add(port);
            }
            if (comboBox_ports.Items.Count > 0)
            {
                comboBox_ports.SelectedIndex = comboBox_ports.Items.Count - 1;
                comPort = comboBox_ports.SelectedItem.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SearchPorts();

            //serial communication settings
            myPort.DtrEnable = true;
            myPort.RtsEnable = true;
            myPort.BaudRate = 9600;
            myPort.Parity = Parity.None;
            myPort.DataBits = 8;
            myPort.StopBits = StopBits.One;
            myPort.PortName = comPort;
            myPort.DataReceived += myPort_DataReceived;
            button_send.Enabled = false;
            textBox_send.Enabled = false;
            textBox_receive.Enabled = false;
        }

        private void Button_search_ports_Click(object sender, EventArgs e)
        {
            SearchPorts();
        }

        private void Button_connect_Click(object sender, EventArgs e)
        {
            if (myPort.IsOpen)
            {
                myPort.Close();
            }
            else
            {
                try
                {
                    myPort.PortName = comPort;
                    myPort.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
            if (myPort.IsOpen)
            {
                Console.WriteLine(myPort.PortName);
                comboBox_ports.Enabled = false;
                comboBox_baud_rate.Enabled = false;
                button_search_ports.Enabled = false;
                button_connect.Text = "Disconnect";
                button_send.Enabled = true;
                textBox_send.Enabled = true;
                textBox_receive.Enabled = true;
                tabControl1.Enabled = true;
            }
            else
            {
                comboBox_ports.Enabled = true;
                comboBox_baud_rate.Enabled = true;
                button_search_ports.Enabled = true;
                button_connect.Text = "Connect";
                button_send.Enabled = false;
                textBox_send.Enabled = false;
                textBox_receive.Enabled = false;
                tabControl1.Enabled = false;
            }
        }

        private void Button_send_Click(object sender, EventArgs e)
        {
            SendLine();
        }

        private void ComboBox_ports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_ports.Items.Count > 0)
            {
                comPort = comboBox_ports.SelectedItem.ToString();
            }
        }

        private void ComboBox_baud_rate_SelectedIndexChanged(object sender, EventArgs e)
        {
            myPort.BaudRate = Convert.ToInt32(comboBox_baud_rate.SelectedItem.ToString());
        }

        // primanje teksta s Arduina
        private void myPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                string line = myPort.ReadExisting();
                this.BeginInvoke(new LineReceivedEvent(LineReceived), line);
            }
            catch (Exception)
            {
                MessageBox.Show("Error in communication");
            }
        }
        private delegate void LineReceivedEvent(string line);
        private void LineReceived(string line)
        {
            textBox_receive.AppendText(line);
            //Console.WriteLine(line); // ispis u Output prozoru za debugiranje
        }

        private void SendLine()
        {
            if (myPort.IsOpen)
            {
                string mycommand = textBox_send.Text + "\r";
                textBox_send.Text = ""; // obriši textbox nakon slanja na Arduino
                myPort.Write(mycommand);
                //Console.WriteLine(mycommand); // ispis u Output prozoru za debugiranje
            }
        }
        private void SendLine(string command)
        {
            if (myPort.IsOpen)
            {
                string mycommand = command + "\r";
                myPort.Write(mycommand);
                //Console.WriteLine(mycommand); // ispis u Output prozoru za debugiranje
            }
        }

        private void Button_Yplus_Click(object sender, EventArgs e)
        {
            XYZJog("Y", "+");
        }

        private void Button_Yminus_Click(object sender, EventArgs e)
        {
            XYZJog("Y", "-");
        }

        private void Button_Xplus_Click(object sender, EventArgs e)
        {
            XYZJog("X", "+");
        }

        private void Button_Xminus_Click(object sender, EventArgs e)
        {
            XYZJog("X", "-");
        }

        private void XYZJog(string motor, string direction)
        {
            if (direction == "+")
            {
                direction = "";
            }
            string command = "G91 G0 " + motor + direction + numericUpDownSuffix_step_multiplier.Value.ToString();

            if (isFirstCommand)
            {
                command = "G21 " + command;
                isFirstCommand = false;
            }
            SendLine(command);
        }

        private void Button_Zplus_Click(object sender, EventArgs e)
        {
            XYZJog("Z", "+");
        }

        private void Button_Zminus_Click(object sender, EventArgs e)
        {
            XYZJog("Z", "-");
        }

        private void Button_homing_cycle_Click(object sender, EventArgs e)
        {
            SendLine("$H");
        }

        private void Button_disable_alarm_lock_Click(object sender, EventArgs e)
        {
            SendLine("$X");
        }

        private void Button_toggle_check_mode_Click(object sender, EventArgs e)
        {
            SendLine("$C");
        }

        private void Button_request_state_information_Click(object sender, EventArgs e)
        {
            SendLine("$G");
        }

        private void Button_reset_zero_Click(object sender, EventArgs e)
        {
            SendLine("G10 P0 L20 X0 Y0 Z0");
        }

        private void Button_return_to_zero_Click(object sender, EventArgs e)
        {
            SendLine("G90 G0 Z0.0");//there is enough space in the GRBL buffer to take two commands at once without looking for the "ok"
            SendLine("G90 G0 X0 Y0 Z0");
        }

        private void Button_send_saved_command_1_Click(object sender, EventArgs e)
        {
            SendLine(textBox_saved_command_1.Text);
        }

        private void Button_send_saved_command_2_Click(object sender, EventArgs e)
        {
            SendLine(textBox_saved_command_2.Text);
        }

        private void Button_send_saved_command_3_Click(object sender, EventArgs e)
        {
            SendLine(textBox_saved_command_3.Text);
        }

        private void Button_send_saved_command_4_Click(object sender, EventArgs e)
        {
            SendLine(textBox_saved_command_4.Text);
        }

        private void TextBox_send_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendLine();
            }
        }

        private void Button_queue_select_file_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label_queue_file_path.Text = openFileDialog1.FileName;
                textBox_queue_text_editor.Text = File.ReadAllText(openFileDialog1.FileName);


                string[] text_lines = Regex.Split(textBox_queue_text_editor.Text.Trim(), "\r\n");
                int line_count = text_lines.Length;
                label_queue_file_number_of_lines.Text = "# of lines: " + line_count.ToString();
            }
        }
    }
    public class NumericUpDownSuffix : NumericUpDown
    {
        protected override void UpdateEditText()
        {
            // Append the units to the end of the numeric value
            Text = Value + "mm";
        }
    }
}
