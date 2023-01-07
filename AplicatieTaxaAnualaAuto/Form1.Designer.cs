
namespace AplicatieTaxaAnualaAuto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emisie = new System.Windows.Forms.TextBox();
            this.cc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.norma = new System.Windows.Forms.ComboBox();
            this.rez = new System.Windows.Forms.TextBox();
            this.calcul = new System.Windows.Forms.Button();
            this.vechime = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taxa anuala pentru autovehicule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emisie CO2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 292);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Capacitate cilindrica:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 351);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vechime:";
            // 
            // emisie
            // 
            this.emisie.Location = new System.Drawing.Point(236, 175);
            this.emisie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emisie.Name = "emisie";
            this.emisie.Size = new System.Drawing.Size(132, 22);
            this.emisie.TabIndex = 4;
            // 
            // cc
            // 
            this.cc.Location = new System.Drawing.Point(236, 286);
            this.cc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(132, 22);
            this.cc.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Norma de poluare";
            // 
            // norma
            // 
            this.norma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.norma.FormattingEnabled = true;
            this.norma.Items.AddRange(new object[] {
            "Electric",
            "Hibrid",
            "Euro 6",
            "Euro 5",
            "Euro 4",
            "Euro 3",
            "Euro 2",
            "Euro 1",
            "Noneuro"});
            this.norma.Location = new System.Drawing.Point(208, 230);
            this.norma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.norma.Name = "norma";
            this.norma.Size = new System.Drawing.Size(160, 24);
            this.norma.TabIndex = 8;
            // 
            // rez
            // 
            this.rez.BackColor = System.Drawing.Color.White;
            this.rez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rez.ForeColor = System.Drawing.Color.Black;
            this.rez.Location = new System.Drawing.Point(467, 266);
            this.rez.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rez.Multiline = true;
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(248, 56);
            this.rez.TabIndex = 9;
            // 
            // calcul
            // 
            this.calcul.BackColor = System.Drawing.Color.Red;
            this.calcul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcul.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calcul.Location = new System.Drawing.Point(467, 175);
            this.calcul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calcul.Name = "calcul";
            this.calcul.Size = new System.Drawing.Size(203, 38);
            this.calcul.TabIndex = 10;
            this.calcul.Text = "Calculeaza";
            this.calcul.UseVisualStyleBackColor = false;
            this.calcul.Click += new System.EventHandler(this.calcul_Click);
            // 
            // vechime
            // 
            this.vechime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vechime.FormattingEnabled = true;
            this.vechime.Items.AddRange(new object[] {
            "nou",
            "<1 an",
            "<3 ani",
            "<5 ani",
            "<10 ani",
            "peste 10 ani"});
            this.vechime.Location = new System.Drawing.Point(208, 343);
            this.vechime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vechime.Name = "vechime";
            this.vechime.Size = new System.Drawing.Size(160, 24);
            this.vechime.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(568, 40);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pentru a calcula taxa anuala va rugam sa completati campurile de mai jos. \r\nApoi " +
    "apasati butonul \"Calculeaza\".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(467, 236);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Suma de plata:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(732, 427);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vechime);
            this.Controls.Add(this.calcul);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.norma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cc);
            this.Controls.Add(this.emisie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Taxa anuala pentru autovehicule";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emisie;
        private System.Windows.Forms.TextBox cc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox norma;
        private System.Windows.Forms.TextBox rez;
        private System.Windows.Forms.ComboBox vechime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button calcul;
        private System.Windows.Forms.Label label7;
    }
}

