using Moonbase.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moonbase
{
    public partial class FormMain : AdjustableForm
    {
        //Holds all possible location the player can be in.
        private enum Locations { Admin, Maintenance, Docs, House };
        private Locations currentLocation = Locations.Admin;


        public FormMain()
        {
            InitializeComponent();
            AdjustWindowSize();

            //Must assign delegates for the info window pages because the chagnge to size is not immediately made. 
            PersonalNavDevicePage.Resize += new System.EventHandler(OnInfoResize);

            //Set the starting location
            MoveLocation(Locations.Admin);
        }

        /// <summary>
        /// Adjusts all UI elements of this form
        /// </summary>
        protected override void OnResize()
        {
            base.OnResize();

            //Set the background image scale for this form
            this.MainBackground.Size = new Size(this.ContentPanel.Width, this.ContentPanel.Height);

            //Set the info window size & position
            InfoWindow.Size = new Size(this.ContentPanel.Width * 2 / 5, this.ContentPanel.Height /2);
            InfoWindow.Location = new Point(this.ContentPanel.Width * 3 / 5 - 5, this.ContentPanel.Height / 2 - 5);
        }

        private void OnInfoResize(object sender, EventArgs e)
        {
            //Set the Nav button size & position
            AdministrativeOffices.Size = new Size(PersonalNavDevicePage.Width / 3, PersonalNavDevicePage.Height / 5);
            AdministrativeOffices.Location = new Point(PersonalNavDevicePage.Width / 3, PersonalNavDevicePage.Height / 5 - 10);
            Maintenance.Size = new Size(PersonalNavDevicePage.Width / 3, PersonalNavDevicePage.Height / 5);
            Maintenance.Location = new Point(PersonalNavDevicePage.Width / 6 - 5, PersonalNavDevicePage.Height * 2 / 5);
            DockingPorts.Size = new Size(PersonalNavDevicePage.Width / 3, PersonalNavDevicePage.Height / 5);
            DockingPorts.Location = new Point(PersonalNavDevicePage.Width / 2 + 5, PersonalNavDevicePage.Height * 2 / 5);
            Residential.Size = new Size(PersonalNavDevicePage.Width / 3, PersonalNavDevicePage.Height / 5);
            Residential.Location = new Point(PersonalNavDevicePage.Width / 3, PersonalNavDevicePage.Height * 3 / 5 + 10);
        }

        #region AdjustableForm radio buttons
        private void Button_Windowed_CheckedChanged(object sender, EventArgs e)
        {
            //Make sure the button is not being unchecked
            if (Button_Windowed.Checked)
            {
                //Tell the program all future forms should be windowed
                Program._windowMode = Program.WindowMode.Windowed;

                //Update the window
                AdjustWindowSize();
            }
        }

        private void Button_Fullscreen_CheckedChanged(object sender, EventArgs e)
        {
            //Make sure the button is not being unchecked
            if (Button_Fullscreen.Checked)
            {
                //Tell the program all future forms should be fullscreen
                Program._windowMode = Program.WindowMode.Fullscreen;

                //Update the window
                AdjustWindowSize();
            }
        }

        private void Button_Widescreen_CheckedChanged(object sender, EventArgs e)
        {
            //Make sure the button is not being unchecked
            if (Button_Widescreen.Checked)
            {
                //Tell the program all future forms should be widescreen
                Program._windowMode = Program.WindowMode.Widescreen;

                //Update the window
                AdjustWindowSize();
            }
        }
        #endregion AdjustableForm radio buttons

        #region Location Data
        private void AdministrativeOffices_Click(object sender, EventArgs e)
        {
            //Check we're not somehow already at the admin offices.
            if (currentLocation != Locations.Admin) 
            {
                MoveLocation(Locations.Admin);
            }
        }

        private void Maintenance_Click(object sender, EventArgs e)
        {
            //Check we're not somehow already at maintenance.
            if (currentLocation != Locations.Maintenance)
            {
                MoveLocation(Locations.Maintenance);
            }
        }

        private void DockingPorts_Click(object sender, EventArgs e)
        {
            //Check we're not somehow already at the docs.
            if (currentLocation != Locations.Docs) 
            {
                MoveLocation(Locations.Docs);
            }
        }

        private void Residential_Click(object sender, EventArgs e)
        {
            //Check we're not somehow already at the houses.
            if (currentLocation != Locations.House) 
            {
                MoveLocation(Locations.House);
            }
        }

        /// <summary>
        /// Disables the appropriate button and changes the appearance of the form.
        /// </summary>
        private void MoveLocation(Locations newLocation)
        {
            //Update the current location
            currentLocation = newLocation;

            //Enable all the buttons
            AdministrativeOffices.Enabled = true;
            Maintenance.Enabled = true;
            DockingPorts.Enabled = true;
            Residential.Enabled = true;

            //Disable the button that was clicked
            switch(newLocation)
            {
                case Locations.Admin:
                    AdministrativeOffices.Enabled = false;
                    break;
                case Locations.Maintenance:
                    Maintenance.Enabled = false;
                    break;
                case Locations.Docs:
                    DockingPorts.Enabled = false;
                    break;
                case Locations.House:
                    Residential.Enabled = false;
                    break;
                default:
                    break;
            }

            //Get what the new form should look like
            MoonbaseLocation newLocationData;
            switch (newLocation)
            {
                case Locations.Admin:
                    newLocationData = MoonbaseLocation.Admin;
                    break;
                case Locations.Maintenance:
                    newLocationData = MoonbaseLocation.Maintenance;
                    break;
                case Locations.Docs:
                    newLocationData = MoonbaseLocation.Docs;
                    break;
                case Locations.House:
                    newLocationData = MoonbaseLocation.Houses;
                    break;
                default:
                    newLocationData = new MoonbaseLocation();
                    break;
            }

            //Apply the changes to the form.
            MainBackground.Image = newLocationData.GetBackgroundImage();
            LocationName.Text = newLocationData.GetName();
            LocationDescription.Text = newLocationData.GetRandomDescription();

            ResetNPCs();

            foreach(Actor npcToAdd in newLocationData.GetNPCs())
            {
                AddNPC(npcToAdd);
            }
        }

        private void ResetNPCs()
        {
            foreach(TabPage activeNPC in activeNPCs)
            {
                activeNPC.Controls.Clear();
                NPCsSelection.Controls.Remove(activeNPC);
            }
            activeNPCs.Clear();
        }

        private void AddNPC(Actor npc)
        {
            //Create the new tab page
            TabPage newNPC = new System.Windows.Forms.TabPage();
            newNPC.Location = new System.Drawing.Point(4, 25);
            newNPC.Name = npc.GetName();
            newNPC.Padding = new System.Windows.Forms.Padding(3);
            newNPC.Size = new System.Drawing.Size(456, 265);
            newNPC.Text = npc.GetName();
            newNPC.UseVisualStyleBackColor = true;

            //Cache the page so that it can be removed
            activeNPCs.Add(newNPC);

            //Add the tab page to the tab group
            NPCsSelection.Controls.Add(newNPC);

            //Create the npc description display
            TextBox npcDescription = new System.Windows.Forms.TextBox();
            npcDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            npcDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            npcDescription.Location = new System.Drawing.Point(0, 0);
            npcDescription.Multiline = true;
            npcDescription.Name = "npcDescription";
            npcDescription.ReadOnly = true;
            npcDescription.Size = new System.Drawing.Size(456, 265);
            //npcDescription.TabIndex = 1;
            npcDescription.Text = npc.GetDescription();
            
            //Add the description to the tab
            newNPC.Controls.Add(npcDescription);
        }

        private List<TabPage> activeNPCs = new List<TabPage>();
        #endregion Location Data

        private void Button_Quit_Click(object sender, EventArgs e)
        {
            Program.Quit();
        }
    }
}
