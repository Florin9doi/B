using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Client {
    /// <summary>
    /// Class wrapper to Cards.dll
    /// </summary>
    public sealed class Cards {
        #region API Declares
        [DllImport ( "cards.dll" )]
        private static extern bool cdtInit ( [In] ref int width, [In] ref int height );

        [DllImport ( "cards.dll" )]
        private static extern void cdtTerm ();

        [DllImport ( "cards.dll" )]
        private static extern int cdtDrawExt ( IntPtr hDC, int x, int y, int dx, int dy,
            int ecsCard, int ectDraw, int clr );

        [DllImport ( "cards.dll" )]
        private static extern int cdtDraw ( IntPtr hDC, int x, int y, int ecsCard,
            int ectDraw, int clr );

        [DllImport ( "cards.dll" )]
        private static extern int cdtAnimate ( IntPtr hDC, int ecbCardBack, int x, int y, int iState );
        #endregion

        #region fields
        private static int _standardWidth;
        private static int _standardHeight;
        #endregion

        #region Constructor
        static Cards () {
            bool ret = Cards.cdtInit ( ref _standardWidth, ref _standardHeight );
            if ( !ret )
                throw new ApplicationException ( "Can't load cards.dll !" );

            // free up library when process exits
            AppDomain.CurrentDomain.ProcessExit += new EventHandler ( CurrentDomain_ProcessExit );
        }
        #endregion

        #region Public Static Members
        public static void DrawFace ( Graphics g, int x, int y, int width, int height, int faceValue, CardSuit suit, Color invertedColor ) {
            if ( faceValue < 0 || faceValue > 12 )
                throw new ArgumentOutOfRangeException ( "FaceValue", faceValue, "faceValue must be in the range 0 - 12." );

            int cardValue = (int)suit + faceValue * 4;
            IntPtr hDc = g.GetHdc ();
            try {
                cdtDrawExt ( hDc, x, y, width, height, cardValue, invertedColor != Color.Empty ? 2 : 0, ConvertColor ( invertedColor ) );
            } finally {
                g.ReleaseHdc ( hDc );
            }
        }
        public static void DrawFace ( Graphics g, int x, int y, int width, int height, int faceValue, CardSuit suit ) {
            DrawFace ( g, x, y, width, height, faceValue, suit, Color.Empty );
        }
        public static void DrawFace ( Graphics g, int x, int y, int faceValue, CardSuit suit, Color invertedColor ) {
            if ( faceValue < 0 || faceValue > 12 )
                throw new ArgumentOutOfRangeException ( "FaceValue", faceValue, "faceValue must be in the range 0 - 12." );

            int cardValue = (int)suit + faceValue * 4;
            IntPtr hDc = g.GetHdc ();
            try {
                cdtDraw ( hDc, x, y, cardValue, invertedColor != Color.Empty ? 2 : 0, ConvertColor ( invertedColor ) );
            } finally {
                g.ReleaseHdc ( hDc );
            }
        }
        public static void DrawFace ( Graphics g, int x, int y, int faceValue, CardSuit suit ) {
            Cards.DrawFace ( g, x, y, faceValue, suit, Color.Empty );
        }
        public static void DrawDeck ( Graphics g, int x, int y, int width, int height, CardDeck deck ) {
            IntPtr hDc = g.GetHdc ();
            try {
                cdtDrawExt ( hDc, x, y, width, height, (int)deck, 1, 0 );
            } finally {
                g.ReleaseHdc ( hDc );
            }
        }
        public static void DrawDeck ( Graphics g, int x, int y, CardDeck deck ) {
            IntPtr hDc = g.GetHdc ();
            try {
                cdtDraw ( hDc, x, y, (int)deck, 1, 0 );
            } finally {
                g.ReleaseHdc ( hDc );
            }
        }
        public static void DrawDeck ( Graphics g, int x, int y, int width, int height, Color backgroundColor ) {
            IntPtr hDc = g.GetHdc ();
            try {
                cdtDrawExt ( hDc, x, y, width, height, (int)CardDeck.CrossHatch, 1, Cards.ConvertColor ( backgroundColor ) );
            } finally {
                g.ReleaseHdc ( hDc );
            }
        }
        public static void DrawDeck ( Graphics g, int x, int y, Color backgroundColor ) {
            IntPtr hDc = g.GetHdc ();
            try {
                cdtDraw ( hDc, x, y, (int)CardDeck.CrossHatch, 1, Cards.ConvertColor ( backgroundColor ) );
            } finally {
                g.ReleaseHdc ( hDc );
            }
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets the standard width of the cards.
        /// </summary>
        public static int StandardWidth {
            get {
                return Cards._standardWidth;
            }
        }
        /// <summary>
        /// Gets the standard height of the cards.
        /// </summary>
        public static int StandardHeight {
            get {
                return Cards._standardHeight;
            }
        }
        #endregion

        #region private members
        private static void CurrentDomain_ProcessExit ( object sender, EventArgs e ) {
            Cards.cdtTerm ();
        }
        private static int ConvertColor ( Color c ) {
            if ( c != Color.Empty )
                return ( Convert.ToInt32 ( c.B ) << 16 ) + ( Convert.ToInt32 ( c.G ) << 8 ) + c.R;
            return 0;
        }
        #endregion
    }

    #region enums
    public enum CardSuit : int {
        Clubs = 0,
        Diamonds = 1,
        Hearts = 2,
        Spades = 3
    }
    public enum CardDeck : int {
        CrossHatch = 53,
        Weave1 = 54,
        Weave2 = 55,
        Robot = 56,
        Flowers = 57,
        Vine1 = 58,
        Vine2 = 59,
        Fish1 = 60,
        Fish2 = 61,
        Shells = 62,
        Castle = 63,
        Island = 64,
        CardHand = 65,
        The_X = 67,
        The_O = 68
    }
    #endregion
}
