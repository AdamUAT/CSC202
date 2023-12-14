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
        private List<string> descriptions;
        private Image backgroundImage;
        private List<Actor> npcs;

        //Default constructor
        public MoonbaseLocation()
        {
            name = "";
            descriptions = new List<string>();
            backgroundImage = Properties.Resources.Transparent;
            npcs = new List<Actor>();
        }

        public MoonbaseLocation(string n, List<string> d, Image i, List<Actor> a)
        {
            name = n;
            descriptions = d;
            backgroundImage = i;
            npcs = a;
        }

        public string GetName()
        {
            return name;
        }

        public string GetRandomDescription()
        {
            System.Random random = new System.Random();
            int iterator = random.Next(descriptions.Count);
            return descriptions[iterator];
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
            new List<string>()
            {
                "This large room features a large glass window providing a full 180 degree view of moonbase Port Waterless. " +
                    "A hologram projector sits in the middle of the room, where the head officers discuss important decisions. " +
                    "Surrounding the room are stations for the moonbase's controls, which are manned by several scientists to make sure nothing bad happens.",
                "The administative offices is alive and busy.",
                "The administrative offices is almost completely empty and silent.",
                "The administrative offices is full of staff members running to and fro as many lights are flashing and alarms are sounding.",
                "Alarms are going crazy in the administrator offices, but no one is there paying attention."
            },            
            Properties.Resources.Admin,
            new List<Actor>() {Actor.Administrator});
        public static readonly MoonbaseLocation Maintenance = new MoonbaseLocation("Maintenance",
            new List<string>()
            {
                "The maintenance wing is the largest of the moonbase's wings." +
                    "It consists of multiple stories, reaching below the surface of the moon.\n" +
                    "The first level has several large energy-to-matter fabricators that is used for all of the moonbase's synthetic needs." +
                    "In addition, it also handles scientific reseach and alien study.\n" +
                    "The other levels include nuclear generators, oxygen converters, storage, and hydroponics.",
                "The lowest level of the Maintnence wing is several miles underneath the serface of the moon, consisting of a hylium fission reactor.",
                "The storage level is the first level underground. It consists of 10 levels, each one almost 100 thousand square feet of space." +
                    "The storage system is managed by automated systems, allowing for quick storage and retrieval without the user needing to walk miles.",
                "The oxygen converters work by seperating the oxygem molecules from carbon dioxide." +
                    "While the process of breaking a stable molecule apart is very energy-inneficient, the nuclear reactors provide plenty of power.",
                "Most of the food for the moonbase is maintained by a hydroponics system." +
                    "This allows the moonbase to be mostly self-sufficient."
            },
            Properties.Resources.Maintenance,
            new List<Actor>() { Actor.DrSteve });
        public static readonly MoonbaseLocation Docs = new MoonbaseLocation("Docking Airlocks",
            new List<string>()
            {
                "Due to the difficulty of docking a spaceship, this wing would be the largest if the dead space was included. " +
                    "The docs support the three major types of spaceships.\n" +
                    "There are 40 internal pressurized docking positions for the dextrous personal ship, the spacefly.\n" +
                    "There are 8 internal non-pressurized for the Alpion mining suits.\n" +
                    "There are 4 external magnetic seals for the large inter-planetary Bynop spaceship.",
                "The docs are currently empty, with only a few ships that belong to the permanent crew of Port Waterless.",
                "The docs are very busy right now. This is apparently the start of vation season, as many Bynop-class cruise ships." +
                    "A line has formed since the port doesn't have enough airlocks for all the Bynop spaceships.",
                "A crew of Alpion miners are offloading their loads of titanium, copper, and lithium.",
                "A wealthy upper-class member is currently trying to dock his \"modified spacefly,\" while the exasperated landing crew are trying to explain that his spacefly is four times the size it should be."
            },
            Properties.Resources.Airlock,
            new List<Actor>() { Actor.MechanicJoe });
        public static readonly MoonbaseLocation Houses = new MoonbaseLocation("Residential Rooms",
            new List<string>()
            {
                "Port Waterless is an important thoroughfare for ships traveling between Earth and the Moon. " +
                    "Due to the low gravity on the moon, the larger ships designed for colonization or deep-space exploration prefer to dock on it rather than the Earth. " +
                    "Specifically, those ships dock at Port Hugo. Port Waterless provides raw resources to Port Hugo for repairs, and many people use Port Waterless as a layover before continuing on to Port Hugo.\n" +
                    "Because of this, Port Waterless is staffed by 120 workers, 36 scientists, and 20 officers. There is also commonly somewhere between 15 and 50 visitors at any given time.\n" +
                    "Due to this, there is 230 bunks in the residential wing. In addition, there is also 10 recreational rooms of different functionality and 5 kitchens.",
                "Stephen lit his room on fire again.",
                "One of the scientist's exprirement got loose in wing 2A, and now it's condemned until the smell aires out.",
                "There was a crew of rowdy tourists last night and now the Janitor Bob is having to clean up their mess.",
                "It's weekly poker night for the officers. Lt. Johnson has only lost one bet, everone thinks he's cheating."
            },
            Properties.Resources.Cabin,
            new List<Actor>() { Actor.Alice, Actor.Riley });
        #endregion Locations (static instances)
    }
}
