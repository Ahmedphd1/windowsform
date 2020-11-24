namespace windowsform
{
    partial class udtrækoplysninger
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
            this.udtrækoplysninger_tilbage = new System.Windows.Forms.Button();
            this.udtrækoplysninger_label = new System.Windows.Forms.Label();
            this.udtrækoplysninger_richtext = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // udtrækoplysninger_tilbage
            // 
            this.udtrækoplysninger_tilbage.Location = new System.Drawing.Point(12, 12);
            this.udtrækoplysninger_tilbage.Name = "udtrækoplysninger_tilbage";
            this.udtrækoplysninger_tilbage.Size = new System.Drawing.Size(75, 23);
            this.udtrækoplysninger_tilbage.TabIndex = 9;
            this.udtrækoplysninger_tilbage.Text = "Tilbage";
            this.udtrækoplysninger_tilbage.UseVisualStyleBackColor = true;
            // 
            // udtrækoplysninger_label
            // 
            this.udtrækoplysninger_label.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.udtrækoplysninger_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.udtrækoplysninger_label.Location = new System.Drawing.Point(93, 12);
            this.udtrækoplysninger_label.Name = "udtrækoplysninger_label";
            this.udtrækoplysninger_label.Size = new System.Drawing.Size(230, 39);
            this.udtrækoplysninger_label.TabIndex = 10;
            this.udtrækoplysninger_label.Text = "Bruger fundet";
            // 
            // udtrækoplysninger_richtext
            // 
            this.udtrækoplysninger_richtext.Location = new System.Drawing.Point(12, 54);
            this.udtrækoplysninger_richtext.Name = "udtrækoplysninger_richtext";
            this.udtrækoplysninger_richtext.Size = new System.Drawing.Size(393, 277);
            this.udtrækoplysninger_richtext.TabIndex = 11;
            this.udtrækoplysninger_richtext.Text = "";
            // 
            // udtrækoplysninger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 408);
            this.Controls.Add(this.udtrækoplysninger_richtext);
            this.Controls.Add(this.udtrækoplysninger_label);
            this.Controls.Add(this.udtrækoplysninger_tilbage);
            this.Name = "udtrækoplysninger";
            this.Text = "udtrækoplysninger";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button udtrækoplysninger_tilbage;
        private System.Windows.Forms.Label udtrækoplysninger_label;
        private System.Windows.Forms.RichTextBox udtrækoplysninger_richtext;
    }
}