using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moonbase
{
    internal class Actor
    {
        private string name;
        private string description;

        //Default constructor
        public Actor()
        {
            name = "";
            description = "";
        }

        public Actor(string n, string d)
        {
            name = n;
            description = d;
        }

        public string GetName()
        {
            return name;
        }

        public string GetDescription()
        {
            return description;
        }

        #region Locations (static instances)
        public static readonly Actor Administrator = new Actor("The Administrator",
            "The Administrator \"controlls\" the entire moonbase, but he doesn't have much to do on a day to day basis because of the automated systems.\n" +
            "Currently, he is sleeping on the holographic projector with a bottle of unidentified expensive liquid next to him.");
        public static readonly Actor DrSteve = new Actor("Dr. Steve",
            "Dr. Steve is not a medical doctor, but instead a expert in fabrication with a doctrite in quantum physics.\n" +
            "Working with the fabricators requires Dr. Steve to dress in a heavy radiation protection suit, which he is wearing right now.");
        public static readonly Actor MechanicJoe = new Actor("Mechanic Joe",
            "Mechanic Joe is hard at work repairing the drive core of a spacefly");
        public static readonly Actor Alice = new Actor("Captain Alice",
            "Captain Alice is currently reading up on \"Space Weekly\" on her datavice. She is waiting for her spacefly to be repaired by Mechanic Joe.");
        public static readonly Actor Riley = new Actor("Riley",
            "Riley is the Non-Essential Systems Maintence Chief for Port Waterless. He is currently sleeping, since he works the night shift.");
        #endregion Locations (static instances)
    }
}
