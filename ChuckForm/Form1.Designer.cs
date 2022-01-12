
namespace ChuckForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GetJokeButton = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // GetJokeButton
            // 
            this.GetJokeButton.Location = new System.Drawing.Point(548, 161);
            this.GetJokeButton.Name = "GetJokeButton";
            this.GetJokeButton.Size = new System.Drawing.Size(112, 34);
            this.GetJokeButton.TabIndex = 0;
            this.GetJokeButton.Text = "Get Joke";
            this.GetJokeButton.UseVisualStyleBackColor = true;
            this.GetJokeButton.Click += new System.EventHandler(this.GetJokeButton_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 12);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(322, 260);
            this.TextBox.TabIndex = 1;
            this.TextBox.Text = "Get a joke i dare you";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(745, 726);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.GetJokeButton);
            this.Name = "Form1";
            this.Text = "Chuck Norris Joke Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetJokeButton;
        private System.Windows.Forms.RichTextBox TextBox;
    }
}

