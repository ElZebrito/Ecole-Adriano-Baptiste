namespace Sicily.Vue
{
    partial class ModifDuree
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbLiaison = new System.Windows.Forms.TextBox();
            this.tbSecteur = new System.Windows.Forms.TextBox();
            this.tbDepart = new System.Windows.Forms.TextBox();
            this.tbArrivee = new System.Windows.Forms.TextBox();
            this.tbDuree = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbLiaison
            // 
            this.tbLiaison.Enabled = false;
            this.tbLiaison.Location = new System.Drawing.Point(115, 33);
            this.tbLiaison.Name = "tbLiaison";
            this.tbLiaison.Size = new System.Drawing.Size(100, 20);
            this.tbLiaison.TabIndex = 1;
            // 
            // tbSecteur
            // 
            this.tbSecteur.Enabled = false;
            this.tbSecteur.Location = new System.Drawing.Point(115, 80);
            this.tbSecteur.Name = "tbSecteur";
            this.tbSecteur.Size = new System.Drawing.Size(100, 20);
            this.tbSecteur.TabIndex = 2;
            // 
            // tbDepart
            // 
            this.tbDepart.Enabled = false;
            this.tbDepart.Location = new System.Drawing.Point(115, 133);
            this.tbDepart.Name = "tbDepart";
            this.tbDepart.Size = new System.Drawing.Size(100, 20);
            this.tbDepart.TabIndex = 3;
            // 
            // tbArrivee
            // 
            this.tbArrivee.Enabled = false;
            this.tbArrivee.Location = new System.Drawing.Point(115, 191);
            this.tbArrivee.Name = "tbArrivee";
            this.tbArrivee.Size = new System.Drawing.Size(100, 20);
            this.tbArrivee.TabIndex = 4;
            // 
            // tbDuree
            // 
            this.tbDuree.Location = new System.Drawing.Point(115, 252);
            this.tbDuree.Name = "tbDuree";
            this.tbDuree.Size = new System.Drawing.Size(100, 20);
            this.tbDuree.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID_Liaison";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID_Secteur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID_Port_Départ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID_Port_Arrivée";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Durée";
            // 
            // ModifDuree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 382);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDuree);
            this.Controls.Add(this.tbArrivee);
            this.Controls.Add(this.tbDepart);
            this.Controls.Add(this.tbSecteur);
            this.Controls.Add(this.tbLiaison);
            this.Controls.Add(this.button1);
            this.Name = "ModifDuree";
            this.Text = "ModifDuree";
            this.Load += new System.EventHandler(this.ModifDuree_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbLiaison;
        private System.Windows.Forms.TextBox tbSecteur;
        private System.Windows.Forms.TextBox tbDepart;
        private System.Windows.Forms.TextBox tbArrivee;
        private System.Windows.Forms.TextBox tbDuree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}