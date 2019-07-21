namespace Arduino_Serial_Monitor_Zavrsni_Rad
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_search_ports = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.button_send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_ports = new System.Windows.Forms.ComboBox();
            this.comboBox_baud_rate = new System.Windows.Forms.ComboBox();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.textBox_receive = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_joystick = new System.Windows.Forms.TabPage();
            this.button_send_saved_command_4 = new System.Windows.Forms.Button();
            this.button_send_saved_command_3 = new System.Windows.Forms.Button();
            this.button_send_saved_command_2 = new System.Windows.Forms.Button();
            this.button_send_saved_command_1 = new System.Windows.Forms.Button();
            this.textBox_saved_command_4 = new System.Windows.Forms.TextBox();
            this.textBox_saved_command_3 = new System.Windows.Forms.TextBox();
            this.textBox_saved_command_2 = new System.Windows.Forms.TextBox();
            this.textBox_saved_command_1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_disable_alarm_lock = new System.Windows.Forms.Button();
            this.button_toggle_check_mode = new System.Windows.Forms.Button();
            this.button_request_state_information = new System.Windows.Forms.Button();
            this.button_reset_zero = new System.Windows.Forms.Button();
            this.button_return_to_zero = new System.Windows.Forms.Button();
            this.button_homing_cycle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownSuffix_step_multiplier = new Arduino_Serial_Monitor_Zavrsni_Rad.NumericUpDownSuffix();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Zminus = new System.Windows.Forms.Button();
            this.button_Zplus = new System.Windows.Forms.Button();
            this.button_Xplus = new System.Windows.Forms.Button();
            this.button_Xminus = new System.Windows.Forms.Button();
            this.button_Yminus = new System.Windows.Forms.Button();
            this.button_Yplus = new System.Windows.Forms.Button();
            this.tabPage_queue = new System.Windows.Forms.TabPage();
            this.label_queue_file_number_of_lines = new System.Windows.Forms.Label();
            this.label_queue_file_path = new System.Windows.Forms.Label();
            this.textBox_queue_text_editor = new System.Windows.Forms.TextBox();
            this.button_queue_select_file = new System.Windows.Forms.Button();
            this.tabPage_convert = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_about = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_joystick.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSuffix_step_multiplier)).BeginInit();
            this.tabPage_queue.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_search_ports
            // 
            this.button_search_ports.Location = new System.Drawing.Point(146, 12);
            this.button_search_ports.Name = "button_search_ports";
            this.button_search_ports.Size = new System.Drawing.Size(121, 23);
            this.button_search_ports.TabIndex = 0;
            this.button_search_ports.Text = "Search";
            this.button_search_ports.UseVisualStyleBackColor = true;
            this.button_search_ports.Click += new System.EventHandler(this.Button_search_ports_Click);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(146, 95);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(121, 23);
            this.button_connect.TabIndex = 1;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.Button_connect_Click);
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(320, 181);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 2;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search COM ports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Baud rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Message to send";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Messages received";
            // 
            // comboBox_ports
            // 
            this.comboBox_ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ports.FormattingEnabled = true;
            this.comboBox_ports.Location = new System.Drawing.Point(146, 41);
            this.comboBox_ports.Name = "comboBox_ports";
            this.comboBox_ports.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ports.TabIndex = 8;
            this.comboBox_ports.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ports_SelectedIndexChanged);
            // 
            // comboBox_baud_rate
            // 
            this.comboBox_baud_rate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baud_rate.FormattingEnabled = true;
            this.comboBox_baud_rate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.comboBox_baud_rate.Location = new System.Drawing.Point(146, 68);
            this.comboBox_baud_rate.Name = "comboBox_baud_rate";
            this.comboBox_baud_rate.Size = new System.Drawing.Size(121, 21);
            this.comboBox_baud_rate.TabIndex = 9;
            this.comboBox_baud_rate.SelectedIndexChanged += new System.EventHandler(this.ComboBox_baud_rate_SelectedIndexChanged);
            // 
            // textBox_send
            // 
            this.textBox_send.Location = new System.Drawing.Point(12, 155);
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(383, 20);
            this.textBox_send.TabIndex = 10;
            // 
            // textBox_receive
            // 
            this.textBox_receive.Location = new System.Drawing.Point(12, 211);
            this.textBox_receive.MaxLength = 0;
            this.textBox_receive.Multiline = true;
            this.textBox_receive.Name = "textBox_receive";
            this.textBox_receive.ReadOnly = true;
            this.textBox_receive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_receive.Size = new System.Drawing.Size(383, 249);
            this.textBox_receive.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_joystick);
            this.tabControl1.Controls.Add(this.tabPage_queue);
            this.tabControl1.Controls.Add(this.tabPage_convert);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(401, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(293, 455);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage_joystick
            // 
            this.tabPage_joystick.Controls.Add(this.button_send_saved_command_4);
            this.tabPage_joystick.Controls.Add(this.button_send_saved_command_3);
            this.tabPage_joystick.Controls.Add(this.button_send_saved_command_2);
            this.tabPage_joystick.Controls.Add(this.button_send_saved_command_1);
            this.tabPage_joystick.Controls.Add(this.textBox_saved_command_4);
            this.tabPage_joystick.Controls.Add(this.textBox_saved_command_3);
            this.tabPage_joystick.Controls.Add(this.textBox_saved_command_2);
            this.tabPage_joystick.Controls.Add(this.textBox_saved_command_1);
            this.tabPage_joystick.Controls.Add(this.groupBox2);
            this.tabPage_joystick.Controls.Add(this.groupBox1);
            this.tabPage_joystick.Location = new System.Drawing.Point(4, 22);
            this.tabPage_joystick.Name = "tabPage_joystick";
            this.tabPage_joystick.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_joystick.Size = new System.Drawing.Size(285, 429);
            this.tabPage_joystick.TabIndex = 0;
            this.tabPage_joystick.Text = "Controls";
            this.tabPage_joystick.UseVisualStyleBackColor = true;
            // 
            // button_send_saved_command_4
            // 
            this.button_send_saved_command_4.Location = new System.Drawing.Point(204, 403);
            this.button_send_saved_command_4.Name = "button_send_saved_command_4";
            this.button_send_saved_command_4.Size = new System.Drawing.Size(75, 20);
            this.button_send_saved_command_4.TabIndex = 6;
            this.button_send_saved_command_4.Text = "Send";
            this.button_send_saved_command_4.UseVisualStyleBackColor = true;
            this.button_send_saved_command_4.Click += new System.EventHandler(this.Button_send_saved_command_4_Click);
            // 
            // button_send_saved_command_3
            // 
            this.button_send_saved_command_3.Location = new System.Drawing.Point(204, 376);
            this.button_send_saved_command_3.Name = "button_send_saved_command_3";
            this.button_send_saved_command_3.Size = new System.Drawing.Size(75, 20);
            this.button_send_saved_command_3.TabIndex = 6;
            this.button_send_saved_command_3.Text = "Send";
            this.button_send_saved_command_3.UseVisualStyleBackColor = true;
            this.button_send_saved_command_3.Click += new System.EventHandler(this.Button_send_saved_command_3_Click);
            // 
            // button_send_saved_command_2
            // 
            this.button_send_saved_command_2.Location = new System.Drawing.Point(204, 350);
            this.button_send_saved_command_2.Name = "button_send_saved_command_2";
            this.button_send_saved_command_2.Size = new System.Drawing.Size(75, 20);
            this.button_send_saved_command_2.TabIndex = 6;
            this.button_send_saved_command_2.Text = "Send";
            this.button_send_saved_command_2.UseVisualStyleBackColor = true;
            this.button_send_saved_command_2.Click += new System.EventHandler(this.Button_send_saved_command_2_Click);
            // 
            // button_send_saved_command_1
            // 
            this.button_send_saved_command_1.Location = new System.Drawing.Point(204, 324);
            this.button_send_saved_command_1.Name = "button_send_saved_command_1";
            this.button_send_saved_command_1.Size = new System.Drawing.Size(75, 20);
            this.button_send_saved_command_1.TabIndex = 6;
            this.button_send_saved_command_1.Text = "Send";
            this.button_send_saved_command_1.UseVisualStyleBackColor = true;
            this.button_send_saved_command_1.Click += new System.EventHandler(this.Button_send_saved_command_1_Click);
            // 
            // textBox_saved_command_4
            // 
            this.textBox_saved_command_4.Location = new System.Drawing.Point(6, 403);
            this.textBox_saved_command_4.Name = "textBox_saved_command_4";
            this.textBox_saved_command_4.Size = new System.Drawing.Size(192, 20);
            this.textBox_saved_command_4.TabIndex = 5;
            // 
            // textBox_saved_command_3
            // 
            this.textBox_saved_command_3.Location = new System.Drawing.Point(6, 376);
            this.textBox_saved_command_3.Name = "textBox_saved_command_3";
            this.textBox_saved_command_3.Size = new System.Drawing.Size(192, 20);
            this.textBox_saved_command_3.TabIndex = 4;
            // 
            // textBox_saved_command_2
            // 
            this.textBox_saved_command_2.Location = new System.Drawing.Point(6, 350);
            this.textBox_saved_command_2.Name = "textBox_saved_command_2";
            this.textBox_saved_command_2.Size = new System.Drawing.Size(192, 20);
            this.textBox_saved_command_2.TabIndex = 3;
            // 
            // textBox_saved_command_1
            // 
            this.textBox_saved_command_1.Location = new System.Drawing.Point(6, 324);
            this.textBox_saved_command_1.Name = "textBox_saved_command_1";
            this.textBox_saved_command_1.Size = new System.Drawing.Size(192, 20);
            this.textBox_saved_command_1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button_disable_alarm_lock);
            this.groupBox2.Controls.Add(this.button_toggle_check_mode);
            this.groupBox2.Controls.Add(this.button_request_state_information);
            this.groupBox2.Controls.Add(this.button_reset_zero);
            this.groupBox2.Controls.Add(this.button_return_to_zero);
            this.groupBox2.Controls.Add(this.button_homing_cycle);
            this.groupBox2.Location = new System.Drawing.Point(6, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 202);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GRBL controls";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Request state information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Toggle check mode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Disable GRBL alarm lock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Begin homing cycle";
            // 
            // button_disable_alarm_lock
            // 
            this.button_disable_alarm_lock.Location = new System.Drawing.Point(6, 54);
            this.button_disable_alarm_lock.Name = "button_disable_alarm_lock";
            this.button_disable_alarm_lock.Size = new System.Drawing.Size(29, 23);
            this.button_disable_alarm_lock.TabIndex = 6;
            this.button_disable_alarm_lock.Text = "$X";
            this.button_disable_alarm_lock.UseVisualStyleBackColor = true;
            this.button_disable_alarm_lock.Click += new System.EventHandler(this.Button_disable_alarm_lock_Click);
            // 
            // button_toggle_check_mode
            // 
            this.button_toggle_check_mode.Location = new System.Drawing.Point(6, 83);
            this.button_toggle_check_mode.Name = "button_toggle_check_mode";
            this.button_toggle_check_mode.Size = new System.Drawing.Size(29, 23);
            this.button_toggle_check_mode.TabIndex = 5;
            this.button_toggle_check_mode.Text = "$C";
            this.button_toggle_check_mode.UseVisualStyleBackColor = true;
            this.button_toggle_check_mode.Click += new System.EventHandler(this.Button_toggle_check_mode_Click);
            // 
            // button_request_state_information
            // 
            this.button_request_state_information.Location = new System.Drawing.Point(6, 112);
            this.button_request_state_information.Name = "button_request_state_information";
            this.button_request_state_information.Size = new System.Drawing.Size(29, 23);
            this.button_request_state_information.TabIndex = 4;
            this.button_request_state_information.Text = "$G";
            this.button_request_state_information.UseVisualStyleBackColor = true;
            this.button_request_state_information.Click += new System.EventHandler(this.Button_request_state_information_Click);
            // 
            // button_reset_zero
            // 
            this.button_reset_zero.Location = new System.Drawing.Point(6, 141);
            this.button_reset_zero.Name = "button_reset_zero";
            this.button_reset_zero.Size = new System.Drawing.Size(160, 23);
            this.button_reset_zero.TabIndex = 3;
            this.button_reset_zero.Text = "Reset zero";
            this.button_reset_zero.UseVisualStyleBackColor = true;
            this.button_reset_zero.Click += new System.EventHandler(this.Button_reset_zero_Click);
            // 
            // button_return_to_zero
            // 
            this.button_return_to_zero.Location = new System.Drawing.Point(6, 170);
            this.button_return_to_zero.Name = "button_return_to_zero";
            this.button_return_to_zero.Size = new System.Drawing.Size(160, 23);
            this.button_return_to_zero.TabIndex = 2;
            this.button_return_to_zero.Text = "Return to zero";
            this.button_return_to_zero.UseVisualStyleBackColor = true;
            this.button_return_to_zero.Click += new System.EventHandler(this.Button_return_to_zero_Click);
            // 
            // button_homing_cycle
            // 
            this.button_homing_cycle.Location = new System.Drawing.Point(6, 25);
            this.button_homing_cycle.Name = "button_homing_cycle";
            this.button_homing_cycle.Size = new System.Drawing.Size(29, 23);
            this.button_homing_cycle.TabIndex = 1;
            this.button_homing_cycle.Text = "$H";
            this.button_homing_cycle.UseVisualStyleBackColor = true;
            this.button_homing_cycle.Click += new System.EventHandler(this.Button_homing_cycle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownSuffix_step_multiplier);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button_Zminus);
            this.groupBox1.Controls.Add(this.button_Zplus);
            this.groupBox1.Controls.Add(this.button_Xplus);
            this.groupBox1.Controls.Add(this.button_Xminus);
            this.groupBox1.Controls.Add(this.button_Yminus);
            this.groupBox1.Controls.Add(this.button_Yplus);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "XYZ motor Joystick";
            // 
            // numericUpDownSuffix_step_multiplier
            // 
            this.numericUpDownSuffix_step_multiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSuffix_step_multiplier.Location = new System.Drawing.Point(186, 19);
            this.numericUpDownSuffix_step_multiplier.Name = "numericUpDownSuffix_step_multiplier";
            this.numericUpDownSuffix_step_multiplier.Size = new System.Drawing.Size(81, 26);
            this.numericUpDownSuffix_step_multiplier.TabIndex = 13;
            this.numericUpDownSuffix_step_multiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownSuffix_step_multiplier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Steps:";
            // 
            // button_Zminus
            // 
            this.button_Zminus.Location = new System.Drawing.Point(172, 62);
            this.button_Zminus.Name = "button_Zminus";
            this.button_Zminus.Size = new System.Drawing.Size(37, 32);
            this.button_Zminus.TabIndex = 5;
            this.button_Zminus.Text = "Z-";
            this.button_Zminus.UseVisualStyleBackColor = true;
            this.button_Zminus.Click += new System.EventHandler(this.Button_Zminus_Click);
            // 
            // button_Zplus
            // 
            this.button_Zplus.Location = new System.Drawing.Point(129, 62);
            this.button_Zplus.Name = "button_Zplus";
            this.button_Zplus.Size = new System.Drawing.Size(37, 32);
            this.button_Zplus.TabIndex = 4;
            this.button_Zplus.Text = "Z+";
            this.button_Zplus.UseVisualStyleBackColor = true;
            this.button_Zplus.Click += new System.EventHandler(this.Button_Zplus_Click);
            // 
            // button_Xplus
            // 
            this.button_Xplus.Location = new System.Drawing.Point(9, 24);
            this.button_Xplus.Name = "button_Xplus";
            this.button_Xplus.Size = new System.Drawing.Size(37, 32);
            this.button_Xplus.TabIndex = 3;
            this.button_Xplus.Text = "X+";
            this.button_Xplus.UseVisualStyleBackColor = true;
            this.button_Xplus.Click += new System.EventHandler(this.Button_Xplus_Click);
            // 
            // button_Xminus
            // 
            this.button_Xminus.Location = new System.Drawing.Point(9, 62);
            this.button_Xminus.Name = "button_Xminus";
            this.button_Xminus.Size = new System.Drawing.Size(37, 32);
            this.button_Xminus.TabIndex = 2;
            this.button_Xminus.Text = "X-";
            this.button_Xminus.UseVisualStyleBackColor = true;
            this.button_Xminus.Click += new System.EventHandler(this.Button_Xminus_Click);
            // 
            // button_Yminus
            // 
            this.button_Yminus.Location = new System.Drawing.Point(52, 62);
            this.button_Yminus.Name = "button_Yminus";
            this.button_Yminus.Size = new System.Drawing.Size(37, 32);
            this.button_Yminus.TabIndex = 1;
            this.button_Yminus.Text = "Y-";
            this.button_Yminus.UseVisualStyleBackColor = true;
            this.button_Yminus.Click += new System.EventHandler(this.Button_Yminus_Click);
            // 
            // button_Yplus
            // 
            this.button_Yplus.Location = new System.Drawing.Point(52, 24);
            this.button_Yplus.Name = "button_Yplus";
            this.button_Yplus.Size = new System.Drawing.Size(37, 32);
            this.button_Yplus.TabIndex = 0;
            this.button_Yplus.Text = "Y+";
            this.button_Yplus.UseVisualStyleBackColor = true;
            this.button_Yplus.Click += new System.EventHandler(this.Button_Yplus_Click);
            // 
            // tabPage_queue
            // 
            this.tabPage_queue.Controls.Add(this.label_queue_file_number_of_lines);
            this.tabPage_queue.Controls.Add(this.label_queue_file_path);
            this.tabPage_queue.Controls.Add(this.textBox_queue_text_editor);
            this.tabPage_queue.Controls.Add(this.button_queue_select_file);
            this.tabPage_queue.Location = new System.Drawing.Point(4, 22);
            this.tabPage_queue.Name = "tabPage_queue";
            this.tabPage_queue.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_queue.Size = new System.Drawing.Size(285, 429);
            this.tabPage_queue.TabIndex = 1;
            this.tabPage_queue.Text = "Queue";
            this.tabPage_queue.UseVisualStyleBackColor = true;
            // 
            // label_queue_file_number_of_lines
            // 
            this.label_queue_file_number_of_lines.AutoSize = true;
            this.label_queue_file_number_of_lines.Location = new System.Drawing.Point(6, 370);
            this.label_queue_file_number_of_lines.Name = "label_queue_file_number_of_lines";
            this.label_queue_file_number_of_lines.Size = new System.Drawing.Size(53, 13);
            this.label_queue_file_number_of_lines.TabIndex = 3;
            this.label_queue_file_number_of_lines.Text = "# of lines:";
            // 
            // label_queue_file_path
            // 
            this.label_queue_file_path.AutoSize = true;
            this.label_queue_file_path.Location = new System.Drawing.Point(6, 357);
            this.label_queue_file_path.Name = "label_queue_file_path";
            this.label_queue_file_path.Size = new System.Drawing.Size(27, 13);
            this.label_queue_file_path.TabIndex = 2;
            this.label_queue_file_path.Text = "N/A";
            // 
            // textBox_queue_text_editor
            // 
            this.textBox_queue_text_editor.Location = new System.Drawing.Point(6, 6);
            this.textBox_queue_text_editor.Multiline = true;
            this.textBox_queue_text_editor.Name = "textBox_queue_text_editor";
            this.textBox_queue_text_editor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_queue_text_editor.Size = new System.Drawing.Size(192, 348);
            this.textBox_queue_text_editor.TabIndex = 1;
            // 
            // button_queue_select_file
            // 
            this.button_queue_select_file.Location = new System.Drawing.Point(204, 6);
            this.button_queue_select_file.Name = "button_queue_select_file";
            this.button_queue_select_file.Size = new System.Drawing.Size(75, 23);
            this.button_queue_select_file.TabIndex = 0;
            this.button_queue_select_file.Text = "Select File";
            this.button_queue_select_file.UseVisualStyleBackColor = true;
            this.button_queue_select_file.Click += new System.EventHandler(this.Button_queue_select_file_Click);
            // 
            // tabPage_convert
            // 
            this.tabPage_convert.Location = new System.Drawing.Point(4, 22);
            this.tabPage_convert.Name = "tabPage_convert";
            this.tabPage_convert.Size = new System.Drawing.Size(285, 429);
            this.tabPage_convert.TabIndex = 2;
            this.tabPage_convert.Text = "Convert";
            this.tabPage_convert.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\Anto";
            this.openFileDialog1.Title = "Select File";
            // 
            // button_about
            // 
            this.button_about.Location = new System.Drawing.Point(320, 12);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(75, 23);
            this.button_about.TabIndex = 13;
            this.button_about.Text = "About";
            this.button_about.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 472);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox_receive);
            this.Controls.Add(this.textBox_send);
            this.Controls.Add(this.comboBox_baud_rate);
            this.Controls.Add(this.comboBox_ports);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.button_search_ports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Arduino GRBL Polar Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_joystick.ResumeLayout(false);
            this.tabPage_joystick.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSuffix_step_multiplier)).EndInit();
            this.tabPage_queue.ResumeLayout(false);
            this.tabPage_queue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_search_ports;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_ports;
        private System.Windows.Forms.ComboBox comboBox_baud_rate;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.TextBox textBox_receive;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_joystick;
        private System.Windows.Forms.TabPage tabPage_queue;
        private System.Windows.Forms.TabPage tabPage_convert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Zminus;
        private System.Windows.Forms.Button button_Zplus;
        private System.Windows.Forms.Button button_Xplus;
        private System.Windows.Forms.Button button_Xminus;
        private System.Windows.Forms.Button button_Yminus;
        private System.Windows.Forms.Button button_Yplus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_disable_alarm_lock;
        private System.Windows.Forms.Button button_toggle_check_mode;
        private System.Windows.Forms.Button button_request_state_information;
        private System.Windows.Forms.Button button_reset_zero;
        private System.Windows.Forms.Button button_return_to_zero;
        private System.Windows.Forms.Button button_homing_cycle;
        private System.Windows.Forms.Button button_send_saved_command_4;
        private System.Windows.Forms.Button button_send_saved_command_3;
        private System.Windows.Forms.Button button_send_saved_command_2;
        private System.Windows.Forms.Button button_send_saved_command_1;
        private System.Windows.Forms.TextBox textBox_saved_command_4;
        private System.Windows.Forms.TextBox textBox_saved_command_3;
        private System.Windows.Forms.TextBox textBox_saved_command_2;
        private System.Windows.Forms.TextBox textBox_saved_command_1;
        private NumericUpDownSuffix numericUpDownSuffix_step_multiplier;
        private System.Windows.Forms.TextBox textBox_queue_text_editor;
        private System.Windows.Forms.Button button_queue_select_file;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label_queue_file_path;
        private System.Windows.Forms.Label label_queue_file_number_of_lines;
        private System.Windows.Forms.Button button_about;
    }
}

