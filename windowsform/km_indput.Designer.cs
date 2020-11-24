using System.Windows.Forms;

namespace windowsform
{
    partial class km_indput
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
            this.km_indput_text = new System.Windows.Forms.TextBox();
            this.km_indput_label = new System.Windows.Forms.Label();
            this.km_indput_enter = new System.Windows.Forms.Button();
            this.km_indput_tilbage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // km_indput_text
            // 
            this.km_indput_text.Location = new System.Drawing.Point(118, 98);
            this.km_indput_text.Name = "km_indput_text";
            this.km_indput_text.Size = new System.Drawing.Size(171, 20);
            this.km_indput_text.TabIndex = 0;
            this.km_indput_text.Text = "Indtast Navn og efternavn eller Nummberplade";
            // 
            // km_indput_label
            // 
            this.km_indput_label.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.km_indput_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.km_indput_label.Location = new System.Drawing.Point(90, 9);
            this.km_indput_label.Name = "km_indput_label";
            this.km_indput_label.Size = new System.Drawing.Size(230, 54);
            this.km_indput_label.TabIndex = 1;
            this.km_indput_label.Text = "Km registrering";
            // 
            // km_indput_enter
            // 
            this.km_indput_enter.Location = new System.Drawing.Point(164, 186);
            this.km_indput_enter.Name = "km_indput_enter";
            this.km_indput_enter.Size = new System.Drawing.Size(75, 23);
            this.km_indput_enter.TabIndex = 2;
            this.km_indput_enter.Text = "Enter";
            this.km_indput_enter.UseVisualStyleBackColor = true;
            this.km_indput_enter.Click += new System.EventHandler(this.km_indput_enter_Click);
            // 
            // km_indput_tilbage
            // 
            this.km_indput_tilbage.Location = new System.Drawing.Point(9, 9);
            this.km_indput_tilbage.Name = "km_indput_tilbage";
            this.km_indput_tilbage.Size = new System.Drawing.Size(75, 23);
            this.km_indput_tilbage.TabIndex = 3;
            this.km_indput_tilbage.Text = "Tilbage";
            this.km_indput_tilbage.UseVisualStyleBackColor = true;
            this.km_indput_tilbage.Click += new System.EventHandler(this.km_indput_tilbage_Click);
            // 
            // km_indput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 221);
            this.Controls.Add(this.km_indput_tilbage);
            this.Controls.Add(this.km_indput_enter);
            this.Controls.Add(this.km_indput_label);
            this.Controls.Add(this.km_indput_text);
            this.Name = "km_indput";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formclosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


            #endregion

        private System.Windows.Forms.TextBox km_indput_text;
        private System.Windows.Forms.Label km_indput_label;
        private System.Windows.Forms.Button km_indput_enter;
        private System.Windows.Forms.Button km_indput_tilbage;
    }
}