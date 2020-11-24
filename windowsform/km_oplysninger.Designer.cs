namespace windowsform
{
    partial class km_oplysninger
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
            this.km_oplysninger_label = new System.Windows.Forms.Label();
            this.km_oplysninger_richtext = new System.Windows.Forms.RichTextBox();
            this.km_oplysninger_label2 = new System.Windows.Forms.Label();
            this.km_oplysninger_textbox = new System.Windows.Forms.TextBox();
            this.km_oplysninger_enter = new System.Windows.Forms.Button();
            this.km_oplysninger_tilbage = new System.Windows.Forms.Button();
            this.km_oplysninger_combobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // km_oplysninger_label
            // 
            this.km_oplysninger_label.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.km_oplysninger_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.km_oplysninger_label.Location = new System.Drawing.Point(100, 9);
            this.km_oplysninger_label.Name = "km_oplysninger_label";
            this.km_oplysninger_label.Size = new System.Drawing.Size(230, 39);
            this.km_oplysninger_label.TabIndex = 2;
            this.km_oplysninger_label.Text = "Bruger fundet";
            // 
            // km_oplysninger_richtext
            // 
            this.km_oplysninger_richtext.Location = new System.Drawing.Point(12, 51);
            this.km_oplysninger_richtext.Name = "km_oplysninger_richtext";
            this.km_oplysninger_richtext.Size = new System.Drawing.Size(393, 145);
            this.km_oplysninger_richtext.TabIndex = 3;
            this.km_oplysninger_richtext.Text = "";
            // 
            // km_oplysninger_label2
            // 
            this.km_oplysninger_label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.km_oplysninger_label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.km_oplysninger_label2.Location = new System.Drawing.Point(119, 215);
            this.km_oplysninger_label2.Name = "km_oplysninger_label2";
            this.km_oplysninger_label2.Size = new System.Drawing.Size(178, 22);
            this.km_oplysninger_label2.TabIndex = 4;
            this.km_oplysninger_label2.Text = "Opdater Kilometertæller";
            // 
            // km_oplysninger_textbox
            // 
            this.km_oplysninger_textbox.Location = new System.Drawing.Point(143, 294);
            this.km_oplysninger_textbox.Name = "km_oplysninger_textbox";
            this.km_oplysninger_textbox.Size = new System.Drawing.Size(123, 20);
            this.km_oplysninger_textbox.TabIndex = 6;
            this.km_oplysninger_textbox.Text = "Indtast antal kilometer";
            // 
            // km_oplysninger_enter
            // 
            this.km_oplysninger_enter.Location = new System.Drawing.Point(160, 373);
            this.km_oplysninger_enter.Name = "km_oplysninger_enter";
            this.km_oplysninger_enter.Size = new System.Drawing.Size(75, 23);
            this.km_oplysninger_enter.TabIndex = 7;
            this.km_oplysninger_enter.Text = "Opdater";
            this.km_oplysninger_enter.UseVisualStyleBackColor = true;
            this.km_oplysninger_enter.Click += new System.EventHandler(this.km_oplysninger_enter_Click);
            // 
            // km_oplysninger_tilbage
            // 
            this.km_oplysninger_tilbage.Location = new System.Drawing.Point(12, 9);
            this.km_oplysninger_tilbage.Name = "km_oplysninger_tilbage";
            this.km_oplysninger_tilbage.Size = new System.Drawing.Size(75, 23);
            this.km_oplysninger_tilbage.TabIndex = 8;
            this.km_oplysninger_tilbage.Text = "Tilbage";
            this.km_oplysninger_tilbage.UseVisualStyleBackColor = true;
            this.km_oplysninger_tilbage.Click += new System.EventHandler(this.km_oplysninger_tilbage_Click);
            // 
            // km_oplysninger_combobox
            // 
            this.km_oplysninger_combobox.FormattingEnabled = true;
            this.km_oplysninger_combobox.Location = new System.Drawing.Point(143, 256);
            this.km_oplysninger_combobox.Name = "km_oplysninger_combobox";
            this.km_oplysninger_combobox.Size = new System.Drawing.Size(121, 21);
            this.km_oplysninger_combobox.TabIndex = 9;
            // 
            // km_oplysninger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 408);
            this.Controls.Add(this.km_oplysninger_combobox);
            this.Controls.Add(this.km_oplysninger_tilbage);
            this.Controls.Add(this.km_oplysninger_enter);
            this.Controls.Add(this.km_oplysninger_textbox);
            this.Controls.Add(this.km_oplysninger_label2);
            this.Controls.Add(this.km_oplysninger_richtext);
            this.Controls.Add(this.km_oplysninger_label);
            this.Name = "km_oplysninger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label km_oplysninger_label;
        private System.Windows.Forms.RichTextBox km_oplysninger_richtext;
        private System.Windows.Forms.Label km_oplysninger_label2;
        private System.Windows.Forms.TextBox km_oplysninger_textbox;
        private System.Windows.Forms.Button km_oplysninger_enter;
        private System.Windows.Forms.Button km_oplysninger_tilbage;
        private System.Windows.Forms.ComboBox km_oplysninger_combobox;
    }
}