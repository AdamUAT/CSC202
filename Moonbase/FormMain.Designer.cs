using System.Windows.Forms;

namespace Moonbase
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ApplicationMode = new System.Windows.Forms.GroupBox();
            this.Button_Windowed = new System.Windows.Forms.RadioButton();
            this.Button_Widescreen = new System.Windows.Forms.RadioButton();
            this.Button_Fullscreen = new System.Windows.Forms.RadioButton();
            this.MainBackground = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ContentPanel.SuspendLayout();
            this.ApplicationMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainBackground)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.ApplicationMode);
            this.ContentPanel.Controls.Add(this.groupBox1);
            this.ContentPanel.Controls.Add(this.MainBackground);
            this.ContentPanel.Location = new System.Drawing.Point(27, 0);
            this.ContentPanel.Size = new System.Drawing.Size(1850, 1041);
            // 
            // ApplicationMode
            // 
            this.ApplicationMode.Controls.Add(this.Button_Windowed);
            this.ApplicationMode.Controls.Add(this.Button_Widescreen);
            this.ApplicationMode.Controls.Add(this.Button_Fullscreen);
            this.ApplicationMode.Location = new System.Drawing.Point(14, 12);
            this.ApplicationMode.Name = "ApplicationMode";
            this.ApplicationMode.Size = new System.Drawing.Size(200, 101);
            this.ApplicationMode.TabIndex = 5;
            this.ApplicationMode.TabStop = false;
            this.ApplicationMode.Text = "Application Mode";
            // 
            // Button_Windowed
            // 
            this.Button_Windowed.AutoSize = true;
            this.Button_Windowed.Location = new System.Drawing.Point(6, 19);
            this.Button_Windowed.Name = "Button_Windowed";
            this.Button_Windowed.Size = new System.Drawing.Size(76, 17);
            this.Button_Windowed.TabIndex = 1;
            this.Button_Windowed.Text = "Windowed";
            this.Button_Windowed.UseVisualStyleBackColor = true;
            this.Button_Windowed.CheckedChanged += new System.EventHandler(this.Button_Windowed_CheckedChanged);
            // 
            // Button_Widescreen
            // 
            this.Button_Widescreen.AutoSize = true;
            this.Button_Widescreen.Location = new System.Drawing.Point(6, 65);
            this.Button_Widescreen.Name = "Button_Widescreen";
            this.Button_Widescreen.Size = new System.Drawing.Size(82, 17);
            this.Button_Widescreen.TabIndex = 3;
            this.Button_Widescreen.Text = "Widescreen";
            this.Button_Widescreen.UseVisualStyleBackColor = true;
            this.Button_Widescreen.CheckedChanged += new System.EventHandler(this.Button_Widescreen_CheckedChanged);
            // 
            // Button_Fullscreen
            // 
            this.Button_Fullscreen.AutoSize = true;
            this.Button_Fullscreen.Checked = true;
            this.Button_Fullscreen.Location = new System.Drawing.Point(6, 42);
            this.Button_Fullscreen.Name = "Button_Fullscreen";
            this.Button_Fullscreen.Size = new System.Drawing.Size(73, 17);
            this.Button_Fullscreen.TabIndex = 2;
            this.Button_Fullscreen.TabStop = true;
            this.Button_Fullscreen.Text = "Fullscreen";
            this.Button_Fullscreen.UseVisualStyleBackColor = true;
            this.Button_Fullscreen.CheckedChanged += new System.EventHandler(this.Button_Fullscreen_CheckedChanged);
            // 
            // MainBackground
            // 
            this.MainBackground.Image = global::Moonbase.Properties.Resources.Moonbase;
            this.MainBackground.Location = new System.Drawing.Point(0, 0);
            this.MainBackground.Margin = new System.Windows.Forms.Padding(2);
            this.MainBackground.Name = "MainBackground";
            this.MainBackground.Size = new System.Drawing.Size(1920, 1080);
            this.MainBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainBackground.TabIndex = 5;
            this.MainBackground.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1077, 616);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 390);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location Information";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(43, 133);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(295, 71);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room Description";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "The Docks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Name";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Name = "FormMain";
            this.Text = "Port Waterless";
            this.ContentPanel.ResumeLayout(false);
            this.ApplicationMode.ResumeLayout(false);
            this.ApplicationMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainBackground)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ApplicationMode;
        private System.Windows.Forms.RadioButton Button_Windowed;
        private System.Windows.Forms.RadioButton Button_Widescreen;
        private System.Windows.Forms.RadioButton Button_Fullscreen;
        private PictureBox MainBackground;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label3;
    }
}