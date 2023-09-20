using System.Drawing;
using System.Windows.Forms;

namespace Tutorial2
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
            this.Button_Windowed = new System.Windows.Forms.RadioButton();
            this.Button_Fullscreen = new System.Windows.Forms.RadioButton();
            this.Button_Widescreen = new System.Windows.Forms.RadioButton();
            this.ApplicationMode = new System.Windows.Forms.GroupBox();
            this.MainBackground = new System.Windows.Forms.PictureBox();
            this.ContentPanel.SuspendLayout();
            this.ApplicationMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.MainBackground);
            this.ContentPanel.Location = new System.Drawing.Point(0, 21);
            this.ContentPanel.Size = new System.Drawing.Size(842, 473);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(162, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
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
            // ApplicationMode
            // 
            this.ApplicationMode.Controls.Add(this.Button_Windowed);
            this.ApplicationMode.Controls.Add(this.Button_Widescreen);
            this.ApplicationMode.Controls.Add(this.Button_Fullscreen);
            this.ApplicationMode.Location = new System.Drawing.Point(507, 132);
            this.ApplicationMode.Name = "ApplicationMode";
            this.ApplicationMode.Size = new System.Drawing.Size(200, 101);
            this.ApplicationMode.TabIndex = 4;
            this.ApplicationMode.TabStop = false;
            this.ApplicationMode.Text = "Application Mode";
            // 
            // MainBackground
            // 
            this.MainBackground.Image = global::Tutorial2.Properties.Resources.Background;
            this.MainBackground.Location = new System.Drawing.Point(0, 0);
            this.MainBackground.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MainBackground.Name = "MainBackground";
            this.MainBackground.Size = new System.Drawing.Size(1, 1);
            this.MainBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainBackground.TabIndex = 5;
            this.MainBackground.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 477);
            this.Controls.Add(this.ApplicationMode);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.ContentPanel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.ApplicationMode, 0);
            this.ContentPanel.ResumeLayout(false);
            this.ApplicationMode.ResumeLayout(false);
            this.ApplicationMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Button_Windowed;
        private System.Windows.Forms.RadioButton Button_Fullscreen;
        private System.Windows.Forms.RadioButton Button_Widescreen;
        private System.Windows.Forms.GroupBox ApplicationMode;
        private PictureBox MainBackground;
    }
}

