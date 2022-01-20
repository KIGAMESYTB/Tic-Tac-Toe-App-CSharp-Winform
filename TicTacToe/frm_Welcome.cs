using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class frm_Welcome : Form
    {
        #region Variable
        frm_settings settings;
        frm_ZoneJeu zoneJeu;
        List<String> playerName;
        List<String> playerSigneMode;
        int count;
        #endregion

        public frm_Welcome()
        {
            InitializeComponent();
            playerName = new List<string>() { "Player1", "Computer" };
            playerSigneMode = new List<String>() { "X", "O", "easy", "P-C"};
            count = 0;
            panelBienvenue.BringToFront();
            panelBienvenue.Dock = DockStyle.Fill;
            timer1.Start();
        }

        #region Procédure
        /// <summary>
        /// affichage de ma banière kigames
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            panelBienvenue.Visible = false;
        }

        
        /// <summary>
        /// Procédure permettant de modifier le choix de l'adversaire
        /// </summary>
        private void changePlayer()
        {
            if (count%2 == 0)
            {
                btnPlayer.BackgroundImage = Properties.Resources.buttonPlayer_Player;
                playerSigneMode[3] = "P-P";
                playerName[1] = "Player2";
            }
            else
            {
                btnPlayer.BackgroundImage = Properties.Resources.buttonPlayer_Computer;
                playerSigneMode[3] = "P-C";
                playerName[1] = "Computer";
            }
            count++;
        }

        #endregion

        #region Click
        /// <summary>
        /// Procédure click lors d'un bouton du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Name)
            {
                case "btnPlay":
                    zoneJeu = new frm_ZoneJeu(playerName, playerSigneMode);
                    zoneJeu.ShowDialog();
                    break;
                case "btnSettings":
                    settings = new frm_settings(ref playerName, ref playerSigneMode);
                    settings.ShowDialog();
                    break;
                case "btnPlayer":
                    changePlayer();
                    break;
                case "btnQuit":
                    Application.Exit();
                    break;
            }
        }

        #endregion

    }
}
