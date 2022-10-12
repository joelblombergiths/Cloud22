namespace Guess
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pGameArea = new System.Windows.Forms.Panel();
            this.pControl = new System.Windows.Forms.Panel();
            this.lblTries = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.pControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pGameArea
            // 
            this.pGameArea.AutoSize = true;
            this.pGameArea.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pGameArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGameArea.Location = new System.Drawing.Point(0, 0);
            this.pGameArea.Name = "pGameArea";
            this.pGameArea.Size = new System.Drawing.Size(352, 506);
            this.pGameArea.TabIndex = 0;
            // 
            // pControl
            // 
            this.pControl.Controls.Add(this.lblTries);
            this.pControl.Controls.Add(this.label1);
            this.pControl.Controls.Add(this.lblResult);
            this.pControl.Controls.Add(this.btnNewGame);
            this.pControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pControl.Location = new System.Drawing.Point(0, 506);
            this.pControl.Name = "pControl";
            this.pControl.Size = new System.Drawing.Size(352, 49);
            this.pControl.TabIndex = 1;
            // 
            // lblTries
            // 
            this.lblTries.AutoSize = true;
            this.lblTries.Location = new System.Drawing.Point(318, 19);
            this.lblTries.Name = "lblTries";
            this.lblTries.Size = new System.Drawing.Size(13, 15);
            this.lblTries.TabIndex = 3;
            this.lblTries.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tries:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(118, 13);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(145, 25);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Guess a number!";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(8, 6);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 40);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(352, 555);
            this.Controls.Add(this.pGameArea);
            this.Controls.Add(this.pControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess The Number";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pControl.ResumeLayout(false);
            this.pControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pGameArea;
        private Panel pControl;
        private Button btnNewGame;
        private Label lblResult;
        private Label lblTries;
        private Label label1;
    }
}