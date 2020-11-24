namespace windowsform
{
    partial class opretbruger
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
            this.opretbruger_label = new System.Windows.Forms.Label();
            this.opretbruger_navn = new System.Windows.Forms.TextBox();
            this.opretbruger_efternavn = new System.Windows.Forms.TextBox();
            this.opretbruger_bil = new System.Windows.Forms.TextBox();
            this.opretbruger_nummerplade = new System.Windows.Forms.TextBox();
            this.opretbruger_model = new System.Windows.Forms.TextBox();
            this.opretbruger_opret = new System.Windows.Forms.Button();
            this.opretbruger_tilbage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // opretbruger_label
            // 
            this.opretbruger_label.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.opretbruger_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.opretbruger_label.Location = new System.Drawing.Point(85, 9);
            this.opretbruger_label.Name = "opretbruger_label";
            this.opretbruger_label.Size = new System.Drawing.Size(246, 54);
            this.opretbruger_label.TabIndex = 2;
            this.opretbruger_label.Text = "Opret ny bruger";
            // 
            // opretbruger_navn
            // 
            this.opretbruger_navn.Location = new System.Drawing.Point(12, 66);
            this.opretbruger_navn.Name = "opretbruger_navn";
            this.opretbruger_navn.Size = new System.Drawing.Size(100, 20);
            this.opretbruger_navn.TabIndex = 3;
            this.opretbruger_navn.Text = "Indtast navn";
            // 
            // opretbruger_efternavn
            // 
            this.opretbruger_efternavn.Location = new System.Drawing.Point(118, 66);
            this.opretbruger_efternavn.Name = "opretbruger_efternavn";
            this.opretbruger_efternavn.Size = new System.Drawing.Size(100, 20);
            this.opretbruger_efternavn.TabIndex = 4;
            this.opretbruger_efternavn.Text = "Indtast efternavn";
            // 
            // opretbruger_bil
            // 
            this.opretbruger_bil.Location = new System.Drawing.Point(12, 121);
            this.opretbruger_bil.Name = "opretbruger_bil";
            this.opretbruger_bil.Size = new System.Drawing.Size(100, 20);
            this.opretbruger_bil.TabIndex = 6;
            this.opretbruger_bil.Text = "Indtast bilnavn";
            // 
            // opretbruger_nummerplade
            // 
            this.opretbruger_nummerplade.Location = new System.Drawing.Point(118, 121);
            this.opretbruger_nummerplade.Name = "opretbruger_nummerplade";
            this.opretbruger_nummerplade.Size = new System.Drawing.Size(110, 20);
            this.opretbruger_nummerplade.TabIndex = 7;
            this.opretbruger_nummerplade.Text = "Indtast nummerplade";
            // 
            // opretbruger_model
            // 
            this.opretbruger_model.Location = new System.Drawing.Point(65, 147);
            this.opretbruger_model.Name = "opretbruger_model";
            this.opretbruger_model.Size = new System.Drawing.Size(100, 20);
            this.opretbruger_model.TabIndex = 8;
            this.opretbruger_model.Text = "Indtast Model";
            // 
            // opretbruger_opret
            // 
            this.opretbruger_opret.Location = new System.Drawing.Point(329, 186);
            this.opretbruger_opret.Name = "opretbruger_opret";
            this.opretbruger_opret.Size = new System.Drawing.Size(75, 23);
            this.opretbruger_opret.TabIndex = 9;
            this.opretbruger_opret.Text = "Opret";
            this.opretbruger_opret.UseVisualStyleBackColor = true;
            this.opretbruger_opret.Click += new System.EventHandler(this.opretbruger_opret_Click);
            // 
            // opretbruger_tilbage
            // 
            this.opretbruger_tilbage.Location = new System.Drawing.Point(4, 9);
            this.opretbruger_tilbage.Name = "opretbruger_tilbage";
            this.opretbruger_tilbage.Size = new System.Drawing.Size(75, 23);
            this.opretbruger_tilbage.TabIndex = 10;
            this.opretbruger_tilbage.Text = "Tilbage";
            this.opretbruger_tilbage.UseVisualStyleBackColor = true;
            this.opretbruger_tilbage.Click += new System.EventHandler(this.opretbruger_tilbage_Click);
            // 
            // opretbruger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 221);
            this.Controls.Add(this.opretbruger_tilbage);
            this.Controls.Add(this.opretbruger_opret);
            this.Controls.Add(this.opretbruger_model);
            this.Controls.Add(this.opretbruger_nummerplade);
            this.Controls.Add(this.opretbruger_bil);
            this.Controls.Add(this.opretbruger_efternavn);
            this.Controls.Add(this.opretbruger_navn);
            this.Controls.Add(this.opretbruger_label);
            this.Name = "opretbruger";
            this.Text = "opretbruger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formclosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label opretbruger_label;
        private System.Windows.Forms.TextBox opretbruger_navn;
        private System.Windows.Forms.TextBox opretbruger_efternavn;
        private System.Windows.Forms.TextBox opretbruger_bil;
        private System.Windows.Forms.TextBox opretbruger_nummerplade;
        private System.Windows.Forms.TextBox opretbruger_model;
        private System.Windows.Forms.Button opretbruger_opret;
        private System.Windows.Forms.Button opretbruger_tilbage;

    }
}