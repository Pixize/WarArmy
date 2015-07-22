using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WarArmy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
   
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Annuler_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult de = MessageBox.Show("Vous allez vider l'ensemble des champs rempli précédement ?", "supprimer", MessageBoxButton.OKCancel);

            if (de == MessageBoxResult.OK)
            {
                cleanField();
        
            }
        }


        public void cleanField()
        {
            // clear of Our army
            OA_Arme.Clear();
            OA_Cdg.Clear();
            OA_Chev.Clear();
            OA_Comm.Clear();
            OA_def.Clear();
            OA_G.Clear();
            OA_Gs.Clear();
            OA_Merc.Clear();
            OA_Mut.Clear();
            OA_Nucl.Clear();
            OA_Pal.Clear();
            OA_Pil.Clear();
            OA_Prot.Clear();
            OA_SupMut.Clear();

            //cleat of ennemy army
            EA_Arme.Clear();
            EA_Cdg.Clear();
            EA_Chev.Clear();
            EA_Comm.Clear();
            EA_Def.Clear();
            EA_G.Clear();
            EA_Gs.Clear();
            EA_Merc.Clear();
            EA_Mut.Clear();
            EA_Nucl.Clear();
            EA_Pal.Clear();
            EA_Pil.Clear();
            EA_Prot.Clear();
            EA_SupMut.Clear();
        }
            
        
    }
}
