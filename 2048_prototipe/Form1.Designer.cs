namespace _2048_prototipe
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
            System.Windows.Forms.Label label1;
            this.box_1 = new System.Windows.Forms.TextBox();
            this.box_2 = new System.Windows.Forms.TextBox();
            this.box_3 = new System.Windows.Forms.TextBox();
            this.box_4 = new System.Windows.Forms.TextBox();
            this.box_8 = new System.Windows.Forms.TextBox();
            this.box_7 = new System.Windows.Forms.TextBox();
            this.box_6 = new System.Windows.Forms.TextBox();
            this.box_5 = new System.Windows.Forms.TextBox();
            this.box_12 = new System.Windows.Forms.TextBox();
            this.box_11 = new System.Windows.Forms.TextBox();
            this.box_10 = new System.Windows.Forms.TextBox();
            this.box_9 = new System.Windows.Forms.TextBox();
            this.box_16 = new System.Windows.Forms.TextBox();
            this.box_15 = new System.Windows.Forms.TextBox();
            this.box_14 = new System.Windows.Forms.TextBox();
            this.box_13 = new System.Windows.Forms.TextBox();
            this.new_game = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Label();
            this.score_value = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(12, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(202, 13);
            label1.TabIndex = 19;
            label1.Text = "Join the numbers and get to the 2048 tile!";
            // 
            // box_1
            // 
            this.box_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_1.Location = new System.Drawing.Point(15, 65);
            this.box_1.Multiline = true;
            this.box_1.Name = "box_1";
            this.box_1.ReadOnly = true;
            this.box_1.Size = new System.Drawing.Size(70, 60);
            this.box_1.TabIndex = 0;
            this.box_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.box_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control);
            // 
            // box_2
            // 
            this.box_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_2.Location = new System.Drawing.Point(91, 65);
            this.box_2.Multiline = true;
            this.box_2.Name = "box_2";
            this.box_2.ReadOnly = true;
            this.box_2.Size = new System.Drawing.Size(70, 60);
            this.box_2.TabIndex = 1;
            this.box_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.box_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control);
            // 
            // box_3
            // 
            this.box_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_3.Location = new System.Drawing.Point(167, 65);
            this.box_3.Multiline = true;
            this.box_3.Name = "box_3";
            this.box_3.ReadOnly = true;
            this.box_3.Size = new System.Drawing.Size(70, 60);
            this.box_3.TabIndex = 2;
            this.box_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.box_3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control);
            // 
            // box_4
            // 
            this.box_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_4.Location = new System.Drawing.Point(244, 65);
            this.box_4.Multiline = true;
            this.box_4.Name = "box_4";
            this.box_4.ReadOnly = true;
            this.box_4.Size = new System.Drawing.Size(70, 60);
            this.box_4.TabIndex = 3;
            this.box_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.box_4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control);
            // 
            // box_8
            // 
            this.box_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_8.Location = new System.Drawing.Point(243, 131);
            this.box_8.Multiline = true;
            this.box_8.Name = "box_8";
            this.box_8.ReadOnly = true;
            this.box_8.Size = new System.Drawing.Size(70, 60);
            this.box_8.TabIndex = 7;
            this.box_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.box_8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control);
            // 
            // box_7
            // 
            this.box_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_7.Location = new System.Drawing.Point(167, 131);
            this.box_7.Multiline = true;
            this.box_7.Name = "box_7";
            this.box_7.ReadOnly = true;
            this.box_7.Size = new System.Drawing.Size(70, 60);
            this.box_7.TabIndex = 6;
            this.box_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.box_7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control);
            // 
            // box_6
            // 
            this.box_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_6.Location = new System.Drawing.Point(91, 131);
            this.box_6.Multiline = true;
            this.box_6.Name = "box_6";
            this.box_6.ReadOnly = true;
            this.box_6.Size = new System.Drawing.Size(70, 60);
            this.box_6.TabIndex = 5;
            this.box_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.box_6.TextChanged += new System.EventHandler(this.box_6_TextChanged);
            this.box_6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control);
            // 
            // box_5
            // 
            this.box_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_5.Location = new System.Drawing.Point(16, 131);
            this.box_5.Multiline = true;
            this.box_5.Name = "box_5";
            this.box_5.ReadOnly = true;
            this.box_5.Size = new System.Drawing.Size(70, 60);
            this.box_5.TabIndex = 4;
            this.box_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.box_5.TextChanged += new System.EventHandler(this.box_5_TextChanged);
            this.box_5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control);
            // 
            // box_12
            // 
            this.box_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_12.Location = new System.Drawing.Point(244, 199);
            this.box_12.Multiline = true;
            this.box_12.Name = "box_12";
            this.box_12.ReadOnly = true;
            this.box_12.Size = new System.Drawing.Size(70, 60);
            this.box_12.TabIndex = 11;
            this.box_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.box_12.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control);
            // 
            // box_11
            // 
            this.box_11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_11.Location = new System.Drawing.Point(168, 199);
            this.box_11.Multiline = true;
            this.box_11.Name = "box_11";
            this.box_11.ReadOnly = true;
            this.box_11.Size = new System.Drawing.Size(70, 60);
            this.box_11.TabIndex = 10;
            this.box_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.box_11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control);
            // 
            // box_10
            // 
            this.box_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_10.Location = new System.Drawing.Point(92, 199);
            this.box_10.Multiline = true;
            this.box_10.Name = "box_10";
            this.box_10.ReadOnly = true;
            this.box_10.Size = new System.Drawing.Size(70, 60);
            this.box_10.TabIndex = 9;
            this.box_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.box_10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control);
            // 
            // box_9
            // 
            this.box_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_9.Location = new System.Drawing.Point(16, 199);
            this.box_9.Multiline = true;
            this.box_9.Name = "box_9";
            this.box_9.ReadOnly = true;
            this.box_9.Size = new System.Drawing.Size(70, 60);
            this.box_9.TabIndex = 8;
            this.box_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.box_9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control);
            // 
            // box_16
            // 
            this.box_16.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_16.Location = new System.Drawing.Point(243, 265);
            this.box_16.Multiline = true;
            this.box_16.Name = "box_16";
            this.box_16.ReadOnly = true;
            this.box_16.Size = new System.Drawing.Size(70, 60);
            this.box_16.TabIndex = 15;
            this.box_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.box_16.TextChanged += new System.EventHandler(this.box_16_TextChanged);
            this.box_16.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control);
            // 
            // box_15
            // 
            this.box_15.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_15.Location = new System.Drawing.Point(168, 265);
            this.box_15.Multiline = true;
            this.box_15.Name = "box_15";
            this.box_15.ReadOnly = true;
            this.box_15.Size = new System.Drawing.Size(70, 60);
            this.box_15.TabIndex = 14;
            this.box_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.box_15.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control);
            // 
            // box_14
            // 
            this.box_14.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_14.Location = new System.Drawing.Point(91, 265);
            this.box_14.Multiline = true;
            this.box_14.Name = "box_14";
            this.box_14.ReadOnly = true;
            this.box_14.Size = new System.Drawing.Size(70, 60);
            this.box_14.TabIndex = 13;
            this.box_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.box_14.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control);
            // 
            // box_13
            // 
            this.box_13.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_13.Location = new System.Drawing.Point(15, 265);
            this.box_13.Multiline = true;
            this.box_13.Name = "box_13";
            this.box_13.ReadOnly = true;
            this.box_13.Size = new System.Drawing.Size(70, 60);
            this.box_13.TabIndex = 12;
            this.box_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.box_13.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control);
            // 
            // new_game
            // 
            this.new_game.Location = new System.Drawing.Point(239, 15);
            this.new_game.Name = "new_game";
            this.new_game.Size = new System.Drawing.Size(75, 23);
            this.new_game.TabIndex = 16;
            this.new_game.Text = "New game";
            this.new_game.UseVisualStyleBackColor = true;
            this.new_game.Click += new System.EventHandler(this.start_a_new_game);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(12, 12);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(35, 13);
            this.score.TabIndex = 17;
            this.score.Text = "Score";
            this.score.Click += new System.EventHandler(this.score_Click);
            // 
            // score_value
            // 
            this.score_value.AutoSize = true;
            this.score_value.Location = new System.Drawing.Point(15, 25);
            this.score_value.Name = "score_value";
            this.score_value.Size = new System.Drawing.Size(13, 13);
            this.score_value.TabIndex = 18;
            this.score_value.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 343);
            this.Controls.Add(label1);
            this.Controls.Add(this.score_value);
            this.Controls.Add(this.score);
            this.Controls.Add(this.new_game);
            this.Controls.Add(this.box_16);
            this.Controls.Add(this.box_15);
            this.Controls.Add(this.box_14);
            this.Controls.Add(this.box_13);
            this.Controls.Add(this.box_12);
            this.Controls.Add(this.box_11);
            this.Controls.Add(this.box_10);
            this.Controls.Add(this.box_9);
            this.Controls.Add(this.box_8);
            this.Controls.Add(this.box_7);
            this.Controls.Add(this.box_6);
            this.Controls.Add(this.box_5);
            this.Controls.Add(this.box_4);
            this.Controls.Add(this.box_3);
            this.Controls.Add(this.box_2);
            this.Controls.Add(this.box_1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(347, 382);
            this.MinimumSize = new System.Drawing.Size(347, 382);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox box_1;
        private System.Windows.Forms.TextBox box_2;
        private System.Windows.Forms.TextBox box_3;
        private System.Windows.Forms.TextBox box_4;
        private System.Windows.Forms.TextBox box_8;
        private System.Windows.Forms.TextBox box_7;
        private System.Windows.Forms.TextBox box_6;
        private System.Windows.Forms.TextBox box_5;
        private System.Windows.Forms.TextBox box_12;
        private System.Windows.Forms.TextBox box_11;
        private System.Windows.Forms.TextBox box_10;
        private System.Windows.Forms.TextBox box_9;
        private System.Windows.Forms.TextBox box_16;
        private System.Windows.Forms.TextBox box_15;
        private System.Windows.Forms.TextBox box_14;
        private System.Windows.Forms.TextBox box_13;
        private System.Windows.Forms.Button new_game;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label score_value;
    }
}

