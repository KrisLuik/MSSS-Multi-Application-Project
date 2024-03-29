﻿namespace ClientApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataProcessing));
            this.labelStarVelocity = new System.Windows.Forms.Label();
            this.labelStarDistance = new System.Windows.Forms.Label();
            this.labelTempInKelvin = new System.Windows.Forms.Label();
            this.labelEventHorizon = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nightModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textboxEventHorizon = new System.Windows.Forms.TextBox();
            this.textboxTemperature = new System.Windows.Forms.TextBox();
            this.textboxStarDistance = new System.Windows.Forms.TextBox();
            this.observedWavelengthTextbox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.restWavelengthTextbox = new System.Windows.Forms.TextBox();
            this.eventHorizonPower = new System.Windows.Forms.NumericUpDown();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStarVelocity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStarDistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTemperature = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEventHorizon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.textboxEventHorizonReadOnly = new System.Windows.Forms.TextBox();
            this.textboxTemperatureReadOnly = new System.Windows.Forms.TextBox();
            this.textboxStarDistanceReadOnly = new System.Windows.Forms.TextBox();
            this.textboxStarVelocityReadOnly = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventHorizonPower)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStarVelocity
            // 
            resources.ApplyResources(this.labelStarVelocity, "labelStarVelocity");
            this.labelStarVelocity.Name = "labelStarVelocity";
            // 
            // labelStarDistance
            // 
            resources.ApplyResources(this.labelStarDistance, "labelStarDistance");
            this.labelStarDistance.Name = "labelStarDistance";
            // 
            // labelTempInKelvin
            // 
            resources.ApplyResources(this.labelTempInKelvin, "labelTempInKelvin");
            this.labelTempInKelvin.Name = "labelTempInKelvin";
            // 
            // labelEventHorizon
            // 
            resources.ApplyResources(this.labelEventHorizon, "labelEventHorizon");
            this.labelEventHorizon.Name = "labelEventHorizon";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.themeToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.frenchToolStripMenuItem,
            this.germanToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Image = global::ClientApplication.Properties.Resources.england3;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // frenchToolStripMenuItem
            // 
            resources.ApplyResources(this.frenchToolStripMenuItem, "frenchToolStripMenuItem");
            this.frenchToolStripMenuItem.Image = global::ClientApplication.Properties.Resources.france2;
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            this.frenchToolStripMenuItem.Click += new System.EventHandler(this.frenchToolStripMenuItem_Click);
            // 
            // germanToolStripMenuItem
            // 
            resources.ApplyResources(this.germanToolStripMenuItem, "germanToolStripMenuItem");
            this.germanToolStripMenuItem.Image = global::ClientApplication.Properties.Resources.germany1;
            this.germanToolStripMenuItem.Name = "germanToolStripMenuItem";
            this.germanToolStripMenuItem.Click += new System.EventHandler(this.germanToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            resources.ApplyResources(this.themeToolStripMenuItem, "themeToolStripMenuItem");
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nightModeToolStripMenuItem,
            this.lightModeToolStripMenuItem,
            this.colourToolStripMenuItem,
            this.defaultToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            // 
            // nightModeToolStripMenuItem
            // 
            resources.ApplyResources(this.nightModeToolStripMenuItem, "nightModeToolStripMenuItem");
            this.nightModeToolStripMenuItem.Image = global::ClientApplication.Properties.Resources.moon;
            this.nightModeToolStripMenuItem.Name = "nightModeToolStripMenuItem";
            this.nightModeToolStripMenuItem.Click += new System.EventHandler(this.nightModeToolStripMenuItem_Click);
            // 
            // lightModeToolStripMenuItem
            // 
            resources.ApplyResources(this.lightModeToolStripMenuItem, "lightModeToolStripMenuItem");
            this.lightModeToolStripMenuItem.Image = global::ClientApplication.Properties.Resources.thesun1;
            this.lightModeToolStripMenuItem.Name = "lightModeToolStripMenuItem";
            this.lightModeToolStripMenuItem.Click += new System.EventHandler(this.lightModeToolStripMenuItem_Click);
            // 
            // colourToolStripMenuItem
            // 
            resources.ApplyResources(this.colourToolStripMenuItem, "colourToolStripMenuItem");
            this.colourToolStripMenuItem.Image = global::ClientApplication.Properties.Resources.colourWheel;
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Click += new System.EventHandler(this.colourToolStripMenuItem_Click);
            // 
            // defaultToolStripMenuItem
            // 
            resources.ApplyResources(this.defaultToolStripMenuItem, "defaultToolStripMenuItem");
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // textboxEventHorizon
            // 
            resources.ApplyResources(this.textboxEventHorizon, "textboxEventHorizon");
            this.textboxEventHorizon.Name = "textboxEventHorizon";
            this.textboxEventHorizon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAction);
            // 
            // textboxTemperature
            // 
            resources.ApplyResources(this.textboxTemperature, "textboxTemperature");
            this.textboxTemperature.Name = "textboxTemperature";
            this.textboxTemperature.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAction);
            // 
            // textboxStarDistance
            // 
            resources.ApplyResources(this.textboxStarDistance, "textboxStarDistance");
            this.textboxStarDistance.Name = "textboxStarDistance";
            this.textboxStarDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAction);
            // 
            // observedWavelengthTextbox
            // 
            resources.ApplyResources(this.observedWavelengthTextbox, "observedWavelengthTextbox");
            this.observedWavelengthTextbox.Name = "observedWavelengthTextbox";
            this.observedWavelengthTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAction);
            // 
            // calculateButton
            // 
            resources.ApplyResources(this.calculateButton, "calculateButton");
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // restWavelengthTextbox
            // 
            resources.ApplyResources(this.restWavelengthTextbox, "restWavelengthTextbox");
            this.restWavelengthTextbox.Name = "restWavelengthTextbox";
            this.restWavelengthTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAction);
            // 
            // eventHorizonPower
            // 
            resources.ApplyResources(this.eventHorizonPower, "eventHorizonPower");
            this.eventHorizonPower.Name = "eventHorizonPower";
            // 
            // listViewItems
            // 
            resources.ApplyResources(this.listViewItems, "listViewItems");
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnStarVelocity,
            this.columnStarDistance,
            this.columnTemperature,
            this.columnEventHorizon});
            this.listViewItems.FullRowSelect = true;
            this.listViewItems.GridLines = true;
            this.listViewItems.HideSelection = false;
            this.listViewItems.MultiSelect = false;
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Scrollable = false;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.View = System.Windows.Forms.View.Details;
            this.listViewItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewItems_MouseClick);
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnStarVelocity
            // 
            resources.ApplyResources(this.columnStarVelocity, "columnStarVelocity");
            // 
            // columnStarDistance
            // 
            resources.ApplyResources(this.columnStarDistance, "columnStarDistance");
            // 
            // columnTemperature
            // 
            resources.ApplyResources(this.columnTemperature, "columnTemperature");
            // 
            // columnEventHorizon
            // 
            resources.ApplyResources(this.columnEventHorizon, "columnEventHorizon");
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Name = "statusStrip1";
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            resources.ApplyResources(this.addButton, "addButton");
            this.addButton.Name = "addButton";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // textboxEventHorizonReadOnly
            // 
            resources.ApplyResources(this.textboxEventHorizonReadOnly, "textboxEventHorizonReadOnly");
            this.textboxEventHorizonReadOnly.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textboxEventHorizonReadOnly.Name = "textboxEventHorizonReadOnly";
            this.textboxEventHorizonReadOnly.ReadOnly = true;
            // 
            // textboxTemperatureReadOnly
            // 
            resources.ApplyResources(this.textboxTemperatureReadOnly, "textboxTemperatureReadOnly");
            this.textboxTemperatureReadOnly.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textboxTemperatureReadOnly.Name = "textboxTemperatureReadOnly";
            this.textboxTemperatureReadOnly.ReadOnly = true;
            // 
            // textboxStarDistanceReadOnly
            // 
            resources.ApplyResources(this.textboxStarDistanceReadOnly, "textboxStarDistanceReadOnly");
            this.textboxStarDistanceReadOnly.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textboxStarDistanceReadOnly.Name = "textboxStarDistanceReadOnly";
            this.textboxStarDistanceReadOnly.ReadOnly = true;
            // 
            // textboxStarVelocityReadOnly
            // 
            resources.ApplyResources(this.textboxStarVelocityReadOnly, "textboxStarVelocityReadOnly");
            this.textboxStarVelocityReadOnly.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textboxStarVelocityReadOnly.Name = "textboxStarVelocityReadOnly";
            this.textboxStarVelocityReadOnly.ReadOnly = true;
            // 
            // DataProcessing
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textboxStarVelocityReadOnly);
            this.Controls.Add(this.textboxStarDistanceReadOnly);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textboxTemperatureReadOnly);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.labelStarVelocity);
            this.Controls.Add(this.textboxEventHorizonReadOnly);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.textboxEventHorizon);
            this.Controls.Add(this.labelEventHorizon);
            this.Controls.Add(this.listViewItems);
            this.Controls.Add(this.labelTempInKelvin);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.eventHorizonPower);
            this.Controls.Add(this.textboxTemperature);
            this.Controls.Add(this.observedWavelengthTextbox);
            this.Controls.Add(this.restWavelengthTextbox);
            this.Controls.Add(this.labelStarDistance);
            this.Controls.Add(this.textboxStarDistance);
            this.Controls.Add(this.calculateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DataProcessing";
            this.Load += new System.EventHandler(this.DataProcessing_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventHorizonPower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStarVelocity;
        private System.Windows.Forms.Label labelStarDistance;
        private System.Windows.Forms.Label labelTempInKelvin;
        private System.Windows.Forms.Label labelEventHorizon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nightModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightModeToolStripMenuItem;
        private System.Windows.Forms.TextBox textboxEventHorizon;
        private System.Windows.Forms.TextBox textboxTemperature;
        private System.Windows.Forms.TextBox textboxStarDistance;
        private System.Windows.Forms.TextBox observedWavelengthTextbox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox restWavelengthTextbox;
        private System.Windows.Forms.NumericUpDown eventHorizonPower;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnStarVelocity;
        private System.Windows.Forms.ColumnHeader columnStarDistance;
        private System.Windows.Forms.ColumnHeader columnTemperature;
        private System.Windows.Forms.ColumnHeader columnEventHorizon;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox textboxEventHorizonReadOnly;
        private System.Windows.Forms.TextBox textboxTemperatureReadOnly;
        private System.Windows.Forms.TextBox textboxStarDistanceReadOnly;
        private System.Windows.Forms.TextBox textboxStarVelocityReadOnly;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
    }
}

