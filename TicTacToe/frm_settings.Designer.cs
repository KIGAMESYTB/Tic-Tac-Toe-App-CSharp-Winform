namespace TicTacToe
{
    partial class frm_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_settings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pieceX = new System.Windows.Forms.RadioButton();
            this.pieceO = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mode2 = new System.Windows.Forms.RadioButton();
            this.mode3 = new System.Windows.Forms.RadioButton();
            this.mode1 = new System.Windows.Forms.RadioButton();
            this.picRetour = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRetour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.labelPlayer2);
            this.groupBox1.Controls.Add(this.txtPlayer2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPlayer1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NAME";
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Location = new System.Drawing.Point(36, 103);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(130, 22);
            this.labelPlayer2.TabIndex = 3;
            this.labelPlayer2.Text = "PLAYER 2 :";
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(190, 100);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(208, 30);
            this.txtPlayer2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "PLAYER 1 :";
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(190, 43);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(208, 30);
            this.txtPlayer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Snow;
            this.groupBox2.Controls.Add(this.pieceX);
            this.groupBox2.Controls.Add(this.pieceO);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PIECE";
            // 
            // pieceX
            // 
            this.pieceX.AutoSize = true;
            this.pieceX.Checked = true;
            this.pieceX.Location = new System.Drawing.Point(200, 50);
            this.pieceX.Name = "pieceX";
            this.pieceX.Size = new System.Drawing.Size(43, 26);
            this.pieceX.TabIndex = 4;
            this.pieceX.TabStop = true;
            this.pieceX.Tag = "X";
            this.pieceX.Text = "X";
            this.pieceX.UseVisualStyleBackColor = true;
            this.pieceX.CheckedChanged += new System.EventHandler(this.pieceChecked);
            // 
            // pieceO
            // 
            this.pieceO.AutoSize = true;
            this.pieceO.Location = new System.Drawing.Point(287, 50);
            this.pieceO.Name = "pieceO";
            this.pieceO.Size = new System.Drawing.Size(43, 26);
            this.pieceO.TabIndex = 3;
            this.pieceO.Tag = "O";
            this.pieceO.Text = "O";
            this.pieceO.UseVisualStyleBackColor = true;
            this.pieceO.CheckedChanged += new System.EventHandler(this.pieceChecked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "PLAYER 1 :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Snow;
            this.groupBox3.Controls.Add(this.mode2);
            this.groupBox3.Controls.Add(this.mode3);
            this.groupBox3.Controls.Add(this.mode1);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 413);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(445, 93);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MODE";
            // 
            // mode2
            // 
            this.mode2.AutoSize = true;
            this.mode2.Location = new System.Drawing.Point(166, 42);
            this.mode2.Name = "mode2";
            this.mode2.Size = new System.Drawing.Size(103, 26);
            this.mode2.TabIndex = 7;
            this.mode2.Tag = "moyen";
            this.mode2.Text = "Normal";
            this.mode2.UseVisualStyleBackColor = true;
            this.mode2.CheckedChanged += new System.EventHandler(this.modeChecked);
            // 
            // mode3
            // 
            this.mode3.AutoSize = true;
            this.mode3.BackColor = System.Drawing.Color.Gainsboro;
            this.mode3.Enabled = false;
            this.mode3.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mode3.Location = new System.Drawing.Point(287, 42);
            this.mode3.Name = "mode3";
            this.mode3.Size = new System.Drawing.Size(130, 24);
            this.mode3.TabIndex = 6;
            this.mode3.Tag = "hard";
            this.mode3.Text = "Impossible";
            this.mode3.UseVisualStyleBackColor = false;
            this.mode3.CheckedChanged += new System.EventHandler(this.modeChecked);
            // 
            // mode1
            // 
            this.mode1.AutoSize = true;
            this.mode1.Checked = true;
            this.mode1.Location = new System.Drawing.Point(37, 42);
            this.mode1.Name = "mode1";
            this.mode1.Size = new System.Drawing.Size(79, 26);
            this.mode1.TabIndex = 5;
            this.mode1.TabStop = true;
            this.mode1.Tag = "easy";
            this.mode1.Text = "Easy";
            this.mode1.UseVisualStyleBackColor = true;
            this.mode1.CheckedChanged += new System.EventHandler(this.modeChecked);
            // 
            // picRetour
            // 
            this.picRetour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRetour.BackgroundImage")));
            this.picRetour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRetour.Location = new System.Drawing.Point(365, 538);
            this.picRetour.Name = "picRetour";
            this.picRetour.Size = new System.Drawing.Size(81, 76);
            this.picRetour.TabIndex = 3;
            this.picRetour.TabStop = false;
            this.picRetour.Click += new System.EventHandler(this.picRetour_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 555);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 46);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.saveClick);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DimGray;
            this.lblError.Location = new System.Drawing.Point(45, 9);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(387, 66);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "Welcome in the settings ! ";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(469, 626);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.picRetour);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRetour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.RadioButton pieceX;
        private System.Windows.Forms.RadioButton pieceO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picRetour;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.RadioButton mode3;
        private System.Windows.Forms.RadioButton mode1;
        private System.Windows.Forms.RadioButton mode2;
    }
}