﻿namespace Snake
{
    partial class Form1
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
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore.Location = new System.Drawing.Point(123, 4);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 38);
            this.lblScore.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Score: ";
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pbCanvas.Location = new System.Drawing.Point(12, 44);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(432, 424);
            this.pbCanvas.TabIndex = 4;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGameOver.Location = new System.Drawing.Point(12, 59);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(113, 41);
            this.lblGameOver.TabIndex = 7;
            this.lblGameOver.Text = "label2";
            this.lblGameOver.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 480);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCanvas);
            this.Controls.Add(this.lblGameOver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblGameOver;
    }
}

