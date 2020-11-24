namespace windowsform
{
    partial class udtræk
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
            this.udtræk_label = new System.Windows.Forms.Label();
            this.udtræk_navn_eller_nummerplade = new System.Windows.Forms.TextBox();
            this.udtræk_enter = new System.Windows.Forms.Button();
            this.udtræk_tilbage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // udtræk_label
            // 
            this.udtræk_label.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.udtræk_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.udtræk_label.Location = new System.Drawing.Point(146, 9);
            this.udtræk_label.Name = "udtræk_label";
            this.udtræk_label.Size = new System.Drawing.Size(115, 54);
            this.udtræk_label.TabIndex = 4;
            this.udtræk_label.Text = "Udtræk";
            // 
            // udtræk_navn_eller_nummerplade
            // 
            this.udtræk_navn_eller_nummerplade.Location = new System.Drawing.Point(124, 82);
            this.udtræk_navn_eller_nummerplade.Name = "udtræk_navn_eller_nummerplade";
            this.udtræk_navn_eller_nummerplade.Size = new System.Drawing.Size(161, 20);
            this.udtræk_navn_eller_nummerplade.TabIndex = 5;
            this.udtræk_navn_eller_nummerplade.Text = "Indtast navn eller nummerplade";
            // 
            // udtræk_enter
            // 
            this.udtræk_enter.Location = new System.Drawing.Point(161, 186);
            this.udtræk_enter.Name = "udtræk_enter";
            this.udtræk_enter.Size = new System.Drawing.Size(75, 23);
            this.udtræk_enter.TabIndex = 6;
            this.udtræk_enter.Text = "Enter";
            this.udtræk_enter.UseVisualStyleBackColor = true;
            // 
            // udtræk_tilbage
            // 
            this.udtræk_tilbage.Location = new System.Drawing.Point(12, 9);
            this.udtræk_tilbage.Name = "udtræk_tilbage";
            this.udtræk_tilbage.Size = new System.Drawing.Size(75, 23);
            this.udtræk_tilbage.TabIndex = 7;
            this.udtræk_tilbage.Text = "Tilbage";
            this.udtræk_tilbage.UseVisualStyleBackColor = true;
            // 
            // udtræk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 221);
            this.Controls.Add(this.udtræk_tilbage);
            this.Controls.Add(this.udtræk_enter);
            this.Controls.Add(this.udtræk_navn_eller_nummerplade);
            this.Controls.Add(this.udtræk_label);
            this.Name = "udtræk";
            this.Text = "udtræk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label udtræk_label;
        private System.Windows.Forms.TextBox udtræk_navn_eller_nummerplade;
        private System.Windows.Forms.Button udtræk_enter;
        private System.Windows.Forms.Button udtræk_tilbage;
    }
}