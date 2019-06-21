using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_Hope_Final_version
{
    public partial class Form1 : Form
    {
        List<Recipe> recipes = new List<Recipe>();
        Recipe recipe;

        public Form1()
        {
            InitializeComponent();
        }

        private void BT_MakeMeal_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        public void UpdateListBox()
        {
            recipe = (Recipe)listBox1.SelectedItem;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            foreach (Recipe recipe in recipes)
            {
                listBox1.Items.Add(recipe);
            }
            foreach (Stock item in recipe.items)
            {
                listBox2.Items.Add(item);
            }
        }
    }
}
