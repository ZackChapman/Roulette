using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Arrays
    {
        /* public string[,] rouletteTable = new string[38,2] 
 {
     { "0","Green"}, {"00","Green"},
     {"1","Red"}, {"2","Black"}, {"3","Red"},
     {"4","Black"}, {"5","Red"}, {"6","Black"},
     {"7","Red"}, {"8","Black"}, {"9","Red"},
     {"10","Black"},{"11","Black"}, {"12","Red"}, 
     {"13","Black"}, { "14","Red"}, { "15","Black"}, 
     { "16","Red"}, { "17","Black"}, { "18","Red"}, 
     { "19","Red"}, { "20","Black"}, { "21","Red"}, 
     { "22","Black"}, { "23","Red"}, { "24","Black"}, 
     { "25","Red"}, { "26","Black"}, { "27","Red"}, 
     { "28","Black"}, { "29","Black"}, { "30","Red"}, 
     { "31","Black"}, { "32","Red"}, { "33","Black"}, 
     { "34","Red"}, { "35","Black"}, { "36","Red"}
 };
*/
        public string[] roulette = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "00", };
        public string[] red = new string[] { "1", "3", "5", "7", "9", "12", "14", "16", "18", "19", "21", "23", "25", "27", "30", "32", "34", "36" };
        public string[] black = new string[] { "2", "4", "6", "8", "10", "11", "13", "15", "17", "20", "22", "24", "26", "28", "29", "31", "33", "35" };
        public string[] green = new string[] { "0", "00" };
        public string[] street1 = new string[] { "1", "2", "3" };
        public string[] street2 = new string[] { "4", "5", "6" };
        public string[] street3 = new string[] { "7", "8", "9" };
        public string[] street4 = new string[] { "10", "11", "12" };
        public string[] street5 = new string[] { "13", "14", "15" };
        public string[] street6 = new string[] { "16", "17", "18" };
        public string[] street7 = new string[] { "19", "20", "21" };
        public string[] street8 = new string[] { "22", "23", "24" };
        public string[] street9 = new string[] { "25", "26", "27" };
        public string[] street10 = new string[] { "28", "29", "30" };
        public string[] street11 = new string[] { "31", "32", "33" };
        public string[] street12 = new string[] { "34", "35", "36" };
        public string[] sixline1 = new string[] { "1", "2", "3", "4", "5", "6" };
        public string[] sixline2 = new string[] { "7", "8", "9", "10", "11", "12" };
        public string[] sixline3 = new string[] { "13", "14", "15", "16", "17", "18" };
        public string[] sixline4 = new string[] { "19", "20", "21", "22", "23", "24" };
        public string[] sixline5 = new string[] { "25", "26", "27", "28", "29", "30" };
        public string[] sixline6 = new string[] { "31", "32", "33", "34", "35", "36" };
        public string[] column3 = new string[] { "3", "6", "9", "12", "15", "18", "21", "24", "27", "30", "33", "36"};
        public string[] column2 = new string[] { "2", "5", "8", "11", "14", "17", "20", "23", "26", "29", "32", "35" };
        public string[] column1 = new string[] { "1", "4", "7", "10", "13", "16", "19", "22", "25", "28", "31", "34" };
    }    
}
