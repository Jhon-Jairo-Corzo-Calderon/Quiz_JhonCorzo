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

namespace QuizJhonCorzo
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {

        public MainPage()
        {
            InitializeComponent();

            classesCombobx.Items.Add("Mage");
            classesCombobx.Items.Add("Warrior");
            classesCombobx.Items.Add("Hunter");
            classesCombobx.Items.Add("Monk");

        }

        public class CharAttributes
        {
            public string CharName { get; set; }
            public string CharGender { get; set; }
            public string CharClass { get; set; }
            public string CharBirthDate { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Extraer Datos del nombre
            string charName = txtCharName.Text;
            
            //Extraer Dato del genero
            bool charmale = (bool)checkCharMale.IsChecked;
            bool charfemale = (bool)checkCharFemale.IsChecked;
            bool charother = (bool)checkCharOther.IsChecked;

            string charGenre;

            if (charmale)
            {
                charGenre = checkCharMale.Content.ToString();
            }
            else if (charfemale)
            {
                charGenre = checkCharFemale.Content.ToString();
            }
            else if (charother)
            {
                charGenre = checkCharFemale.Content.ToString();
            }
            else
            {
                charGenre = "No gender chosen.";
            }

            //Extraer Clase y evitar error
            string charClass;
            if (classesCombobx.SelectedItem == null)
            {
                charClass = "No class chosen";
            }
            else
            {
                charClass = classesCombobx.SelectedItem.ToString();
            }
            

            //Extraer fecha de nacimiento y evitar error
            string charBirthDate;

            if (calendarCharDateBirth.SelectedDate == null)
            {
                charBirthDate = "No date choosen";
            }
            else
            {
                charBirthDate = calendarCharDateBirth.SelectedDate.Value.ToString();

                charBirthDate = charBirthDate.Remove(10);
            }
            
            //Mostrar los datos en pantalla o en el caso de que no esten todos los datos, aparecera una ventana advirtiendo esto.

            if (charName=="" || charGenre== "No gender chosen." || charClass== "No class chosen" || charBirthDate== "No date choosen")
            {
                MessageBox.Show("Please choose all the atributes for your character.");
            }
            else
            {
                CharAttributes character = new CharAttributes();

                character.CharName = charName;
                character.CharGender = charGenre;
                character.CharClass = charClass;
                character.CharBirthDate = charBirthDate;

                dataChar.Items.Add(character);
            }
            
            
        }

        private void checkCharMale_Checked(object sender, RoutedEventArgs e)
        {
            checkCharFemale.Visibility = Visibility.Hidden;
            checkCharOther.Visibility = Visibility.Hidden;
        }

        private void checkCharMale_Unchecked(object sender, RoutedEventArgs e)
        {
            checkCharFemale.Visibility = Visibility.Visible;
            checkCharOther.Visibility = Visibility.Visible;
        }

        private void checkCharFemale_Checked(object sender, RoutedEventArgs e)
        {
            checkCharMale.Visibility = Visibility.Hidden;
            checkCharOther.Visibility = Visibility.Hidden;
        }

        private void checkCharFemale_Unchecked(object sender, RoutedEventArgs e)
        {
            checkCharMale.Visibility = Visibility.Visible;
            checkCharOther.Visibility = Visibility.Visible;
        }

        private void checkCharOther_Checked(object sender, RoutedEventArgs e)
        {
            checkCharMale.Visibility = Visibility.Hidden;
            checkCharFemale.Visibility = Visibility.Hidden;
        }
        private void checkCharOther_Unchecked(object sender, RoutedEventArgs e)
        {
            checkCharMale.Visibility = Visibility.Visible;
            checkCharFemale.Visibility = Visibility.Visible;
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.loginFrame.Visibility = Visibility.Visible;
            w.mainFrame.Visibility = Visibility.Hidden;
        }
    }
}
