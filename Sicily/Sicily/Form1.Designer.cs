namespace Sicily
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxSecteur = new System.Windows.Forms.ListBox();
            this.listBoxliaison = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Insertion = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Suppression = new System.Windows.Forms.GroupBox();
            this.Supprimer = new System.Windows.Forms.Button();
            this.groupBoxMAJ = new System.Windows.Forms.GroupBox();
            this.Modifier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Insertion.SuspendLayout();
            this.Suppression.SuspendLayout();
            this.groupBoxMAJ.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSecteur
            // 
            this.listBoxSecteur.FormattingEnabled = true;
            this.listBoxSecteur.Location = new System.Drawing.Point(268, 54);
            this.listBoxSecteur.Name = "listBoxSecteur";
            this.listBoxSecteur.Size = new System.Drawing.Size(236, 212);
            this.listBoxSecteur.TabIndex = 0;
            this.listBoxSecteur.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxliaison
            // 
            this.listBoxliaison.FormattingEnabled = true;
            this.listBoxliaison.Location = new System.Drawing.Point(268, 93);
            this.listBoxliaison.Name = "listBoxliaison";
            this.listBoxliaison.Size = new System.Drawing.Size(236, 173);
            this.listBoxliaison.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Insertion
            // 
            this.Insertion.Controls.Add(this.textBox5);
            this.Insertion.Controls.Add(this.textBox4);
            this.Insertion.Controls.Add(this.textBox3);
            this.Insertion.Controls.Add(this.textBox2);
            this.Insertion.Controls.Add(this.label5);
            this.Insertion.Controls.Add(this.label4);
            this.Insertion.Controls.Add(this.label3);
            this.Insertion.Controls.Add(this.label2);
            this.Insertion.Controls.Add(this.label1);
            this.Insertion.Controls.Add(this.button1);
            this.Insertion.Controls.Add(this.textBox1);
            this.Insertion.Location = new System.Drawing.Point(517, 43);
            this.Insertion.Name = "Insertion";
            this.Insertion.Size = new System.Drawing.Size(253, 375);
            this.Insertion.TabIndex = 5;
            this.Insertion.TabStop = false;
            this.Insertion.Text = "Insertion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Insérer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Suppression
            // 
            this.Suppression.Controls.Add(this.Supprimer);
            this.Suppression.Location = new System.Drawing.Point(259, 306);
            this.Suppression.Name = "Suppression";
            this.Suppression.Size = new System.Drawing.Size(221, 112);
            this.Suppression.TabIndex = 6;
            this.Suppression.TabStop = false;
            this.Suppression.Text = "Suppression";
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(64, 44);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Supprimer.TabIndex = 0;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            // 
            // groupBoxMAJ
            // 
            this.groupBoxMAJ.Controls.Add(this.textBox6);
            this.groupBoxMAJ.Controls.Add(this.Modifier);
            this.groupBoxMAJ.Location = new System.Drawing.Point(12, 253);
            this.groupBoxMAJ.Name = "groupBoxMAJ";
            this.groupBoxMAJ.Size = new System.Drawing.Size(241, 178);
            this.groupBoxMAJ.TabIndex = 7;
            this.groupBoxMAJ.TabStop = false;
            this.groupBoxMAJ.Text = "Mise à jour ";
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(60, 115);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(75, 23);
            this.Modifier.TabIndex = 0;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID liaison : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID SECTEUR : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID PORT DEPART :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID PORT ARRIVEE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Duree";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(131, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(131, 210);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(63, 246);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(46, 50);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.groupBoxMAJ);
            this.Controls.Add(this.Suppression);
            this.Controls.Add(this.Insertion);
            this.Controls.Add(this.listBoxliaison);
            this.Controls.Add(this.listBoxSecteur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Insertion.ResumeLayout(false);
            this.Insertion.PerformLayout();
            this.Suppression.ResumeLayout(false);
            this.groupBoxMAJ.ResumeLayout(false);
            this.groupBoxMAJ.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSecteur;
        private System.Windows.Forms.ListBox listBoxliaison;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox Insertion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Suppression;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxMAJ;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
    }
}

