
namespace ProjectTeori
{
    partial class Food
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Food));
            this.btnNoodles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNoodles
            // 
            this.btnNoodles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNoodles.BackgroundImage")));
            this.btnNoodles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNoodles.Location = new System.Drawing.Point(12, 12);
            this.btnNoodles.Name = "btnNoodles";
            this.btnNoodles.Size = new System.Drawing.Size(218, 171);
            this.btnNoodles.TabIndex = 0;
            this.btnNoodles.UseVisualStyleBackColor = true;
            this.btnNoodles.Click += new System.EventHandler(this.btnNoodles_Click);
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNoodles);
            this.Name = "Food";
            this.Text = "Food";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNoodles;
    }
}