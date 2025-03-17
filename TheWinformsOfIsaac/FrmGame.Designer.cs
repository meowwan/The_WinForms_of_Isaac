namespace Arkanoid
{
    partial class FrmGame
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            this.PctBox_Background = new System.Windows.Forms.PictureBox();
            this.PctBox_Boss = new System.Windows.Forms.PictureBox();
            this.Tmr_GameClock = new System.Windows.Forms.Timer(this.components);
            this.PctBox_Character = new System.Windows.Forms.PictureBox();
            this.ImgLst_CharacterAnimations = new System.Windows.Forms.ImageList(this.components);
            this.PctBox_Attack = new System.Windows.Forms.PictureBox();
            this.Tmr_DamageDelay = new System.Windows.Forms.Timer(this.components);
            this.PctBox_BossBar = new System.Windows.Forms.PictureBox();
            this.PctBox_Hearts = new System.Windows.Forms.PictureBox();
            this.ImgLst_CharacterLife = new System.Windows.Forms.ImageList(this.components);
            this.ImgLst_BossLife = new System.Windows.Forms.ImageList(this.components);
            this.PctBx_Items = new System.Windows.Forms.PictureBox();
            this.Lbl_Coins = new System.Windows.Forms.Label();
            this.Lbl_Bombs = new System.Windows.Forms.Label();
            this.Lbl_Keys = new System.Windows.Forms.Label();
            this.PctBox_Bomb = new System.Windows.Forms.PictureBox();
            this.Tmr_Explosion = new System.Windows.Forms.Timer(this.components);
            this.ImgLst_BombAnimations = new System.Windows.Forms.ImageList(this.components);
            this.PctBox_Map = new System.Windows.Forms.PictureBox();
            this.PctBox_ItemLudovico = new System.Windows.Forms.PictureBox();
            this.PctBox_Death = new System.Windows.Forms.PictureBox();
            this.PctBox_End = new System.Windows.Forms.PictureBox();
            this.PctBox_Menu = new System.Windows.Forms.PictureBox();
            this.Btn_Skip = new System.Windows.Forms.Button();
            this.Tmr_Movement = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Boss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Attack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_BossBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Hearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBx_Items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_ItemLudovico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Death)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_End)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // PctBox_Background
            // 
            this.PctBox_Background.Image = ((System.Drawing.Image)(resources.GetObject("PctBox_Background.Image")));
            this.PctBox_Background.Location = new System.Drawing.Point(12, 12);
            this.PctBox_Background.Name = "PctBox_Background";
            this.PctBox_Background.Size = new System.Drawing.Size(776, 426);
            this.PctBox_Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBox_Background.TabIndex = 0;
            this.PctBox_Background.TabStop = false;
            // 
            // PctBox_Boss
            // 
            this.PctBox_Boss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(67)))), ((int)(((byte)(56)))));
            this.PctBox_Boss.Image = ((System.Drawing.Image)(resources.GetObject("PctBox_Boss.Image")));
            this.PctBox_Boss.Location = new System.Drawing.Point(332, 118);
            this.PctBox_Boss.Name = "PctBox_Boss";
            this.PctBox_Boss.Size = new System.Drawing.Size(110, 111);
            this.PctBox_Boss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBox_Boss.TabIndex = 1;
            this.PctBox_Boss.TabStop = false;
            // 
            // Tmr_GameClock
            // 
            this.Tmr_GameClock.Interval = 10;
            this.Tmr_GameClock.Tick += new System.EventHandler(this.Tmr_GameClock_Tick);
            // 
            // PctBox_Character
            // 
            this.PctBox_Character.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(67)))), ((int)(((byte)(56)))));
            this.PctBox_Character.Image = ((System.Drawing.Image)(resources.GetObject("PctBox_Character.Image")));
            this.PctBox_Character.Location = new System.Drawing.Point(358, 317);
            this.PctBox_Character.Name = "PctBox_Character";
            this.PctBox_Character.Size = new System.Drawing.Size(56, 75);
            this.PctBox_Character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctBox_Character.TabIndex = 2;
            this.PctBox_Character.TabStop = false;
            // 
            // ImgLst_CharacterAnimations
            // 
            this.ImgLst_CharacterAnimations.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgLst_CharacterAnimations.ImageStream")));
            this.ImgLst_CharacterAnimations.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgLst_CharacterAnimations.Images.SetKeyName(0, "character-front1.png");
            this.ImgLst_CharacterAnimations.Images.SetKeyName(1, "character-left1.png");
            this.ImgLst_CharacterAnimations.Images.SetKeyName(2, "character-right1.png");
            this.ImgLst_CharacterAnimations.Images.SetKeyName(3, "character-back1.png");
            this.ImgLst_CharacterAnimations.Images.SetKeyName(4, "character-hurt.png");
            this.ImgLst_CharacterAnimations.Images.SetKeyName(5, "character-death.png");
            // 
            // PctBox_Attack
            // 
            this.PctBox_Attack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(67)))), ((int)(((byte)(56)))));
            this.PctBox_Attack.Image = ((System.Drawing.Image)(resources.GetObject("PctBox_Attack.Image")));
            this.PctBox_Attack.Location = new System.Drawing.Point(373, 286);
            this.PctBox_Attack.Name = "PctBox_Attack";
            this.PctBox_Attack.Size = new System.Drawing.Size(25, 25);
            this.PctBox_Attack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBox_Attack.TabIndex = 3;
            this.PctBox_Attack.TabStop = false;
            // 
            // Tmr_DamageDelay
            // 
            this.Tmr_DamageDelay.Interval = 350;
            this.Tmr_DamageDelay.Tick += new System.EventHandler(this.Tmr_DamageDelay_Tick);
            // 
            // PctBox_BossBar
            // 
            this.PctBox_BossBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(67)))), ((int)(((byte)(56)))));
            this.PctBox_BossBar.Image = ((System.Drawing.Image)(resources.GetObject("PctBox_BossBar.Image")));
            this.PctBox_BossBar.Location = new System.Drawing.Point(226, 391);
            this.PctBox_BossBar.Name = "PctBox_BossBar";
            this.PctBox_BossBar.Size = new System.Drawing.Size(315, 47);
            this.PctBox_BossBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBox_BossBar.TabIndex = 4;
            this.PctBox_BossBar.TabStop = false;
            // 
            // PctBox_Hearts
            // 
            this.PctBox_Hearts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(67)))), ((int)(((byte)(56)))));
            this.PctBox_Hearts.Image = ((System.Drawing.Image)(resources.GetObject("PctBox_Hearts.Image")));
            this.PctBox_Hearts.Location = new System.Drawing.Point(59, 23);
            this.PctBox_Hearts.Name = "PctBox_Hearts";
            this.PctBox_Hearts.Size = new System.Drawing.Size(113, 37);
            this.PctBox_Hearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBox_Hearts.TabIndex = 5;
            this.PctBox_Hearts.TabStop = false;
            // 
            // ImgLst_CharacterLife
            // 
            this.ImgLst_CharacterLife.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgLst_CharacterLife.ImageStream")));
            this.ImgLst_CharacterLife.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgLst_CharacterLife.Images.SetKeyName(0, "hearts.png");
            this.ImgLst_CharacterLife.Images.SetKeyName(1, "hearts_1.png");
            this.ImgLst_CharacterLife.Images.SetKeyName(2, "hearts_2.png");
            this.ImgLst_CharacterLife.Images.SetKeyName(3, "hearts_3.png");
            // 
            // ImgLst_BossLife
            // 
            this.ImgLst_BossLife.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgLst_BossLife.ImageStream")));
            this.ImgLst_BossLife.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgLst_BossLife.Images.SetKeyName(0, "bossbar.png");
            this.ImgLst_BossLife.Images.SetKeyName(1, "bossbar_1.png");
            this.ImgLst_BossLife.Images.SetKeyName(2, "bossbar_2.png");
            this.ImgLst_BossLife.Images.SetKeyName(3, "bossbar_3.png");
            this.ImgLst_BossLife.Images.SetKeyName(4, "bossbar_4.png");
            this.ImgLst_BossLife.Images.SetKeyName(5, "bossbar_5.png");
            this.ImgLst_BossLife.Images.SetKeyName(6, "bossbar_6.png");
            this.ImgLst_BossLife.Images.SetKeyName(7, "bossbar_7.png");
            this.ImgLst_BossLife.Images.SetKeyName(8, "bossbar_8.png");
            this.ImgLst_BossLife.Images.SetKeyName(9, "bossbar_9.png");
            this.ImgLst_BossLife.Images.SetKeyName(10, "bossbar_10.png");
            // 
            // PctBx_Items
            // 
            this.PctBx_Items.Image = ((System.Drawing.Image)(resources.GetObject("PctBx_Items.Image")));
            this.PctBx_Items.Location = new System.Drawing.Point(23, 66);
            this.PctBx_Items.Name = "PctBx_Items";
            this.PctBx_Items.Size = new System.Drawing.Size(30, 105);
            this.PctBx_Items.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBx_Items.TabIndex = 6;
            this.PctBx_Items.TabStop = false;
            // 
            // Lbl_Coins
            // 
            this.Lbl_Coins.AutoSize = true;
            this.Lbl_Coins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(67)))), ((int)(((byte)(56)))));
            this.Lbl_Coins.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Coins.ForeColor = System.Drawing.Color.White;
            this.Lbl_Coins.Location = new System.Drawing.Point(59, 66);
            this.Lbl_Coins.Name = "Lbl_Coins";
            this.Lbl_Coins.Size = new System.Drawing.Size(34, 26);
            this.Lbl_Coins.TabIndex = 7;
            this.Lbl_Coins.Text = "00";
            // 
            // Lbl_Bombs
            // 
            this.Lbl_Bombs.AutoSize = true;
            this.Lbl_Bombs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(67)))), ((int)(((byte)(56)))));
            this.Lbl_Bombs.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Bombs.ForeColor = System.Drawing.Color.White;
            this.Lbl_Bombs.Location = new System.Drawing.Point(59, 103);
            this.Lbl_Bombs.Name = "Lbl_Bombs";
            this.Lbl_Bombs.Size = new System.Drawing.Size(34, 26);
            this.Lbl_Bombs.TabIndex = 8;
            this.Lbl_Bombs.Text = "03";
            // 
            // Lbl_Keys
            // 
            this.Lbl_Keys.AutoSize = true;
            this.Lbl_Keys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(67)))), ((int)(((byte)(56)))));
            this.Lbl_Keys.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Keys.ForeColor = System.Drawing.Color.White;
            this.Lbl_Keys.Location = new System.Drawing.Point(59, 145);
            this.Lbl_Keys.Name = "Lbl_Keys";
            this.Lbl_Keys.Size = new System.Drawing.Size(34, 26);
            this.Lbl_Keys.TabIndex = 9;
            this.Lbl_Keys.Text = "00";
            // 
            // PctBox_Bomb
            // 
            this.PctBox_Bomb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(67)))), ((int)(((byte)(56)))));
            this.PctBox_Bomb.Image = ((System.Drawing.Image)(resources.GetObject("PctBox_Bomb.Image")));
            this.PctBox_Bomb.Location = new System.Drawing.Point(358, 317);
            this.PctBox_Bomb.Name = "PctBox_Bomb";
            this.PctBox_Bomb.Size = new System.Drawing.Size(40, 37);
            this.PctBox_Bomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBox_Bomb.TabIndex = 10;
            this.PctBox_Bomb.TabStop = false;
            this.PctBox_Bomb.Visible = false;
            // 
            // Tmr_Explosion
            // 
            this.Tmr_Explosion.Interval = 500;
            this.Tmr_Explosion.Tick += new System.EventHandler(this.Tmr_Explosion_Tick);
            // 
            // ImgLst_BombAnimations
            // 
            this.ImgLst_BombAnimations.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgLst_BombAnimations.ImageStream")));
            this.ImgLst_BombAnimations.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgLst_BombAnimations.Images.SetKeyName(0, "bomb.png");
            this.ImgLst_BombAnimations.Images.SetKeyName(1, "bomb_1.png");
            this.ImgLst_BombAnimations.Images.SetKeyName(2, "bomb_2.png");
            this.ImgLst_BombAnimations.Images.SetKeyName(3, "bomb_3.png");
            this.ImgLst_BombAnimations.Images.SetKeyName(4, "bomb_4.png");
            this.ImgLst_BombAnimations.Images.SetKeyName(5, "explosion_1.png");
            this.ImgLst_BombAnimations.Images.SetKeyName(6, "explosion_2.png");
            this.ImgLst_BombAnimations.Images.SetKeyName(7, "explosion_3.png");
            // 
            // PctBox_Map
            // 
            this.PctBox_Map.Image = ((System.Drawing.Image)(resources.GetObject("PctBox_Map.Image")));
            this.PctBox_Map.Location = new System.Drawing.Point(666, 23);
            this.PctBox_Map.Name = "PctBox_Map";
            this.PctBox_Map.Size = new System.Drawing.Size(100, 93);
            this.PctBox_Map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBox_Map.TabIndex = 11;
            this.PctBox_Map.TabStop = false;
            // 
            // PctBox_ItemLudovico
            // 
            this.PctBox_ItemLudovico.Image = ((System.Drawing.Image)(resources.GetObject("PctBox_ItemLudovico.Image")));
            this.PctBox_ItemLudovico.Location = new System.Drawing.Point(708, 122);
            this.PctBox_ItemLudovico.Name = "PctBox_ItemLudovico";
            this.PctBox_ItemLudovico.Size = new System.Drawing.Size(47, 49);
            this.PctBox_ItemLudovico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBox_ItemLudovico.TabIndex = 12;
            this.PctBox_ItemLudovico.TabStop = false;
            // 
            // PctBox_Death
            // 
            this.PctBox_Death.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(67)))), ((int)(((byte)(56)))));
            this.PctBox_Death.Image = ((System.Drawing.Image)(resources.GetObject("PctBox_Death.Image")));
            this.PctBox_Death.Location = new System.Drawing.Point(178, 12);
            this.PctBox_Death.Name = "PctBox_Death";
            this.PctBox_Death.Size = new System.Drawing.Size(420, 426);
            this.PctBox_Death.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBox_Death.TabIndex = 13;
            this.PctBox_Death.TabStop = false;
            this.PctBox_Death.Visible = false;
            // 
            // PctBox_End
            // 
            this.PctBox_End.Enabled = false;
            this.PctBox_End.Image = ((System.Drawing.Image)(resources.GetObject("PctBox_End.Image")));
            this.PctBox_End.Location = new System.Drawing.Point(-1, -1);
            this.PctBox_End.Name = "PctBox_End";
            this.PctBox_End.Size = new System.Drawing.Size(802, 451);
            this.PctBox_End.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBox_End.TabIndex = 14;
            this.PctBox_End.TabStop = false;
            this.PctBox_End.Visible = false;
            // 
            // PctBox_Menu
            // 
            this.PctBox_Menu.Image = ((System.Drawing.Image)(resources.GetObject("PctBox_Menu.Image")));
            this.PctBox_Menu.Location = new System.Drawing.Point(-1, -1);
            this.PctBox_Menu.Name = "PctBox_Menu";
            this.PctBox_Menu.Size = new System.Drawing.Size(802, 451);
            this.PctBox_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBox_Menu.TabIndex = 15;
            this.PctBox_Menu.TabStop = false;
            // 
            // Btn_Skip
            // 
            this.Btn_Skip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(106)))), ((int)(((byte)(86)))));
            this.Btn_Skip.Enabled = false;
            this.Btn_Skip.FlatAppearance.BorderSize = 0;
            this.Btn_Skip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Skip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(106)))), ((int)(((byte)(86)))));
            this.Btn_Skip.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Skip.Image")));
            this.Btn_Skip.Location = new System.Drawing.Point(673, 345);
            this.Btn_Skip.Name = "Btn_Skip";
            this.Btn_Skip.Size = new System.Drawing.Size(93, 64);
            this.Btn_Skip.TabIndex = 20;
            this.Btn_Skip.TabStop = false;
            this.Btn_Skip.UseVisualStyleBackColor = false;
            this.Btn_Skip.Visible = false;
            this.Btn_Skip.Click += new System.EventHandler(this.Btn_Skip_Click);
            // 
            // Tmr_Movement
            // 
            this.Tmr_Movement.Enabled = true;
            this.Tmr_Movement.Interval = 16;
            this.Tmr_Movement.Tick += new System.EventHandler(this.Tmr_Movement_Tick);
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Skip);
            this.Controls.Add(this.PctBox_Menu);
            this.Controls.Add(this.PctBox_End);
            this.Controls.Add(this.PctBox_Death);
            this.Controls.Add(this.PctBox_ItemLudovico);
            this.Controls.Add(this.Lbl_Keys);
            this.Controls.Add(this.Lbl_Coins);
            this.Controls.Add(this.Lbl_Bombs);
            this.Controls.Add(this.PctBx_Items);
            this.Controls.Add(this.PctBox_Map);
            this.Controls.Add(this.PctBox_Hearts);
            this.Controls.Add(this.PctBox_BossBar);
            this.Controls.Add(this.PctBox_Attack);
            this.Controls.Add(this.PctBox_Bomb);
            this.Controls.Add(this.PctBox_Boss);
            this.Controls.Add(this.PctBox_Character);
            this.Controls.Add(this.PctBox_Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The WinForms of Isaac";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Boss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Attack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_BossBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Hearts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBx_Items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_ItemLudovico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Death)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_End)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctBox_Background;
        private System.Windows.Forms.PictureBox PctBox_Boss;
        private System.Windows.Forms.Timer Tmr_GameClock;
        private System.Windows.Forms.PictureBox PctBox_Character;
        private System.Windows.Forms.ImageList ImgLst_CharacterAnimations;
        private System.Windows.Forms.PictureBox PctBox_Attack;
        private System.Windows.Forms.Timer Tmr_DamageDelay;
        private System.Windows.Forms.PictureBox PctBox_BossBar;
        private System.Windows.Forms.PictureBox PctBox_Hearts;
        private System.Windows.Forms.ImageList ImgLst_CharacterLife;
        private System.Windows.Forms.ImageList ImgLst_BossLife;
        private System.Windows.Forms.PictureBox PctBx_Items;
        private System.Windows.Forms.Label Lbl_Coins;
        private System.Windows.Forms.Label Lbl_Bombs;
        private System.Windows.Forms.Label Lbl_Keys;
        private System.Windows.Forms.PictureBox PctBox_Bomb;
        private System.Windows.Forms.Timer Tmr_Explosion;
        private System.Windows.Forms.ImageList ImgLst_BombAnimations;
        private System.Windows.Forms.PictureBox PctBox_Map;
        private System.Windows.Forms.PictureBox PctBox_ItemLudovico;
        private System.Windows.Forms.PictureBox PctBox_Death;
        private System.Windows.Forms.PictureBox PctBox_End;
        private System.Windows.Forms.PictureBox PctBox_Menu;
        private System.Windows.Forms.Button Btn_Skip;
        private System.Windows.Forms.Timer Tmr_Movement;
    }
}

