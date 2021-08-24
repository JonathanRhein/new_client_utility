
using System;
using System.Linq;

namespace NewClient
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
            this.CreateButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AbortButton = new System.Windows.Forms.Button();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Einkommenssteuererklaerung_CheckBox = new System.Windows.Forms.CheckBox();
            this.Lohnbuchhaltung_CheckBox = new System.Windows.Forms.CheckBox();
            this.Jahresabschluss_CheckBox = new System.Windows.Forms.CheckBox();
            this.Umsatzsteuervoranmeldung_CheckBox = new System.Windows.Forms.CheckBox();
            this.Finanzbuchhaltung_Check_Box = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(194, 366);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(102, 41);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Erstellen";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(37, 80);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PlaceholderText = "Organisation oder Nachname, Vorname";
            this.NameTextBox.Size = new System.Drawing.Size(259, 23);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeadingLabel.Location = new System.Drawing.Point(37, 27);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(153, 25);
            this.HeadingLabel.TabIndex = 2;
            this.HeadingLabel.Text = "Neuer Mandant";
            this.HeadingLabel.Click += new System.EventHandler(this.HeadingLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 3;
            // 
            // AbortButton
            // 
            this.AbortButton.Location = new System.Drawing.Point(88, 366);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(102, 41);
            this.AbortButton.TabIndex = 4;
            this.AbortButton.Text = "Abbrechen";
            this.AbortButton.UseVisualStyleBackColor = true;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // YearComboBox
            // 
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Location = new System.Drawing.Point(162, 124);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(134, 23);
            this.YearComboBox.TabIndex = 5;
            this.YearComboBox.Text = "- bitte auswählen -";
            this.YearComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mandant seit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Leistungen";
            // 
            // Einkommenssteuererklaerung_CheckBox
            // 
            this.Einkommenssteuererklaerung_CheckBox.AutoSize = true;
            this.Einkommenssteuererklaerung_CheckBox.Location = new System.Drawing.Point(50, 205);
            this.Einkommenssteuererklaerung_CheckBox.Name = "Einkommenssteuererklaerung_CheckBox";
            this.Einkommenssteuererklaerung_CheckBox.Size = new System.Drawing.Size(177, 19);
            this.Einkommenssteuererklaerung_CheckBox.TabIndex = 9;
            this.Einkommenssteuererklaerung_CheckBox.Text = "Einkommenssteuererklärung";
            this.Einkommenssteuererklaerung_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Lohnbuchhaltung_CheckBox
            // 
            this.Lohnbuchhaltung_CheckBox.AutoSize = true;
            this.Lohnbuchhaltung_CheckBox.Location = new System.Drawing.Point(50, 255);
            this.Lohnbuchhaltung_CheckBox.Name = "Lohnbuchhaltung_CheckBox";
            this.Lohnbuchhaltung_CheckBox.Size = new System.Drawing.Size(121, 19);
            this.Lohnbuchhaltung_CheckBox.TabIndex = 11;
            this.Lohnbuchhaltung_CheckBox.Text = "Lohnbuchhaltung";
            this.Lohnbuchhaltung_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Jahresabschluss_CheckBox
            // 
            this.Jahresabschluss_CheckBox.AutoSize = true;
            this.Jahresabschluss_CheckBox.Location = new System.Drawing.Point(50, 280);
            this.Jahresabschluss_CheckBox.Name = "Jahresabschluss_CheckBox";
            this.Jahresabschluss_CheckBox.Size = new System.Drawing.Size(109, 19);
            this.Jahresabschluss_CheckBox.TabIndex = 12;
            this.Jahresabschluss_CheckBox.Text = "Jahresabschluss";
            this.Jahresabschluss_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Umsatzsteuervoranmeldung_CheckBox
            // 
            this.Umsatzsteuervoranmeldung_CheckBox.AutoSize = true;
            this.Umsatzsteuervoranmeldung_CheckBox.Location = new System.Drawing.Point(50, 305);
            this.Umsatzsteuervoranmeldung_CheckBox.Name = "Umsatzsteuervoranmeldung_CheckBox";
            this.Umsatzsteuervoranmeldung_CheckBox.Size = new System.Drawing.Size(175, 19);
            this.Umsatzsteuervoranmeldung_CheckBox.TabIndex = 13;
            this.Umsatzsteuervoranmeldung_CheckBox.Text = "Umsatzsteuervoranmeldung";
            this.Umsatzsteuervoranmeldung_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Finanzbuchhaltung_Check_Box
            // 
            this.Finanzbuchhaltung_Check_Box.AutoSize = true;
            this.Finanzbuchhaltung_Check_Box.Location = new System.Drawing.Point(50, 230);
            this.Finanzbuchhaltung_Check_Box.Name = "Finanzbuchhaltung_Check_Box";
            this.Finanzbuchhaltung_Check_Box.Size = new System.Drawing.Size(128, 19);
            this.Finanzbuchhaltung_Check_Box.TabIndex = 14;
            this.Finanzbuchhaltung_Check_Box.Text = "Finanzbuchhaltung";
            this.Finanzbuchhaltung_Check_Box.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 438);
            this.Controls.Add(this.Finanzbuchhaltung_Check_Box);
            this.Controls.Add(this.Umsatzsteuervoranmeldung_CheckBox);
            this.Controls.Add(this.Jahresabschluss_CheckBox);
            this.Controls.Add(this.Lohnbuchhaltung_CheckBox);
            this.Controls.Add(this.Einkommenssteuererklaerung_CheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YearComboBox);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HeadingLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CreateButton);
            this.Name = "Form1";
            this.Text = "Neuer Mandant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox Einkommenssteuererklaerung_CheckBox;
        private System.Windows.Forms.CheckBox Lohnbuchhaltung_CheckBox;
        private System.Windows.Forms.CheckBox Jahresabschluss_CheckBox;
        private System.Windows.Forms.CheckBox Umsatzsteuervoranmeldung_CheckBox;
        private System.Windows.Forms.CheckBox Finanzbuchhaltung_Check_Box;
    }
}

