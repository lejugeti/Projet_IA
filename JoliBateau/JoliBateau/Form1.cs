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
using System.Xml.Serialization;

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

            int methode = 2;
            Point P0 = new Point(Char.Parse(cas));
            SearchTree tree = new SearchTree(methode);
            List<GenericNode> solution =  tree.RechercheSolutionAEtoile(P0);

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
            }

            GenericNode Pf = solution.Last();
            string tempsPf = Math.Round(Pf.GetGCost(), 3).ToString();
            tempsSolution.Text = $"Temps total du parcours : {tempsPf} heures";
            nbNoeudsSolution.Text = $"Nb de noeuds dans la solution : {solution.Count().ToString()}";

            StreamWriter sw = new StreamWriter($"../../Solutions/nodes_cas_{cas}_step_{P0.distNoeud}.xml");
            XmlSerializer w = new XmlSerializer(typeof(SearchTree));
            w.Serialize(sw, tree);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
