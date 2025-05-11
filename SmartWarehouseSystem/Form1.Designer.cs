namespace SmartWarehouseSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLoad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBattery = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpService = new System.Windows.Forms.DateTimePicker();
            this.chkEmergency = new System.Windows.Forms.CheckBox();
            this.btnAddRobot = new System.Windows.Forms.Button();
            this.dgvRobots = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPick = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDrop = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpSchedule = new System.Windows.Forms.DateTimePicker();
            this.chkTaskEmergency = new System.Windows.Forms.CheckBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lstAlerts = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRobots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // txtModel
            // 
            this.txtModel.AccessibleName = "";
            this.txtModel.BackColor = System.Drawing.Color.White;
            this.txtModel.Location = new System.Drawing.Point(52, 51);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(148, 26);
            this.txtModel.TabIndex = 2;
            this.txtModel.TextChanged += new System.EventHandler(this.txtModel_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Max Load (kg):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Robot Model:";
            // 
            // txtLoad
            // 
            this.txtLoad.BackColor = System.Drawing.Color.White;
            this.txtLoad.Location = new System.Drawing.Point(52, 131);
            this.txtLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLoad.Name = "txtLoad";
            this.txtLoad.Size = new System.Drawing.Size(148, 26);
            this.txtLoad.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Battery (%):";
            // 
            // txtBattery
            // 
            this.txtBattery.BackColor = System.Drawing.Color.White;
            this.txtBattery.Location = new System.Drawing.Point(52, 211);
            this.txtBattery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBattery.Name = "txtBattery";
            this.txtBattery.Size = new System.Drawing.Size(148, 26);
            this.txtBattery.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 272);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Last Service Date:";
            // 
            // dtpService
            // 
            this.dtpService.Location = new System.Drawing.Point(49, 306);
            this.dtpService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpService.Name = "dtpService";
            this.dtpService.Size = new System.Drawing.Size(298, 26);
            this.dtpService.TabIndex = 10;
            // 
            // chkEmergency
            // 
            this.chkEmergency.AutoSize = true;
            this.chkEmergency.Location = new System.Drawing.Point(49, 374);
            this.chkEmergency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEmergency.Name = "chkEmergency";
            this.chkEmergency.Size = new System.Drawing.Size(163, 24);
            this.chkEmergency.TabIndex = 11;
            this.chkEmergency.Text = "Emergency Robot";
            this.chkEmergency.UseVisualStyleBackColor = true;
            this.chkEmergency.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnAddRobot
            // 
            this.btnAddRobot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddRobot.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddRobot.Location = new System.Drawing.Point(49, 408);
            this.btnAddRobot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddRobot.Name = "btnAddRobot";
            this.btnAddRobot.Size = new System.Drawing.Size(112, 35);
            this.btnAddRobot.TabIndex = 12;
            this.btnAddRobot.Text = "Add Robot";
            this.btnAddRobot.UseVisualStyleBackColor = false;
            this.btnAddRobot.Click += new System.EventHandler(this.btnAddRobot_Click);
            // 
            // dgvRobots
            // 
            this.dgvRobots.BackgroundColor = System.Drawing.Color.White;
            this.dgvRobots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRobots.Location = new System.Drawing.Point(237, 28);
            this.dgvRobots.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRobots.Name = "dgvRobots";
            this.dgvRobots.RowHeadersWidth = 62;
            this.dgvRobots.Size = new System.Drawing.Size(376, 201);
            this.dgvRobots.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(686, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pick Location:";
            // 
            // txtPick
            // 
            this.txtPick.BackColor = System.Drawing.Color.White;
            this.txtPick.Location = new System.Drawing.Point(690, 53);
            this.txtPick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPick.Name = "txtPick";
            this.txtPick.Size = new System.Drawing.Size(148, 26);
            this.txtPick.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(687, 94);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Drop Location:";
            // 
            // txtDrop
            // 
            this.txtDrop.BackColor = System.Drawing.Color.White;
            this.txtDrop.Location = new System.Drawing.Point(691, 119);
            this.txtDrop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDrop.Name = "txtDrop";
            this.txtDrop.Size = new System.Drawing.Size(148, 26);
            this.txtDrop.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(690, 169);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Load Weight:";
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.White;
            this.txtWeight.Location = new System.Drawing.Point(691, 194);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(148, 26);
            this.txtWeight.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(684, 272);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Scheduled Start Time:";
            // 
            // dtpSchedule
            // 
            this.dtpSchedule.Location = new System.Drawing.Point(688, 306);
            this.dtpSchedule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpSchedule.Name = "dtpSchedule";
            this.dtpSchedule.Size = new System.Drawing.Size(298, 26);
            this.dtpSchedule.TabIndex = 21;
            // 
            // chkTaskEmergency
            // 
            this.chkTaskEmergency.AutoSize = true;
            this.chkTaskEmergency.Location = new System.Drawing.Point(688, 359);
            this.chkTaskEmergency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTaskEmergency.Name = "chkTaskEmergency";
            this.chkTaskEmergency.Size = new System.Drawing.Size(231, 24);
            this.chkTaskEmergency.TabIndex = 22;
            this.chkTaskEmergency.Text = "Requires Emergency Robot";
            this.chkTaskEmergency.UseVisualStyleBackColor = true;
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddTask.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddTask.Location = new System.Drawing.Point(971, 257);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(112, 35);
            this.btnAddTask.TabIndex = 23;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // dgvTasks
            // 
            this.dgvTasks.BackgroundColor = System.Drawing.Color.White;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Location = new System.Drawing.Point(861, 26);
            this.dgvTasks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.RowHeadersWidth = 62;
            this.dgvTasks.Size = new System.Drawing.Size(339, 203);
            this.dgvTasks.TabIndex = 24;
            this.dgvTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellContentClick);
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAssign.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAssign.Location = new System.Drawing.Point(371, 527);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(148, 35);
            this.btnAssign.TabIndex = 25;
            this.btnAssign.Text = "Assign Robot";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lstAlerts
            // 
            this.lstAlerts.BackColor = System.Drawing.Color.White;
            this.lstAlerts.FormattingEnabled = true;
            this.lstAlerts.ItemHeight = 20;
            this.lstAlerts.Location = new System.Drawing.Point(570, 467);
            this.lstAlerts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstAlerts.Name = "lstAlerts";
            this.lstAlerts.Size = new System.Drawing.Size(496, 164);
            this.lstAlerts.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(524, 665);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 26);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "Name: Khalid Bin Sayed ID: 22203090";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1226, 716);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstAlerts);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.dgvTasks);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.chkTaskEmergency);
            this.Controls.Add(this.dtpSchedule);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDrop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPick);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvRobots);
            this.Controls.Add(this.btnAddRobot);
            this.Controls.Add(this.dtpService);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBattery);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLoad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkEmergency);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRobots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLoad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBattery;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpService;
        private System.Windows.Forms.CheckBox chkEmergency;
        private System.Windows.Forms.Button btnAddRobot;
        private System.Windows.Forms.DataGridView dgvRobots;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPick;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDrop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpSchedule;
        private System.Windows.Forms.CheckBox chkTaskEmergency;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.ListBox lstAlerts;
        private System.Windows.Forms.TextBox textBox1;
    }
}

