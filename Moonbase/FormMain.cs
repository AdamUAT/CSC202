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

            //Change the appearance of the screen
            switch (newLocation)
            {
                case Locations.Admin:
                    this.MainBackground.Image = global::Moonbase.Properties.Resources.Admin;
                    LocationName.Text = "Administrative Offices";
                    LocationDescription.Text = "This large room features a large glass window providing a full 180 degree view of moonbase Port Waterless. " +
                        "A hologram projector sits in the middle of the room, where the head officers discuss important decisions. " +
                        "Surrounding the room are stations for the moonbase's controls, which are manned by several scientists to make sure nothing bad happens.";
                    break;
                case Locations.Maintenance:
                    this.MainBackground.Image = global::Moonbase.Properties.Resources.Maintenance;
                    LocationName.Text = "Maintenance";
                    LocationDescription.Text = "The maintenance wing is the largest of the moonbase's wings." +
                        "It consists of multiple stories, reaching below the surface of the moon.\n" +
                        "The first level has several large energy-to-matter fabricators that is used for all of the moonbase's synthetic needs." +
                        "In addition, it also handles scientific reseach and alien study.\n" +
                        "The other levels include nuclear generators, oxygen converters, storage, and hydroponics.";
                    break;
                case Locations.Docs:
                    this.MainBackground.Image = global::Moonbase.Properties.Resources.Airlock;
                    LocationName.Text = "Docking Airlocks";
                    LocationDescription.Text = "Due to the difficulty of docking a spaceship, this wing would be the largest if the dead space was included. " +
                        "The docs support the three major types of spaceships.\n" +
                        "There are 40 internal pressurized docking positions for the dextrous personal ship, the spacefly.\n" +
                        "There are 8 internal non-pressurized for the Alpion mining suits.\n" +
                        "There are 4 external magnetic seals for the large inter-planetary Bynop spaceship.";
                    break;
                case Locations.House:
                    this.MainBackground.Image = global::Moonbase.Properties.Resources.Cabin;
                    LocationName.Text = "Residential Rooms";
                    LocationDescription.Text = "Port Waterless is an important thoroughfare for ships traveling between Earth and the Moon. " +
                        "Due to the low gravity on the moon, the larger ships designed for colonization or deep-space exploration prefer to dock on it rather than the Earth. " +
                        "Specifically, those ships dock at Port Hugo. Port Waterless provides raw resources to Port Hugo for repairs, and many people use Port Waterless as a layover before continuing on to Port Hugo.\n" +
                        "Because of this, Port Waterless is staffed by 120 workers, 36 scientists, and 20 officers. There is also commonly somewhere between 15 and 50 visitors at any given time.\n" +
                        "Due to this, there is 230 bunks in the residential wing. In addition, there is also 10 recreational rooms of different functionality and 5 kitchens.";
                    break;
                default:
                    break;
            }

        }
        #endregion Location Data

        private void Button_Quit_Click(object sender, EventArgs e)
        {
            Program.Quit();
        }
    }
}
