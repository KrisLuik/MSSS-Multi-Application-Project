namespace ClientApplication
{
    partial class DataProcessing
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
            this.labelStarVelocity = new System.Windows.Forms.Label();
            this.labelStarDistance = new System.Windows.Forms.Label();
            this.labelTempInKelvin = new System.Windows.Forms.Label();
            this.labelEventHorizon = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nightModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStarVelocity
            // 
            this.labelStarVelocity.AutoSize = true;
            this.labelStarVelocity.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStarVelocity.Location = new System.Drawing.Point(20, 106);
            this.labelStarVelocity.Name = "labelStarVelocity";
            this.labelStarVelocity.Size = new System.Drawing.Size(88, 16);
            this.labelStarVelocity.TabIndex = 0;
            this.labelStarVelocity.Text = "Star Velocity";
            // 
            // labelStarDistance
            // 
            this.labelStarDistance.AutoSize = true;
            this.labelStarDistance.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStarDistance.Location = new System.Drawing.Point(20, 145);
            this.labelStarDistance.Name = "labelStarDistance";
            this.labelStarDistance.Size = new System.Drawing.Size(89, 16);
            this.labelStarDistance.TabIndex = 1;
            this.labelStarDistance.Text = "Star Distance";
            // 
            // labelTempInKelvin
            // 
            this.labelTempInKelvin.AutoSize = true;
            this.labelTempInKelvin.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempInKelvin.Location = new System.Drawing.Point(20, 186);
            this.labelTempInKelvin.Name = "labelTempInKelvin";
            this.labelTempInKelvin.Size = new System.Drawing.Size(86, 16);
            this.labelTempInKelvin.TabIndex = 2;
            this.labelTempInKelvin.Text = "Temperature";
            // 
            // labelEventHorizon
            // 
            this.labelEventHorizon.AutoSize = true;
            this.labelEventHorizon.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEventHorizon.Location = new System.Drawing.Point(20, 243);
            this.labelEventHorizon.Name = "labelEventHorizon";
            this.labelEventHorizon.Size = new System.Drawing.Size(98, 16);
            this.labelEventHorizon.TabIndex = 3;
            this.labelEventHorizon.Text = "Event Horizon";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(127, 186);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(113, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(127, 241);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(113, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(241, 218);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(52, 20);
            this.textBox5.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.themeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "Choose Language";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.frenchToolStripMenuItem,
            this.germanToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // frenchToolStripMenuItem
            // 
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            this.frenchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.frenchToolStripMenuItem.Text = "French";
            // 
            // germanToolStripMenuItem
            // 
            this.germanToolStripMenuItem.Name = "germanToolStripMenuItem";
            this.germanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.germanToolStripMenuItem.Text = "German";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nightModeToolStripMenuItem,
            this.lightModeToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // nightModeToolStripMenuItem
            // 
            this.nightModeToolStripMenuItem.Name = "nightModeToolStripMenuItem";
            this.nightModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nightModeToolStripMenuItem.Text = "Night Mode";
            // 
            // lightModeToolStripMenuItem
            // 
            this.lightModeToolStripMenuItem.Name = "lightModeToolStripMenuItem";
            this.lightModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lightModeToolStripMenuItem.Text = "Light Mode";
            // 
            // DataProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelEventHorizon);
            this.Controls.Add(this.labelTempInKelvin);
            this.Controls.Add(this.labelStarDistance);
            this.Controls.Add(this.labelStarVelocity);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DataProcessing";
            this.Text = "Data Processing";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStarVelocity;
        private System.Windows.Forms.Label labelStarDistance;
        private System.Windows.Forms.Label labelTempInKelvin;
        private System.Windows.Forms.Label labelEventHorizon;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nightModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightModeToolStripMenuItem;
    }
}

