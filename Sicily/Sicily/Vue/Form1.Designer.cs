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
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxSecteur = new System.Windows.Forms.ListBox();
            this.listBoxliaison = new System.Windows.Forms.ListBox();
            this.tbLiaison = new System.Windows.Forms.TextBox();
            this.Insertion = new System.Windows.Forms.GroupBox();
            this.tbDuree = new System.Windows.Forms.TextBox();
            this.tbArrivee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Suppression = new System.Windows.Forms.GroupBox();
            this.Supprimer = new System.Windows.Forms.Button();
            this.groupBoxMAJ = new System.Windows.Forms.GroupBox();
            this.Modifier = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.Insertion.SuspendLayout();
            this.Suppression.SuspendLayout();
            this.groupBoxMAJ.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSecteur
            // 
            this.listBoxSecteur.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listBoxSecteur.FormattingEnabled = true;
            this.listBoxSecteur.Location = new System.Drawing.Point(37, 57);
            this.listBoxSecteur.Name = "listBoxSecteur";
            this.listBoxSecteur.Size = new System.Drawing.Size(316, 394);
            this.listBoxSecteur.TabIndex = 0;
            this.listBoxSecteur.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxliaison
            // 
            this.listBoxliaison.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxliaison.FormattingEnabled = true;
            this.listBoxliaison.Location = new System.Drawing.Point(408, 57);
            this.listBoxliaison.Name = "listBoxliaison";
            this.listBoxliaison.Size = new System.Drawing.Size(330, 392);
            this.listBoxliaison.TabIndex = 1;
            this.listBoxliaison.SelectedIndexChanged += new System.EventHandler(this.listBoxliaison_SelectedIndexChanged);
            // 
            // tbLiaison
            // 
            this.tbLiaison.Location = new System.Drawing.Point(128, 119);
            this.tbLiaison.Name = "tbLiaison";
            this.tbLiaison.Size = new System.Drawing.Size(100, 20);
            this.tbLiaison.TabIndex = 2;
            this.tbLiaison.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Insertion
            // 
            this.Insertion.Controls.Add(this.tbDuree);
            this.Insertion.Controls.Add(this.tbArrivee);
            this.Insertion.Controls.Add(this.label5);
            this.Insertion.Controls.Add(this.label4);
            this.Insertion.Controls.Add(this.label1);
            this.Insertion.Controls.Add(this.button1);
            this.Insertion.Controls.Add(this.tbLiaison);
            this.Insertion.Location = new System.Drawing.Point(775, 57);
            this.Insertion.Name = "Insertion";
            this.Insertion.Size = new System.Drawing.Size(253, 375);
            this.Insertion.TabIndex = 5;
            this.Insertion.TabStop = false;
            this.Insertion.Text = "Insertion";
            this.Insertion.Enter += new System.EventHandler(this.Insertion_Enter);
            // 
            // tbDuree
            // 
            this.tbDuree.Location = new System.Drawing.Point(128, 243);
            this.tbDuree.Name = "tbDuree";
            this.tbDuree.Size = new System.Drawing.Size(100, 20);
            this.tbDuree.TabIndex = 15;
            // 
            // tbArrivee
            // 
            this.tbArrivee.Location = new System.Drawing.Point(128, 183);
            this.tbArrivee.Name = "tbArrivee";
            this.tbArrivee.Size = new System.Drawing.Size(100, 20);
            this.tbArrivee.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Duree";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID PORT ARRIVEE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID liaison : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Insérer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Suppression
            // 
            this.Suppression.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Suppression.Controls.Add(this.Supprimer);
            this.Suppression.Location = new System.Drawing.Point(504, 523);
            this.Suppression.Name = "Suppression";
            this.Suppression.Size = new System.Drawing.Size(200, 95);
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
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // groupBoxMAJ
            // 
            this.groupBoxMAJ.Controls.Add(this.Modifier);
            this.groupBoxMAJ.Location = new System.Drawing.Point(67, 462);
            this.groupBoxMAJ.Name = "groupBoxMAJ";
            this.groupBoxMAJ.Size = new System.Drawing.Size(241, 178);
            this.groupBoxMAJ.TabIndex = 7;
            this.groupBoxMAJ.TabStop = false;
            this.groupBoxMAJ.Text = "Mise à jour ";
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(64, 61);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(75, 50);
            this.Modifier.TabIndex = 0;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(139, 29);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(94, 13);
            label2.TabIndex = 16;
            label2.Text = "Liste des Secteurs";
            label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Liste des Liaisons";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 698);
            this.Controls.Add(this.label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.groupBoxMAJ);
            this.Controls.Add(this.Suppression);
            this.Controls.Add(this.Insertion);
            this.Controls.Add(this.listBoxliaison);
            this.Controls.Add(this.listBoxSecteur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Insertion.ResumeLayout(false);
            this.Insertion.PerformLayout();
            this.Suppression.ResumeLayout(false);
            this.groupBoxMAJ.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSecteur;
        private System.Windows.Forms.ListBox listBoxliaison;
        private System.Windows.Forms.TextBox tbLiaison;
        private System.Windows.Forms.GroupBox Insertion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Suppression;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxMAJ;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDuree;
        private System.Windows.Forms.TextBox tbArrivee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}

