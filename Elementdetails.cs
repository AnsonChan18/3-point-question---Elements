using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Element_details__3_points_
{
    internal class Program
    {
        //define the funtion
        static void _details()
        {
            //list properties
            List<Int16> list = new List<Int16>();
            List<string> authors = new List<string>(5);

            
            
            //list of grp 1 elements
            string[] _grp_1 = { "Lithium", "Sodium", "Potassium" };

            //list of grp 2 elements
            string[] _grp_2 = { "Berylium", "Magnesium", "Calcium" };

            //list of grp 1 element weights
            string[] _weight_1 = { "6.94","22.99","39.10" };

            //list of grp 2 element weights
            string[] _weight_2 = { "9.01", "24.31", "40.08" };

            //list of group names
            string[] grps = { "Alkali Metals", "Alkali Earth Metals" };



            //promt the user to enter the symbol
            Console.WriteLine("enter the symbol of the element in the first 2 columns (e.g. Ca):");
            
            //reads and stores the user input
            string _symbol = Console.ReadLine();


            //decisions
            //if user input is "Li"
            if (_symbol == "LI")
            {
                //output details
                Console.WriteLine(_grp_1[0]);
                Console.WriteLine(_weight_1[0]);
                Console.WriteLine(grps[0]);

            }
            
            
            //if user input is "Na"
            else if (_symbol == "Na")
            {
                Console.WriteLine("Element:" + _grp_1[1]);
                Console.WriteLine("Atomic weight: " + _weight_1[1]);
                Console.WriteLine("Group: "+grps[0]);
            }


            //if user input is "K"
            else if ( _symbol == "K")
            {
                Console.WriteLine("Element: "+_grp_1[2]);
                Console.WriteLine("Atomic weight: "+_weight_1[2]);
                Console.WriteLine("Group: "+grps[0]);
            }


            //if user input is "Be"
            else if ( _symbol == "Be")
            {
                Console.WriteLine("Element: "+_grp_2[0]);
                Console.WriteLine("Atomic weight: "+_weight_2[0]);
                Console.WriteLine("Group: " + grps[1]);
            }


            //if user input is "Mg"
            else if ( _symbol == "Mg")
            {
                Console.WriteLine("Element: "+ _grp_2[1]);
                Console.WriteLine("Atomic weight: " + _weight_2[1]);
                Console.WriteLine("Group: "+ grps[1]);
            }


            //if user input is "Ca"
            else if ( _symbol == "Ca")
            {
                Console.WriteLine("Element: "+ _grp_2[2]);
                Console.WriteLine("Atomic weight: " + _weight_2[2]);
                Console.WriteLine("Group: "+ grps[1]);
            }


            //if user input is none of the symblos
            else
            {
                //prompt the user that the symbol is not accepted
                Console.WriteLine("Invalid symbol or out of coverage.");
                //restart function
                _details();
            }

        }
        static void Main(string[] args)
        {
            //calling the function
            _details();
            //pause for user
            Console.ReadLine();
        }
    }
}
