
namespace TeacherForm
{
    partial class MainMenu
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
            this.labelGreet = new System.Windows.Forms.Label();
            this.labelGreetText = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGreet
            // 
            this.labelGreet.AutoSize = true;
            this.labelGreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelGreet.Location = new System.Drawing.Point(147, 23);
            this.labelGreet.Name = "labelGreet";
            this.labelGreet.Size = new System.Drawing.Size(182, 24);
            this.labelGreet.TabIndex = 3;
            this.labelGreet.Text = "Добро пожаловать";
            this.labelGreet.Click += new System.EventHandler(this.labelGreet_Click);
            // 
            // labelGreetText
            // 
            this.labelGreetText.AutoSize = true;
            this.labelGreetText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelGreetText.Location = new System.Drawing.Point(392, 23);
            this.labelGreetText.Name = "labelGreetText";
            this.labelGreetText.Size = new System.Drawing.Size(110, 24);
            this.labelGreetText.TabIndex = 4;
            this.labelGreetText.Text = "SampleTest";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::TeacherForm.Properties.Resources._31;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(12, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::TeacherForm.Properties.Resources._22;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(12, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TeacherForm.Properties.Resources._1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(464, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1064, 656);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.labelGreetText);
            this.Controls.Add(this.labelGreet);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1082, 700);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelGreet;
        private System.Windows.Forms.Label labelGreetText;
        private System.Windows.Forms.Button button4;
    }
}