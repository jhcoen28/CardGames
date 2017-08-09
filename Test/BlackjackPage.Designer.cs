namespace Test
{
    partial class BlackjackPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picDealerFaceUp = new System.Windows.Forms.PictureBox();
            this.picDealerFaceDown = new System.Windows.Forms.PictureBox();
            this.picPlayerCard2 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerFaceUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerFaceDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dealer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player";
            // 
            // picDealerFaceUp
            // 
            this.picDealerFaceUp.Location = new System.Drawing.Point(295, 79);
            this.picDealerFaceUp.Name = "picDealerFaceUp";
            this.picDealerFaceUp.Size = new System.Drawing.Size(100, 122);
            this.picDealerFaceUp.TabIndex = 6;
            this.picDealerFaceUp.TabStop = false;
            // 
            // picDealerFaceDown
            // 
            this.picDealerFaceDown.Location = new System.Drawing.Point(481, 79);
            this.picDealerFaceDown.Name = "picDealerFaceDown";
            this.picDealerFaceDown.Size = new System.Drawing.Size(100, 122);
            this.picDealerFaceDown.TabIndex = 7;
            this.picDealerFaceDown.TabStop = false;
            // 
            // picPlayerCard2
            // 
            this.picPlayerCard2.Location = new System.Drawing.Point(481, 360);
            this.picPlayerCard2.Name = "picPlayerCard2";
            this.picPlayerCard2.Size = new System.Drawing.Size(100, 122);
            this.picPlayerCard2.TabIndex = 8;
            this.picPlayerCard2.TabStop = false;
            // 
            // picPlayerCard1
            // 
            this.picPlayerCard1.Location = new System.Drawing.Point(295, 360);
            this.picPlayerCard1.Name = "picPlayerCard1";
            this.picPlayerCard1.Size = new System.Drawing.Size(100, 122);
            this.picPlayerCard1.TabIndex = 9;
            this.picPlayerCard1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // BlackjackPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 568);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picPlayerCard1);
            this.Controls.Add(this.picPlayerCard2);
            this.Controls.Add(this.picDealerFaceDown);
            this.Controls.Add(this.picDealerFaceUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BlackjackPage";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Blackjack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDealerFaceUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerFaceDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picDealerFaceUp;
        private System.Windows.Forms.PictureBox picDealerFaceDown;
        private System.Windows.Forms.PictureBox picPlayerCard2;
        private System.Windows.Forms.PictureBox picPlayerCard1;
        private System.Windows.Forms.Label label3;
    }
}