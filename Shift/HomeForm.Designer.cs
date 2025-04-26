namespace Shift
{
    partial class HomeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.FriendsButton = new System.Windows.Forms.Button();
            this.SettingButton = new System.Windows.Forms.Button();
            this.BrowserButton = new System.Windows.Forms.Button();
            this.GameButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HideButton = new System.Windows.Forms.PictureBox();
            this.StrecthButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HideButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrecthButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FriendsButton);
            this.panel1.Controls.Add(this.SettingButton);
            this.panel1.Controls.Add(this.BrowserButton);
            this.panel1.Controls.Add(this.GameButton);
            this.panel1.Controls.Add(this.HideButton);
            this.panel1.Controls.Add(this.StrecthButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1452, 40);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // FriendsButton
            // 
            this.FriendsButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FriendsButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FriendsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendsButton.Location = new System.Drawing.Point(598, -8);
            this.FriendsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FriendsButton.Name = "FriendsButton";
            this.FriendsButton.Size = new System.Drawing.Size(190, 48);
            this.FriendsButton.TabIndex = 7;
            this.FriendsButton.Text = "Friends";
            this.FriendsButton.UseVisualStyleBackColor = true;
            this.FriendsButton.Click += new System.EventHandler(this.FriendsButton_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SettingButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.SettingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingButton.Location = new System.Drawing.Point(399, -8);
            this.SettingButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(190, 48);
            this.SettingButton.TabIndex = 6;
            this.SettingButton.Text = "Setting";
            this.SettingButton.UseVisualStyleBackColor = true;
            // 
            // BrowserButton
            // 
            this.BrowserButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BrowserButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.BrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowserButton.Location = new System.Drawing.Point(200, -8);
            this.BrowserButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BrowserButton.Name = "BrowserButton";
            this.BrowserButton.Size = new System.Drawing.Size(190, 48);
            this.BrowserButton.TabIndex = 5;
            this.BrowserButton.Text = "Browser";
            this.BrowserButton.UseVisualStyleBackColor = true;
            this.BrowserButton.Click += new System.EventHandler(this.BrowserButton_Click);
            // 
            // GameButton
            // 
            this.GameButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameButton.Location = new System.Drawing.Point(0, -8);
            this.GameButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GameButton.Name = "GameButton";
            this.GameButton.Size = new System.Drawing.Size(190, 48);
            this.GameButton.TabIndex = 4;
            this.GameButton.Text = "Game";
            this.GameButton.UseVisualStyleBackColor = true;
            this.GameButton.Click += new System.EventHandler(this.GameButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Shift.Properties.Resources.WelcomMain1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1452, 829);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HideButton
            // 
            this.HideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HideButton.Image = global::Shift.Properties.Resources.One;
            this.HideButton.Location = new System.Drawing.Point(1290, 0);
            this.HideButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(48, 48);
            this.HideButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HideButton.TabIndex = 3;
            this.HideButton.TabStop = false;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // StrecthButton
            // 
            this.StrecthButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StrecthButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StrecthButton.Image = global::Shift.Properties.Resources.Two;
            this.StrecthButton.Location = new System.Drawing.Point(1347, 0);
            this.StrecthButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StrecthButton.Name = "StrecthButton";
            this.StrecthButton.Size = new System.Drawing.Size(48, 48);
            this.StrecthButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StrecthButton.TabIndex = 2;
            this.StrecthButton.TabStop = false;
            this.StrecthButton.Click += new System.EventHandler(this.StrecthButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Image = global::Shift.Properties.Resources.tree;
            this.CloseButton.Location = new System.Drawing.Point(1404, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(48, 48);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseButton.TabIndex = 1;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1452, 866);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HideButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrecthButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox StrecthButton;
        private System.Windows.Forms.PictureBox HideButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GameButton;
        private System.Windows.Forms.Button BrowserButton;
        private System.Windows.Forms.Button FriendsButton;
        private System.Windows.Forms.Button SettingButton;
    }
}