﻿namespace JoliBateau
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
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.labelTreeview = new System.Windows.Forms.Label();
            this.listeSolution = new System.Windows.Forms.ListBox();
            this.labelSolution = new System.Windows.Forms.Label();
            this.labelCountOpen = new System.Windows.Forms.Label();
            this.labelCountClosed = new System.Windows.Forms.Label();
            this.tempsSolution = new System.Windows.Forms.Label();
            this.nbNoeudsSolution = new System.Windows.Forms.Label();
            this.labelStopwatch = new System.Windows.Forms.Label();
            this.groupCas = new System.Windows.Forms.GroupBox();
            this.groupBoxPavage = new System.Windows.Forms.GroupBox();
            this.radioButtonPavage2 = new System.Windows.Forms.RadioButton();
            this.radioButtonPavage1 = new System.Windows.Forms.RadioButton();
            this.radioButtonPavage0 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDist2 = new System.Windows.Forms.RadioButton();
            this.radioButtonDist1 = new System.Windows.Forms.RadioButton();
            this.radioButtonDist0 = new System.Windows.Forms.RadioButton();
            this.textBoxP1X = new System.Windows.Forms.TextBox();
            this.textBoxP1Y = new System.Windows.Forms.TextBox();
            this.textBoxPfX = new System.Windows.Forms.TextBox();
            this.textBoxPfY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();

            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupCas.SuspendLayout();
            this.groupBoxPavage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();

            this.comboTailleCarre = new System.Windows.Forms.ComboBox();
            this.radioButtonPavage3 = new System.Windows.Forms.RadioButton();


            this.comboTailleCarre = new System.Windows.Forms.ComboBox();
            this.radioButtonPavage3 = new System.Windows.Forms.RadioButton();

            this.groupCas.SuspendLayout();
            this.groupBoxPavage.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Recherche A*";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(859, 192);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(166, 303);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // radioButtonCasA
            // 
            this.radioButtonCasA.AutoSize = true;
            this.radioButtonCasA.Checked = true;
            this.radioButtonCasA.Location = new System.Drawing.Point(15, 19);
            this.radioButtonCasA.Name = "radioButtonCasA";
            this.radioButtonCasA.Size = new System.Drawing.Size(31, 17);
            this.radioButtonCasA.TabIndex = 4;
            this.radioButtonCasA.TabStop = true;
            this.radioButtonCasA.Text = "a";
            this.radioButtonCasA.UseVisualStyleBackColor = true;
            // 
            // radioButtonCasB
            // 
            this.radioButtonCasB.AutoSize = true;
            this.radioButtonCasB.Location = new System.Drawing.Point(15, 51);
            this.radioButtonCasB.Name = "radioButtonCasB";
            this.radioButtonCasB.Size = new System.Drawing.Size(31, 17);
            this.radioButtonCasB.TabIndex = 5;
            this.radioButtonCasB.Text = "b";
            this.radioButtonCasB.UseVisualStyleBackColor = true;
            // 
            // radioButtonCasC
            // 
            this.radioButtonCasC.AutoSize = true;
            this.radioButtonCasC.Location = new System.Drawing.Point(15, 84);
            this.radioButtonCasC.Name = "radioButtonCasC";
            this.radioButtonCasC.Size = new System.Drawing.Size(31, 17);
            this.radioButtonCasC.TabIndex = 6;
            this.radioButtonCasC.Text = "c";
            this.radioButtonCasC.UseVisualStyleBackColor = true;
            // 
            // labelTreeview
            // 
            this.labelTreeview.AutoSize = true;
            this.labelTreeview.Location = new System.Drawing.Point(872, 159);
            this.labelTreeview.Name = "labelTreeview";
            this.labelTreeview.Size = new System.Drawing.Size(137, 13);
            this.labelTreeview.TabIndex = 7;
            this.labelTreeview.Text = "Arborescence des solutions";
            // 
            // listeSolution
            // 
            this.listeSolution.FormattingEnabled = true;
            this.listeSolution.Location = new System.Drawing.Point(711, 192);
            this.listeSolution.Name = "listeSolution";
            this.listeSolution.Size = new System.Drawing.Size(131, 303);
            this.listeSolution.TabIndex = 8;
            // 
            // labelSolution
            // 
            this.labelSolution.AutoSize = true;
            this.labelSolution.Location = new System.Drawing.Point(221, 789);
            this.labelSolution.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelSolution.Name = "labelSolution";
            this.labelSolution.Size = new System.Drawing.Size(0, 13);
            this.labelSolution.TabIndex = 9;
            // 
            // labelCountOpen
            // 
            this.labelCountOpen.AutoSize = true;
            this.labelCountOpen.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelCountOpen.Location = new System.Drawing.Point(800, 997);
            this.labelCountOpen.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelCountOpen.Name = "labelCountOpen";
            this.labelCountOpen.Size = new System.Drawing.Size(0, 13);
            this.labelCountOpen.TabIndex = 10;
            // 
            // labelCountClosed
            // 
            this.labelCountClosed.AutoSize = true;
            this.labelCountClosed.Location = new System.Drawing.Point(800, 1066);
            this.labelCountClosed.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelCountClosed.Name = "labelCountClosed";
            this.labelCountClosed.Size = new System.Drawing.Size(0, 13);
            this.labelCountClosed.TabIndex = 11;
            // 
            // tempsSolution
            // 
            this.tempsSolution.AutoSize = true;
            this.tempsSolution.Location = new System.Drawing.Point(800, 882);
            this.tempsSolution.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tempsSolution.Name = "tempsSolution";
            this.tempsSolution.Size = new System.Drawing.Size(0, 13);
            this.tempsSolution.TabIndex = 12;
            // 
            // nbNoeudsSolution
            // 
            this.nbNoeudsSolution.AutoSize = true;
            this.nbNoeudsSolution.Location = new System.Drawing.Point(800, 930);
            this.nbNoeudsSolution.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.nbNoeudsSolution.Name = "nbNoeudsSolution";
            this.nbNoeudsSolution.Size = new System.Drawing.Size(0, 13);
            this.nbNoeudsSolution.TabIndex = 13;
            // 
            // labelStopwatch
            // 
            this.labelStopwatch.AutoSize = true;
            this.labelStopwatch.Location = new System.Drawing.Point(300, 497);
            this.labelStopwatch.Name = "labelStopwatch";
            this.labelStopwatch.Size = new System.Drawing.Size(0, 13);
            this.labelStopwatch.TabIndex = 14;
            this.labelStopwatch.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupCas
            // 
            this.groupCas.Controls.Add(this.radioButtonCasA);
            this.groupCas.Controls.Add(this.radioButtonCasB);
            this.groupCas.Controls.Add(this.radioButtonCasC);
            this.groupCas.Location = new System.Drawing.Point(25, 160);
            this.groupCas.Name = "groupCas";
            this.groupCas.Size = new System.Drawing.Size(228, 107);
            this.groupCas.TabIndex = 15;
            this.groupCas.TabStop = false;
            this.groupCas.Text = "Vent";
            this.groupCas.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBoxPavage
            // 
            this.groupBoxPavage.Controls.Add(this.radioButtonPavage2);
            this.groupBoxPavage.Controls.Add(this.radioButtonPavage1);
            this.groupBoxPavage.Controls.Add(this.radioButtonPavage0);
            this.groupBoxPavage.Location = new System.Drawing.Point(67, 997);
            this.groupBoxPavage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBoxPavage.Name = "groupBoxPavage";
            this.groupBoxPavage.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBoxPavage.Size = new System.Drawing.Size(533, 360);
            this.groupBoxPavage.TabIndex = 16;
            this.groupBoxPavage.TabStop = false;
            this.groupBoxPavage.Text = "Pavage";
            // 
            // radioButtonPavage2
            // 
            this.radioButtonPavage2.AutoSize = true;
            this.radioButtonPavage2.Location = new System.Drawing.Point(48, 200);
            this.radioButtonPavage2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonPavage2.Name = "radioButtonPavage2";
            this.radioButtonPavage2.Size = new System.Drawing.Size(67, 17);
            this.radioButtonPavage2.TabIndex = 2;
            this.radioButtonPavage2.Text = "Diagonal";
            this.radioButtonPavage2.UseVisualStyleBackColor = true;
            // 
            // radioButtonPavage1
            // 
            this.radioButtonPavage1.AutoSize = true;
            this.radioButtonPavage1.Location = new System.Drawing.Point(18, 69);
            this.radioButtonPavage1.Name = "radioButtonPavage1";
            this.radioButtonPavage1.Size = new System.Drawing.Size(74, 17);
            this.radioButtonPavage1.TabIndex = 1;
            this.radioButtonPavage1.Text = "Carré de 10";
            this.radioButtonPavage1.UseVisualStyleBackColor = true;
            this.radioButtonPavage1.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButtonPavage0
            // 
            this.radioButtonPavage0.AutoSize = true;
            this.radioButtonPavage0.Checked = true;
            this.radioButtonPavage0.Location = new System.Drawing.Point(18, 19);
            this.radioButtonPavage0.Name = "radioButtonPavage0";
            this.radioButtonPavage0.Size = new System.Drawing.Size(74, 17);
            this.radioButtonPavage0.TabIndex = 0;
            this.radioButtonPavage0.TabStop = true;
            this.radioButtonPavage0.Text = "Carré de 1";
            this.radioButtonPavage0.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDist2);
            this.groupBox1.Controls.Add(this.radioButtonDist1);
            this.groupBox1.Controls.Add(this.radioButtonDist0);
            this.groupBox1.Location = new System.Drawing.Point(67, 684);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(533, 255);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distance entre noeuds";
            // 
            // radioButtonDist2
            // 
            this.radioButtonDist2.AutoSize = true;
            this.radioButtonDist2.Location = new System.Drawing.Point(48, 155);
            this.radioButtonDist2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonDist2.Name = "radioButtonDist2";
            this.radioButtonDist2.Size = new System.Drawing.Size(84, 36);
            this.radioButtonDist2.TabIndex = 2;
            this.radioButtonDist2.Text = "10";
            this.radioButtonDist2.UseVisualStyleBackColor = true;
            // 
            // radioButtonDist1
            // 
            this.radioButtonDist1.AutoSize = true;
            this.radioButtonDist1.Location = new System.Drawing.Point(48, 100);
            this.radioButtonDist1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonDist1.Name = "radioButtonDist1";
            this.radioButtonDist1.Size = new System.Drawing.Size(92, 36);
            this.radioButtonDist1.TabIndex = 1;
            this.radioButtonDist1.Text = "0.1";
            this.radioButtonDist1.UseVisualStyleBackColor = true;
            // 
            // radioButtonDist0
            // 
            this.radioButtonDist0.AutoSize = true;
            this.radioButtonDist0.Checked = true;
            this.radioButtonDist0.Location = new System.Drawing.Point(48, 45);
            this.radioButtonDist0.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonDist0.Name = "radioButtonDist0";
            this.radioButtonDist0.Size = new System.Drawing.Size(68, 36);
            this.radioButtonDist0.TabIndex = 0;
            this.radioButtonDist0.TabStop = true;
            this.radioButtonDist0.Text = "1";
            this.radioButtonDist0.UseVisualStyleBackColor = true;
            // 
            // textBoxP1X
            // 
            this.textBoxP1X.Location = new System.Drawing.Point(43, 98);
            this.textBoxP1X.Name = "textBoxP1X";
            this.textBoxP1X.Size = new System.Drawing.Size(100, 20);
            this.textBoxP1X.TabIndex = 18;
            this.textBoxP1X.Text = "100";
            // 
            // textBoxP1Y
            // 
            this.textBoxP1Y.Location = new System.Drawing.Point(43, 124);
            this.textBoxP1Y.Name = "textBoxP1Y";
            this.textBoxP1Y.Size = new System.Drawing.Size(100, 20);
            this.textBoxP1Y.TabIndex = 19;
            this.textBoxP1Y.Text = "200";
            // 
            // textBoxPfX
            // 
            this.textBoxPfX.Location = new System.Drawing.Point(168, 98);
            this.textBoxPfX.Name = "textBoxPfX";
            this.textBoxPfX.Size = new System.Drawing.Size(100, 20);
            this.textBoxPfX.TabIndex = 20;
            this.textBoxPfX.Text = "200";
            // 
            // textBoxPfY
            // 
            this.textBoxPfY.Location = new System.Drawing.Point(168, 124);
            this.textBoxPfY.Name = "textBoxPfY";
            this.textBoxPfY.Size = new System.Drawing.Size(100, 20);
            this.textBoxPfY.TabIndex = 21;
            this.textBoxPfY.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Point Initial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Point Final";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Y";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = global::JoliBateau.Properties.Resources.ocean;
            this.pictureBox1.Location = new System.Drawing.Point(1023, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.comboTailleCarre.FormattingEnabled = true;
            this.comboTailleCarre.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
             
            // comboTailleCarre
            // 
            this.comboTailleCarre.FormattingEnabled = true;
            this.comboTailleCarre.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboTailleCarre.Location = new System.Drawing.Point(113, 94);
            this.comboTailleCarre.Name = "comboTailleCarre";
            this.comboTailleCarre.Size = new System.Drawing.Size(41, 21);
            this.comboTailleCarre.TabIndex = 26;
            this.comboTailleCarre.Text = "1";
            // 
            // radioButtonPavage3
            // 
            this.radioButtonPavage3.AutoSize = true;
            this.radioButtonPavage3.Location = new System.Drawing.Point(18, 94);
            this.radioButtonPavage3.Name = "radioButtonPavage3";
            this.radioButtonPavage3.Size = new System.Drawing.Size(89, 17);
            this.radioButtonPavage3.TabIndex = 26;
            this.radioButtonPavage3.Text = "Carré de taille";
            this.radioButtonPavage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3204, 1748);
            this.Controls.Add(this.pictureBox1);
            this.ClientSize = new System.Drawing.Size(1396, 792);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPfY);
            this.Controls.Add(this.textBoxPfX);
            this.Controls.Add(this.textBoxP1Y);
            this.Controls.Add(this.textBoxP1X);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxPavage);
            this.Controls.Add(this.groupCas);
            this.Controls.Add(this.labelStopwatch);
            this.Controls.Add(this.nbNoeudsSolution);
            this.Controls.Add(this.tempsSolution);
            this.Controls.Add(this.labelCountClosed);
            this.Controls.Add(this.labelCountOpen);
            this.Controls.Add(this.labelSolution);
            this.Controls.Add(this.listeSolution);
            this.Controls.Add(this.labelTreeview);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupCas.ResumeLayout(false);
            this.groupCas.PerformLayout();
            this.groupBoxPavage.ResumeLayout(false);
            this.groupBoxPavage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label labelTreeview;
        private System.Windows.Forms.ListBox listeSolution;
        private System.Windows.Forms.Label labelSolution;
        private System.Windows.Forms.Label labelCountOpen;
        private System.Windows.Forms.Label labelCountClosed;
        private System.Windows.Forms.Label tempsSolution;
        private System.Windows.Forms.Label nbNoeudsSolution;
        private System.Windows.Forms.Label labelStopwatch;
        private System.Windows.Forms.GroupBox groupCas;
        private System.Windows.Forms.GroupBox groupBoxPavage;
        private System.Windows.Forms.RadioButton radioButtonPavage2;
        private System.Windows.Forms.RadioButton radioButtonPavage1;
        private System.Windows.Forms.RadioButton radioButtonPavage0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDist2;
        private System.Windows.Forms.RadioButton radioButtonDist1;
        private System.Windows.Forms.RadioButton radioButtonDist0;
        private System.Windows.Forms.TextBox textBoxP1X;
        private System.Windows.Forms.TextBox textBoxP1Y;
        private System.Windows.Forms.TextBox textBoxPfX;
        private System.Windows.Forms.TextBox textBoxPfY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.ComboBox comboTailleCarre;
        private System.Windows.Forms.RadioButton radioButtonPavage3;

    }
}

