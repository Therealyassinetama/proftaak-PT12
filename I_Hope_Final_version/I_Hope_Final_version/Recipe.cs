using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Hope_Final_version
{
    class Recipe
    {
        public List<Stock> items = new List<Stock>();

        private string name;
        private int calories;

        public Recipe()
        {

        }

        public string Naam { get; set; }
        public int Calories { get; set; }
    }
}
