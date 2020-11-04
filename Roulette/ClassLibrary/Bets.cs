using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Bets
    {
        public List<string> Gambeling()
        {
            List<string> results = new List<string>();
            Arrays rouletteNumbers = new Arrays();
            Random spin = new Random();
            int a = spin.Next(0, 38);
            string b = rouletteNumbers.roulette[a];
            int e = int.Parse(b);

            results.Add($"The ball landed on : {b} and the payout is 35 to 1");

            string z = Color(b);
            results.Add(z);

            if (e != 0)
            {

                if (e % 2 == 0) results.Add("The number is even and the payout is 1 to 1");
                else results.Add("The number is odd and the payout is 1 to 1");
            }

            if (e <= 18 && e != 0) results.Add("The number is low and the payout is 1 to 1");
            else if(e >= 18 && e != 0) results.Add("The number is high and the payout is 1 to 1");

            if (e <= 12 && e != 0) results.Add("The number is in the 1st dozen and the payout is 2 to 1");
            else if (e >= 13 && e <= 24 && e != 0) results.Add("The number is in the 2nd dozen and the payout is 2 to 1");
            else if (e >= 25 && e != 0) results.Add("The number is in the 3rd dozen and the payout is 2 to 1");

            string x = Column(b);
            results.Add(x);

            x = Steet(b);
            results.Add(x);

            x = Sixline(b);
            results.Add(x);

            string g;
            string h;
            (g, h) = SplitCornerBets(b);
            results.Add(g);
            results.Add(h);
            return results;
        }
        private (string, string) SplitCornerBets(string b)
        {
            string a = "";
            string c = "";

            switch (b)
            {
                case "1":
                    a = ("Split Bets : 1/2 and 1/5 and the payout is 17 to 1");
                    c = ("Corner Bets : 1/2/4/5 and the payout is 8 to 1");
                    break;
                case "2":
                    a =("Split Bets : 1/2 and 2/3 and 2/5 and the payout is 17 to 1");
                    c = ("Corner Bets : 1/2/4/5 and 2/3/5/6 and the payout is 8 to 1");
                    break;
                case "3":
                    a = ("Split Bets : 2/3 and 3/6 and the payout is 17 to 1");
                    c = ("Corner Bets : 2/3/5/6 and the payout is 8 to 1");
                    break;
                case "4":
                    a = ("Split Bets : 1/4 and 4/5 and 4/7 and the payout is 17 to 1");
                    c = ("Corner Bets : 1/2/4/5 and 4/5/7/8 and the payout is 8 to 1");
                    break;
                case "5":
                    a = ("Split Bets : 2/5 and 5/6 and 5/8 and 4/5 and the payout is 17 to 1");
                    c = ("Corner Bets : 1/2/4/5 and 2/3/5/6 and 4/5/7/8 and 5/6/8/9 and the payout is 8 to 1");
                    break;
                case "6":
                    a = ("Split Bets : 3/6 and 5/6 and 6/9 and the payout is 17 to 1");
                    c = ("Corner Bets : 2/3/5/6 and 5/6/8/9 and the payout is 8 to 1");
                    break;
                case "7":
                    a = ("Split Bets : 4/7 and 7/8 and 7/10 and the payout is 17 to 1");
                    c = ("Corner Bets : 4/5/7/8 and 7/8/10/11 and the payout is 8 to 1");
                    break;
                case "8":
                    a = ("Split Bets : 5/8 and 8/9 and 8/11 and 7/8 and the payout is 17 to 1");
                    c = ("Corner Bets : 4/5/7/8 and 5/6/8/9 and 7/8/10/11 and 8/9/11/12 and the payout is 8 to 1");
                    break;
                case "9":
                    a = ("Split Bets : 6/9 and 8/9 and 9/12 and the payout is 17 to 1");
                    c = ("Corner Bets : 5/6/8/9 and 8/9/11/12 and the payout is 8 to 1");
                    break;
                case "10":
                    a = ("Split Bets : 7/10 and 10/11 and 10/13 and the payout is 17 to 1");
                    c = ("Corner Bets : 7/8/10/11 and 10/11/13/14 and the payout is 8 to 1");
                    break;
                case "11":
                    a = ("Split Bets : 8/11 and 11/12 and 11/14 and 10/11 and the payout is 17 to 1");
                    c = ("Corner Bets : 7/8/10/11 and 8/9/11/12 and 10/11/13/14 and 11/12/14/15 and the payout is 8 to 1");
                    break;
                case "12":
                    a = ("Split Bets : 9/12 and 11/12 and 12/15 and the payout is 17 to 1");
                    c = ("Corner Bets : 8/9/11/12 and 11/12/14/15 and the payout is 8 to 1");
                    break;
                case "13":
                    a = ("Split Bets : 10/13 and 13/14 and 13/16 and the payout is 17 to 1");
                    c = ("Corner Bets : 10/11/13/14 and 13/14/16/17 and the payout is 8 to 1");
                    break;
                case "14":
                    a = ("Split Bets : 11/14 and 14/15 and 14/17 and 13/14 and the payout is 17 to 1");
                    c = ("Corner Bets : 10/11/13/14 and 11/12/14/15 and 13/14/16/17 and 14/15/17/18 and the payout is 8 to 1");
                    break;
                case "15":
                    a = ("Split Bets : 12/15 and 14/15 and 15/18 and the payout is 17 to 1");
                    c = ("Corner Bets : 11/12/14/15 and 14/15/17/18 and the payout is 8 to 1");
                    break;
                case "16":
                    a = ("Split Bets : 13/16 and 16/17 and 16/19 and the payout is 17 to 1");
                    c = ("Corner Bets : 13/14/16/17 and 16/17/19/20 and the payout is 8 to 1 and the payout is 8 to 1");
                    break;
                case "17":
                    a = ("Split Bets : 14/17 and 17/18 and 17/20 and 16/17 and the payout is 17 to 1");
                    c = ("Corner Bets : 13/14/16/17 and 14/15/17/18 and 16/17/19/20 and 17/18/20/21 and the payout is 8 to 1");
                    break;
                case "18":
                    a = ("Split Bets : 15/18 and 17/18 and 18/21 and the payout is 17 to 1");
                    c = ("Corner Bets : 14/15/17/18 and 17/18/20/21 and the payout is 8 to 1");
                    break;
                case "19":
                    a = ("Split Bets : 16/19 and 19/20 and 19/22 and the payout is 17 to 1");
                    c = ("Corner Bets : 16/17/19/20 and 19/20/22/23 and the payout is 8 to 1");
                    break;
                case "20":
                    a = ("Split Bets : 17/20 and 20/21 and 20/23 and 19/20 and the payout is 17 to 1");
                    c = ("Corner Bets : 16/17/19/20 and 17/18/20/21 and 19/20/22/23 and 20/21/23/24 and the payout is 8 to 1");
                    break;
                case "21":
                    a = ("Split Bets : 18/21 and 20/21 and 21/24 and the payout is 17 to 1");
                    c = ("Corner Bets : 17/18/20/21 and 20/21/23/24 and the payout is 8 to 1");
                    break;
                case "22":
                    a = ("Split Bets : 19/22 and 22/23 and 22/25 and the payout is 17 to 1");
                    c = ("Corner Bets : 19/20/22/23 and 22/23/25/26 and the payout is 8 to 1");
                    break;
                case "23":
                    a = ("Split Bets : 20/23 and 23/24 and 23/26 and 22/23 and the payout is 17 to 1");
                    c = ("Corner Bets : 19/20/22/23 and 20/21/23/24 and 22/23/25/26 and 23/24/26/27 and the payout is 8 to 1");
                    break;
                case "24":
                    a = ("Split Bets : 21/24 and 23/24 and 24/27 and the payout is 17 to 1");
                    c = ("Corner Bets : 20/21/23/24 and 23/24/26/27 and the payout is 8 to 1");
                    break;
                case "25":
                    a = ("Split Bets : 22/25 and 25/26 and 25/28 and the payout is 17 to 1");
                    c = ("Corner Bets : 22/23/25/26 and 25/26/28/29 and the payout is 8 to 1");
                    break;
                case "26":
                    a = ("Split Bets : 23/26 and 26/27 and 26/29 and 25/26 and the payout is 17 to 1");
                    c = ("Corner Bets : 22/23/25/26 and 23/24/26/27 and 25/26/28/29 and 26/27/29/30 and the payout is 8 to 1");
                    break;
                case "27":
                    a = ("Split Bets : 24/27 and 26/27 and 27/30 and the payout is 17 to 1");
                    c = ("Corner Bets : 23/24/26/27 and 26/27/29/30 and the payout is 8 to 1");
                    break;
                case "28":
                    a = ("Split Bets : 25/28 and 28/29 and 28/31 and the payout is 17 to 1");
                    c = ("Corner Bets : 25/26/28/29 and 28/29/31/32 and the payout is 8 to 1");
                    break;
                case "29":
                    a = ("Split Bets : 26/29 and 29/30 and 29/32 and 28/29 and the payout is 17 to 1");
                    c = ("Corner Bets : 25/26/28/29 and 26/27/29/30 and 28/29/31/32 and 29/30/32/33 and the payout is 8 to 1");
                    break;
                case "30":
                    a = ("Split Bets : 27/30 and 29/30 and 30/33 and the payout is 17 to 1");
                    c = ("Corner Bets : 26/27/29/30 and 29/30/32/33 and the payout is 8 to 1");
                    break;
                case "31":
                    a = ("Split Bets : 28/31 and 31/32 and 31/34 and the payout is 17 to 1");
                    c = ("Corner Bets : 28/29/31/32 and 31/32/34/35 and the payout is 8 to 1");
                    break;
                case "32":
                    a = ("Split Bets : 29/32 and 32/33 and 32/35 and 31/32 and the payout is 17 to 1");
                    c = ("Corner Bets : 28/29/31/32 and 29/30/32/33 and 31/32/34/35 and 32/33/35/36 and the payout is 8 to 1");
                    break;
                case "33":
                    a = ("Split Bets : 30/33 and 32/33 and 33/36 and the payout is 17 to 1");
                    c = ("Corner Bets : 29/30/32/33 and 32/33/35/36 and the payout is 8 to 1");
                    break;
                case "34":
                    a = ("Split Bets : 31/34 and 34/35 and the payout is 17 to 1");
                    c = ("Corner Bets : 31/32/34/35 and the payout is 8 to 1");
                    break;
                case "35":
                    a = ("Split Bets : 32/35 and 35/36 and 34/35 and the payout is 17 to 1");
                    c = ("Corner Bets : 31/32/34/35 and 32/33/35/36 and the payout is 8 to 1");
                    break;
                case "36":
                    a = ("Split Bets : 33/36 and 35/36 and the payout is 17 to 1");
                    c = ("Corner Bets : 32/33/35/36 and the payout is 8 to 1");
                    break;
            }

            return (a, c);
        }
        private string Color(string b)
        {
            Arrays rouletteNumbers = new Arrays();
            string a = "";
            foreach (string c in rouletteNumbers.red)
            {
                if (b == c) a = ("The color is red and the payout is 1 to 1");
            }
            foreach (string c in rouletteNumbers.black)
            {
                if (b == c) a = ("The color is black and the payout is 1 to 1");
            }
            foreach (string c in rouletteNumbers.green)
            {
                if (b == c) a = ("The color is green and the payout is 17 to 1 for top row");
            }
            return a;
        }
        private string Column(string b)
        {
            Arrays rouletteNumbers = new Arrays();
            string a = "";

            foreach (string c in rouletteNumbers.column1)
            {
                if (b == c) a = ("The number is in the 1st column and the payout is 2 to 1");
            }
            foreach (string c in rouletteNumbers.column2)
            {
                if (b == c) a = ("The number is in the 2nd column and the payout is 2 to 1");
            }
            foreach (string c in rouletteNumbers.column3)
            {
                if (b == c) a = ("The number is in the 3rd column and the payout is 2 to 1");
            }

            return a;
        }
        private string Steet(string b)
        {
            Arrays rouletteNumbers = new Arrays();
            string a = "";

            foreach (string c in rouletteNumbers.street1)
            {
                if (b == c) a = "The number is in the 1st street and the payout is 17 to 1";
            }
            foreach (string c in rouletteNumbers.street2)
            {
                if (b == c) a = "The number is in the 2nd street and the payout is 17 to 1";
            }
            foreach (string c in rouletteNumbers.street3)
            {
                if (b == c) a = "The number is in the 3rd street and the payout is 17 to 1";
            }
            foreach (string c in rouletteNumbers.street4)
            {
                if (b == c) a = "The number is in the 4th street and the payout is 17 to 1";
            }
            foreach (string c in rouletteNumbers.street5)
            {
                if (b == c) a = "The number is in the 5th street and the payout is 17 to 1";
            }
            foreach (string c in rouletteNumbers.street6)
            {
                if (b == c) a = "The number is in the 6th street and the payout is 17 to 1";
            }
            foreach (string c in rouletteNumbers.street7)
            {
                if (b == c) a = "The number is in the 7th street and the payout is 17 to 1";
            }
            foreach (string c in rouletteNumbers.street8)
            {
                if (b == c) a = "The number is in the 8th street and the payout is 17 to 1";
            }
            foreach (string c in rouletteNumbers.street9)
            {
                if (b == c) a = "The number is in the 9th street and the payout is 17 to 1";
            }
            foreach (string c in rouletteNumbers.street10)
            {
                if (b == c) a = "The number is in the 10th street and the payout is 17 to 1";
            }
            foreach (string c in rouletteNumbers.street11)
            {
                if (b == c) a = "The number is in the 11th street and the payout is 17 to 1";
            }
            foreach (string c in rouletteNumbers.street12)
            {
                if (b == c) a = "The number is in the 12th street and the payout is 17 to 1";
            }

            return a;
        }
        private string Sixline(string b)
        {
            Arrays rouletteNumbers = new Arrays();
            string a = "";

            foreach (string c in rouletteNumbers.sixline1)
            {
                if (b == c) a = "The number is in the 1st double street and the payout is 11 to 1";
            }
            foreach (string c in rouletteNumbers.sixline2)
            {
                if (b == c) a = "The number is in the 2nd double street and the payout is 11 to 1";
            }
            foreach (string c in rouletteNumbers.sixline3)
            {
                if (b == c) a = "The number is in the 3rd double street and the payout is 11 to 1";
            }
            foreach (string c in rouletteNumbers.sixline4)
            {
                if (b == c) a = "The number is in the 4th double street and the payout is 11 to 1";
            }
            foreach (string c in rouletteNumbers.sixline5)
            {
                if (b == c) a = "The number is in the 5th double street and the payout is 11 to 1";
            }
            foreach (string c in rouletteNumbers.sixline6)
            {
                if (b == c) a = "The number is in the 6th double street and the payout is 11 to 1";
            }
            return a;
        }
    }
}
