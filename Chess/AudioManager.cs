using Chess.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class AudioManager
    {
        private SoundPlayer piecePickup;
        private SoundPlayer pieceSetdown;
        private SoundPlayer textSlide;

        public AudioManager() 
        {
            piecePickup = new SoundPlayer(Resources.pickUp);
            pieceSetdown = new SoundPlayer(Resources.SetDown);
            textSlide = new SoundPlayer(Resources.buttonSlide);
        }

        public void PlayPiecePickup()
        {
            piecePickup.Play();
        }

        public void PlayPieceSetdown()
        {
            pieceSetdown.Play();
        }

        public void PlayTextSlide()
        {
            textSlide.Play();
        }

    }
}
