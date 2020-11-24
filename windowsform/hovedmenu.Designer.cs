using System;
using System.Drawing;
using System.Windows.Forms;

namespace windowsform
{
    partial class hovedmenu
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
            this.hovedmenu_label = new System.Windows.Forms.Label();
            this.hovedmenu_km_input = new System.Windows.Forms.Button();
            this.hovedmenu_opret = new System.Windows.Forms.Button();
            this.hovedmenu_udtræk = new System.Windows.Forms.Button();
            this.hovedmenu_rette = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hovedmenu_label
            // 
            this.hovedmenu_label.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.hovedmenu_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.hovedmenu_label.Location = new System.Drawing.Point(12, 9);
            this.hovedmenu_label.Name = "hovedmenu_label";
            this.hovedmenu_label.Size = new System.Drawing.Size(407, 54);
            this.hovedmenu_label.TabIndex = 0;
            this.hovedmenu_label.Text = "Velkommen til motorkontoret";
            // 
            // hovedmenu_km_input
            // 
            this.hovedmenu_km_input.Location = new System.Drawing.Point(126, 132);
            this.hovedmenu_km_input.Name = "hovedmenu_km_input";
            this.hovedmenu_km_input.Size = new System.Drawing.Size(75, 23);
            this.hovedmenu_km_input.TabIndex = 1;
            this.hovedmenu_km_input.Text = "KM_input";
            this.hovedmenu_km_input.UseVisualStyleBackColor = true;
            this.hovedmenu_km_input.Click += new System.EventHandler(this.hovedmenu_km_input_Click);
            // 
            // hovedmenu_opret
            // 
            this.hovedmenu_opret.Location = new System.Drawing.Point(207, 132);
            this.hovedmenu_opret.Name = "hovedmenu_opret";
            this.hovedmenu_opret.Size = new System.Drawing.Size(75, 23);
            this.hovedmenu_opret.TabIndex = 2;
            this.hovedmenu_opret.Text = "OPRET";
            this.hovedmenu_opret.UseVisualStyleBackColor = true;
            this.hovedmenu_opret.Click += new System.EventHandler(this.hovedmenu_opret_Click);
            // 
            // hovedmenu_udtræk
            // 
            this.hovedmenu_udtræk.Location = new System.Drawing.Point(126, 161);
            this.hovedmenu_udtræk.Name = "hovedmenu_udtræk";
            this.hovedmenu_udtræk.Size = new System.Drawing.Size(75, 23);
            this.hovedmenu_udtræk.TabIndex = 3;
            this.hovedmenu_udtræk.Text = "UDTRÆK";
            this.hovedmenu_udtræk.UseVisualStyleBackColor = true;
            this.hovedmenu_udtræk.Click += new System.EventHandler(this.hovedmenu_udtræk_Click);
            // 
            // hovedmenu_rette
            // 
            this.hovedmenu_rette.Location = new System.Drawing.Point(207, 161);
            this.hovedmenu_rette.Name = "hovedmenu_rette";
            this.hovedmenu_rette.Size = new System.Drawing.Size(75, 23);
            this.hovedmenu_rette.TabIndex = 4;
            this.hovedmenu_rette.Text = "RETTE";
            this.hovedmenu_rette.UseVisualStyleBackColor = true;
            this.hovedmenu_rette.Click += new System.EventHandler(this.hovedmenu_rette_Click);
            // 
            // hovedmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 208);
            this.Controls.Add(this.hovedmenu_rette);
            this.Controls.Add(this.hovedmenu_udtræk);
            this.Controls.Add(this.hovedmenu_opret);
            this.Controls.Add(this.hovedmenu_km_input);
            this.Controls.Add(this.hovedmenu_label);
            this.Name = "hovedmenu";
            this.Text = "hovedmenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hovedmenu_label;
        private System.Windows.Forms.Button hovedmenu_km_input;
        private System.Windows.Forms.Button hovedmenu_opret;
        private System.Windows.Forms.Button hovedmenu_udtræk;
        private System.Windows.Forms.Button hovedmenu_rette;
    }
}

