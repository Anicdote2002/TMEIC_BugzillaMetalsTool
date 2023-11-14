//Name: Metals Tool.Designer.cs
//Author:
//Date:
//Modified:
/*----
 * Alexander Summerton - 11/14/2022 - Removed XML Edit and Test Cookie buttons following program update.
 */


namespace WindowsFormsApplication1
{
    partial class Metals_tool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Metals_tool));
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.typeRequisit = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_ProjMan = new System.Windows.Forms.ComboBox();
            this.comboBox_SWEngineer = new System.Windows.Forms.ComboBox();
            this.comboBox_HWEngineer = new System.Windows.Forms.ComboBox();
            this.comboBox_ContEng = new System.Windows.Forms.ComboBox();
            this.comboBox_HMIEng = new System.Windows.Forms.ComboBox();
            this.comboBox_AppEng = new System.Windows.Forms.ComboBox();
            this.comboBox_CompTech = new System.Windows.Forms.ComboBox();
            this.comboBox_DriveEng = new System.Windows.Forms.ComboBox();
            this.checkedListBox_DriveComp = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_RequistComp = new System.Windows.Forms.CheckedListBox();
            this.typeDrive = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton_Yes = new System.Windows.Forms.RadioButton();
            this.radio_No = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(435, 798);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 42);
            this.button4.TabIndex = 12;
            this.button4.Text = "Create New Project";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bugzilla Login";
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(173, 128);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(451, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "first.last@tmeic.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bugzilla Password";
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.Location = new System.Drawing.Point(173, 159);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(451, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(563, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Note - Project Name should include the project number, OEM, End User, and Project" +
    " Contents. ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(513, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Metals Bugzilla Project Creation Utility";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Example:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 241);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "12345 - Erdemir Plate Mill";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 287);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Project Name";
            // 
            // textBox3
            // 
            this.textBox3.AllowDrop = true;
            this.textBox3.Location = new System.Drawing.Point(173, 287);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(524, 22);
            this.textBox3.TabIndex = 2;
            // 
            // typeRequisit
            // 
            this.typeRequisit.AutoSize = true;
            this.typeRequisit.Location = new System.Drawing.Point(461, 491);
            this.typeRequisit.Margin = new System.Windows.Forms.Padding(4);
            this.typeRequisit.Name = "typeRequisit";
            this.typeRequisit.Size = new System.Drawing.Size(189, 20);
            this.typeRequisit.TabIndex = 6;
            this.typeRequisit.TabStop = true;
            this.typeRequisit.Text = "All RequisitionComponents";
            this.typeRequisit.UseVisualStyleBackColor = true;
            this.typeRequisit.CheckedChanged += new System.EventHandler(this.typeRequisit_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 495);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Project Type:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(191, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 62);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 660);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Project Manager";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 723);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Hardware Engineer";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 753);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "Control Engineer";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 319);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 16);
            this.label14.TabIndex = 5;
            this.label14.Text = "Project Description";
            // 
            // textBox7
            // 
            this.textBox7.AllowDrop = true;
            this.textBox7.Location = new System.Drawing.Point(173, 319);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox7.Size = new System.Drawing.Size(524, 76);
            this.textBox7.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(543, 798);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(133, 28);
            this.progressBar1.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(408, 660);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 16);
            this.label15.TabIndex = 5;
            this.label15.Text = "L1 HMI Engineer";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(381, 688);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "Application Engineer";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(38, 693);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 16);
            this.label17.TabIndex = 13;
            this.label17.Text = "System Engineer";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(382, 720);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 16);
            this.label18.TabIndex = 15;
            this.label18.Text = "Computer Technician";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(417, 748);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 16);
            this.label19.TabIndex = 17;
            this.label19.Text = "Drive Engineer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 798);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 41);
            this.button1.TabIndex = 19;
            this.button1.Text = "Get Users";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_ProjMan
            // 
            this.comboBox_ProjMan.FormattingEnabled = true;
            this.comboBox_ProjMan.Location = new System.Drawing.Point(154, 660);
            this.comboBox_ProjMan.Name = "comboBox_ProjMan";
            this.comboBox_ProjMan.Size = new System.Drawing.Size(197, 24);
            this.comboBox_ProjMan.TabIndex = 20;
            // 
            // comboBox_SWEngineer
            // 
            this.comboBox_SWEngineer.FormattingEnabled = true;
            this.comboBox_SWEngineer.Location = new System.Drawing.Point(154, 690);
            this.comboBox_SWEngineer.Name = "comboBox_SWEngineer";
            this.comboBox_SWEngineer.Size = new System.Drawing.Size(197, 24);
            this.comboBox_SWEngineer.TabIndex = 21;
            // 
            // comboBox_HWEngineer
            // 
            this.comboBox_HWEngineer.FormattingEnabled = true;
            this.comboBox_HWEngineer.Location = new System.Drawing.Point(154, 720);
            this.comboBox_HWEngineer.Name = "comboBox_HWEngineer";
            this.comboBox_HWEngineer.Size = new System.Drawing.Size(198, 24);
            this.comboBox_HWEngineer.TabIndex = 22;
            // 
            // comboBox_ContEng
            // 
            this.comboBox_ContEng.FormattingEnabled = true;
            this.comboBox_ContEng.Location = new System.Drawing.Point(154, 750);
            this.comboBox_ContEng.Name = "comboBox_ContEng";
            this.comboBox_ContEng.Size = new System.Drawing.Size(199, 24);
            this.comboBox_ContEng.TabIndex = 23;
            // 
            // comboBox_HMIEng
            // 
            this.comboBox_HMIEng.FormattingEnabled = true;
            this.comboBox_HMIEng.Location = new System.Drawing.Point(520, 655);
            this.comboBox_HMIEng.Name = "comboBox_HMIEng";
            this.comboBox_HMIEng.Size = new System.Drawing.Size(199, 24);
            this.comboBox_HMIEng.TabIndex = 24;
            // 
            // comboBox_AppEng
            // 
            this.comboBox_AppEng.FormattingEnabled = true;
            this.comboBox_AppEng.Location = new System.Drawing.Point(519, 685);
            this.comboBox_AppEng.Name = "comboBox_AppEng";
            this.comboBox_AppEng.Size = new System.Drawing.Size(199, 24);
            this.comboBox_AppEng.TabIndex = 25;
            // 
            // comboBox_CompTech
            // 
            this.comboBox_CompTech.FormattingEnabled = true;
            this.comboBox_CompTech.Location = new System.Drawing.Point(519, 715);
            this.comboBox_CompTech.Name = "comboBox_CompTech";
            this.comboBox_CompTech.Size = new System.Drawing.Size(200, 24);
            this.comboBox_CompTech.TabIndex = 26;
            // 
            // comboBox_DriveEng
            // 
            this.comboBox_DriveEng.FormattingEnabled = true;
            this.comboBox_DriveEng.Location = new System.Drawing.Point(520, 745);
            this.comboBox_DriveEng.Name = "comboBox_DriveEng";
            this.comboBox_DriveEng.Size = new System.Drawing.Size(199, 24);
            this.comboBox_DriveEng.TabIndex = 27;
            // 
            // checkedListBox_DriveComp
            // 
            this.checkedListBox_DriveComp.FormattingEnabled = true;
            this.checkedListBox_DriveComp.Items.AddRange(new object[] {
            "General Hardware",
            "Application Engineering",
            "General Software",
            "L1 Software",
            "L2 Software",
            "Drive Hardware",
            "Drive Software",
            "L1 HMI Project",
            "L1 HMI Screens",
            "L2 HMI Projects",
            "L2 HMI Screens",
            "General Model Issues",
            "Elementaries"});
            this.checkedListBox_DriveComp.Location = new System.Drawing.Point(172, 520);
            this.checkedListBox_DriveComp.Name = "checkedListBox_DriveComp";
            this.checkedListBox_DriveComp.Size = new System.Drawing.Size(207, 106);
            this.checkedListBox_DriveComp.TabIndex = 28;
            // 
            // checkedListBox_RequistComp
            // 
            this.checkedListBox_RequistComp.FormattingEnabled = true;
            this.checkedListBox_RequistComp.Items.AddRange(new object[] {
            "Drive Software",
            "Drive Hardware",
            "Elementaries",
            "General Hardware",
            "Application Engineering",
            "General Software"});
            this.checkedListBox_RequistComp.Location = new System.Drawing.Point(461, 520);
            this.checkedListBox_RequistComp.Name = "checkedListBox_RequistComp";
            this.checkedListBox_RequistComp.Size = new System.Drawing.Size(207, 106);
            this.checkedListBox_RequistComp.TabIndex = 29;
            // 
            // typeDrive
            // 
            this.typeDrive.AutoSize = true;
            this.typeDrive.Location = new System.Drawing.Point(172, 491);
            this.typeDrive.Name = "typeDrive";
            this.typeDrive.Size = new System.Drawing.Size(157, 20);
            this.typeDrive.TabIndex = 30;
            this.typeDrive.TabStop = true;
            this.typeDrive.Text = "All Drive Components";
            this.typeDrive.UseVisualStyleBackColor = true;
            this.typeDrive.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Is this a Requisition Project?";
            // 
            // radioButton_Yes
            // 
            this.radioButton_Yes.AutoSize = true;
            this.radioButton_Yes.Location = new System.Drawing.Point(173, 442);
            this.radioButton_Yes.Name = "radioButton_Yes";
            this.radioButton_Yes.Size = new System.Drawing.Size(52, 20);
            this.radioButton_Yes.TabIndex = 32;
            this.radioButton_Yes.TabStop = true;
            this.radioButton_Yes.Text = "Yes";
            this.radioButton_Yes.UseVisualStyleBackColor = true;
            // 
            // radio_No
            // 
            this.radio_No.AutoSize = true;
            this.radio_No.Location = new System.Drawing.Point(282, 442);
            this.radio_No.Name = "radio_No";
            this.radio_No.Size = new System.Drawing.Size(46, 20);
            this.radio_No.TabIndex = 33;
            this.radio_No.TabStop = true;
            this.radio_No.Text = "No";
            this.radio_No.UseVisualStyleBackColor = true;
            // 
            // Metals_tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(752, 952);
            this.Controls.Add(this.radio_No);
            this.Controls.Add(this.radioButton_Yes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.typeDrive);
            this.Controls.Add(this.checkedListBox_RequistComp);
            this.Controls.Add(this.checkedListBox_DriveComp);
            this.Controls.Add(this.comboBox_DriveEng);
            this.Controls.Add(this.comboBox_CompTech);
            this.Controls.Add(this.comboBox_AppEng);
            this.Controls.Add(this.comboBox_HMIEng);
            this.Controls.Add(this.comboBox_ContEng);
            this.Controls.Add(this.comboBox_HWEngineer);
            this.Controls.Add(this.comboBox_SWEngineer);
            this.Controls.Add(this.comboBox_ProjMan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.typeRequisit);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Metals_tool";
            this.Text = "MH_tool";
            this.Load += new System.EventHandler(this.Metals_tool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton typeRequisit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_ProjMan;
        private System.Windows.Forms.ComboBox comboBox_SWEngineer;
        private System.Windows.Forms.ComboBox comboBox_HWEngineer;
        private System.Windows.Forms.ComboBox comboBox_ContEng;
        private System.Windows.Forms.ComboBox comboBox_HMIEng;
        private System.Windows.Forms.ComboBox comboBox_AppEng;
        private System.Windows.Forms.ComboBox comboBox_CompTech;
        private System.Windows.Forms.ComboBox comboBox_DriveEng;
        private System.Windows.Forms.CheckedListBox checkedListBox_DriveComp;
        private System.Windows.Forms.CheckedListBox checkedListBox_RequistComp;
        private System.Windows.Forms.RadioButton typeDrive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton_Yes;
        private System.Windows.Forms.RadioButton radio_No;
        //private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.Button button2;
    }
}

