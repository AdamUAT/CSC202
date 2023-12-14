using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Board : AdjustableForm
    {
        float boardMarginPercent = 0;

        public Board()
        {
            InitializeComponent();
        }

        protected override void OnResize()
        {
            base.OnResize();

            if(boardMarginPercent == 0)
            {
                boardMarginPercent = (float)BoardImage.Location.Y / ContentPanel.Height;
            }

            BoardBackground.Width = ContentPanel.Width;
            BoardBackground.Height = ContentPanel.Height;

            int boardMargin = (int)(boardMarginPercent * BoardBackground.Height);

            BoardImage.Height = BoardBackground.Height - boardMargin * 2;
            BoardImage.Width = BoardImage.Height;
            BoardImage.Location = new Point((int)((BoardBackground.Width / 2.0f) - (BoardImage.Width / 2.0f)), boardMargin);

        }
    }
}
