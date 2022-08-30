
namespace WinForms_project {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InsertBookButton = new System.Windows.Forms.Button();
            this.bookTitleText = new System.Windows.Forms.TextBox();
            this.genreText = new System.Windows.Forms.TextBox();
            this.bookIsbnText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AuthorIDText = new System.Windows.Forms.TextBox();
            this.AuthorFnameText = new System.Windows.Forms.TextBox();
            this.AuthorLnameText = new System.Windows.Forms.TextBox();
            this.InsertAuthor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 86);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(531, 404);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(511, 231);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // InsertBookButton
            // 
            this.InsertBookButton.Location = new System.Drawing.Point(726, 265);
            this.InsertBookButton.Name = "InsertBookButton";
            this.InsertBookButton.Size = new System.Drawing.Size(160, 99);
            this.InsertBookButton.TabIndex = 2;
            this.InsertBookButton.Text = "InsertBookButton";
            this.InsertBookButton.UseVisualStyleBackColor = true;
            this.InsertBookButton.Click += new System.EventHandler(this.InsertBookButton_Click);
            // 
            // bookTitleText
            // 
            this.bookTitleText.Location = new System.Drawing.Point(619, 25);
            this.bookTitleText.Name = "bookTitleText";
            this.bookTitleText.Size = new System.Drawing.Size(395, 23);
            this.bookTitleText.TabIndex = 3;
            // 
            // genreText
            // 
            this.genreText.Location = new System.Drawing.Point(619, 54);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(395, 23);
            this.genreText.TabIndex = 4;
            // 
            // bookIsbnText
            // 
            this.bookIsbnText.Location = new System.Drawing.Point(619, 111);
            this.bookIsbnText.Name = "bookIsbnText";
            this.bookIsbnText.Size = new System.Drawing.Size(395, 23);
            this.bookIsbnText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Isbn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Author ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "First name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(556, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Last name";
            // 
            // AuthorIDText
            // 
            this.AuthorIDText.Location = new System.Drawing.Point(619, 171);
            this.AuthorIDText.Name = "AuthorIDText";
            this.AuthorIDText.Size = new System.Drawing.Size(395, 23);
            this.AuthorIDText.TabIndex = 13;
            // 
            // AuthorFnameText
            // 
            this.AuthorFnameText.Location = new System.Drawing.Point(619, 205);
            this.AuthorFnameText.Name = "AuthorFnameText";
            this.AuthorFnameText.Size = new System.Drawing.Size(395, 23);
            this.AuthorFnameText.TabIndex = 14;
            // 
            // AuthorLnameText
            // 
            this.AuthorLnameText.Location = new System.Drawing.Point(619, 236);
            this.AuthorLnameText.Name = "AuthorLnameText";
            this.AuthorLnameText.Size = new System.Drawing.Size(395, 23);
            this.AuthorLnameText.TabIndex = 15;
            // 
            // InsertAuthor
            // 
            this.InsertAuthor.Location = new System.Drawing.Point(1020, 101);
            this.InsertAuthor.Name = "InsertAuthor";
            this.InsertAuthor.Size = new System.Drawing.Size(163, 81);
            this.InsertAuthor.TabIndex = 16;
            this.InsertAuthor.Text = "Insert Author";
            this.InsertAuthor.UseVisualStyleBackColor = true;
            this.InsertAuthor.Click += new System.EventHandler(this.InsertAuthor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(499, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "fill up mwith data then click insert book then inster author and click buttton on" +
    "w to veiw data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1781, 751);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.InsertAuthor);
            this.Controls.Add(this.AuthorLnameText);
            this.Controls.Add(this.AuthorFnameText);
            this.Controls.Add(this.AuthorIDText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookIsbnText);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.bookTitleText);
            this.Controls.Add(this.InsertBookButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button InsertBookButton;
        private System.Windows.Forms.TextBox bookTitleText;
        private System.Windows.Forms.TextBox genreText;
        private System.Windows.Forms.TextBox bookIsbnText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AuthorIDText;
        private System.Windows.Forms.TextBox AuthorFnameText;
        private System.Windows.Forms.TextBox AuthorLnameText;
        private System.Windows.Forms.Button InsertAuthor;
        private System.Windows.Forms.Label label7;
    }
}

