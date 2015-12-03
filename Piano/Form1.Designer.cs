using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Piano
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.TabControl();
            this.playTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.playingNotesText = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.recordFileText = new System.Windows.Forms.TextBox();
            this.recordFileBrowse = new System.Windows.Forms.Button();
            this.helpPage = new System.Windows.Forms.TabPage();
            this.helpBrowser = new System.Windows.Forms.WebBrowser();
            this.aboutTab = new System.Windows.Forms.TabPage();
            this.aboutDescLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aboutAppName = new System.Windows.Forms.Label();
            this.aboutLogoBox = new System.Windows.Forms.PictureBox();
            this.showGutterCheckbox = new System.Windows.Forms.CheckBox();
            this.optionsGroup = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.highlightNoteCheck = new System.Windows.Forms.CheckBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.recordSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.pianoControl1 = new Piano.PianoControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.tabs.SuspendLayout();
            this.playTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.helpPage.SuspendLayout();
            this.aboutTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutLogoBox)).BeginInit();
            this.optionsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 60);
            this.panel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.iconBox);
            this.splitContainer1.Panel1MinSize = 60;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.appNameLabel);
            this.splitContainer1.Size = new System.Drawing.Size(861, 60);
            this.splitContainer1.SplitterDistance = 60;
            this.splitContainer1.TabIndex = 0;
            // 
            // iconBox
            // 
            this.iconBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconBox.Image = global::Piano.Properties.Resources.Piano_Icon_Small;
            this.iconBox.Location = new System.Drawing.Point(0, 0);
            this.iconBox.MaximumSize = new System.Drawing.Size(60, 60);
            this.iconBox.MinimumSize = new System.Drawing.Size(60, 60);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(60, 60);
            this.iconBox.TabIndex = 0;
            this.iconBox.TabStop = false;
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appNameLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(0, 0);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(197, 65);
            this.appNameLabel.TabIndex = 0;
            this.appNameLabel.Text = "2i Piano";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabs
            // 
            this.tabs.CausesValidation = false;
            this.tabs.Controls.Add(this.playTab);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.helpPage);
            this.tabs.Controls.Add(this.aboutTab);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.HotTrack = true;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(653, 291);
            this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabs.TabIndex = 2;
            // 
            // playTab
            // 
            this.playTab.Controls.Add(this.groupBox1);
            this.playTab.Location = new System.Drawing.Point(4, 22);
            this.playTab.Name = "playTab";
            this.playTab.Padding = new System.Windows.Forms.Padding(3);
            this.playTab.Size = new System.Drawing.Size(645, 265);
            this.playTab.TabIndex = 0;
            this.playTab.Text = "Jouer";
            this.playTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.playingNotesText);
            this.groupBox1.Location = new System.Drawing.Point(8, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notes";
            // 
            // playingNotesText
            // 
            this.playingNotesText.BackColor = System.Drawing.Color.White;
            this.playingNotesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playingNotesText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.playingNotesText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playingNotesText.Enabled = false;
            this.playingNotesText.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playingNotesText.ForeColor = System.Drawing.Color.Black;
            this.playingNotesText.Location = new System.Drawing.Point(3, 16);
            this.playingNotesText.Name = "playingNotesText";
            this.playingNotesText.Size = new System.Drawing.Size(625, 86);
            this.playingNotesText.TabIndex = 0;
            this.playingNotesText.Text = "Jouez!";
            this.playingNotesText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(645, 265);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Enregistrer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(353, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 62);
            this.button3.TabIndex = 5;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(96, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 62);
            this.button2.TabIndex = 4;
            this.button2.Text = "Commencer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(8, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(625, 86);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "00:00:00";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.recordFileText);
            this.groupBox2.Controls.Add(this.recordFileBrowse);
            this.groupBox2.Location = new System.Drawing.Point(8, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(631, 49);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination";
            // 
            // recordFileText
            // 
            this.recordFileText.Location = new System.Drawing.Point(6, 19);
            this.recordFileText.Name = "recordFileText";
            this.recordFileText.Size = new System.Drawing.Size(538, 20);
            this.recordFileText.TabIndex = 1;
            // 
            // recordFileBrowse
            // 
            this.recordFileBrowse.Location = new System.Drawing.Point(550, 17);
            this.recordFileBrowse.Name = "recordFileBrowse";
            this.recordFileBrowse.Size = new System.Drawing.Size(75, 23);
            this.recordFileBrowse.TabIndex = 0;
            this.recordFileBrowse.Text = "Parcourir";
            this.recordFileBrowse.UseVisualStyleBackColor = true;
            this.recordFileBrowse.Click += new System.EventHandler(this.onSelectFile);
            // 
            // helpPage
            // 
            this.helpPage.Controls.Add(this.helpBrowser);
            this.helpPage.Location = new System.Drawing.Point(4, 22);
            this.helpPage.Name = "helpPage";
            this.helpPage.Size = new System.Drawing.Size(645, 265);
            this.helpPage.TabIndex = 2;
            this.helpPage.Text = "Aide";
            this.helpPage.UseVisualStyleBackColor = true;
            // 
            // helpBrowser
            // 
            this.helpBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpBrowser.IsWebBrowserContextMenuEnabled = false;
            this.helpBrowser.Location = new System.Drawing.Point(0, 0);
            this.helpBrowser.Margin = new System.Windows.Forms.Padding(0);
            this.helpBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.helpBrowser.Name = "helpBrowser";
            this.helpBrowser.ScriptErrorsSuppressed = true;
            this.helpBrowser.Size = new System.Drawing.Size(645, 265);
            this.helpBrowser.TabIndex = 0;
            this.helpBrowser.Url = new System.Uri("file:///C:\\Program Files (x86)\\Microsoft Visual Studio 14.0\\Common7\\IDE/Help.html" +
        "", System.UriKind.Absolute);
            // 
            // aboutTab
            // 
            this.aboutTab.Controls.Add(this.aboutDescLabel);
            this.aboutTab.Controls.Add(this.label4);
            this.aboutTab.Controls.Add(this.aboutAppName);
            this.aboutTab.Controls.Add(this.aboutLogoBox);
            this.aboutTab.Location = new System.Drawing.Point(4, 22);
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.aboutTab.Size = new System.Drawing.Size(645, 265);
            this.aboutTab.TabIndex = 3;
            this.aboutTab.Text = "A propos";
            this.aboutTab.UseVisualStyleBackColor = true;
            // 
            // aboutDescLabel
            // 
            this.aboutDescLabel.AutoSize = true;
            this.aboutDescLabel.Location = new System.Drawing.Point(284, 98);
            this.aboutDescLabel.Name = "aboutDescLabel";
            this.aboutDescLabel.Size = new System.Drawing.Size(330, 78);
            this.aboutDescLabel.TabIndex = 3;
            this.aboutDescLabel.Text = "Projet IHM, Décembre 2015\r\n\r\nRéalisé par François Vidogue et Jessy Vanderaugstrae" +
    "te\r\nSons par \"Jaz_the_MAN_2\" sur freesound.org\r\n\r\nAucun animal n\'a été blessé pe" +
    "ndant la réalisation de ce programme.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 2;
            // 
            // aboutAppName
            // 
            this.aboutAppName.AutoSize = true;
            this.aboutAppName.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutAppName.Location = new System.Drawing.Point(270, 12);
            this.aboutAppName.Name = "aboutAppName";
            this.aboutAppName.Size = new System.Drawing.Size(279, 86);
            this.aboutAppName.TabIndex = 1;
            this.aboutAppName.Text = "2i Piano";
            // 
            // aboutLogoBox
            // 
            this.aboutLogoBox.Image = global::Piano.Properties.Resources.Piano_Icon;
            this.aboutLogoBox.Location = new System.Drawing.Point(8, 3);
            this.aboutLogoBox.Name = "aboutLogoBox";
            this.aboutLogoBox.Size = new System.Drawing.Size(256, 256);
            this.aboutLogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aboutLogoBox.TabIndex = 0;
            this.aboutLogoBox.TabStop = false;
            // 
            // showGutterCheckbox
            // 
            this.showGutterCheckbox.AutoSize = true;
            this.showGutterCheckbox.Checked = true;
            this.showGutterCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showGutterCheckbox.Location = new System.Drawing.Point(6, 19);
            this.showGutterCheckbox.Name = "showGutterCheckbox";
            this.showGutterCheckbox.Size = new System.Drawing.Size(155, 17);
            this.showGutterCheckbox.TabIndex = 0;
            this.showGutterCheckbox.TabStop = false;
            this.showGutterCheckbox.Text = "Afficher les noms des notes";
            this.showGutterCheckbox.UseVisualStyleBackColor = true;
            this.showGutterCheckbox.CheckedChanged += new System.EventHandler(this.onShowGutterToggle);
            // 
            // optionsGroup
            // 
            this.optionsGroup.Controls.Add(this.listBox1);
            this.optionsGroup.Controls.Add(this.label3);
            this.optionsGroup.Controls.Add(this.label2);
            this.optionsGroup.Controls.Add(this.numericUpDown1);
            this.optionsGroup.Controls.Add(this.highlightNoteCheck);
            this.optionsGroup.Controls.Add(this.showGutterCheckbox);
            this.optionsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsGroup.Location = new System.Drawing.Point(0, 14);
            this.optionsGroup.Name = "optionsGroup";
            this.optionsGroup.Size = new System.Drawing.Size(201, 277);
            this.optionsGroup.TabIndex = 1;
            this.optionsGroup.TabStop = false;
            this.optionsGroup.Text = "Options";
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Piano (Défaut)"});
            this.listBox1.Location = new System.Drawing.Point(10, 177);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 95);
            this.listBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Instrument";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Octave";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(74, 66);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // highlightNoteCheck
            // 
            this.highlightNoteCheck.AutoSize = true;
            this.highlightNoteCheck.Checked = true;
            this.highlightNoteCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.highlightNoteCheck.Location = new System.Drawing.Point(6, 43);
            this.highlightNoteCheck.Name = "highlightNoteCheck";
            this.highlightNoteCheck.Size = new System.Drawing.Size(131, 17);
            this.highlightNoteCheck.TabIndex = 1;
            this.highlightNoteCheck.Text = "Surligner la note jouée";
            this.highlightNoteCheck.UseVisualStyleBackColor = true;
            this.highlightNoteCheck.CheckedChanged += new System.EventHandler(this.onHighlightNotesToggle);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 60);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabs);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.optionsGroup);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(0, 14, 3, 0);
            this.splitContainer2.Size = new System.Drawing.Size(861, 291);
            this.splitContainer2.SplitterDistance = 653;
            this.splitContainer2.TabIndex = 3;
            // 
            // recordSaveDialog
            // 
            this.recordSaveDialog.DefaultExt = "*.wav";
            this.recordSaveDialog.Filter = "Fichiers WAV|*.wav|Tous les fichiers|*.*";
            this.recordSaveDialog.Title = "Enregistrer une mélodie";
            // 
            // pianoControl1
            // 
            this.pianoControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pianoControl1.HighlightNotes = true;
            this.pianoControl1.KeyLength = 40;
            this.pianoControl1.Location = new System.Drawing.Point(0, 351);
            this.pianoControl1.MaximumSize = new System.Drawing.Size(0, 128);
            this.pianoControl1.Name = "pianoControl1";
            this.pianoControl1.Octave = 3;
            this.pianoControl1.ShowGutter = true;
            this.pianoControl1.Size = new System.Drawing.Size(861, 128);
            this.pianoControl1.TabIndex = 0;
            this.pianoControl1.OnPlay += new System.EventHandler(this.onNoteChange);
            this.pianoControl1.OnRelease += new System.EventHandler(this.onNoteChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 479);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pianoControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "2i Piano";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.tabs.ResumeLayout(false);
            this.playTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.helpPage.ResumeLayout(false);
            this.aboutTab.ResumeLayout(false);
            this.aboutTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutLogoBox)).EndInit();
            this.optionsGroup.ResumeLayout(false);
            this.optionsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PianoControl pianoControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage playTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.CheckBox showGutterCheckbox;

        // Event handles
        private void onShowGutterToggle( object sender, EventArgs e){
            System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox) sender;
            pianoControl1.ShowGutter = cb.Checked;
        }

        private void onHighlightNotesToggle( object sender, EventArgs e){
            System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;
            pianoControl1.HighlightNotes = cb.Checked;
        }

        private void onOctaveChange( object sender, EventArgs e){
            System.Windows.Forms.NumericUpDown ctrl = (System.Windows.Forms.NumericUpDown)sender;
            pianoControl1.Octave = (int) ctrl.Value;
        }

        private void onNoteChange( object sender, EventArgs e){
            PianoControl ctrl = (PianoControl)sender;
            LinkedList<Note> playingNotes = ctrl.PlayingNotes;

            String text = "";

            foreach (Note n in playingNotes)
                text += n.ToString() + " ";

            this.playingNotesText.Text = text;
        }

        private void onSelectFile( object sender, EventArgs e){
            if(recordSaveDialog.ShowDialog() == DialogResult.OK)
                recordFileText.Text = recordSaveDialog.FileName;
        }

        private System.Windows.Forms.GroupBox optionsGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox highlightNoteCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabPage helpPage;
        private System.Windows.Forms.TabPage aboutTab;
        private System.Windows.Forms.Label aboutAppName;
        private System.Windows.Forms.PictureBox aboutLogoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label aboutDescLabel;
        private System.Windows.Forms.WebBrowser helpBrowser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox playingNotesText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox recordFileText;
        private System.Windows.Forms.Button recordFileBrowse;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog recordSaveDialog;
    }
}

