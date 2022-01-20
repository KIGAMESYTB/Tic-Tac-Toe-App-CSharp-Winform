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
    public partial class frm_settings : Form
    {
        #region Variable
        List<String> playerName;
        List<String> playerSigneMode;
        List<RadioButton> radioButtonList;

        #endregion

        public frm_settings(ref List<String> playerName, ref List<String> playerSigneMode)
        {
            InitializeComponent();
            this.playerName = new List<string>();
            this.playerSigneMode = new List<String>();
            this.radioButtonList = new List<RadioButton>() { pieceX, pieceO, mode1, mode3};
            this.playerName = playerName;
            this.playerSigneMode = playerSigneMode;
            initialisation();
        }

        #region Procédure
        /// <summary>
        /// Initialisation du formulaire
        /// </summary>
        private void initialisation()
        {
            txtPlayer1.Text = playerName[0];
            txtPlayer2.Text = playerName[1];
            if(playerSigneMode[3] == "P-C")
            {
                txtPlayer2.Visible = false;
                labelPlayer2.Visible = false;
            }
            foreach (RadioButton rb in radioButtonList)
            {
                if (rb.Tag.ToString() == playerSigneMode[0] || rb.Tag.ToString() == playerSigneMode[2])
                {
                    rb.Checked = true;
                }
            }
        }

        /// <summary>
        /// Modifier les pieces "X" or "O" par les joueurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pieceChecked(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            this.playerSigneMode[0] = "X";
            this.playerSigneMode[1] = "O";
            if (rb.Text == "O")
            {
                this.playerSigneMode[0] = rb.Text;
                this.playerSigneMode[1] = "X";
            }
        }

        /// <summary>
        /// Sauvegarde dans une liste le mode a effectué
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modeChecked(object sender, EventArgs e)
        {
            RadioButton rbMode = (RadioButton)sender;
            playerSigneMode[2] = rbMode.Tag.ToString();
        }

        #endregion

        #region Click

        /// <summary>
        /// Sauvegarde des éléments modifier + message d'erreur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveClick(object sender, EventArgs e)
        {
            if (txtPlayer1.Text == "" || txtPlayer2.Text == "" || txtPlayer1.Text.Length >8 || txtPlayer2.Text.Length > 8)
            {
                lblError.Text = "One of the fields is empty OR the name is too long";
                lblError.BackColor = Color.Red;
            }
            else
            {
                playerName[0] = txtPlayer1.Text;
                playerName[1] = txtPlayer2.Text;
                lblError.Text = "good save";
                lblError.BackColor = Color.Orange;
            }
            lblError.ForeColor = Color.White;
        }


        /// <summary>
        /// fermeture du formualaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
