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
            this.InfoWindow = new System.Windows.Forms.TabControl();
            this.PersonalNavDevicePage = new System.Windows.Forms.TabPage();
            this.Residential = new System.Windows.Forms.Button();
            this.DockingPorts = new System.Windows.Forms.Button();
            this.Maintenance = new System.Windows.Forms.Button();
            this.AdministrativeOffices = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LocationDescription = new System.Windows.Forms.TextBox();
            this.LocationName = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.MainBackground = new System.Windows.Forms.PictureBox();
            this.Button_Quit = new System.Windows.Forms.Button();
            this.ContentPanel.SuspendLayout();
            this.ApplicationMode.SuspendLayout();
            this.InfoWindow.SuspendLayout();
            this.PersonalNavDevicePage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.InfoWindow);
            this.ContentPanel.Controls.Add(this.MainBackground);
            this.ContentPanel.Location = new System.Drawing.Point(33, 0);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ContentPanel.Size = new System.Drawing.Size(1196, 673);
            // 
            // ApplicationMode
            // 
            this.ApplicationMode.Controls.Add(this.Button_Windowed);
            this.ApplicationMode.Controls.Add(this.Button_Widescreen);
            this.ApplicationMode.Controls.Add(this.Button_Fullscreen);
            this.ApplicationMode.Location = new System.Drawing.Point(7, 7);
            this.ApplicationMode.Margin = new System.Windows.Forms.Padding(4);
            this.ApplicationMode.Name = "ApplicationMode";
            this.ApplicationMode.Padding = new System.Windows.Forms.Padding(4);
            this.ApplicationMode.Size = new System.Drawing.Size(267, 124);
            this.ApplicationMode.TabIndex = 5;
            this.ApplicationMode.TabStop = false;
            this.ApplicationMode.Text = "Application Mode";
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
            // InfoWindow
            // 
            this.InfoWindow.Controls.Add(this.PersonalNavDevicePage);
            this.InfoWindow.Controls.Add(this.tabPage2);
            this.InfoWindow.Controls.Add(this.tabPage3);
            this.InfoWindow.Location = new System.Drawing.Point(712, 316);
            this.InfoWindow.Name = "InfoWindow";
            this.InfoWindow.SelectedIndex = 0;
            this.InfoWindow.Size = new System.Drawing.Size(481, 354);
            this.InfoWindow.TabIndex = 6;
            // 
            // PersonalNavDevicePage
            // 
            this.PersonalNavDevicePage.Controls.Add(this.Residential);
            this.PersonalNavDevicePage.Controls.Add(this.DockingPorts);
            this.PersonalNavDevicePage.Controls.Add(this.Maintenance);
            this.PersonalNavDevicePage.Controls.Add(this.AdministrativeOffices);
            this.PersonalNavDevicePage.Location = new System.Drawing.Point(4, 25);
            this.PersonalNavDevicePage.Name = "PersonalNavDevicePage";
            this.PersonalNavDevicePage.Padding = new System.Windows.Forms.Padding(3);
            this.PersonalNavDevicePage.Size = new System.Drawing.Size(473, 325);
            this.PersonalNavDevicePage.TabIndex = 0;
            this.PersonalNavDevicePage.Text = "Personal Nav Device";
            this.PersonalNavDevicePage.UseVisualStyleBackColor = true;
            // 
            // Residential
            // 
            this.Residential.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Residential.Location = new System.Drawing.Point(145, 217);
            this.Residential.Name = "Residential";
            this.Residential.Size = new System.Drawing.Size(172, 56);
            this.Residential.TabIndex = 3;
            this.Residential.Text = "Residential";
            this.Residential.UseVisualStyleBackColor = true;
            this.Residential.Click += new System.EventHandler(this.Residential_Click);
            // 
            // DockingPorts
            // 
            this.DockingPorts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DockingPorts.Location = new System.Drawing.Point(260, 137);
            this.DockingPorts.Name = "DockingPorts";
            this.DockingPorts.Size = new System.Drawing.Size(172, 56);
            this.DockingPorts.TabIndex = 2;
            this.DockingPorts.Text = "Docking Ports";
            this.DockingPorts.UseVisualStyleBackColor = true;
            this.DockingPorts.Click += new System.EventHandler(this.DockingPorts_Click);
            // 
            // Maintenance
            // 
            this.Maintenance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Maintenance.Location = new System.Drawing.Point(33, 137);
            this.Maintenance.Name = "Maintenance";
            this.Maintenance.Size = new System.Drawing.Size(172, 56);
            this.Maintenance.TabIndex = 1;
            this.Maintenance.Text = "Maintenance";
            this.Maintenance.UseVisualStyleBackColor = true;
            this.Maintenance.Click += new System.EventHandler(this.Maintenance_Click);
            // 
            // AdministrativeOffices
            // 
            this.AdministrativeOffices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdministrativeOffices.Location = new System.Drawing.Point(145, 49);
            this.AdministrativeOffices.Name = "AdministrativeOffices";
            this.AdministrativeOffices.Size = new System.Drawing.Size(172, 56);
            this.AdministrativeOffices.TabIndex = 0;
            this.AdministrativeOffices.Text = "Administrative Offices";
            this.AdministrativeOffices.UseVisualStyleBackColor = true;
            this.AdministrativeOffices.Click += new System.EventHandler(this.AdministrativeOffices_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LocationDescription);
            this.tabPage2.Controls.Add(this.LocationName);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(473, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Current Location";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LocationDescription
            // 
            this.LocationDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LocationDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LocationDescription.Location = new System.Drawing.Point(3, 40);
            this.LocationDescription.Multiline = true;
            this.LocationDescription.Name = "LocationDescription";
            this.LocationDescription.ReadOnly = true;
            this.LocationDescription.Size = new System.Drawing.Size(467, 279);
            this.LocationDescription.TabIndex = 1;
            this.LocationDescription.Text = resources.GetString("LocationDescription.Text");
            // 
            // LocationName
            // 
            this.LocationName.AutoSize = true;
            this.LocationName.BackColor = System.Drawing.Color.White;
            this.LocationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationName.Location = new System.Drawing.Point(7, 7);
            this.LocationName.Name = "LocationName";
            this.LocationName.Size = new System.Drawing.Size(137, 18);
            this.LocationName.TabIndex = 0;
            this.LocationName.Text = "Administrative Offices";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Button_Quit);
            this.tabPage3.Controls.Add(this.ApplicationMode);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(473, 325);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Menu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MainBackground
            // 
            this.MainBackground.Image = global::Moonbase.Properties.Resources.Admin;
            this.MainBackground.Location = new System.Drawing.Point(0, 0);
            this.MainBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainBackground.Name = "MainBackground";
            this.MainBackground.Size = new System.Drawing.Size(2560, 1329);
            this.MainBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainBackground.TabIndex = 5;
            this.MainBackground.TabStop = false;
            // 
            // Button_Quit
            // 
            this.Button_Quit.Location = new System.Drawing.Point(7, 152);
            this.Button_Quit.Name = "Button_Quit";
            this.Button_Quit.Size = new System.Drawing.Size(75, 23);
            this.Button_Quit.TabIndex = 6;
            this.Button_Quit.Text = "Quit";
            this.Button_Quit.UseVisualStyleBackColor = true;
            this.Button_Quit.Click += new System.EventHandler(this.Button_Quit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FormMain";
            this.Text = "Port Waterless";
            this.ContentPanel.ResumeLayout(false);
            this.ApplicationMode.ResumeLayout(false);
            this.ApplicationMode.PerformLayout();
            this.InfoWindow.ResumeLayout(false);
            this.PersonalNavDevicePage.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ApplicationMode;
        private System.Windows.Forms.RadioButton Button_Windowed;
        private System.Windows.Forms.RadioButton Button_Widescreen;
        private System.Windows.Forms.RadioButton Button_Fullscreen;
        private TabControl InfoWindow;
        private TabPage PersonalNavDevicePage;
        private TabPage tabPage2;
        private PictureBox MainBackground;
        private TabPage tabPage3;
        private Button Residential;
        private Button DockingPorts;
        private Button Maintenance;
        private Button AdministrativeOffices;
        private Label LocationName;
        private TextBox LocationDescription;
        private Button Button_Quit;
    }
}