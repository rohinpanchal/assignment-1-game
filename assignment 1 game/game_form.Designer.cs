namespace assignment_1_game
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
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_spin = new System.Windows.Forms.Button();
            this.pic_b = new System.Windows.Forms.PictureBox();
            this.btn_shootaway = new System.Windows.Forms.Button();
            this.btn_shoot = new System.Windows.Forms.Button();
            this.btn_playagain = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_rules = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_b)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.ForeColor = System.Drawing.Color.Black;
            this.btn_load.Location = new System.Drawing.Point(12, 440);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(124, 57);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_spin
            // 
            this.btn_spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_spin.Location = new System.Drawing.Point(12, 514);
            this.btn_spin.Name = "btn_spin";
            this.btn_spin.Size = new System.Drawing.Size(124, 57);
            this.btn_spin.TabIndex = 1;
            this.btn_spin.Text = "Spin";
            this.btn_spin.UseVisualStyleBackColor = true;
            this.btn_spin.Click += new System.EventHandler(this.btn_spin_Click);
            // 
            // pic_b
            // 
            this.pic_b.BackgroundImage = global::assignment_1_game.Properties.Resources.gun_mgn_shooting_33767592_ver1_0_1;
            this.pic_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_b.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_b.Location = new System.Drawing.Point(12, 39);
            this.pic_b.Name = "pic_b";
            this.pic_b.Size = new System.Drawing.Size(311, 364);
            this.pic_b.TabIndex = 2;
            this.pic_b.TabStop = false;
            // 
            // btn_shootaway
            // 
            this.btn_shootaway.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shootaway.Location = new System.Drawing.Point(431, 426);
            this.btn_shootaway.Name = "btn_shootaway";
            this.btn_shootaway.Size = new System.Drawing.Size(122, 57);
            this.btn_shootaway.TabIndex = 3;
            this.btn_shootaway.Text = "Shoot Away";
            this.btn_shootaway.UseVisualStyleBackColor = true;
            this.btn_shootaway.Click += new System.EventHandler(this.btn_shootaway_Click);
            // 
            // btn_shoot
            // 
            this.btn_shoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shoot.Location = new System.Drawing.Point(289, 426);
            this.btn_shoot.Name = "btn_shoot";
            this.btn_shoot.Size = new System.Drawing.Size(122, 57);
            this.btn_shoot.TabIndex = 4;
            this.btn_shoot.Text = "Shoot";
            this.btn_shoot.UseVisualStyleBackColor = true;
            this.btn_shoot.Click += new System.EventHandler(this.btn_shoot_Click);
            // 
            // btn_playagain
            // 
            this.btn_playagain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playagain.Location = new System.Drawing.Point(712, 440);
            this.btn_playagain.Name = "btn_playagain";
            this.btn_playagain.Size = new System.Drawing.Size(122, 57);
            this.btn_playagain.TabIndex = 5;
            this.btn_playagain.Text = "Play Again";
            this.btn_playagain.UseVisualStyleBackColor = true;
            this.btn_playagain.Click += new System.EventHandler(this.btn_playagain_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(712, 514);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(122, 57);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_rules
            // 
            this.btn_rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rules.Location = new System.Drawing.Point(738, 12);
            this.btn_rules.Name = "btn_rules";
            this.btn_rules.Size = new System.Drawing.Size(96, 50);
            this.btn_rules.TabIndex = 7;
            this.btn_rules.Text = "Rules";
            this.btn_rules.UseVisualStyleBackColor = true;
            this.btn_rules.Click += new System.EventHandler(this.btn_rules_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::assignment_1_game.Properties.Resources.OIP__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(846, 583);
            this.Controls.Add(this.btn_rules);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_playagain);
            this.Controls.Add(this.btn_shoot);
            this.Controls.Add(this.btn_shootaway);
            this.Controls.Add(this.pic_b);
            this.Controls.Add(this.btn_spin);
            this.Controls.Add(this.btn_load);
            this.Name = "Form1";
            this.Text = "assignment 1 game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_b)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_spin;
        private System.Windows.Forms.PictureBox pic_b;
        private System.Windows.Forms.Button btn_shootaway;
        private System.Windows.Forms.Button btn_shoot;
        private System.Windows.Forms.Button btn_playagain;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_rules;
    }
}

