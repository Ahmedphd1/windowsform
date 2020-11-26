namespace windowsform
{
    partial class rette
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
            this.rette_label = new System.Windows.Forms.Label();
            this.rette_navn_eller_nummerplade_text = new System.Windows.Forms.TextBox();
            this.rette_enter = new System.Windows.Forms.Button();
            this.rette_tilbage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rette_label
            // 
            this.rette_label.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.rette_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rette_label.Location = new System.Drawing.Point(93, 9);
            this.rette_label.Name = "rette_label";
            this.rette_label.Size = new System.Drawing.Size(250, 54);
            this.rette_label.TabIndex = 5;
            this.rette_label.Text = "Find brugerdata";
            // 
            // rette_navn_eller_nummerplade_text
            // 
            this.rette_navn_eller_nummerplade_text.Location = new System.Drawing.Point(99, 66);
            this.rette_navn_eller_nummerplade_text.Name = "rette_navn_eller_nummerplade_text";
            this.rette_navn_eller_nummerplade_text.Size = new System.Drawing.Size(221, 20);
            this.rette_navn_eller_nummerplade_text.TabIndex = 6;
            this.rette_navn_eller_nummerplade_text.Text = "Indtast navn eller nummerplade";
            // 
            // rette_enter
            // 
            this.rette_enter.Location = new System.Drawing.Point(148, 214);
            this.rette_enter.Name = "rette_enter";
            this.rette_enter.Size = new System.Drawing.Size(75, 23);
            this.rette_enter.TabIndex = 7;
            this.rette_enter.Text = "Enter";
            this.rette_enter.UseVisualStyleBackColor = true;
            this.rette_enter.Click += new System.EventHandler(this.rette_enter_Click);
            // 
            // rette_tilbage
            // 
            this.rette_tilbage.Location = new System.Drawing.Point(12, 9);
            this.rette_tilbage.Name = "rette_tilbage";
            this.rette_tilbage.Size = new System.Drawing.Size(75, 23);
            this.rette_tilbage.TabIndex = 10;
            this.rette_tilbage.Text = "Tilbage";
            this.rette_tilbage.UseVisualStyleBackColor = true;
            this.rette_tilbage.Click += new System.EventHandler(this.rette_tilbage_Click_1);
            // 
            // rette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 249);
            this.Controls.Add(this.rette_tilbage);
            this.Controls.Add(this.rette_enter);
            this.Controls.Add(this.rette_navn_eller_nummerplade_text);
            this.Controls.Add(this.rette_label);
            this.Name = "rette";
            this.Text = "rette";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rette_label;
        private System.Windows.Forms.TextBox rette_navn_eller_nummerplade_text;
        private System.Windows.Forms.Button rette_enter;
        private System.Windows.Forms.Button rette_tilbage;
    }
}