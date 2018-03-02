using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TD_IA_Reconnaissance_de_forme
{
    public partial class Form1 : Form
    {
        // Voici un exemple de code associé à un bouton permettant de lire un fichier texte et
        // de remplir une matrice. On suppose que la 1ère valeur du fichier est le nombre de
        // nœuds du graphe, puis qu’il y a la liste des relations, chacune définie sur 3
        // lignes : d’abord la coordonnée x de la matrice, puis la coordonnée y, puis la
        // valeur d ou b indiquant le type de relation.
        int nbnodes;
        char[,] matrix = new char[100, 100];
      

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Si le fichier n'existe pas, on ne va pas plus loin !
            if (File.Exists("H:\\2A\\S2\\IAtoto.txt") == false) return;
            // Création d'une instance de StreamReader pour permettre la
            // lecture dans le fichier toto. A vous de donner le nom approprié
            StreamReader monStreamReader = new StreamReader("H:\\2A\\S2\\IAtoto.txt");
            string ligne = monStreamReader.ReadLine();
            nbnodes = Convert.ToInt32(ligne); // Nombre de nœuds du graphe
            for (int i = 0; i < nbnodes; i++)
                for (int j = 0; j < nbnodes; j++)
                    matrix[i, j] = '0'; // On initialise à « 0 »
            ligne = monStreamReader.ReadLine();
            while (ligne != null) // Tant qu’il reste une ligne dans le fichier
            {
                int x = Convert.ToInt32(ligne);
                ligne = monStreamReader.ReadLine();
                int y = Convert.ToInt32(ligne);
                ligne = monStreamReader.ReadLine();
                matrix[x, y] = ligne[0]; // C’est « d » ou « b » normalement
                ligne = monStreamReader.ReadLine();
            }
            // Fermeture du StreamReader (obligatoire)
            monStreamReader.Close();

          
        }


        private List<char> compteExtremite(char [,] mat)
        {
            List<int[]> Liste = new List<int[]>();
            foreach (int[] i in Liste)
            {
                
            }
 
        }

        /// <summary>
        /// Nombre de relations entrantes pour un noeud
        /// </summary>
        /// <param name="numeroNoeud"></param>
        /// <returns></returns>
        private int CompterRelationsEntrantes(int numeroNoeud)
        {
            int nbRelations = 0;
            for (int i = 0; i < nbnodes; i++)
                if (matrix[i, numeroNoeud] != '0')
                    nbRelations++;
            return nbRelations;
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Affichage dans un listbox pour vérifier les relations
            listBox1.ResetText();
            listBox1.Items.Clear();
            rtbAdjacence.ResetText();
            for (int i = 0; i < nbnodes; i++)
                for (int j = 0; j < nbnodes; j++)
                {
                    if (matrix[i, j] != '0')
                        listBox1.Items.Add(Convert.ToString(i) + ' '
                        + Convert.ToString(j) + ' '
                        + matrix[i, j]);
                    rtbAdjacence.Text += "\n";
                
                }
        }

        private int ReconnaitreChiffre(int nbnodes)
        {
            int chiffreReconnu;

            if (nbnodes == nbExtremites)
            {
                chiffreReconnu = 0;
            }
            return chiffreReconnu;

        }
    
    }
}
