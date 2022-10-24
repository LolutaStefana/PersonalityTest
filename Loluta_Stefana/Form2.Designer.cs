namespace Loluta_Stefana
{
    partial class Form2
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
            this.label_Animal = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_Gata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Animal
            // 
            this.label_Animal.AutoSize = true;
            this.label_Animal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Animal.Location = new System.Drawing.Point(292, 37);
            this.label_Animal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Animal.Name = "label_Animal";
            this.label_Animal.Size = new System.Drawing.Size(52, 17);
            this.label_Animal.TabIndex = 0;
            this.label_Animal.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(200, 78);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(229, 173);
            this.listBox1.TabIndex = 1;
            // 
            // button_Gata
            // 
            this.button_Gata.Location = new System.Drawing.Point(266, 278);
            this.button_Gata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Gata.Name = "button_Gata";
            this.button_Gata.Size = new System.Drawing.Size(95, 19);
            this.button_Gata.TabIndex = 2;
            this.button_Gata.Text = "Vezi animalul";
            this.button_Gata.UseVisualStyleBackColor = true;
            this.button_Gata.Click += new System.EventHandler(this.button_Gata_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button_Gata);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label_Animal);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Animal;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_Gata;
    }
}