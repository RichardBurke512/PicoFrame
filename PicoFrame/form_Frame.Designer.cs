﻿namespace PicoFrame
{
    partial class form_Frame
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Frame = new System.Windows.Forms.Panel();
            this.tb_DisplayMessage = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.pnl_Image = new System.Windows.Forms.Panel();
            this.btn_NewFrame = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.pnl_Frame.SuspendLayout();
            this.pnl_Image.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip
            // 
            this.menuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(-2, 208);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(34, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "MenuStrip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeToolStripMenuItem,
            this.editMessageToolStripMenuItem,
            this.changeImageToolStripMenuItem,
            this.newFrameToolStripMenuItem,
            this.removeFrameToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem1.Text = "...";
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.largeToolStripMenuItem});
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // smallToolStripMenuItem
            // 
            this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            this.smallToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.smallToolStripMenuItem.Text = "Small";
            this.smallToolStripMenuItem.Click += new System.EventHandler(this.smallToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // largeToolStripMenuItem
            // 
            this.largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            this.largeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.largeToolStripMenuItem.Text = "Large";
            this.largeToolStripMenuItem.Click += new System.EventHandler(this.largeToolStripMenuItem_Click);
            // 
            // editMessageToolStripMenuItem
            // 
            this.editMessageToolStripMenuItem.Name = "editMessageToolStripMenuItem";
            this.editMessageToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.editMessageToolStripMenuItem.Text = "Edit Message";
            this.editMessageToolStripMenuItem.Click += new System.EventHandler(this.editMessageToolStripMenuItem_Click);
            // 
            // changeImageToolStripMenuItem
            // 
            this.changeImageToolStripMenuItem.Name = "changeImageToolStripMenuItem";
            this.changeImageToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.changeImageToolStripMenuItem.Text = "Change Image";
            this.changeImageToolStripMenuItem.Click += new System.EventHandler(this.changeImageToolStripMenuItem_Click);
            // 
            // newFrameToolStripMenuItem
            // 
            this.newFrameToolStripMenuItem.Name = "newFrameToolStripMenuItem";
            this.newFrameToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newFrameToolStripMenuItem.Text = "New Frame";
            this.newFrameToolStripMenuItem.Click += new System.EventHandler(this.newFrameToolStripMenuItem_Click);
            // 
            // removeFrameToolStripMenuItem
            // 
            this.removeFrameToolStripMenuItem.Name = "removeFrameToolStripMenuItem";
            this.removeFrameToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.removeFrameToolStripMenuItem.Text = "Remove Frame";
            this.removeFrameToolStripMenuItem.Click += new System.EventHandler(this.removeFrameToolStripMenuItem_Click);
            // 
            // pnl_Frame
            // 
            this.pnl_Frame.Controls.Add(this.tb_DisplayMessage);
            this.pnl_Frame.Controls.Add(this.menuStrip);
            this.pnl_Frame.Location = new System.Drawing.Point(0, 0);
            this.pnl_Frame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_Frame.Name = "pnl_Frame";
            this.pnl_Frame.Size = new System.Drawing.Size(165, 232);
            this.pnl_Frame.TabIndex = 7;
            // 
            // tb_DisplayMessage
            // 
            this.tb_DisplayMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_DisplayMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_DisplayMessage.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DisplayMessage.Location = new System.Drawing.Point(33, 204);
            this.tb_DisplayMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_DisplayMessage.MaxLength = 100;
            this.tb_DisplayMessage.Name = "tb_DisplayMessage";
            this.tb_DisplayMessage.ReadOnly = true;
            this.tb_DisplayMessage.Size = new System.Drawing.Size(92, 20);
            this.tb_DisplayMessage.TabIndex = 5;
            this.tb_DisplayMessage.TabStop = false;
            this.tb_DisplayMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_DisplayMessage.Enter += new System.EventHandler(this.tb_DisplayMessage_Enter);
            this.tb_DisplayMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_DisplayMessage_KeyDown);
            // 
            // btn_Add
            // 
            this.btn_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Add.Font = new System.Drawing.Font("PMingLiU-ExtB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(0, 0);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(150, 162);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "+";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // pnl_Image
            // 
            this.pnl_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_Image.Controls.Add(this.btn_Add);
            this.pnl_Image.Location = new System.Drawing.Point(8, 16);
            this.pnl_Image.Name = "pnl_Image";
            this.pnl_Image.Size = new System.Drawing.Size(150, 162);
            this.pnl_Image.TabIndex = 2;
            // 
            // btn_NewFrame
            // 
            this.btn_NewFrame.Location = new System.Drawing.Point(14, 23);
            this.btn_NewFrame.Name = "btn_NewFrame";
            this.btn_NewFrame.Size = new System.Drawing.Size(75, 23);
            this.btn_NewFrame.TabIndex = 8;
            this.btn_NewFrame.Text = "btn_NewFrame";
            this.btn_NewFrame.UseVisualStyleBackColor = true;
            // 
            // form_Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 233);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Image);
            this.Controls.Add(this.pnl_Frame);
            this.Controls.Add(this.btn_NewFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_Frame";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.form_Frame_Activated);
            this.Deactivate += new System.EventHandler(this.form_Frame_Deactivate);
            this.Load += new System.EventHandler(this.form_Frame_Load);
            this.LocationChanged += new System.EventHandler(this.form_Frame_LocationChanged);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnl_Frame.ResumeLayout(false);
            this.pnl_Frame.PerformLayout();
            this.pnl_Image.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changeImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFrameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Frame;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Panel pnl_Image;
        private System.Windows.Forms.TextBox tb_DisplayMessage;
        private System.Windows.Forms.ToolStripMenuItem editMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFrameToolStripMenuItem;
        private System.Windows.Forms.Button btn_NewFrame;
    }
}

