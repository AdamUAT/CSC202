using Moonbase.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moonbase
{
    internal class AudioManager
    {
        private SoundPlayer walk1;
        private SoundPlayer walk2;
        private SoundPlayer walk3;
        private SoundPlayer walk4;
        private List<SoundPlayer> walkSounds;
        private SoundPlayer lastPlayedWalkSound;

        public void PlayWalkSound()
        {
            try
            {
                //Check if the audio has been loaded
                if (walkSounds == null || walkSounds.Count == 0)
                {
                    walk1 = new SoundPlayer(Resources.walk1);
                    walk2 = new SoundPlayer(Resources.walk2);
                    walk3 = new SoundPlayer(Resources.walk3);
                    walk4 = new SoundPlayer(Resources.walk4);

                    walkSounds = new List<SoundPlayer>();
                    walkSounds.Add(walk1);
                    walkSounds.Add(walk2);
                    walkSounds.Add(walk3);
                    walkSounds.Add(walk4);
                }

                System.Random random = new System.Random();
                int soundToPlay = random.Next(walkSounds.Count);

                SoundPlayer soundPlayed = walkSounds[soundToPlay];
                soundPlayed.Play();
                walkSounds.RemoveAt(soundToPlay);
                if (lastPlayedWalkSound != null)
                    walkSounds.Add(lastPlayedWalkSound);
                lastPlayedWalkSound = soundPlayed;
            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
