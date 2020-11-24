namespace windowsform
{
    partial class opretbrugerbil
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
            this.opretbrugerbil_menu = new System.Windows.Forms.Label();
            this.opretbrugerbil_bruger = new System.Windows.Forms.Button();
            this.opretbrugerbil_logind = new System.Windows.Forms.Button();
            this.opretbrugerbil_tilbage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // opretbrugerbil_menu
            // 
            this.opretbrugerbil_menu.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.opretbrugerbil_menu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.opretbrugerbil_menu.Location = new System.Drawing.Point(93, 9);
            this.opretbrugerbil_menu.Name = "opretbrugerbil_menu";
            this.opretbrugerbil_menu.Size = new System.Drawing.Size(246, 54);
            this.opretbrugerbil_menu.TabIndex = 1;
            this.opretbrugerbil_menu.Text = "Oprettelsesmenu";
            // 
            // opretbrugerbil_bruger
            // 
            this.opretbrugerbil_bruger.Location = new System.Drawing.Point(73, 154);
            this.opretbrugerbil_bruger.Name = "opretbrugerbil_bruger";
            this.opretbrugerbil_bruger.Size = new System.Drawing.Size(106, 55);
            this.opretbrugerbil_bruger.TabIndex = 2;
            this.opretbrugerbil_bruger.Text = "Opret bruger";
            this.opretbrugerbil_bruger.UseVisualStyleBackColor = true;
            this.opretbrugerbil_bruger.Click += new System.EventHandler(this.opretbrugerbil_bruger_Click);
            // 
            // opretbrugerbil_logind
            // 
            this.opretbrugerbil_logind.Location = new System.Drawing.Point(228, 152);
            this.opretbrugerbil_logind.Name = "opretbrugerbil_logind";
            this.opretbrugerbil_logind.Size = new System.Drawing.Size(111, 59);
            this.opretbrugerbil_logind.TabIndex = 3;
            this.opretbrugerbil_logind.Text = "Tilføj bil";
            this.opretbrugerbil_logind.UseVisualStyleBackColor = true;
            this.opretbrugerbil_logind.Click += new System.EventHandler(this.opretbrugerbil_logind_Click);
            // 
            // opretbrugerbil_tilbage
            // 
            this.opretbrugerbil_tilbage.Location = new System.Drawing.Point(12, 9);
            this.opretbrugerbil_tilbage.Name = "opretbrugerbil_tilbage";
            this.opretbrugerbil_tilbage.Size = new System.Drawing.Size(75, 23);
            this.opretbrugerbil_tilbage.TabIndex = 4;
            this.opretbrugerbil_tilbage.Text = "Tilbage";
            this.opretbrugerbil_tilbage.UseVisualStyleBackColor = true;
            this.opretbrugerbil_tilbage.Click += new System.EventHandler(this.opretbrugerbil_tilbage_Click);
            // 
            // opretbrugerbil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 221);
            this.Controls.Add(this.opretbrugerbil_tilbage);
            this.Controls.Add(this.opretbrugerbil_logind);
            this.Controls.Add(this.opretbrugerbil_bruger);
            this.Controls.Add(this.opretbrugerbil_menu);
            this.Name = "opretbrugerbil";
            this.Text = "opretbrugerbil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label opretbrugerbil_menu;
        private System.Windows.Forms.Button opretbrugerbil_bruger;
        private System.Windows.Forms.Button opretbrugerbil_logind;
        private System.Windows.Forms.Button opretbrugerbil_tilbage;
    }
}