namespace Client
{
    partial class game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.chatOut = new System.Windows.Forms.TextBox();
            this.chatAdd = new System.Windows.Forms.TextBox();
            this.gameBoard = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.player1card1 = new System.Windows.Forms.PictureBox();
            this.player1card2 = new System.Windows.Forms.PictureBox();
            this.player1card3 = new System.Windows.Forms.PictureBox();
            this.player1card4 = new System.Windows.Forms.PictureBox();
            this.player1card5 = new System.Windows.Forms.PictureBox();
            this.player2card5 = new System.Windows.Forms.PictureBox();
            this.player2card4 = new System.Windows.Forms.PictureBox();
            this.player2card3 = new System.Windows.Forms.PictureBox();
            this.player2card2 = new System.Windows.Forms.PictureBox();
            this.player2card1 = new System.Windows.Forms.PictureBox();
            this.backCard = new System.Windows.Forms.PictureBox();
            this.hostPlayer = new System.Windows.Forms.Label();
            this.guestPlayer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backCard)).BeginInit();
            this.SuspendLayout();
            // 
            // chatOut
            // 
            this.chatOut.Location = new System.Drawing.Point(397, 12);
            this.chatOut.Multiline = true;
            this.chatOut.Name = "chatOut";
            this.chatOut.ReadOnly = true;
            this.chatOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chatOut.Size = new System.Drawing.Size(139, 274);
            this.chatOut.TabIndex = 21;
            // 
            // chatAdd
            // 
            this.chatAdd.Location = new System.Drawing.Point(397, 292);
            this.chatAdd.Name = "chatAdd";
            this.chatAdd.Size = new System.Drawing.Size(139, 20);
            this.chatAdd.TabIndex = 20;
            this.chatAdd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // gameBoard
            // 
            this.gameBoard.AllowUserToAddRows = false;
            this.gameBoard.AllowUserToDeleteRows = false;
            this.gameBoard.AllowUserToResizeColumns = false;
            this.gameBoard.AllowUserToResizeRows = false;
            this.gameBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameBoard.ColumnHeadersVisible = false;
            this.gameBoard.Location = new System.Drawing.Point(541, 74);
            this.gameBoard.Name = "gameBoard";
            this.gameBoard.RowHeadersVisible = false;
            this.gameBoard.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gameBoard.Size = new System.Drawing.Size(137, 136);
            this.gameBoard.TabIndex = 0;
            this.gameBoard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gameBoard_CellContentClick);
            this.gameBoard.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gameBoard_CellContentDoubleClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(397, 318);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 32);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // player1card1
            // 
            this.player1card1.InitialImage = ((System.Drawing.Image)(resources.GetObject("player1card1.InitialImage")));
            this.player1card1.Location = new System.Drawing.Point(12, 12);
            this.player1card1.Name = "player1card1";
            this.player1card1.Size = new System.Drawing.Size(71, 96);
            this.player1card1.TabIndex = 25;
            this.player1card1.TabStop = false;
            // 
            // player1card2
            // 
            this.player1card2.InitialImage = ((System.Drawing.Image)(resources.GetObject("player1card2.InitialImage")));
            this.player1card2.Location = new System.Drawing.Point(89, 12);
            this.player1card2.Name = "player1card2";
            this.player1card2.Size = new System.Drawing.Size(71, 96);
            this.player1card2.TabIndex = 26;
            this.player1card2.TabStop = false;
            // 
            // player1card3
            // 
            this.player1card3.InitialImage = ((System.Drawing.Image)(resources.GetObject("player1card3.InitialImage")));
            this.player1card3.Location = new System.Drawing.Point(166, 12);
            this.player1card3.Name = "player1card3";
            this.player1card3.Size = new System.Drawing.Size(71, 96);
            this.player1card3.TabIndex = 27;
            this.player1card3.TabStop = false;
            // 
            // player1card4
            // 
            this.player1card4.InitialImage = ((System.Drawing.Image)(resources.GetObject("player1card4.InitialImage")));
            this.player1card4.Location = new System.Drawing.Point(243, 12);
            this.player1card4.Name = "player1card4";
            this.player1card4.Size = new System.Drawing.Size(71, 96);
            this.player1card4.TabIndex = 28;
            this.player1card4.TabStop = false;
            // 
            // player1card5
            // 
            this.player1card5.InitialImage = ((System.Drawing.Image)(resources.GetObject("player1card5.InitialImage")));
            this.player1card5.Location = new System.Drawing.Point(320, 12);
            this.player1card5.Name = "player1card5";
            this.player1card5.Size = new System.Drawing.Size(71, 96);
            this.player1card5.TabIndex = 29;
            this.player1card5.TabStop = false;
            // 
            // player2card5
            // 
            this.player2card5.InitialImage = ((System.Drawing.Image)(resources.GetObject("player2card5.InitialImage")));
            this.player2card5.Location = new System.Drawing.Point(320, 216);
            this.player2card5.Name = "player2card5";
            this.player2card5.Size = new System.Drawing.Size(71, 96);
            this.player2card5.TabIndex = 34;
            this.player2card5.TabStop = false;
            // 
            // player2card4
            // 
            this.player2card4.InitialImage = ((System.Drawing.Image)(resources.GetObject("player2card4.InitialImage")));
            this.player2card4.Location = new System.Drawing.Point(243, 216);
            this.player2card4.Name = "player2card4";
            this.player2card4.Size = new System.Drawing.Size(71, 96);
            this.player2card4.TabIndex = 33;
            this.player2card4.TabStop = false;
            // 
            // player2card3
            // 
            this.player2card3.InitialImage = ((System.Drawing.Image)(resources.GetObject("player2card3.InitialImage")));
            this.player2card3.Location = new System.Drawing.Point(166, 216);
            this.player2card3.Name = "player2card3";
            this.player2card3.Size = new System.Drawing.Size(71, 96);
            this.player2card3.TabIndex = 32;
            this.player2card3.TabStop = false;
            // 
            // player2card2
            // 
            this.player2card2.InitialImage = ((System.Drawing.Image)(resources.GetObject("player2card2.InitialImage")));
            this.player2card2.Location = new System.Drawing.Point(89, 216);
            this.player2card2.Name = "player2card2";
            this.player2card2.Size = new System.Drawing.Size(71, 96);
            this.player2card2.TabIndex = 31;
            this.player2card2.TabStop = false;
            // 
            // player2card1
            // 
            this.player2card1.InitialImage = ((System.Drawing.Image)(resources.GetObject("player2card1.InitialImage")));
            this.player2card1.Location = new System.Drawing.Point(12, 216);
            this.player2card1.Name = "player2card1";
            this.player2card1.Size = new System.Drawing.Size(71, 96);
            this.player2card1.TabIndex = 30;
            this.player2card1.TabStop = false;
            // 
            // backCard
            // 
            this.backCard.InitialImage = ((System.Drawing.Image)(resources.GetObject("backCard.InitialImage")));
            this.backCard.Location = new System.Drawing.Point(166, 114);
            this.backCard.Name = "backCard";
            this.backCard.Size = new System.Drawing.Size(71, 96);
            this.backCard.TabIndex = 35;
            this.backCard.TabStop = false;
            // 
            // hostPlayer
            // 
            this.hostPlayer.BackColor = System.Drawing.Color.Green;
            this.hostPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hostPlayer.ForeColor = System.Drawing.Color.White;
            this.hostPlayer.Location = new System.Drawing.Point(541, 11);
            this.hostPlayer.Name = "hostPlayer";
            this.hostPlayer.Size = new System.Drawing.Size(66, 23);
            this.hostPlayer.TabIndex = 15;
            this.hostPlayer.Text = "Player 1";
            this.hostPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guestPlayer
            // 
            this.guestPlayer.BackColor = System.Drawing.Color.Green;
            this.guestPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guestPlayer.ForeColor = System.Drawing.Color.White;
            this.guestPlayer.Location = new System.Drawing.Point(614, 11);
            this.guestPlayer.Name = "guestPlayer";
            this.guestPlayer.Size = new System.Drawing.Size(65, 23);
            this.guestPlayer.TabIndex = 16;
            this.guestPlayer.Text = "Player 2";
            this.guestPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(542, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Chat Box";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 32);
            this.button1.TabIndex = 36;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 32);
            this.button2.TabIndex = 37;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 360);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backCard);
            this.Controls.Add(this.player2card5);
            this.Controls.Add(this.player2card4);
            this.Controls.Add(this.player2card3);
            this.Controls.Add(this.player2card2);
            this.Controls.Add(this.player2card1);
            this.Controls.Add(this.player1card5);
            this.Controls.Add(this.player1card4);
            this.Controls.Add(this.player1card3);
            this.Controls.Add(this.player1card2);
            this.Controls.Add(this.player1card1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chatOut);
            this.Controls.Add(this.chatAdd);
            this.Controls.Add(this.guestPlayer);
            this.Controls.Add(this.hostPlayer);
            this.Controls.Add(this.gameBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "game";
            this.Text = "Blackjack";
            ((System.ComponentModel.ISupportInitialize)(this.gameBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox chatOut;
        private System.Windows.Forms.TextBox chatAdd;
        private System.Windows.Forms.DataGridView gameBoard;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox player1card1;
        private System.Windows.Forms.PictureBox player1card2;
        private System.Windows.Forms.PictureBox player1card3;
        private System.Windows.Forms.PictureBox player1card4;
        private System.Windows.Forms.PictureBox player1card5;
        private System.Windows.Forms.PictureBox player2card5;
        private System.Windows.Forms.PictureBox player2card4;
        private System.Windows.Forms.PictureBox player2card3;
        private System.Windows.Forms.PictureBox player2card2;
        private System.Windows.Forms.PictureBox player2card1;
        private System.Windows.Forms.PictureBox backCard;
        private System.Windows.Forms.Label hostPlayer;
        private System.Windows.Forms.Label guestPlayer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

