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

        List<Piece> pieces = new List<Piece>();

        float returnLocationPercentX = 0;
        float returnLocationPercentY = 0;
        float returnScalePercentX = 0;
        float returnScalePercentY = 0;

        public Board()
        {
            InitializeComponent();

            //Initialize the board
            #region Pieces
            Piece leftBlackRook = new Piece(Piece.PieceTypes.Rook, true, BoardImage);
            leftBlackRook.SetLocation((int)(BoardImage.Width * 1 / 18.0f), (int)(BoardImage.Height * 1 / 18.0f));
            leftBlackRook.SetScale((int)(BoardImage.Width * 1.0f / 9), (int)(BoardImage.Height * 1.0f / 9));
            pieces.Add(leftBlackRook);

            Piece leftBlackKnight = new Piece(Piece.PieceTypes.Knight, true, BoardImage);
            leftBlackKnight.SetLocation((int)(BoardImage.Width * 3 / 18.0f), (int)(BoardImage.Height * 1 / 18.0f));
            leftBlackKnight.SetScale((int)(BoardImage.Width * 1.0f / 9), (int)(BoardImage.Height * 1.0f / 9));
            pieces.Add(leftBlackKnight);

            Piece leftBlackBishop = new Piece(Piece.PieceTypes.Bishop, true, BoardImage);
            leftBlackBishop.SetLocation((int)(BoardImage.Width * 5 / 18.0f), (int)(BoardImage.Height * 1 / 18.0f));
            leftBlackBishop.SetScale((int)(BoardImage.Width * 1.0f / 9), (int)(BoardImage.Height * 1.0f / 9));
            pieces.Add(leftBlackBishop);

            Piece blackKing = new Piece(Piece.PieceTypes.King, true, BoardImage);
            blackKing.SetLocation((int)(BoardImage.Width * 7 / 18.0f), (int)(BoardImage.Height * 1 / 18.0f));
            blackKing.SetScale((int)(BoardImage.Width * 1.0f / 9), (int)(BoardImage.Height * 1.0f / 9));
            pieces.Add(blackKing);

            Piece blackQueen = new Piece(Piece.PieceTypes.Queen, true, BoardImage);
            blackQueen.SetLocation((int)(BoardImage.Width * 9 / 18.0f), (int)(BoardImage.Height * 1 / 18.0f));
            blackQueen.SetScale((int)(BoardImage.Width * 1.0f / 9), (int)(BoardImage.Height * 1.0f / 9));
            pieces.Add(blackQueen);

            Piece rightBlackBishop = new Piece(Piece.PieceTypes.Bishop, true, BoardImage);
            rightBlackBishop.SetLocation((int)(BoardImage.Width * 11 / 18.0f), (int)(BoardImage.Height * 1 / 18.0f));
            rightBlackBishop.SetScale((int)(BoardImage.Width * 1.0f / 9), (int)(BoardImage.Height * 1.0f / 9));
            pieces.Add(rightBlackBishop);

            Piece rightBlackKnight = new Piece(Piece.PieceTypes.Knight, true, BoardImage);
            rightBlackKnight.SetLocation((int)(BoardImage.Width * 13 / 18.0f), (int)(BoardImage.Height * 1 / 18.0f));
            rightBlackKnight.SetScale((int)(BoardImage.Width * 1.0f / 9), (int)(BoardImage.Height * 1.0f / 9));
            pieces.Add(rightBlackKnight);

            Piece rightBlackRook = new Piece(Piece.PieceTypes.Rook, true, BoardImage);
            rightBlackRook.SetLocation((int)(BoardImage.Width * 15 / 18.0f), (int)(BoardImage.Height * 1 / 18.0f));
            rightBlackRook.SetScale((int)(BoardImage.Width * 1.0f / 9), (int)(BoardImage.Height * 1.0f / 9));
            pieces.Add(rightBlackRook);

            for (int i = 0; i < 8; i++)
            {
                Piece blackPawn = new Piece(Piece.PieceTypes.Pawn, true, BoardImage);
                blackPawn.SetLocation((int)(BoardImage.Width * (i * 2 + 1) / 18.0f), (int)(BoardImage.Height * 3 / 18.0f));
                blackPawn.SetScale((int)(BoardImage.Width * 1.0f / 9), (int)(BoardImage.Height * 1.0f / 9));
                pieces.Add(blackPawn);
            }

            for (int i = 0; i < 8; i++)
            {
                Piece blackPawn = new Piece(Piece.PieceTypes.Pawn, false, BoardImage);
                blackPawn.SetLocation((int)(BoardImage.Width * (i * 2 + 1) / 18.0f), (int)(BoardImage.Height * 13 / 18.0f));
                blackPawn.SetScale((int)(BoardImage.Width * 1.0f / 9), (int)(BoardImage.Height * 1.0f / 9));
                pieces.Add(blackPawn);
            }

            Piece leftWhiteRook = new Piece(Piece.PieceTypes.Rook, false, BoardImage);
            leftWhiteRook.SetLocation((int)(BoardImage.Width * 1 / 18.0f), (int)(BoardImage.Height * 15 / 18.0f));
            leftWhiteRook.SetScale((int)(BoardImage.Width * 1.0f / 9), (int)(BoardImage.Height * 1.0f / 9));
            pieces.Add(leftWhiteRook);

            Piece leftWhiteKnight = new Piece(Piece.PieceTypes.Knight, false, BoardImage);
            leftWhiteKnight.SetLocation((int)(BoardImage.Width * 3 / 18.0f), (int)(BoardImage.Height * 15 / 18.0f));
            leftWhiteKnight.SetScale((int)(BoardImage.Width * 1.0f / 9), (int)(BoardImage.Height * 1.0f / 9));
            pieces.Add(leftWhiteKnight);

            Piece leftWhiteBishop = new Piece(Piece.PieceTypes.Bishop, false, BoardImage);
            leftWhiteBishop.SetLocation((int)(BoardImage.Width * 5 / 18.0f), (int)(BoardImage.Height * 15 / 18.0f));
            leftWhiteBishop.SetScale((int)(BoardImage.Width * 1.0f / 9), (int)(BoardImage.Height * 1.0f / 9));
            pieces.Add(leftWhiteBishop);

            Piece whiteKing = new Piece(Piece.PieceTypes.King, false, BoardImage);
            whiteKing.SetLocation((int)(BoardImage.Width * 7 / 18.0f), (int)(BoardImage.Height * 15 / 18.0f));
            whiteKing.SetScale((int)(BoardImage.Width * 1.0f / 9), (int)(BoardImage.Height * 1.0f / 9));
            pieces.Add(whiteKing);

            Piece whiteQueen = new Piece(Piece.PieceTypes.Queen, false, BoardImage);
            whiteQueen.SetLocation((int)(BoardImage.Width * 9 / 18.0f), (int)(BoardImage.Height * 15 / 18.0f));
            whiteQueen.SetScale((int)(BoardImage.Width * 1.0f / 9), (int)(BoardImage.Height * 1.0f / 9));
            pieces.Add(whiteQueen);

            Piece rightWhiteBishop = new Piece(Piece.PieceTypes.Bishop, false, BoardImage);
            rightWhiteBishop.SetLocation((int)(BoardImage.Width * 11 / 18.0f), (int)(BoardImage.Height * 15 / 18.0f));
            rightWhiteBishop.SetScale((int)(BoardImage.Width * 1.0f / 9), (int)(BoardImage.Height * 1.0f / 9));
            pieces.Add(rightWhiteBishop);

            Piece rightWhiteKnight = new Piece(Piece.PieceTypes.Knight, false, BoardImage);
            rightWhiteKnight.SetLocation((int)(BoardImage.Width * 13 / 18.0f), (int)(BoardImage.Height * 15 / 18.0f));
            rightWhiteKnight.SetScale((int)(BoardImage.Width * 1.0f / 9), (int)(BoardImage.Height * 1.0f / 9));
            pieces.Add(rightWhiteKnight);

            Piece rightWhiteRook = new Piece(Piece.PieceTypes.Rook, false, BoardImage);
            rightWhiteRook.SetLocation((int)(BoardImage.Width * 15 / 18.0f), (int)(BoardImage.Height * 15 / 18.0f));
            rightWhiteRook.SetScale((int)(BoardImage.Width * 1.0f / 9), (int)(BoardImage.Height * 1.0f / 9));
            pieces.Add(rightWhiteRook);

            #endregion Pieces

            AdjustWindowSize();
        }

        protected override void OnResize()
        {
            base.OnResize();

            //Find what the percent position of each piece before resizes to the board.
            System.Numerics.Vector2[] piecesLocationPercent = new System.Numerics.Vector2[pieces.Count];
            for(int i = 0; i < pieces.Count; i++)
            {
                float locationPercentX = (float)pieces[i].GetLocation().X / BoardImage.Width;
                float locationPercentY = (float)pieces[i].GetLocation().Y / BoardImage.Height;
                piecesLocationPercent[i] = new System.Numerics.Vector2(locationPercentX, locationPercentY);
            }


            if (boardMarginPercent == 0)
            {
                boardMarginPercent = (float)BoardImage.Location.Y / ContentPanel.Height;

                returnLocationPercentX = (float)Return.Location.X / BoardBackground.Width;
                returnLocationPercentY = (float)Return.Location.Y / BoardBackground.Height;
                returnScalePercentX = (float)Return.Width / BoardBackground.Width;
                returnScalePercentY = (float)Return.Height / BoardBackground.Height;
            }

            BoardBackground.Width = ContentPanel.Width;
            BoardBackground.Height = ContentPanel.Height;

            int boardMargin = (int)(boardMarginPercent * BoardBackground.Height);

            BoardImage.Height = BoardBackground.Height - boardMargin * 2;
            BoardImage.Width = BoardImage.Height;
            BoardImage.Location = new Point((int)((BoardBackground.Width / 2.0f) - (BoardImage.Width / 2.0f)), boardMargin);

            for(int i = 0; i < pieces.Count; i++)
            {
                pieces[i].SetLocation((int)(piecesLocationPercent[i].X * BoardImage.Width), (int)(piecesLocationPercent[i].Y * BoardImage.Height));

                pieces[i].SetScale((int)(BoardImage.Width * 1.0f / 9), (int)(BoardImage.Height * 1.0f / 9));
            }

            Return.Location = new Point((int)(returnLocationPercentX * BoardBackground.Width), (int)(returnLocationPercentY * BoardBackground.Height));
            Return.Width = (int)(returnScalePercentX * BoardBackground.Width);
            Return.Height = (int)(returnScalePercentY * BoardBackground.Height);
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Program.menuInstance.Show();
            this.Close();
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

            //Play audio
            Program.audioManager.PlayPiecePickup();
        }

        private void DragPiece(Object sender, EventArgs e)
        {
            Point mousePoint = parent.PointToClient(Control.MousePosition);
            image.Location = new Point((int)(mousePoint.X - image.Width / 2.0f), (int)(mousePoint.Y - image.Height / 2.0f));

        }

        private void StopDragging(object sender, EventArgs e)
        {
            image.Click += StartDragging;
            image.Click -= StopDragging;
            Program.updateTimer.Tick -= DragPiece;

            //Play audio
            Program.audioManager.PlayPieceSetdown();
        }

        public void SetLocation(int x, int y)
        {
            image.Location = new Point(x, y);
        }

        public void SetScale(int width, int height)
        {
            image.Width = width;
            image.Height = height;
        }

        public Point GetLocation()
        {
            return (image.Location);
        }

        //The pieces should be square, so the width and height are the same.
        public int GetScale()
        {
            return (image.Width);
        }
    }
}
