namespace Project_soluation01
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnWatch = new System.Windows.Forms.Button();
            this.btnRate = new System.Windows.Forms.Button();
            this.listBoxMovies = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtName.Location = new System.Drawing.Point(129, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "ee";
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtTitle.Location = new System.Drawing.Point(129, 79);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // txtGenre
            // 
            this.txtGenre.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtGenre.Location = new System.Drawing.Point(129, 128);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 20);
            this.txtGenre.TabIndex = 2;
            // 
            // txtRating
            // 
            this.txtRating.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtRating.Location = new System.Drawing.Point(129, 179);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(100, 20);
            this.txtRating.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(338, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(346, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(346, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Genre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(344, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rating";
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(115, 251);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(75, 23);
            this.btnAddMovie.TabIndex = 8;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnWatch
            // 
            this.btnWatch.Location = new System.Drawing.Point(255, 251);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(75, 23);
            this.btnWatch.TabIndex = 9;
            this.btnWatch.Text = "Watch";
            this.btnWatch.UseVisualStyleBackColor = true;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
            // 
            // btnRate
            // 
            this.btnRate.Location = new System.Drawing.Point(373, 251);
            this.btnRate.Name = "btnRate";
            this.btnRate.Size = new System.Drawing.Size(75, 23);
            this.btnRate.TabIndex = 10;
            this.btnRate.Text = "Rate";
            this.btnRate.UseVisualStyleBackColor = true;
            this.btnRate.Click += new System.EventHandler(this.btnRate_Click);
            // 
            // listBoxMovies
            // 
            this.listBoxMovies.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxMovies.FormattingEnabled = true;
            this.listBoxMovies.Location = new System.Drawing.Point(76, 285);
            this.listBoxMovies.Name = "listBoxMovies";
            this.listBoxMovies.Size = new System.Drawing.Size(592, 95);
            this.listBoxMovies.TabIndex = 11;
            this.listBoxMovies.SelectedIndexChanged += new System.EventHandler(this.listBoxMovies_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxMovies);
            this.Controls.Add(this.btnRate);
            this.Controls.Add(this.btnWatch);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtName);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnWatch;
        private System.Windows.Forms.Button btnRate;
        private System.Windows.Forms.ListBox listBoxMovies;
    }
}

