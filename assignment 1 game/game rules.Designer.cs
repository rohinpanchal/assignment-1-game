namespace assignment_1_game
{
    partial class game_rules
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
            this.lbl_rules = new System.Windows.Forms.Label();
            this.lbl_rule2 = new System.Windows.Forms.Label();
            this.lbl_rule1 = new System.Windows.Forms.Label();
            this.lbl_rule3 = new System.Windows.Forms.Label();
            this.lbl_rule4 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_rules
            // 
            this.lbl_rules.AutoSize = true;
            this.lbl_rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rules.Location = new System.Drawing.Point(232, 26);
            this.lbl_rules.Name = "lbl_rules";
            this.lbl_rules.Size = new System.Drawing.Size(321, 39);
            this.lbl_rules.TabIndex = 0;
            this.lbl_rules.Text = "Rules for the game";
            this.lbl_rules.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_rule2
            // 
            this.lbl_rule2.AutoSize = true;
            this.lbl_rule2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rule2.Location = new System.Drawing.Point(70, 133);
            this.lbl_rule2.Name = "lbl_rule2";
            this.lbl_rule2.Size = new System.Drawing.Size(376, 29);
            this.lbl_rule2.TabIndex = 1;
            this.lbl_rule2.Text = "# You can play the game by steps ";
            // 
            // lbl_rule1
            // 
            this.lbl_rule1.AutoSize = true;
            this.lbl_rule1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rule1.Location = new System.Drawing.Point(70, 101);
            this.lbl_rule1.Name = "lbl_rule1";
            this.lbl_rule1.Size = new System.Drawing.Size(243, 29);
            this.lbl_rule1.TabIndex = 2;
            this.lbl_rule1.Text = "# There are six steps ";
            // 
            // lbl_rule3
            // 
            this.lbl_rule3.AutoSize = true;
            this.lbl_rule3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rule3.Location = new System.Drawing.Point(70, 168);
            this.lbl_rule3.Name = "lbl_rule3";
            this.lbl_rule3.Size = new System.Drawing.Size(366, 29);
            this.lbl_rule3.TabIndex = 3;
            this.lbl_rule3.Text = "# You are unable to skip any step";
            // 
            // lbl_rule4
            // 
            this.lbl_rule4.AutoSize = true;
            this.lbl_rule4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rule4.Location = new System.Drawing.Point(73, 200);
            this.lbl_rule4.Name = "lbl_rule4";
            this.lbl_rule4.Size = new System.Drawing.Size(512, 29);
            this.lbl_rule4.TabIndex = 4;
            this.lbl_rule4.Text = "# You can exit and playagain the game anytime";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(705, 384);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 42);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // game_rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_rule4);
            this.Controls.Add(this.lbl_rule3);
            this.Controls.Add(this.lbl_rule1);
            this.Controls.Add(this.lbl_rule2);
            this.Controls.Add(this.lbl_rules);
            this.Name = "game_rules";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_rules;
        private System.Windows.Forms.Label lbl_rule2;
        private System.Windows.Forms.Label lbl_rule1;
        private System.Windows.Forms.Label lbl_rule3;
        private System.Windows.Forms.Label lbl_rule4;
        private System.Windows.Forms.Button btn_back;
    }
}