namespace TicTacToe
{
    partial class frm_ZoneJeu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ZoneJeu));
            this.lblGagnant = new System.Windows.Forms.Label();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblScoreJoueur1 = new System.Windows.Forms.Label();
            this.lblJoueur1 = new System.Windows.Forms.Label();
            this.lblJoueur2 = new System.Windows.Forms.Label();
            this.lblScoreJoueur2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelIndicationJoueur = new System.Windows.Forms.Label();
            this.btnAffichageJoueur1 = new System.Windows.Forms.Button();
            this.btnAffichageJoueur2 = new System.Windows.Forms.Button();
            this.timerOrdinateur = new System.Windows.Forms.Timer(this.components);
            this.lblLettreGagnant = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGagnant
            // 
            this.lblGagnant.BackColor = System.Drawing.Color.Transparent;
            this.lblGagnant.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGagnant.ForeColor = System.Drawing.Color.Snow;
            this.lblGagnant.Location = new System.Drawing.Point(3, 346);
            this.lblGagnant.Name = "lblGagnant";
            this.lblGagnant.Size = new System.Drawing.Size(466, 91);
            this.lblGagnant.TabIndex = 2;
            this.lblGagnant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGagnant.Visible = false;
            // 
            // btnRejouer
            // 
            this.btnRejouer.BackColor = System.Drawing.Color.Transparent;
            this.btnRejouer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRejouer.FlatAppearance.BorderSize = 2;
            this.btnRejouer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRejouer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRejouer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRejouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRejouer.ForeColor = System.Drawing.Color.White;
            this.btnRejouer.Location = new System.Drawing.Point(112, 459);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(106, 47);
            this.btnRejouer.TabIndex = 3;
            this.btnRejouer.Text = "Replay";
            this.btnRejouer.UseVisualStyleBackColor = false;
            this.btnRejouer.Visible = false;
            this.btnRejouer.Click += new System.EventHandler(this.buttonQuitRejouer);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQuitter.FlatAppearance.BorderSize = 2;
            this.btnQuitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(257, 459);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(106, 47);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Leave";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Visible = false;
            this.btnQuitter.Click += new System.EventHandler(this.buttonQuitRejouer);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblScoreJoueur1
            // 
            this.lblScoreJoueur1.BackColor = System.Drawing.Color.White;
            this.lblScoreJoueur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreJoueur1.ForeColor = System.Drawing.Color.DimGray;
            this.lblScoreJoueur1.Location = new System.Drawing.Point(152, 61);
            this.lblScoreJoueur1.Name = "lblScoreJoueur1";
            this.lblScoreJoueur1.Size = new System.Drawing.Size(57, 30);
            this.lblScoreJoueur1.TabIndex = 14;
            this.lblScoreJoueur1.Text = "a";
            this.lblScoreJoueur1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJoueur1
            // 
            this.lblJoueur1.BackColor = System.Drawing.Color.White;
            this.lblJoueur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoueur1.ForeColor = System.Drawing.Color.Black;
            this.lblJoueur1.Location = new System.Drawing.Point(88, 61);
            this.lblJoueur1.Name = "lblJoueur1";
            this.lblJoueur1.Size = new System.Drawing.Size(38, 30);
            this.lblJoueur1.TabIndex = 15;
            this.lblJoueur1.Text = "a";
            this.lblJoueur1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJoueur2
            // 
            this.lblJoueur2.BackColor = System.Drawing.Color.White;
            this.lblJoueur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoueur2.ForeColor = System.Drawing.Color.Black;
            this.lblJoueur2.Location = new System.Drawing.Point(265, 61);
            this.lblJoueur2.Name = "lblJoueur2";
            this.lblJoueur2.Size = new System.Drawing.Size(46, 30);
            this.lblJoueur2.TabIndex = 16;
            this.lblJoueur2.Text = "a";
            this.lblJoueur2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreJoueur2
            // 
            this.lblScoreJoueur2.BackColor = System.Drawing.Color.White;
            this.lblScoreJoueur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreJoueur2.ForeColor = System.Drawing.Color.DimGray;
            this.lblScoreJoueur2.Location = new System.Drawing.Point(330, 61);
            this.lblScoreJoueur2.Name = "lblScoreJoueur2";
            this.lblScoreJoueur2.Size = new System.Drawing.Size(49, 30);
            this.lblScoreJoueur2.TabIndex = 17;
            this.lblScoreJoueur2.Text = "a";
            this.lblScoreJoueur2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelIndicationJoueur);
            this.panel1.Controls.Add(this.btnAffichageJoueur1);
            this.panel1.Controls.Add(this.lblScoreJoueur2);
            this.panel1.Controls.Add(this.btnAffichageJoueur2);
            this.panel1.Controls.Add(this.lblJoueur2);
            this.panel1.Controls.Add(this.lblScoreJoueur1);
            this.panel1.Controls.Add(this.lblJoueur1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 169);
            this.panel1.TabIndex = 18;
            // 
            // labelIndicationJoueur
            // 
            this.labelIndicationJoueur.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndicationJoueur.ForeColor = System.Drawing.Color.Black;
            this.labelIndicationJoueur.Location = new System.Drawing.Point(78, 117);
            this.labelIndicationJoueur.Name = "labelIndicationJoueur";
            this.labelIndicationJoueur.Size = new System.Drawing.Size(310, 33);
            this.labelIndicationJoueur.TabIndex = 18;
            this.labelIndicationJoueur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAffichageJoueur1
            // 
            this.btnAffichageJoueur1.BackColor = System.Drawing.Color.White;
            this.btnAffichageJoueur1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(189)))), ((int)(((byte)(172)))));
            this.btnAffichageJoueur1.FlatAppearance.BorderSize = 2;
            this.btnAffichageJoueur1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAffichageJoueur1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAffichageJoueur1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAffichageJoueur1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAffichageJoueur1.ForeColor = System.Drawing.Color.White;
            this.btnAffichageJoueur1.Location = new System.Drawing.Point(81, 54);
            this.btnAffichageJoueur1.Name = "btnAffichageJoueur1";
            this.btnAffichageJoueur1.Size = new System.Drawing.Size(137, 45);
            this.btnAffichageJoueur1.TabIndex = 5;
            this.btnAffichageJoueur1.UseVisualStyleBackColor = false;
            // 
            // btnAffichageJoueur2
            // 
            this.btnAffichageJoueur2.BackColor = System.Drawing.Color.White;
            this.btnAffichageJoueur2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(189)))), ((int)(((byte)(172)))));
            this.btnAffichageJoueur2.FlatAppearance.BorderSize = 2;
            this.btnAffichageJoueur2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAffichageJoueur2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAffichageJoueur2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAffichageJoueur2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAffichageJoueur2.ForeColor = System.Drawing.Color.White;
            this.btnAffichageJoueur2.Location = new System.Drawing.Point(251, 54);
            this.btnAffichageJoueur2.Name = "btnAffichageJoueur2";
            this.btnAffichageJoueur2.Size = new System.Drawing.Size(137, 45);
            this.btnAffichageJoueur2.TabIndex = 11;
            this.btnAffichageJoueur2.UseVisualStyleBackColor = false;
            // 
            // timerOrdinateur
            // 
            this.timerOrdinateur.Interval = 1000;
            this.timerOrdinateur.Tick += new System.EventHandler(this.timerOrdinateur_Tick);
            // 
            // lblLettreGagnant
            // 
            this.lblLettreGagnant.BackColor = System.Drawing.Color.Transparent;
            this.lblLettreGagnant.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLettreGagnant.ForeColor = System.Drawing.Color.Snow;
            this.lblLettreGagnant.Location = new System.Drawing.Point(112, 200);
            this.lblLettreGagnant.Name = "lblLettreGagnant";
            this.lblLettreGagnant.Size = new System.Drawing.Size(251, 174);
            this.lblLettreGagnant.TabIndex = 19;
            this.lblLettreGagnant.Text = "X";
            this.lblLettreGagnant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLettreGagnant.Visible = false;
            // 
            // frm_ZoneJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(189)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(469, 626);
            this.Controls.Add(this.lblLettreGagnant);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRejouer);
            this.Controls.Add(this.lblGagnant);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ZoneJeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblGagnant;
        private System.Windows.Forms.Button btnRejouer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblScoreJoueur1;
        private System.Windows.Forms.Label lblJoueur1;
        private System.Windows.Forms.Label lblJoueur2;
        private System.Windows.Forms.Label lblScoreJoueur2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAffichageJoueur1;
        private System.Windows.Forms.Button btnAffichageJoueur2;
        private System.Windows.Forms.Timer timerOrdinateur;
        private System.Windows.Forms.Label labelIndicationJoueur;
        private System.Windows.Forms.Label lblLettreGagnant;
    }
}