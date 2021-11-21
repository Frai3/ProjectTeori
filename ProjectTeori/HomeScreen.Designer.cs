
namespace ProjectTeori
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.btnFood = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBeverages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFood
            // 
            this.btnFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFood.BackgroundImage")));
            this.btnFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.Location = new System.Drawing.Point(12, 12);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(382, 390);
            this.btnFood.TabIndex = 0;
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 418);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "No Meja";
            // 
            // btnBeverages
            // 
            this.btnBeverages.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBeverages.BackgroundImage")));
            this.btnBeverages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBeverages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeverages.Location = new System.Drawing.Point(406, 12);
            this.btnBeverages.Name = "btnBeverages";
            this.btnBeverages.Size = new System.Drawing.Size(382, 390);
            this.btnBeverages.TabIndex = 1;
            this.btnBeverages.UseVisualStyleBackColor = true;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBeverages);
            this.Controls.Add(this.btnFood);
            this.Name = "HomeScreen";
            this.Text = "Home Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBeverages;
    }
}

