namespace PowerMeUp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azureCliLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goDirectToAziothubpsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateEntitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadEntitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAvailabilityOfEntityNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.txtHub = new System.Windows.Forms.TextBox();
            this.txtDevice = new System.Windows.Forms.TextBox();
            this.txtDPS = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 47);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.azureCliLoginToolStripMenuItem,
            this.goDirectToAziothubpsToolStripMenuItem,
            this.generateEntitiesToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(126, 43);
            this.actionsToolStripMenuItem.Text = "&Actions";
            // 
            // azureCliLoginToolStripMenuItem
            // 
            this.azureCliLoginToolStripMenuItem.Name = "azureCliLoginToolStripMenuItem";
            this.azureCliLoginToolStripMenuItem.Size = new System.Drawing.Size(471, 48);
            this.azureCliLoginToolStripMenuItem.Text = "Azure Cli &Login";
            this.azureCliLoginToolStripMenuItem.Click += new System.EventHandler(this.azureCliLoginToolStripMenuItem_Click);
            // 
            // goDirectToAziothubpsToolStripMenuItem
            // 
            this.goDirectToAziothubpsToolStripMenuItem.Name = "goDirectToAziothubpsToolStripMenuItem";
            this.goDirectToAziothubpsToolStripMenuItem.Size = new System.Drawing.Size(471, 48);
            this.goDirectToAziothubpsToolStripMenuItem.Text = "Go Direct to &az-iothub-ps";
            this.goDirectToAziothubpsToolStripMenuItem.Click += new System.EventHandler(this.goDirectToAziothubpsToolStripMenuItem_Click);
            // 
            // generateEntitiesToolStripMenuItem
            // 
            this.generateEntitiesToolStripMenuItem.Name = "generateEntitiesToolStripMenuItem";
            this.generateEntitiesToolStripMenuItem.Size = new System.Drawing.Size(471, 48);
            this.generateEntitiesToolStripMenuItem.Text = "&Cancel";
            this.generateEntitiesToolStripMenuItem.Click += new System.EventHandler(this.generateEntitiesToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.reloadEntitiesToolStripMenuItem,
            this.checkAvailabilityOfEntityNamesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(85, 43);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(569, 48);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // reloadEntitiesToolStripMenuItem
            // 
            this.reloadEntitiesToolStripMenuItem.Name = "reloadEntitiesToolStripMenuItem";
            this.reloadEntitiesToolStripMenuItem.Size = new System.Drawing.Size(569, 48);
            this.reloadEntitiesToolStripMenuItem.Text = "&Reload Entities";
            this.reloadEntitiesToolStripMenuItem.Click += new System.EventHandler(this.reloadEntitiesToolStripMenuItem_Click);
            // 
            // checkAvailabilityOfEntityNamesToolStripMenuItem
            // 
            this.checkAvailabilityOfEntityNamesToolStripMenuItem.Name = "checkAvailabilityOfEntityNamesToolStripMenuItem";
            this.checkAvailabilityOfEntityNamesToolStripMenuItem.Size = new System.Drawing.Size(569, 48);
            this.checkAvailabilityOfEntityNamesToolStripMenuItem.Text = "Check Availability of Entity Names";
            this.checkAvailabilityOfEntityNamesToolStripMenuItem.Click += new System.EventHandler(this.checkAvailabilityOfEntityNamesToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(123, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 82);
            this.label1.TabIndex = 1;
            this.label1.Text = "az-iothub-ps";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(73, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subscription:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(195, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 48);
            this.label3.TabIndex = 3;
            this.label3.Text = "Group:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(161, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 48);
            this.label4.TabIndex = 4;
            this.label4.Text = "IoT Hub:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(182, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 48);
            this.label5.TabIndex = 5;
            this.label5.Text = "Device:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(227, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 48);
            this.label6.TabIndex = 6;
            this.label6.Text = "DPS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(73, 608);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(290, 48);
            this.label7.TabIndex = 7;
            this.label7.Text = "Hub Location:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(136, 674);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 48);
            this.label8.TabIndex = 8;
            this.label8.Text = "Hub SKU:";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 48;
            this.listBox1.Items.AddRange(new object[] {
            "B1",
            "B2",
            "B3",
            "F",
            "S1",
            "S2",
            "S3"});
            this.listBox1.Location = new System.Drawing.Point(385, 677);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(131, 196);
            this.listBox1.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(377, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 48);
            this.label9.TabIndex = 10;
            this.label9.Text = "Pending";
            // 
            // txtGroup
            // 
            this.txtGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroup.Location = new System.Drawing.Point(385, 283);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(498, 55);
            this.txtGroup.TabIndex = 11;
            // 
            // txtHub
            // 
            this.txtHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHub.Location = new System.Drawing.Point(385, 359);
            this.txtHub.Name = "txtHub";
            this.txtHub.Size = new System.Drawing.Size(498, 55);
            this.txtHub.TabIndex = 12;
            // 
            // txtDevice
            // 
            this.txtDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevice.Location = new System.Drawing.Point(385, 427);
            this.txtDevice.Name = "txtDevice";
            this.txtDevice.Size = new System.Drawing.Size(498, 55);
            this.txtDevice.TabIndex = 13;
            // 
            // txtDPS
            // 
            this.txtDPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDPS.Location = new System.Drawing.Point(385, 504);
            this.txtDPS.Name = "txtDPS";
            this.txtDPS.Size = new System.Drawing.Size(498, 55);
            this.txtDPS.TabIndex = 14;
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(385, 601);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(498, 55);
            this.txtLocation.TabIndex = 15;
            this.txtLocation.Text = "This is handled later.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 966);
            this.ControlBox = false;
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtDPS);
            this.Controls.Add(this.txtDevice);
            this.Controls.Add(this.txtHub);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "az-iothub-ps";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azureCliLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goDirectToAziothubpsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateEntitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadEntitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAvailabilityOfEntityNamesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.TextBox txtHub;
        private System.Windows.Forms.TextBox txtDevice;
        private System.Windows.Forms.TextBox txtDPS;
        private System.Windows.Forms.TextBox txtLocation;
    }
}

