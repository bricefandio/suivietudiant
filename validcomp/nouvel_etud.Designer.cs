namespace validcomp
{
    partial class nouvel_etud
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
            this.txt_referentiel = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.enregistrer = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "prenom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "referentiel";
            // 
            // txt_referentiel
            // 
            this.txt_referentiel.Location = new System.Drawing.Point(212, 170);
            this.txt_referentiel.Name = "txt_referentiel";
            this.txt_referentiel.Size = new System.Drawing.Size(101, 23);
            this.txt_referentiel.TabIndex = 4;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(212, 128);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(101, 23);
            this.txt_prenom.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(581, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "validation competence";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // enregistrer
            // 
            this.enregistrer.Location = new System.Drawing.Point(63, 271);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(87, 23);
            this.enregistrer.TabIndex = 8;
            this.enregistrer.Text = "enregistrer";
            this.enregistrer.UseVisualStyleBackColor = true;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(297, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "modifier";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(212, 85);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(101, 23);
            this.txt_nom.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(231, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Enregistrement Etudiant";
            // 
            // nouvel_etud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_referentiel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "nouvel_etud";
            this.Text = "nouvel_etud";
            this.Load += new System.EventHandler(this.nouvel_etud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_referentiel;
        private TextBox txt_prenom;
        private Button button2;
        private Button enregistrer;
        private Button button4;
        private OpenFileDialog openFileDialog1;
        private TextBox txt_nom;
        private Label label4;
    }
}