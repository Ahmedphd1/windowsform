namespace windowsform
{
    partial class tilføjbil
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
            this.tilføjbil_label = new System.Windows.Forms.Label();
            this.tilføjbil_navn_eller_model = new System.Windows.Forms.TextBox();
            this.tilføjbil_bil = new System.Windows.Forms.TextBox();
            this.tilføjbil_model = new System.Windows.Forms.TextBox();
            this.tilføjbil_enter = new System.Windows.Forms.Button();
            this.tilføjbil_tilbage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tilføjbil_label
            // 
            this.tilføjbil_label.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.tilføjbil_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tilføjbil_label.Location = new System.Drawing.Point(133, 9);
            this.tilføjbil_label.Name = "tilføjbil_label";
            this.tilføjbil_label.Size = new System.Drawing.Size(141, 54);
            this.tilføjbil_label.TabIndex = 3;
            this.tilføjbil_label.Text = "Tilføj bil";
            // 
            // tilføjbil_navn_eller_model
            // 
            this.tilføjbil_navn_eller_model.Location = new System.Drawing.Point(139, 66);
            this.tilføjbil_navn_eller_model.Name = "tilføjbil_navn_eller_model";
            this.tilføjbil_navn_eller_model.Size = new System.Drawing.Size(112, 20);
            this.tilføjbil_navn_eller_model.TabIndex = 4;
            this.tilføjbil_navn_eller_model.Text = "Indtast navn";
            // 
            // tilføjbil_bil
            // 
            this.tilføjbil_bil.Location = new System.Drawing.Point(21, 66);
            this.tilføjbil_bil.Name = "tilføjbil_bil";
            this.tilføjbil_bil.Size = new System.Drawing.Size(112, 20);
            this.tilføjbil_bil.TabIndex = 5;
            this.tilføjbil_bil.Text = "Indtast bilnavn";
            // 
            // tilføjbil_model
            // 
            this.tilføjbil_model.Location = new System.Drawing.Point(257, 66);
            this.tilføjbil_model.Name = "tilføjbil_model";
            this.tilføjbil_model.Size = new System.Drawing.Size(112, 20);
            this.tilføjbil_model.TabIndex = 6;
            this.tilføjbil_model.Text = "Indtast model";
            // 
            // tilføjbil_enter
            // 
            this.tilføjbil_enter.Location = new System.Drawing.Point(159, 186);
            this.tilføjbil_enter.Name = "tilføjbil_enter";
            this.tilføjbil_enter.Size = new System.Drawing.Size(75, 23);
            this.tilføjbil_enter.TabIndex = 7;
            this.tilføjbil_enter.Text = "Enter";
            this.tilføjbil_enter.UseVisualStyleBackColor = true;
            // 
            // tilføjbil_tilbage
            // 
            this.tilføjbil_tilbage.Location = new System.Drawing.Point(12, 9);
            this.tilføjbil_tilbage.Name = "tilføjbil_tilbage";
            this.tilføjbil_tilbage.Size = new System.Drawing.Size(75, 23);
            this.tilføjbil_tilbage.TabIndex = 8;
            this.tilføjbil_tilbage.Text = "Tilbage";
            this.tilføjbil_tilbage.UseVisualStyleBackColor = true;
            // 
            // tilføjbil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 221);
            this.Controls.Add(this.tilføjbil_tilbage);
            this.Controls.Add(this.tilføjbil_enter);
            this.Controls.Add(this.tilføjbil_model);
            this.Controls.Add(this.tilføjbil_bil);
            this.Controls.Add(this.tilføjbil_navn_eller_model);
            this.Controls.Add(this.tilføjbil_label);
            this.Name = "tilføjbil";
            this.Text = "tilføjbil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tilføjbil_label;
        private System.Windows.Forms.TextBox tilføjbil_navn_eller_model;
        private System.Windows.Forms.TextBox tilføjbil_bil;
        private System.Windows.Forms.TextBox tilføjbil_model;
        private System.Windows.Forms.Button tilføjbil_enter;
        private System.Windows.Forms.Button tilføjbil_tilbage;
    }
}