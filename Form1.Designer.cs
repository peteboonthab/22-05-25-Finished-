namespace Original1
{
    partial class Form1
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
            this.Achievement = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Tutorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Achievement
            // 
            this.Achievement.Location = new System.Drawing.Point(172, 262);
            this.Achievement.Name = "Achievement";
            this.Achievement.Size = new System.Drawing.Size(460, 117);
            this.Achievement.TabIndex = 0;
            this.Achievement.Text = "ContactAndHelp";
            this.Achievement.UseVisualStyleBackColor = true;
            this.Achievement.Click += new System.EventHandler(this.ContactHelp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 73);
            this.label2.TabIndex = 2;
            this.label2.Text = "HOMEPAGE";
            // 
            // Tutorial
            // 
            this.Tutorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tutorial.Location = new System.Drawing.Point(172, 85);
            this.Tutorial.Name = "Tutorial";
            this.Tutorial.Size = new System.Drawing.Size(460, 110);
            this.Tutorial.TabIndex = 3;
            this.Tutorial.Text = "Lesson";
            this.Tutorial.UseVisualStyleBackColor = true;
            this.Tutorial.Click += new System.EventHandler(this.Tutorial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tutorial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Achievement);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Achievement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Tutorial;
    }
}

