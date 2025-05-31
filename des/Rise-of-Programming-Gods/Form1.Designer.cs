using System;
using System.Windows.Forms;

namespace Rise_of_Programming_Gods
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (pictureBox1.Image != null)
                    pictureBox1.Image.Dispose();

                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtPlayer1Name = new System.Windows.Forms.TextBox();
            this.txtPlayer2Name = new System.Windows.Forms.TextBox();
            this.cmbPlayer1Type = new System.Windows.Forms.ComboBox();
            this.cmbPlayer2Type = new System.Windows.Forms.ComboBox();
            this.btnStartBattle = new System.Windows.Forms.Button();
            this.txtBattleLog = new System.Windows.Forms.RichTextBox();
            this.lblPlayer1Health = new System.Windows.Forms.Label();
            this.lblPlayer2Health = new System.Windows.Forms.Label();
            this.progressBarPlayer1 = new System.Windows.Forms.ProgressBar();
            this.progressBarPlayer2 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlayer1Name
            // 
            this.txtPlayer1Name.Location = new System.Drawing.Point(30, 45);
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.Size = new System.Drawing.Size(150, 22);
            this.txtPlayer1Name.TabIndex = 1;
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.Location = new System.Drawing.Point(570, 45);
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.Size = new System.Drawing.Size(150, 22);
            this.txtPlayer2Name.TabIndex = 7;
            // 
            // cmbPlayer1Type
            // 
            this.cmbPlayer1Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayer1Type.Location = new System.Drawing.Point(30, 100);
            this.cmbPlayer1Type.Name = "cmbPlayer1Type";
            this.cmbPlayer1Type.Size = new System.Drawing.Size(150, 24);
            this.cmbPlayer1Type.TabIndex = 3;
            // 
            // cmbPlayer2Type
            // 
            this.cmbPlayer2Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayer2Type.Location = new System.Drawing.Point(570, 100);
            this.cmbPlayer2Type.Name = "cmbPlayer2Type";
            this.cmbPlayer2Type.Size = new System.Drawing.Size(150, 24);
            this.cmbPlayer2Type.TabIndex = 9;
            // 
            // btnStartBattle
            // 
            this.btnStartBattle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartBattle.Location = new System.Drawing.Point(191, 625);
            this.btnStartBattle.Name = "btnStartBattle";
            this.btnStartBattle.Size = new System.Drawing.Size(350, 30);
            this.btnStartBattle.TabIndex = 13;
            this.btnStartBattle.Text = "Start Battle";
            this.btnStartBattle.Click += new System.EventHandler(this.btnStartBattle_Click);
            // 
            // txtBattleLog
            // 
            this.txtBattleLog.BackColor = System.Drawing.Color.White;
            this.txtBattleLog.Location = new System.Drawing.Point(149, 474);
            this.txtBattleLog.Name = "txtBattleLog";
            this.txtBattleLog.ReadOnly = true;
            this.txtBattleLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtBattleLog.Size = new System.Drawing.Size(461, 130);
            this.txtBattleLog.TabIndex = 5;
            this.txtBattleLog.Text = "";
            // 
            // lblPlayer1Health
            // 
            this.lblPlayer1Health.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Health.Location = new System.Drawing.Point(30, 135);
            this.lblPlayer1Health.Name = "lblPlayer1Health";
            this.lblPlayer1Health.Size = new System.Drawing.Size(150, 20);
            this.lblPlayer1Health.TabIndex = 4;
            this.lblPlayer1Health.Text = "Health: 100";
            // 
            // lblPlayer2Health
            // 
            this.lblPlayer2Health.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Health.Location = new System.Drawing.Point(570, 135);
            this.lblPlayer2Health.Name = "lblPlayer2Health";
            this.lblPlayer2Health.Size = new System.Drawing.Size(150, 20);
            this.lblPlayer2Health.TabIndex = 10;
            this.lblPlayer2Health.Text = "Health: 100";
            // 
            // progressBarPlayer1
            // 
            this.progressBarPlayer1.Location = new System.Drawing.Point(30, 160);
            this.progressBarPlayer1.Name = "progressBarPlayer1";
            this.progressBarPlayer1.Size = new System.Drawing.Size(150, 20);
            this.progressBarPlayer1.TabIndex = 5;
            this.progressBarPlayer1.Value = 100;
            // 
            // progressBarPlayer2
            // 
            this.progressBarPlayer2.Location = new System.Drawing.Point(570, 160);
            this.progressBarPlayer2.Name = "progressBarPlayer2";
            this.progressBarPlayer2.Size = new System.Drawing.Size(150, 20);
            this.progressBarPlayer2.TabIndex = 11;
            this.progressBarPlayer2.Value = 100;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(570, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player 2:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Character:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(570, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Character:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(690, 229);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rise_of_Programming_Gods.Properties.Resources.classroombg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 686);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlayer1Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPlayer1Type);
            this.Controls.Add(this.lblPlayer1Health);
            this.Controls.Add(this.progressBarPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlayer2Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbPlayer2Type);
            this.Controls.Add(this.lblPlayer2Health);
            this.Controls.Add(this.progressBarPlayer2);
            this.Controls.Add(this.txtBattleLog);
            this.Controls.Add(this.btnStartBattle);
            this.MinimumSize = new System.Drawing.Size(780, 360);
            this.Name = "Form1";
            this.Text = "Rise of Programming Gods";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AttackPlayers()
        {
            Random rnd = new Random();

            int damageToP1 = rnd.Next(5, 21);
            int damageToP2 = rnd.Next(5, 21);

            player1Health = Math.Max(0, player1Health - damageToP1);
            player2Health = Math.Max(0, player2Health - damageToP2);

            lblPlayer1Health.Text = $"Health: {player1Health}";
            progressBarPlayer1.Value = player1Health;

            lblPlayer2Health.Text = $"Health: {player2Health}";
            progressBarPlayer2.Value = player2Health;

            txtBattleLog.AppendText($"Player 1 takes {damageToP1} damage! Health now: {player1Health}\n");
            txtBattleLog.AppendText($"Player 2 takes {damageToP2} damage! Health now: {player2Health}\n");
            txtBattleLog.ScrollToCaret();

            if (player1Health == 0 || player2Health == 0)
            {
                btnStartBattle.Enabled = false;
                string winner = player1Health == 0 && player2Health == 0 ? "No one, it's a tie!" :
                                player1Health == 0 ? "Player 2 wins!" : "Player 1 wins!";
                txtBattleLog.AppendText($"Battle Over! {winner}\n");
            }
        }




        #endregion

        private System.Windows.Forms.TextBox txtPlayer1Name;
        private System.Windows.Forms.TextBox txtPlayer2Name;
        private System.Windows.Forms.ComboBox cmbPlayer1Type;
        private System.Windows.Forms.ComboBox cmbPlayer2Type;
        private System.Windows.Forms.Button btnStartBattle;
        private System.Windows.Forms.RichTextBox txtBattleLog;
        private System.Windows.Forms.Label lblPlayer1Health;
        private System.Windows.Forms.Label lblPlayer2Health;
        private System.Windows.Forms.ProgressBar progressBarPlayer1;
        private System.Windows.Forms.ProgressBar progressBarPlayer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private PictureBox pictureBox1;
    }
}
