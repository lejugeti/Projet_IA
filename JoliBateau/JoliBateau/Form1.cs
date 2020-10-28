﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;

namespace JoliBateau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // on clear les solution si jamais on a lancé auparavant
            listeSolution.Items.Clear();

            // sélection du cas à traiter
            string cas;
            if (radioButton1.Checked)
            {
                cas = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                cas = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                cas = radioButton3.Text;
            }
            else cas = "a";

            // sélection du type de pavage
            int pavage;
            if (radioButtonPavage0.Checked)
            {
                pavage = radioButtonPavage0.TabIndex;
            }
            else if (radioButtonPavage1.Checked)
            {
                pavage = radioButtonPavage1.TabIndex;
            }
            else if (radioButtonPavage2.Checked)
            {
                pavage = radioButtonPavage2.TabIndex;
            }
            else if (radioButtonPavage3.Checked)
            {
                pavage = radioButtonPavage3.TabIndex;
            }
            else pavage = 0; // pavage en carré par défaut


            // sélection du type de la distance entre les noeuds. 1km par défaut
            double distance = 1;
            if (radioButtonDist0.Checked)
            {
                distance = 1;
            }
            else if (radioButtonDist1.Checked)
            {
                distance = 0.1;
            }
            else if (radioButtonDist2.Checked)
            {
                distance = 2;
            }
            else if (radioButtonDist3.Checked)
            {
                distance = 5;
            }
            else if (radioButtonDist4.Checked)
            {
                distance = 10;
            }

            Point P0 = new Point(Char.Parse(cas), pavage, distance);
            SearchTree tree = new SearchTree(pavage);
            Stopwatch stopwatch = new Stopwatch();
            
            stopwatch.Start();
            List<GenericNode> solution =  tree.RechercheSolutionAEtoile(P0); //recherche des solution d'A*
            stopwatch.Stop();

            if (solution.Count == 0)
            {
                labelSolution.Text = "Pas de solution";
            }
            else
            {
                labelSolution.Text = "Une solution a été trouvée";
                foreach (GenericNode N in solution)
                {
                    listeSolution.Items.Add(N);
                }
                labelCountOpen.Text = "Nb noeuds des ouverts : " + tree.CountInOpenList().ToString();
                labelCountClosed.Text = "Nb noeuds des fermés : " + tree.CountInClosedList().ToString();
                tree.GetSearchTree(treeView1);

                //Différents affichages pour les stats de la recherche
                GenericNode Pf = solution.Last();
                string tempsPf = Math.Round(Pf.GetGCost(), 3).ToString();
                tempsSolution.Text = $"Temps total du parcours : {tempsPf} heures";
                nbNoeudsSolution.Text = $"Nb de noeuds dans la solution : {solution.Count().ToString()}";
                labelStopwatch.Text = $"{stopwatch.Elapsed.Minutes} min {stopwatch.Elapsed.Seconds} seconds";

                // on sauvegarde les données au cas où
                StreamWriter sw = new StreamWriter($"../../Solutions/nodes_cas_{cas}_pavage_{pavage}distNoeuds_{distance}.xml");
                XmlSerializer w = new XmlSerializer(typeof(SearchTree));
                w.Serialize(sw, tree);
            }

            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
