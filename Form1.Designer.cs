namespace Mysterium
{
    partial class MysteriumChoose
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
            this.PlayerCB = new System.Windows.Forms.ComboBox();
            this.labelPhychics = new System.Windows.Forms.Label();
            this.labelGhostState = new System.Windows.Forms.Label();
            this.GhostStateCB = new System.Windows.Forms.ComboBox();
            this.checkBoxSecretLies = new System.Windows.Forms.CheckBox();
            this.checkBoxHiddenSigns = new System.Windows.Forms.CheckBox();
            this.Promo1CB = new System.Windows.Forms.CheckBox();
            this.Promo2CB = new System.Windows.Forms.CheckBox();
            this.Promo3CB = new System.Windows.Forms.CheckBox();
            this.Promo4CB = new System.Windows.Forms.CheckBox();
            this.Promo5CB = new System.Windows.Forms.CheckBox();
            this.Promo6CB = new System.Windows.Forms.CheckBox();
            this.labelObjectStory = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LabelExpensions = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerCB
            // 
            this.PlayerCB.AllowDrop = true;
            this.PlayerCB.Font = new System.Drawing.Font("Ravie", 11F, System.Drawing.FontStyle.Italic);
            this.PlayerCB.FormattingEnabled = true;
            this.PlayerCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.PlayerCB.Location = new System.Drawing.Point(732, 353);
            this.PlayerCB.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.PlayerCB.Name = "PlayerCB";
            this.PlayerCB.Size = new System.Drawing.Size(143, 32);
            this.PlayerCB.TabIndex = 0;
            this.PlayerCB.SelectedIndexChanged += new System.EventHandler(this.PlayerCB_SelectedIndexChanged);
            // 
            // labelPhychics
            // 
            this.labelPhychics.AutoSize = true;
            this.labelPhychics.BackColor = System.Drawing.Color.Transparent;
            this.labelPhychics.Font = new System.Drawing.Font("Ravie", 11F, System.Drawing.FontStyle.Italic);
            this.labelPhychics.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPhychics.Location = new System.Drawing.Point(95, 356);
            this.labelPhychics.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelPhychics.Name = "labelPhychics";
            this.labelPhychics.Size = new System.Drawing.Size(616, 26);
            this.labelPhychics.TabIndex = 1;
            this.labelPhychics.Text = "How many phychics are going to help the Ghost";
            this.labelPhychics.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelGhostState
            // 
            this.labelGhostState.AutoSize = true;
            this.labelGhostState.BackColor = System.Drawing.Color.Transparent;
            this.labelGhostState.Font = new System.Drawing.Font("Ravie", 11F, System.Drawing.FontStyle.Italic);
            this.labelGhostState.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelGhostState.Location = new System.Drawing.Point(202, 397);
            this.labelGhostState.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelGhostState.Name = "labelGhostState";
            this.labelGhostState.Size = new System.Drawing.Size(509, 26);
            this.labelGhostState.TabIndex = 2;
            this.labelGhostState.Text = "Choose the mentale state of the Ghost";
            this.labelGhostState.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // GhostStateCB
            // 
            this.GhostStateCB.Font = new System.Drawing.Font("Ravie", 11F, System.Drawing.FontStyle.Italic);
            this.GhostStateCB.FormattingEnabled = true;
            this.GhostStateCB.Items.AddRange(new object[] {
            "A bit confused, but still know what he\'s doing(Easy)",
            "Fairly confused, things are a bit hazy(Normal)",
            "Compleetly bonkers (Hard)"});
            this.GhostStateCB.Location = new System.Drawing.Point(732, 397);
            this.GhostStateCB.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.GhostStateCB.Name = "GhostStateCB";
            this.GhostStateCB.Size = new System.Drawing.Size(701, 32);
            this.GhostStateCB.TabIndex = 3;
            this.GhostStateCB.SelectedIndexChanged += new System.EventHandler(this.GhostStateCB_SelectedIndexChanged);
            // 
            // checkBoxSecretLies
            // 
            this.checkBoxSecretLies.AutoSize = true;
            this.checkBoxSecretLies.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxSecretLies.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxSecretLies.Location = new System.Drawing.Point(549, 581);
            this.checkBoxSecretLies.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxSecretLies.Name = "checkBoxSecretLies";
            this.checkBoxSecretLies.Size = new System.Drawing.Size(304, 38);
            this.checkBoxSecretLies.TabIndex = 4;
            this.checkBoxSecretLies.Text = "Secrets and Lies";
            this.checkBoxSecretLies.UseVisualStyleBackColor = false;
            this.checkBoxSecretLies.CheckedChanged += new System.EventHandler(this.checkBoxSecretLies_CheckedChanged);
            // 
            // checkBoxHiddenSigns
            // 
            this.checkBoxHiddenSigns.AutoSize = true;
            this.checkBoxHiddenSigns.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxHiddenSigns.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxHiddenSigns.Location = new System.Drawing.Point(273, 581);
            this.checkBoxHiddenSigns.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxHiddenSigns.Name = "checkBoxHiddenSigns";
            this.checkBoxHiddenSigns.Size = new System.Drawing.Size(237, 38);
            this.checkBoxHiddenSigns.TabIndex = 5;
            this.checkBoxHiddenSigns.Text = "Hidden Signs";
            this.checkBoxHiddenSigns.UseVisualStyleBackColor = false;
            this.checkBoxHiddenSigns.CheckedChanged += new System.EventHandler(this.checkBoxHiddenSigns_CheckedChanged);
            // 
            // Promo1CB
            // 
            this.Promo1CB.AutoSize = true;
            this.Promo1CB.BackColor = System.Drawing.Color.Transparent;
            this.Promo1CB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Promo1CB.Location = new System.Drawing.Point(273, 639);
            this.Promo1CB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Promo1CB.Name = "Promo1CB";
            this.Promo1CB.Size = new System.Drawing.Size(160, 38);
            this.Promo1CB.TabIndex = 6;
            this.Promo1CB.Text = "Promo 1";
            this.Promo1CB.UseVisualStyleBackColor = false;
            // 
            // Promo2CB
            // 
            this.Promo2CB.AutoSize = true;
            this.Promo2CB.BackColor = System.Drawing.Color.Transparent;
            this.Promo2CB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Promo2CB.Location = new System.Drawing.Point(482, 639);
            this.Promo2CB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Promo2CB.Name = "Promo2CB";
            this.Promo2CB.Size = new System.Drawing.Size(167, 38);
            this.Promo2CB.TabIndex = 7;
            this.Promo2CB.Text = "Promo 2";
            this.Promo2CB.UseVisualStyleBackColor = false;
            // 
            // Promo3CB
            // 
            this.Promo3CB.AutoSize = true;
            this.Promo3CB.BackColor = System.Drawing.Color.Transparent;
            this.Promo3CB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Promo3CB.Location = new System.Drawing.Point(698, 639);
            this.Promo3CB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Promo3CB.Name = "Promo3CB";
            this.Promo3CB.Size = new System.Drawing.Size(168, 38);
            this.Promo3CB.TabIndex = 8;
            this.Promo3CB.Text = "Promo 3";
            this.Promo3CB.UseVisualStyleBackColor = false;
            // 
            // Promo4CB
            // 
            this.Promo4CB.AutoSize = true;
            this.Promo4CB.BackColor = System.Drawing.Color.Transparent;
            this.Promo4CB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Promo4CB.Location = new System.Drawing.Point(268, 684);
            this.Promo4CB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Promo4CB.Name = "Promo4CB";
            this.Promo4CB.Size = new System.Drawing.Size(171, 38);
            this.Promo4CB.TabIndex = 9;
            this.Promo4CB.Text = "Promo 4";
            this.Promo4CB.UseVisualStyleBackColor = false;
            // 
            // Promo5CB
            // 
            this.Promo5CB.AutoSize = true;
            this.Promo5CB.BackColor = System.Drawing.Color.Transparent;
            this.Promo5CB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Promo5CB.Location = new System.Drawing.Point(482, 684);
            this.Promo5CB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Promo5CB.Name = "Promo5CB";
            this.Promo5CB.Size = new System.Drawing.Size(168, 38);
            this.Promo5CB.TabIndex = 10;
            this.Promo5CB.Text = "Promo 5";
            this.Promo5CB.UseVisualStyleBackColor = false;
            // 
            // Promo6CB
            // 
            this.Promo6CB.AutoSize = true;
            this.Promo6CB.BackColor = System.Drawing.Color.Transparent;
            this.Promo6CB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Promo6CB.Location = new System.Drawing.Point(698, 684);
            this.Promo6CB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Promo6CB.Name = "Promo6CB";
            this.Promo6CB.Size = new System.Drawing.Size(167, 38);
            this.Promo6CB.TabIndex = 11;
            this.Promo6CB.Text = "Promo 6";
            this.Promo6CB.UseVisualStyleBackColor = false;
            // 
            // labelObjectStory
            // 
            this.labelObjectStory.AutoSize = true;
            this.labelObjectStory.BackColor = System.Drawing.Color.Transparent;
            this.labelObjectStory.Font = new System.Drawing.Font("Ravie", 11F, System.Drawing.FontStyle.Italic);
            this.labelObjectStory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelObjectStory.Location = new System.Drawing.Point(168, 438);
            this.labelObjectStory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelObjectStory.Name = "labelObjectStory";
            this.labelObjectStory.Size = new System.Drawing.Size(543, 52);
            this.labelObjectStory.TabIndex = 12;
            this.labelObjectStory.Text = "Are you searching for the murder object\r\nor the story behind the murder?\r\n";
            this.labelObjectStory.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Ravie", 11F, System.Drawing.FontStyle.Italic);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "The murder object",
            "The story of how the ghost got killed"});
            this.comboBox1.Location = new System.Drawing.Point(732, 449);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(649, 32);
            this.comboBox1.TabIndex = 13;
            // 
            // LabelExpensions
            // 
            this.LabelExpensions.AutoSize = true;
            this.LabelExpensions.BackColor = System.Drawing.Color.Transparent;
            this.LabelExpensions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelExpensions.Location = new System.Drawing.Point(273, 526);
            this.LabelExpensions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelExpensions.Name = "LabelExpensions";
            this.LabelExpensions.Size = new System.Drawing.Size(848, 34);
            this.LabelExpensions.TabIndex = 14;
            this.LabelExpensions.Text = "Choose with Expansions you are adding to the game";
            this.LabelExpensions.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.BackgroundImage = global::Mysterium.Properties.Resources.img_20180428_183857_1664x1248__2_;
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartButton.Font = new System.Drawing.Font("Ravie", 11F, System.Drawing.FontStyle.Italic);
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(958, 564);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(181, 183);
            this.StartButton.TabIndex = 15;
            this.StartButton.Text = "Let\'s start to investigate";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MysteriumChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Mysterium.Properties.Resources.Mysterium_banner;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 753);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.LabelExpensions);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelObjectStory);
            this.Controls.Add(this.Promo6CB);
            this.Controls.Add(this.Promo5CB);
            this.Controls.Add(this.Promo4CB);
            this.Controls.Add(this.Promo3CB);
            this.Controls.Add(this.Promo2CB);
            this.Controls.Add(this.Promo1CB);
            this.Controls.Add(this.checkBoxHiddenSigns);
            this.Controls.Add(this.checkBoxSecretLies);
            this.Controls.Add(this.GhostStateCB);
            this.Controls.Add(this.labelGhostState);
            this.Controls.Add(this.labelPhychics);
            this.Controls.Add(this.PlayerCB);
            this.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "MysteriumChoose";
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPhychics;
        private System.Windows.Forms.Label labelGhostState;
        private System.Windows.Forms.ComboBox GhostStateCB;
        private System.Windows.Forms.CheckBox checkBoxSecretLies;
        private System.Windows.Forms.CheckBox checkBoxHiddenSigns;
        private System.Windows.Forms.CheckBox Promo1CB;
        private System.Windows.Forms.CheckBox Promo2CB;
        private System.Windows.Forms.CheckBox Promo3CB;
        private System.Windows.Forms.CheckBox Promo4CB;
        private System.Windows.Forms.CheckBox Promo5CB;
        private System.Windows.Forms.CheckBox Promo6CB;
        private System.Windows.Forms.Label labelObjectStory;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LabelExpensions;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ComboBox PlayerCB;
    }
}

