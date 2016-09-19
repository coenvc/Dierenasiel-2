namespace Dierenasiel_week1
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
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbRace = new System.Windows.Forms.TextBox();
            this.tbBirthYear = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCommon = new System.Windows.Forms.GroupBox();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rbDog = new System.Windows.Forms.RadioButton();
            this.rbCat = new System.Windows.Forms.RadioButton();
            this.tbBehaviour = new System.Windows.Forms.TextBox();
            this.lblBehaviour = new System.Windows.Forms.Label();
            this.btnNewAnimal = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnWalk = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.gbCommon.SuspendLayout();
            this.gbType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(86, 19);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(127, 20);
            this.tbNaam.TabIndex = 0;
            // 
            // tbRace
            // 
            this.tbRace.Location = new System.Drawing.Point(86, 45);
            this.tbRace.Name = "tbRace";
            this.tbRace.Size = new System.Drawing.Size(127, 20);
            this.tbRace.TabIndex = 1;
            // 
            // tbBirthYear
            // 
            this.tbBirthYear.Location = new System.Drawing.Point(86, 71);
            this.tbBirthYear.Name = "tbBirthYear";
            this.tbBirthYear.Size = new System.Drawing.Size(127, 20);
            this.tbBirthYear.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Naam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Geboortejaar";
            // 
            // gbCommon
            // 
            this.gbCommon.Controls.Add(this.tbNaam);
            this.gbCommon.Controls.Add(this.label2);
            this.gbCommon.Controls.Add(this.tbRace);
            this.gbCommon.Controls.Add(this.label1);
            this.gbCommon.Controls.Add(this.tbBirthYear);
            this.gbCommon.Controls.Add(this.lblName);
            this.gbCommon.Location = new System.Drawing.Point(12, 12);
            this.gbCommon.Name = "gbCommon";
            this.gbCommon.Size = new System.Drawing.Size(219, 109);
            this.gbCommon.TabIndex = 6;
            this.gbCommon.TabStop = false;
            this.gbCommon.Text = "Gegevens";
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.lblBehaviour);
            this.gbType.Controls.Add(this.tbBehaviour);
            this.gbType.Controls.Add(this.rbCat);
            this.gbType.Controls.Add(this.rbDog);
            this.gbType.Location = new System.Drawing.Point(237, 12);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(200, 109);
            this.gbType.TabIndex = 7;
            this.gbType.TabStop = false;
            this.gbType.Text = "DierSoort";
            // 
            // rbDog
            // 
            this.rbDog.AutoSize = true;
            this.rbDog.Location = new System.Drawing.Point(7, 19);
            this.rbDog.Name = "rbDog";
            this.rbDog.Size = new System.Drawing.Size(51, 17);
            this.rbDog.TabIndex = 0;
            this.rbDog.TabStop = true;
            this.rbDog.Text = "Hond";
            this.rbDog.UseVisualStyleBackColor = true;
            // 
            // rbCat
            // 
            this.rbCat.AutoSize = true;
            this.rbCat.Location = new System.Drawing.Point(7, 48);
            this.rbCat.Name = "rbCat";
            this.rbCat.Size = new System.Drawing.Size(41, 17);
            this.rbCat.TabIndex = 1;
            this.rbCat.TabStop = true;
            this.rbCat.Text = "Kat";
            this.rbCat.UseVisualStyleBackColor = true;
            // 
            // tbBehaviour
            // 
            this.tbBehaviour.Location = new System.Drawing.Point(68, 71);
            this.tbBehaviour.Name = "tbBehaviour";
            this.tbBehaviour.Size = new System.Drawing.Size(126, 20);
            this.tbBehaviour.TabIndex = 8;
            // 
            // lblBehaviour
            // 
            this.lblBehaviour.AutoSize = true;
            this.lblBehaviour.Location = new System.Drawing.Point(7, 77);
            this.lblBehaviour.Name = "lblBehaviour";
            this.lblBehaviour.Size = new System.Drawing.Size(42, 13);
            this.lblBehaviour.TabIndex = 9;
            this.lblBehaviour.Text = "Gedrag";
            // 
            // btnNewAnimal
            // 
            this.btnNewAnimal.Location = new System.Drawing.Point(444, 19);
            this.btnNewAnimal.Name = "btnNewAnimal";
            this.btnNewAnimal.Size = new System.Drawing.Size(176, 29);
            this.btnNewAnimal.TabIndex = 8;
            this.btnNewAnimal.Text = "Toevoegen";
            this.btnNewAnimal.UseVisualStyleBackColor = true;
            this.btnNewAnimal.Click += new System.EventHandler(this.btnNewAnimal_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 131);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(607, 342);
            this.listBox1.TabIndex = 9;
            // 
            // btnWalk
            // 
            this.btnWalk.Location = new System.Drawing.Point(444, 57);
            this.btnWalk.Name = "btnWalk";
            this.btnWalk.Size = new System.Drawing.Size(175, 29);
            this.btnWalk.TabIndex = 10;
            this.btnWalk.Text = "Uitlaten";
            this.btnWalk.UseVisualStyleBackColor = true;
            this.btnWalk.Click += new System.EventHandler(this.btnWalk_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(444, 92);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(176, 29);
            this.btnReserve.TabIndex = 11;
            this.btnReserve.Text = "Reserveren";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 519);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnWalk);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnNewAnimal);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.gbCommon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbCommon.ResumeLayout(false);
            this.gbCommon.PerformLayout();
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbRace;
        private System.Windows.Forms.TextBox tbBirthYear;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbCommon;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.Label lblBehaviour;
        private System.Windows.Forms.TextBox tbBehaviour;
        private System.Windows.Forms.RadioButton rbCat;
        private System.Windows.Forms.RadioButton rbDog;
        private System.Windows.Forms.Button btnNewAnimal;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnWalk;
        private System.Windows.Forms.Button btnReserve;
    }
}

