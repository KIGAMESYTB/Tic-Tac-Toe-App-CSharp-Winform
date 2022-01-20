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
    public partial class frm_ZoneJeu : Form
    {
        
        #region Variable

        Random random;
        TableLayoutPanel table;
        List<String> playerName;
        List<String> playerSigneMode;
        String letterWin;
        int countNameBtn = 0;
        int nbColRow;
        int countEachInTurn;
        bool valeurVertical, valeurHorizontal, valeurDiagonalDroite, valeurDiagonalGauche;
        List<Control> buttonListEnabled;
        bool stop; 
        Control buttonChoose;
        int valueNbElement;
        int scoreJoueur1;
        int scoreJoueur2;
        #endregion

        public frm_ZoneJeu(List<String> playerName, List<String> playerSigneMode)
        {
            InitializeComponent();
            this.playerName = new List<string>();
            this.playerSigneMode = new List<String>(); 
            this.playerName = playerName;
            this.playerSigneMode = playerSigneMode;
            buttonListEnabled = new List<Control>();
            scoreJoueur1 = 0;
            scoreJoueur2 = 0;
            nbColRow = 3;
            table = createTableLayoutPanel(nbColRow);
            valueNbElement = 0;
            random = new Random();
            btnAffichageJoueur1.SendToBack();
            btnAffichageJoueur2.SendToBack();
            eachInTurn(countEachInTurn);
            initialisation();
        }

        /// <summary>
        /// Initialisation de la partie
        /// </summary>
        private void initialisation()
        {
            valeurVertical = false;
            valeurHorizontal = false;
            valeurDiagonalDroite = false;
            valeurDiagonalGauche = false;
            countEachInTurn = 0;
            countNameBtn = 0;
            deleteButton();
            addButtonTable();
            stop = false;
            lblJoueur1.Text = playerSigneMode[0];
            lblScoreJoueur1.Text = scoreJoueur1.ToString();
            lblJoueur2.Text = playerSigneMode[1];
            lblScoreJoueur2.Text = scoreJoueur2.ToString();
            eachInTurn(countEachInTurn);
            if (letterWin == playerSigneMode[0])
            {
                if (playerSigneMode[3] == "P-C")
                {
                    countEachInTurn++;
                    buttonEnabledFalse();
                    opposingPlayerComputer(buttonListEnabled, stop);
                }

            }
            else
            {
                countEachInTurn = 0;
            }
            letterWin = "";
        }
        /// <summary>
        /// Supression des button de la table
        /// </summary>
        private void deleteButton()
        {
            for (int i = 0; i < table.RowCount; i++)
            {
                for (int j = 0; j < table.ColumnCount; j++)
                {
                    table.Controls.Remove(table.GetControlFromPosition(j, i));
                }
            }
        }

        /// <summary>
        /// Ajout de button dans la table
        /// </summary>
        private void addButtonTable()
        {
            for (int i = 0; i < table.RowCount; i++)
            {
                for (int j = 0; j < table.ColumnCount; j++)
                {
                    Button btn = createButton();
                    table.Controls.Add(btn, j, i);
                }
            }
        }

        /// <summary>
        /// Création de button
        /// </summary>
        /// <returns>Button créé</returns>
        
        private void buttonEnabledFalse()
        {
            buttonListEnabled.Clear();
            foreach (Control ctrl in table.Controls)
            {
                if (ctrl.Enabled == true)
                {
                    buttonListEnabled.Add(ctrl);
                }
            }
        }

        private void rendreButtonEnabled(bool enabled)
        {
            foreach (Button ctrl in buttonListEnabled)
            {
                ctrl.Enabled = enabled;
            }
        }

        private Button createButton()
        {
            countNameBtn++;
            Button btn = new Button();
            btn.Name = "button" + (countNameBtn).ToString();
            btn.Text = "";
            btn.Tag = btn.Name;
            btn.Font = new Font("Courier New", 35F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Dock = DockStyle.Fill;
            btn.BackColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(144)))), ((int)(((byte)(240)))));
            btn.Click += new System.EventHandler(this.buttonTableClick);
            return btn;
        }

        /// <summary>
        /// Procédure lors d'un click sur le button d'une table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTableClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            countEachInTurn++;
            btn.Text = eachInTurn(countEachInTurn);
            btn.Tag = eachInTurn(countEachInTurn);
            btn.Enabled = false;
            winResult(nbColRow, ref stop);
            
            buttonEnabledFalse();
            if (buttonListEnabled.Count != 0)
            {
                if (playerSigneMode[3] == "P-C" && !stop)
                {
                    timerOrdinateur.Start();
                    foreach(Control ctrl in buttonListEnabled)
                    {
                        ctrl.Enabled = false;
                    }
                }
            }
            else if(buttonListEnabled.Count == 0 && !stop)
            {
                finDePartie("X/O", "Equality");
            }
            
        }

        /// <summary>
        /// L'ordinateur joue 
        /// </summary>
        /// <param name="buttonListEnabled"></param>
        /// <param name="stop"></param>
        private void opposingPlayerComputer( List<Control> buttonListEnabled, bool stop)
        {
            int entier;
            valueNbElement = 0;
            entier = random.Next(0,buttonListEnabled.Count); 
            
            switch (playerSigneMode[2])
            {
                case "easy":
                    buttonChoose = buttonListEnabled[entier];
                    break;
                case "moyen":
                    buttonChoose = buttonListEnabled[entier];
                    difficultieMoyenHard();
                    break;
            }
            countEachInTurn++;
            buttonChoose.Text = eachInTurn(countEachInTurn);
            buttonChoose.Tag = eachInTurn(countEachInTurn);
            buttonChoose.Enabled = false;
            winResult(nbColRow, ref stop);
            buttonEnabledFalse();
            if (buttonListEnabled.Count == 0 && !stop)
            {
                finDePartie("X/O", "Equality");
            }
        }

        /// <summary>
        /// L'ordinateur calcule les coups gagnant et les coups à contrer
        /// </summary>
        private void difficultieMoyenHard()
        {

            determineElementLigneColonne(playerSigneMode[1], ref buttonChoose, ref valueNbElement, false);

            if (valueNbElement < 2)
            {
                determineElementColonneLigne(playerSigneMode[1], ref buttonChoose, ref valueNbElement, false);
            }
            if (valueNbElement < 2)
            {
                determineElementDiagonaleDroite(playerSigneMode[1], ref buttonChoose, ref valueNbElement, false);
            }
            if (valueNbElement < 2)
            {
                determineElementDiagonaleGauche(playerSigneMode[1], ref buttonChoose, ref valueNbElement, false);
            }
            if (valueNbElement < 2)
            {
                determineElementLigneColonne(playerSigneMode[0], ref buttonChoose, ref valueNbElement, false);
            }
            if (valueNbElement < 2)
            {
                determineElementColonneLigne(playerSigneMode[0], ref buttonChoose, ref valueNbElement, false);
            }
            if (valueNbElement < 2)
            {
                determineElementDiagonaleDroite(playerSigneMode[0], ref buttonChoose, ref valueNbElement, false);
            }
            if (valueNbElement < 2)
            {
                determineElementDiagonaleGauche(playerSigneMode[0], ref buttonChoose, ref valueNbElement, false);
            }

        }
        private void determineElementLigneColonne(String caractere, ref Control buttonChoose, ref int valueNbElement, bool valueColonneLigneEnabled)
        {
            int colonne = 0;
            int ligne = 0;
            for (int i = 0; i < table.RowCount; i++)
            {
                valueNbElement = 0;
                for (int j = 0; j < table.ColumnCount; j++)
                {
                    if (table.GetControlFromPosition(j, i).Tag.ToString() == caractere)
                    {
                        valueNbElement++;
                    }
                    if (table.GetControlFromPosition(j, i).Enabled == true)
                    {
                        colonne = j;
                        ligne = i;
                        valueColonneLigneEnabled = true;
                    }
                }
                if (valueNbElement >= 2 && valueColonneLigneEnabled)
                {
                    buttonChoose = table.GetControlFromPosition(colonne, ligne);
                    valueColonneLigneEnabled = false;
                    break;
                }
            }
        }

        private void determineElementColonneLigne(String caractere, ref Control buttonChoose, ref int valueNbElement, bool valueColonneLigneEnabled)
        {
            int colonne = 0;
            int ligne = 0;
            for (int j = 0; j < table.ColumnCount; j++)
            {
                valueNbElement = 0;
                for (int i = 0; i < table.RowCount; i++)
                {
                    if (table.GetControlFromPosition(j, i).Tag.ToString() == caractere)
                    {
                        valueNbElement++;
                    }
                    if (table.GetControlFromPosition(j, i).Enabled == true)
                    {
                        colonne = j;
                        ligne = i;
                        valueColonneLigneEnabled = true;
                    }
                }
                if (valueNbElement >= 2 && valueColonneLigneEnabled)
                {
                    buttonChoose = table.GetControlFromPosition(colonne, ligne);
                    valueColonneLigneEnabled = false;
                    break;
                }
            }
        }

        private void determineElementDiagonaleDroite(String caractere, ref Control buttonChoose, ref int valueNbElement, bool valueColonneLigneEnabled)
        {
            int colonne = 0;
            int ligne = 0;
            valueNbElement = 0;
            for (int i = 0; i < nbColRow; i++)
            {
                if (table.GetControlFromPosition(i, i).Tag.ToString() == caractere)
                {
                    valueNbElement++;
                }
                if (table.GetControlFromPosition(i, i).Enabled == true)
                {
                    colonne = i;
                    ligne = i;
                    valueColonneLigneEnabled = true;
                }
            }
            if (valueNbElement >= 2 && valueColonneLigneEnabled)
            {
                buttonChoose = table.GetControlFromPosition(colonne, ligne);
                valueColonneLigneEnabled = false;
            }
        }

        private void determineElementDiagonaleGauche(String caractere, ref Control buttonChoose, ref int valueNbElement, bool valueColonneLigneEnabled)
        {
            int colonne = 0;
            int ligne = 0;
            valueNbElement = 0;
            for (int i = 0; i < nbColRow; i++)
            {
                if (table.GetControlFromPosition(nbColRow-1-i, i).Tag.ToString() == caractere)
                {
                    valueNbElement++;
                }
                if (table.GetControlFromPosition(nbColRow - 1 - i, i).Enabled == true)
                {
                    colonne = nbColRow - 1 - i;
                    ligne = i;
                    valueColonneLigneEnabled = true;
                }
            }
            if (valueNbElement >= 2 && valueColonneLigneEnabled)
            {
                buttonChoose = table.GetControlFromPosition(colonne, ligne);
                valueColonneLigneEnabled = false;
            }
        }


        /// <summary>
        /// Fonction donnant le tag d'un control de la table selon sa position
        /// </summary>
        /// <param name="column">colonne de la table</param>
        /// <param name="row">ligne de la table</param>
        /// <returns>Retourne le tag du button de la table</returns>
        private Object eachTagBtn(int column, int row)
        {
            return table.GetControlFromPosition(column, row).Tag;
        }

        /// <summary>
        /// Fonction permettant de colorier les 3 pieces identiques alignées
        /// </summary>
        /// <param name="tagBtn">tag du button</param>
        /// <param name="position">
        /// La position des 3 pieces identiques alignées 
        /// "V" = les pieces sont alignées verticalement
        /// "H" = les pieces sont alignées horizontalement
        /// "DD" = les pieces sont alignées diagonalement en commençant par la droite
        /// "DG" = les pieces sont alignées diagonalement en commençant par la gauche
        /// </param>
        /// <param name="column">colonne du button gagnant</param>
        /// <param name="row">ligne du button gagnant</param>
        /// <returns>Retourne le tag du button gagnant</returns>
        private String letterColorWin(Object tagBtn, String position, int column, int row)
        {
            List<int> columnRowBtnPrecAct = new List<int>();
            switch (position)
            {
                case "V":
                    columnRowBtnPrecAct = new List<int>() { 1, 0 };
                    break;
                case "H":
                    columnRowBtnPrecAct = new List<int>() { 0, 1 };
                    break;
                case "DD":
                    columnRowBtnPrecAct = new List<int>() { 1, 1 };
                    break;
                case "DG":
                    columnRowBtnPrecAct = new List<int>() { 1, -1 };
                    break;
            }
            rendreButtonEnabled(false);
            for (int i=0; i<2; i++)
            {
                table.GetControlFromPosition(column, row).BackColor = Color.Gold;
                table.GetControlFromPosition(column + columnRowBtnPrecAct[0], row + columnRowBtnPrecAct[1]).BackColor = Color.Gold;
                table.GetControlFromPosition(column -columnRowBtnPrecAct[0], row - columnRowBtnPrecAct[1]).BackColor = Color.Gold;
            }

            return tagBtn.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nbColRow"></param>
        /// <param name="stop"></param>
        private void winResult(int nbColRow, ref bool stop)
        {
            for(int i=0; i<table.RowCount; i++)
            {
                for(int j=0; j<table.ColumnCount; j++)
                {
                    if ((j!=0 || i!=0) && (j!= nbColRow-1 || i != nbColRow -1) && (j != 0 || i != nbColRow - 1) && (j != nbColRow - 1 || i != 0))
                    {
                        Object tagBtn = table.GetControlFromPosition(j, i).Tag;

                        differentCasGagnant(i, j, nbColRow, tagBtn);
                    }
                }
            }

            if (valeurDiagonalDroite || valeurDiagonalGauche ||  valeurHorizontal || valeurVertical)
            {
                stop = true;
                timer1.Start();

            }
        }

        /// <summary>
        /// Procédure permettant de calculer les différents cas gagnant
        /// </summary>
        /// <param name="i">nombre de ligne de la table</param>
        /// <param name="j">nombre de colonne de la table</param>
        /// <param name="nbColRow">dimension de la table</param>
        /// <param name="tagBtn">Tag du bouton</param>
        private void differentCasGagnant(int i, int j, int nbColRow, Object tagBtn)
        {
            if (j != 0 && j != nbColRow - 1)
            {
                if (eachTagBtn(j + 1, i) == tagBtn && eachTagBtn(j - 1, i) == tagBtn)
                {
                    valeurVertical = true;
                    letterWin = letterColorWin(tagBtn, "V", j, i);
                }
            }
            if (i != 0 && i != nbColRow - 1)
            {
                if (eachTagBtn(j, i + 1) == tagBtn && eachTagBtn(j, i - 1) == tagBtn)
                {
                    valeurHorizontal = true;
                    letterWin = letterColorWin(tagBtn, "H", j, i);
                }
            }
            if (i != 0 && i != nbColRow - 1 && j != 0 && j != nbColRow - 1)
            {
                if (eachTagBtn(j + 1, i + 1) == tagBtn && eachTagBtn(j - 1, i - 1) == tagBtn)
                {
                    valeurDiagonalDroite = true;
                    letterWin = letterColorWin(tagBtn, "DD", j, i);
                }
                if (eachTagBtn(j + 1, i - 1) == tagBtn && eachTagBtn(j - 1, i + 1) == tagBtn)
                {
                    valeurDiagonalGauche = true;
                    letterWin = letterColorWin(tagBtn, "DG", j, i);
                }
            }
        }

        /// <summary>
        /// Procédure timer permettant d'animer la fin de partie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if ((countEachInTurn - 1) % 2 == 0)
            {
                scoreJoueur1++;
            }
            else
            {
                scoreJoueur2++;
            }
            finDePartie(letterWin, playerName[(countEachInTurn - 1) % 2] + " win !!");
            
        }

        private void finDePartie(String letterGagnant, String gagnant)
        {
            table.Visible = false;
            lblLettreGagnant.Text = letterGagnant;
            lblGagnant.Text = gagnant;
            lblScoreJoueur1.Text = scoreJoueur1.ToString();
            lblScoreJoueur2.Text = scoreJoueur2.ToString(); 
            affichageCouleurJoueurButtonLabel(btnAffichageJoueur2, lblScoreJoueur2, lblJoueur2, false, Color.White, Color.White);
            labelIndicationJoueur.Text = "Do you want to replay ?";
            lblLettreGagnant.Visible = true;
            lblGagnant.Visible = true;
            btnQuitter.Visible = true;
            btnRejouer.Visible = true;
        }
        /// <summary>
        /// Procédure lors d'un click sur le bouton rejouer ou quitter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonQuitRejouer(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            timer1.Stop();
            lblGagnant.Text = "";
            lblLettreGagnant.Visible = false;
            lblGagnant.Visible = false;
            btnQuitter.Visible = false;
            btnRejouer.Visible = false;
            if(btn.Name == "btnRejouer")
            {
                table.Visible = true;
                initialisation();
            }
            else if(btn.Name == "btnQuitter")
            {
                this.Close();
            }

        }

        private void timerOrdinateur_Tick(object sender, EventArgs e)
        {
            timerOrdinateur.Stop();
            foreach(Control ctrl in buttonListEnabled)
            {
                ctrl.Enabled = true;
            }
            opposingPlayerComputer(buttonListEnabled, stop);
        }

        /// <summary>
        /// Fonction permettant de jouer un par un les joueurs
        /// </summary>
        /// <param name="countEachInTurn"></param>
        /// <returns>la piece choisi par le joueur</returns>
        private String eachInTurn(int countEachInTurn)
        {
            String letter = playerSigneMode[0];
            affichageCouleurJoueurButtonLabel(btnAffichageJoueur1, lblScoreJoueur1, lblJoueur1, false, Color.LightGray, Color.White);
            labelIndicationJoueur.Text = playerName[1] + ", it's your turn !";

            if (countEachInTurn%2 == 0)
            {
                letter = playerSigneMode[1];
                affichageCouleurJoueurButtonLabel(btnAffichageJoueur2, lblScoreJoueur2, lblJoueur2, true, Color.LightGray, Color.White);
                labelIndicationJoueur.Text = playerName[0] + ", it's your turn !";
            }
            return letter;
        }

        /// <summary>
        /// Procédure permettant de modifier la couleur lorsque lorque c'est au tour de l'utilisateur
        /// </summary>
        /// <param name="btnAffichageJoueur">button d'affichage du joueur</param>
        /// <param name="lblScoreJoueur">label score du joueur</param>
        /// <param name="lblJoueur">label du joueur</param>
        /// <param name="affichage1">booleen permettant de savoir qui est en train de jouer </param>
        private void affichageCouleurJoueurButtonLabel(Button btnAffichageJoueur, Label lblScoreJoueur, Label lblJoueur, bool affichage1, Color couleur, Color couleurInitiale)
        {
            Color couleurBack = couleur;
            Color nonAffichageBack = couleurInitiale;
            if (affichage1)
            {
                couleurBack = couleurInitiale;
                nonAffichageBack = couleur;
            }
            btnAffichageJoueur2.BackColor = couleurBack;
            lblScoreJoueur2.BackColor = couleurBack;
            lblJoueur2.BackColor = couleurBack;
            btnAffichageJoueur1.BackColor = nonAffichageBack;
            lblScoreJoueur1.BackColor = nonAffichageBack;
            lblJoueur1.BackColor = nonAffichageBack;
        }

        /// <summary>
        /// Fonction permettant de créer une table selon les dimensions choisi
        /// </summary>
        /// <param name="nbColRow">Dimension de la table en colonne et ligne</param>
        /// <returns>Retourne la table</returns>
        private TableLayoutPanel createTableLayoutPanel(int nbColRow)
        {
            TableLayoutPanel table = new TableLayoutPanel();
            table.Location = new Point(30, 150);
            table.Size = new Size(300, 300);
            float oui = 100 / nbColRow;
            table.ColumnCount = nbColRow;
            table.RowCount = nbColRow;
            table.BackColor = Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(189)))), ((int)(((byte)(172)))));
            for (int i=0; i<nbColRow; i++)
            {
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            }
            this.Controls.Add(table);

            return table;
        }

    }
}
