using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

namespace JoliBateau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            radioButtonCasA.CheckedChanged += new EventHandler(radioButtonCas_Changed);
            radioButtonCasB.CheckedChanged += new EventHandler(radioButtonCas_Changed);
            radioButtonCasC.CheckedChanged += new EventHandler(radioButtonCas_Changed);
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
            if (radioButtonCasA.Checked)
            {
                cas = radioButtonCasA.Text;
            }
            else if (radioButtonCasB.Checked)
            {
                cas = radioButtonCasB.Text;
            }
            else if (radioButtonCasC.Checked)
            {
                cas = radioButtonCasC.Text;
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
            double distance;
            if (radioButtonPavage3.Checked) distance = Int32.Parse(comboTailleCarre.Text);
            else distance = 1;

            Point P0 = new Point(Int32.Parse(textBoxP1X.Text), Int32.Parse(textBoxP1Y.Text), Char.Parse(cas), pavage, distance);
            Point.Pf = new Point(Int32.Parse(textBoxPfX.Text), Int32.Parse(textBoxPfY.Text));

            SearchTree tree = new SearchTree();
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
                nbNoeudsSolution.Text = $"Nb de noeuds dans la solution : {solution.Count()}";
                labelStopwatch.Text = $"Temps écoulé A* : {stopwatch.Elapsed.Minutes} min {stopwatch.Elapsed.Seconds} seconds";
            }
        }

        private void radioButtonCas_Changed(object sender, EventArgs e)
        {
            var radio = groupCas.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (radio.Text == "a")
            {
                textBoxP1X.Text = "100";
                textBoxP1Y.Text = "200";
                textBoxPfX.Text = "200";
                textBoxPfY.Text = "100";
            }
            else if (radio.Text == "b")
            {
                textBoxP1X.Text = "100";
                textBoxP1Y.Text = "200";
                textBoxPfX.Text = "200";
                textBoxPfY.Text = "100";
            }
            else if (radio.Text == "c")
            {
                textBoxP1X.Text = "200";
                textBoxP1Y.Text = "100";
                textBoxPfX.Text = "100";
                textBoxPfY.Text = "200";
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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
