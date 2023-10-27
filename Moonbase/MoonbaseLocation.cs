using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moonbase
{
    internal class MoonbaseLocation
    {
        private string name;
        private string description;
        private Image backgroundImage;
        private List<Actor> npcs;

        //Default constructor
        public MoonbaseLocation()
        {
            name = "";
            description = "";
            backgroundImage = Properties.Resources.Transparent;
            npcs = new List<Actor>();
        }

        public MoonbaseLocation(string n, string d, Image i, List<Actor> a)
        {
            name = n;
            description = d;
            backgroundImage = i;
            npcs = a;
        }

        public string GetName()
        {
            return name;
        }

        public string GetDescription()
        {
            return description;
        }

        public Image GetBackgroundImage()
        {
            return backgroundImage;
        }

        public List<Actor> GetNPCs()
        {
            return npcs;
        }

        #region Locations (static instances)
        public static readonly MoonbaseLocation Admin = new MoonbaseLocation("Administrative Offices",
            "This large room features a large glass window providing a full 180 degree view of moonbase Port Waterless. " +
            "A hologram projector sits in the middle of the room, where the head officers discuss important decisions. " +
            "Surrounding the room are stations for the moonbase's controls, which are manned by several scientists to make sure nothing bad happens.",
            Properties.Resources.Admin,
            new List<Actor>() {Actor.Administrator});
        public static readonly MoonbaseLocation Maintenance = new MoonbaseLocation("Maintenance",
            "The maintenance wing is the largest of the moonbase's wings." +
            "It consists of multiple stories, reaching below the surface of the moon.\n" +
            "The first level has several large energy-to-matter fabricators that is used for all of the moonbase's synthetic needs." +
            "In addition, it also handles scientific reseach and alien study.\n" +
            "The other levels include nuclear generators, oxygen converters, storage, and hydroponics.",
            Properties.Resources.Maintenance,
            new List<Actor>() { Actor.DrSteve });
        public static readonly MoonbaseLocation Docs = new MoonbaseLocation("Docking Airlocks",
            "Due to the difficulty of docking a spaceship, this wing would be the largest if the dead space was included. " +
            "The docs support the three major types of spaceships.\n" +
            "There are 40 internal pressurized docking positions for the dextrous personal ship, the spacefly.\n" +
            "There are 8 internal non-pressurized for the Alpion mining suits.\n" +
            "There are 4 external magnetic seals for the large inter-planetary Bynop spaceship.",
            Properties.Resources.Airlock,
            new List<Actor>() { Actor.MechanicJoe });
        public static readonly MoonbaseLocation Houses = new MoonbaseLocation("Residential Rooms",
            "Port Waterless is an important thoroughfare for ships traveling between Earth and the Moon. " +
            "Due to the low gravity on the moon, the larger ships designed for colonization or deep-space exploration prefer to dock on it rather than the Earth. " +
            "Specifically, those ships dock at Port Hugo. Port Waterless provides raw resources to Port Hugo for repairs, and many people use Port Waterless as a layover before continuing on to Port Hugo.\n" +
            "Because of this, Port Waterless is staffed by 120 workers, 36 scientists, and 20 officers. There is also commonly somewhere between 15 and 50 visitors at any given time.\n" +
            "Due to this, there is 230 bunks in the residential wing. In addition, there is also 10 recreational rooms of different functionality and 5 kitchens.",
            Properties.Resources.Cabin,
            new List<Actor>() { Actor.Alice, Actor.Riley });
        #endregion Locations (static instances)
    }
}
