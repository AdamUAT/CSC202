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
            this.ContentPanel.Location = new System.Drawing.Point(0, 2);
            this.ContentPanel.Size = new System.Drawing.Size(1119, 629);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(216, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Button_Windowed
            // 
            this.Button_Windowed.AutoSize = true;
            this.Button_Windowed.Location = new System.Drawing.Point(8, 23);
            this.Button_Windowed.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Windowed.Name = "Button_Windowed";
            this.Button_Windowed.Size = new System.Drawing.Size(92, 20);
            this.Button_Windowed.TabIndex = 1;
            this.Button_Windowed.Text = "Windowed";
            this.Button_Windowed.UseVisualStyleBackColor = true;
            this.Button_Windowed.CheckedChanged += new System.EventHandler(this.Button_Windowed_CheckedChanged);
            // 
            // Button_Fullscreen
            // 
            this.Button_Fullscreen.AutoSize = true;
            this.Button_Fullscreen.Checked = true;
            this.Button_Fullscreen.Location = new System.Drawing.Point(8, 52);
            this.Button_Fullscreen.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Fullscreen.Name = "Button_Fullscreen";
            this.Button_Fullscreen.Size = new System.Drawing.Size(90, 20);
            this.Button_Fullscreen.TabIndex = 2;
            this.Button_Fullscreen.TabStop = true;
            this.Button_Fullscreen.Text = "Fullscreen";
            this.Button_Fullscreen.UseVisualStyleBackColor = true;
            this.Button_Fullscreen.CheckedChanged += new System.EventHandler(this.Button_Fullscreen_CheckedChanged);
            // 
            // Button_Widescreen
            // 
            this.Button_Widescreen.AutoSize = true;
            this.Button_Widescreen.Location = new System.Drawing.Point(8, 80);
            this.Button_Widescreen.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Widescreen.Name = "Button_Widescreen";
            this.Button_Widescreen.Size = new System.Drawing.Size(101, 20);
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
            this.ApplicationMode.Location = new System.Drawing.Point(676, 162);
            this.ApplicationMode.Margin = new System.Windows.Forms.Padding(4);
            this.ApplicationMode.Name = "ApplicationMode";
            this.ApplicationMode.Padding = new System.Windows.Forms.Padding(4);
            this.ApplicationMode.Size = new System.Drawing.Size(267, 124);
            this.ApplicationMode.TabIndex = 4;
            this.ApplicationMode.TabStop = false;
            this.ApplicationMode.Text = "Application Mode";
            // 
            // MainBackground
            // 
            this.MainBackground.Image = global::Tutorial2.Properties.Resources.Background;
            this.MainBackground.Location = new System.Drawing.Point(0, 0);
            this.MainBackground.Name = "MainBackground";
            this.MainBackground.Size = new System.Drawing.Size(1, 1);
            this.MainBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainBackground.TabIndex = 5;
            this.MainBackground.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 587);
            this.Controls.Add(this.ApplicationMode);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
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

