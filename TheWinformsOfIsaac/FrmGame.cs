using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class FrmGame : Form
    {
        private int bossDirection = new Random().Next(1,5); // Boss' starting direction (random)
        private int CHARACTER_SPEED = 8; // Character's speed constant
        private int BOSS_SPEED = 6; // Boss' speed constant
        private int ATTACK_SPEED = 4; // Attack's speed constant
        int CharacterLifeState = 1; // Character's life state variable
        int BossLifeState = 1; // Boss' life state variable
        int ExplosionState = 0; // Explosion state variable
        Boolean bombExploding = false; // Exploding bomb variable (only one can be placed at a time)
        // Movement flags
        private bool movingUp = false;
        private bool movingLeft = false;
        private bool movingDown = false;
        private bool movingRight = false;
        // Tear flags
        private bool tearUp = false;
        private bool tearLeft = false;
        private bool tearDown = false;
        private bool tearRight = false;

        public FrmGame()
        {
            InitializeComponent();
        }

        private void Tmr_GameClock_Tick(object sender, EventArgs e)
        {
            // Boss' movement Map
            /*
         0,0 ++=======++=======++   Case 1: Up-Right : -Top +Left
             || /\    ||    /\ ||   Case 2: Down-Right : +Top +Left
             ||  \    ||    /  ||   Case 3: Down-Left : +Top -Left
             ||   \ 4 || 1 /   ||   Case 4: Up-Left : -Top -Left
             ++-------++-------++
             ||   / 3 || 2 \   ||
             ||  /    ||    \  ||
             || \/    ||    \/ ||
             ++=======++=======++
            */
            // Changes the direction of the Boss' trayectory when it hits the wall
            switch (bossDirection)
            {
                case 1:
                    PctBox_Boss.Left += BOSS_SPEED;
                    PctBox_Boss.Top -= BOSS_SPEED;

                    if (PctBox_Boss.Top <= 50)
                    {
                        bossDirection = 2;
                    }
                    if ((PctBox_Boss.Left + PctBox_Boss.Width) >= this.ClientSize.Width-50)
                    {
                        bossDirection = 4;
                    }
                    break;
                case 2:
                    PctBox_Boss.Left += BOSS_SPEED;
                    PctBox_Boss.Top += BOSS_SPEED;
                    if (PctBox_Boss.Top + PctBox_Boss.Height >= this.ClientSize.Height - 50)
                    {
                        bossDirection = 1;
                    }
                    if ((PctBox_Boss.Left + PctBox_Boss.Width) >= this.ClientSize.Width - 50)
                    {
                        bossDirection = 3;
                    }
                    break;
                case 3:
                    PctBox_Boss.Left -= BOSS_SPEED;
                    PctBox_Boss.Top += BOSS_SPEED;
                    if (PctBox_Boss.Top + PctBox_Boss.Height >= this.ClientSize.Height - 50)
                    {
                        bossDirection = 4;
                    }
                    if (PctBox_Boss.Left <= 50)
                    {
                        bossDirection = 2;
                    }
                    break;
                case 4:
                    PctBox_Boss.Left -= BOSS_SPEED;
                    PctBox_Boss.Top -= BOSS_SPEED;
                    if (PctBox_Boss.Top <= 50)
                    {
                        bossDirection = 3;
                    }
                    if (PctBox_Boss.Left <= 50)
                    {
                        bossDirection = 1;
                    }
                    break;
            }
        }

        private void FrmGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (CharacterLifeState != 4)
            {
                // WALK ---------------------------------------------------------------------------------
                if (e.KeyCode == Keys.W) { movingUp = true; PctBox_Character.Image = ImgLst_CharacterAnimations.Images[3]; }
                if (e.KeyCode == Keys.A) { movingLeft = true; PctBox_Character.Image = ImgLst_CharacterAnimations.Images[1]; }
                if (e.KeyCode == Keys.S) { movingDown = true; PctBox_Character.Image = ImgLst_CharacterAnimations.Images[0]; }
                if (e.KeyCode == Keys.D) { movingRight = true; PctBox_Character.Image = ImgLst_CharacterAnimations.Images[2]; }

                // ATACK -------------------------------------------------------------------------------
                if (e.KeyCode == Keys.Up) tearUp = true;
                if (e.KeyCode == Keys.Left) tearLeft = true;
                if (e.KeyCode == Keys.Down) tearDown = true;
                if (e.KeyCode == Keys.Right) tearRight = true;

                // BOMBS ----------------------------------------------------------------------------------
                if (e.KeyCode == Keys.E)
                {
                    int BombsLeft = int.Parse(Lbl_Bombs.Text);
                    if (BombsLeft > 00)
                    {
                        // Verify if a bomb is already exploding
                        if (bombExploding == false)
                        {
                            // Put the bomb in the same position as the Character
                            PctBox_Bomb.Top = PctBox_Character.Top;
                            PctBox_Bomb.Left = PctBox_Character.Left;
                            PctBox_Bomb.Visible = true;
                            // Bomb counter down
                            BombsLeft--;
                            Lbl_Bombs.Text = "0" + BombsLeft.ToString();
                            // Set the bomb to explode
                            bombExploding = true;
                        }
                    }
                }
            }
            // MENUS ------------------------------------------------------------------------------------
            // Win/Death Screen
            if (e.KeyCode == Keys.Space) {
                if (PctBox_Death.Visible == true || PctBox_End.Visible == true) {
                    Btn_Skip_Click(null,null);
    }
                if (PctBox_Menu.Visible == true) {
                    Btn_Start_Click(null,null);
                }
            }
            if (e.KeyCode == Keys.Escape) {
                if (PctBox_Menu.Visible == true)
                    Btn_Salir_Click(null,null);
                else
                {
                    Btn_Skip_Click(null, null);
                }
            }
            if (e.KeyCode == Keys.C) {
                Btn_Controls_Click(null,null);
            }
        }
        
        private void Tmr_DamageDelay_Tick(object sender, EventArgs e)
        {
            // Invencibility frames
            // Hitboxes
            Rectangle Rct_IsaacHitBox = PctBox_Character.Bounds;
            Rectangle Rtc_BossHitBox = PctBox_Boss.Bounds;
            // Character gets damage from the Boss
            if (Rct_IsaacHitBox.IntersectsWith(Rtc_BossHitBox))
            {
                DanioIsaac();
            }

            // Boss gets damage from the attack
            Rectangle Rct_TearHitBox = PctBox_Attack.Bounds;

            if (Rct_TearHitBox.IntersectsWith(Rtc_BossHitBox))
            {
                DanioBoss();
            }

            // Explosion's Hitbox
            Rectangle Rct_ExplosionHitBox = new Rectangle();
            if (ExplosionState == 6) // Bomb only damages when it explodes
            {
                Rct_ExplosionHitBox = PctBox_Bomb.Bounds;
            }
            // Boss gets damage from the explosion
            if (Rct_ExplosionHitBox.IntersectsWith(Rtc_BossHitBox)) {
                DanioBoss();
            }
            // Character gets damage from the explosion
            if (Rct_ExplosionHitBox.IntersectsWith(Rct_IsaacHitBox))
            {
                DanioIsaac();
            }
        }

        private void DanioBoss() {
            PctBox_BossBar.Image = ImgLst_BossLife.Images[BossLifeState];
            BossLifeState++;
            if (BossLifeState > 10)
            {
                Tmr_GameClock.Enabled = false;
                Tmr_DamageDelay.Enabled = false;
                Tmr_Explosion.Enabled = false;
                PctBox_End.Visible = true;
                Btn_Skip.Visible = true;
                Btn_Skip.Enabled = true;
            }
        }

        private void DanioIsaac() {
            PctBox_Character.Image = ImgLst_CharacterAnimations.Images[4];

            PctBox_Hearts.Image = ImgLst_CharacterLife.Images[CharacterLifeState];
            CharacterLifeState++;
            if (CharacterLifeState == 4)
            {
                PctBox_Character.Image = ImgLst_CharacterAnimations.Images[5];
                Tmr_GameClock.Enabled = false;
                Tmr_DamageDelay.Enabled = false;
                Tmr_Explosion.Enabled = false;
                PctBox_Death.Visible = true;
            }
        }

        private void Tmr_Explosion_Tick(object sender, EventArgs e)
        {
            // If a bomb is exploding
            if (bombExploding == true) {
                if (ExplosionState < ImgLst_BombAnimations.Images.Count) {
                    if (ExplosionState == 5){
                        PctBox_Bomb.Size = new Size(100, 100);
                    }
                    PctBox_Bomb.Image = ImgLst_BombAnimations.Images[ExplosionState];
                    ExplosionState++;
                } else {
                    // When it finishes exploding, reset its values
                    PctBox_Bomb.Visible = false;
                    PctBox_Bomb.Size = new Size(40, 37);
                    ExplosionState = 0;
                    PctBox_Bomb.Image = ImgLst_BombAnimations.Images[ExplosionState];
                    bombExploding = false;
                }
            }
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            // Start the game
            Tmr_DamageDelay.Enabled = true;
            Tmr_Explosion.Enabled = true;
            Tmr_GameClock.Enabled = true;
            // Hide the menu
            PctBox_Menu.Visible = false;
        }

        private void Btn_Controls_Click(object sender, EventArgs e)
        {
            // Stop the game
            Tmr_GameClock.Enabled = false;
            Tmr_DamageDelay.Enabled = false;
            Tmr_Explosion.Enabled = false;
            Tmr_Movement.Enabled = false;
            // Show Help Message
            MessageBox.Show("Controls:\n- [WASD] Move the character.\n- [Arrows] Move character's attack.\n- [E] Place bombs.\n- [Space] Accept.\n- [C] Help Window.", "Help");
            // Start the game again
            Tmr_GameClock.Enabled = true;
            Tmr_DamageDelay.Enabled = true;
            Tmr_Explosion.Enabled = true;
            Tmr_Movement.Enabled = true;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Skip_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void FrmGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) movingUp = false;
            if (e.KeyCode == Keys.A) movingLeft = false;
            if (e.KeyCode == Keys.S) movingDown = false;
            if (e.KeyCode == Keys.D) movingRight = false;

            if (e.KeyCode == Keys.Up) tearUp = false;
            if (e.KeyCode == Keys.Left) tearLeft = false;
            if (e.KeyCode == Keys.Down) tearDown = false;
            if (e.KeyCode == Keys.Right) tearRight = false;
        }

        private void Tmr_Movement_Tick(object sender, EventArgs e)
        {
            // Character
            if (movingUp && PctBox_Character.Top > 50)
                PctBox_Character.Top -= CHARACTER_SPEED;

            if (movingLeft && PctBox_Character.Left > 50)
                PctBox_Character.Left -= CHARACTER_SPEED;

            if (movingDown && PctBox_Character.Top + PctBox_Character.Height < this.ClientSize.Height - 50)
                PctBox_Character.Top += CHARACTER_SPEED;

            if (movingRight && PctBox_Character.Left + PctBox_Character.Width < this.ClientSize.Width - 50)
                PctBox_Character.Left += CHARACTER_SPEED;
            // Attack
            if (tearUp && PctBox_Attack.Top > 50)
                PctBox_Attack.Top -= ATTACK_SPEED;

            if (tearLeft && PctBox_Attack.Left > 50)
                PctBox_Attack.Left -= ATTACK_SPEED;

            if (tearDown && PctBox_Attack.Top + PctBox_Attack.Height < this.ClientSize.Height - 50)
                PctBox_Attack.Top += ATTACK_SPEED;

            if (tearRight && PctBox_Attack.Left + PctBox_Attack.Width < this.ClientSize.Width - 50)
                PctBox_Attack.Left += ATTACK_SPEED;
        }
    }
}
