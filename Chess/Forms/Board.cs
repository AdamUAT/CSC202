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

        BoardSpace[] spaces = new BoardSpace[64];

        public Board()
        {
            InitializeComponent();

            //Initialize the board
            for (int i = 0; i < 64; i++)
            {
                spaces[i] = new BoardSpace(Piece.PieceTypes.Pawn, true, BoardImage);
            }
        }

        protected override void OnResize()
        {
            base.OnResize();

            if (boardMarginPercent == 0)
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

    internal class BoardSpace
    {
        public Piece Piece;

        public BoardSpace(Piece.PieceTypes initialPiece, bool isBlack, Control parent)
        {
            Piece = new Piece(initialPiece, isBlack, parent);
        }
    }

    internal class Piece
    {
        public enum PieceTypes { None, Pawn, Rook, Bishop, Knight, Queen, King }

        public PieceTypes pieceType = PieceTypes.None;

        PictureBox image;

        private Control parent;

        bool isBlack = true;

        public Piece(PieceTypes type, bool _isBlack, Control _parent)
        {
            pieceType = type;
            isBlack = _isBlack;
            parent = _parent;

            if (pieceType != PieceTypes.None)
            {
                image = new PictureBox();

                //Set image
                switch (pieceType)
                {
                    case PieceTypes.Pawn:
                        if (isBlack)
                        {
                            image.Image = Properties.Resources.Pawn_Black;
                        }
                        else
                        {
                            image.Image = Properties.Resources.Pawn_White;
                        }
                        break;
                    case PieceTypes.Rook:
                        if (isBlack)
                        {
                            image.Image = Properties.Resources.Rook_Black;
                        }
                        else
                        {
                            image.Image = Properties.Resources.Rook_White;
                        }
                        break;
                    case PieceTypes.Bishop:
                        if (isBlack)
                        {
                            image.Image = Properties.Resources.Bishop_Black;
                        }
                        else
                        {
                            image.Image = Properties.Resources.Bishop_White;
                        }
                        break;
                    case PieceTypes.Knight:
                        if (isBlack)
                        {
                            image.Image = Properties.Resources.Knight_Black;
                        }
                        else
                        {
                            image.Image = Properties.Resources.Knight_White;
                        }
                        break;
                    case PieceTypes.Queen:
                        if (isBlack)
                        {
                            image.Image = Properties.Resources.Queen_Black;
                        }
                        else
                        {
                            image.Image = Properties.Resources.Queen_White;
                        }
                        break;
                    case PieceTypes.King:
                        if (isBlack)
                        {
                            image.Image = Properties.Resources.King_Black;
                        }
                        else
                        {
                            image.Image = Properties.Resources.King_White;
                        }
                        break;
                    default:
                        MessageBox.Show("Enum PieceType went out of scope.");
                        break;
                }

                image.BackColor = Color.Transparent;
                image.Location = new Point(0, 0);
                image.Size = new Size(50, 50);
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.TabIndex = 0;
                image.TabStop = false;
                parent.Controls.Add(image);
                image.Click += StartDragging;
            }

        }

        private void StartDragging(object sender, EventArgs e)
        {
            image.Click -= StartDragging;
            image.Click += StopDragging;

            Program.updateTimer.Tick += DragPiece;
        }

        private void DragPiece(Object sender, EventArgs e)
        {
            image.Location = parent.PointToClient(Control.MousePosition);

        }

        private void StopDragging(object sender, EventArgs e)
        {
            image.Click += StartDragging;
            image.Click -= StopDragging;
            Program.updateTimer.Tick -= DragPiece;
        }
    }
}
