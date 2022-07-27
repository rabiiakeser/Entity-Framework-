using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace deneme2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)//event
        {


           // ListProductsByCategories();
            ListProducts();
        }

        
        private void ListProducts()
        {
            using (NortWindContext context = new NortWindContext())
            {
                dgwProduct.DataSource = context.Products.ToList();
                //bu satırda app.config yüzünden hata aldım.
            }
        }
        private void ListProductsByCategories(int CategoryId)
        {
            using (NortWindContext context = new NortWindContext())
            {
                dgwProduct.DataSource = context.Products.Where(x => x.CategoryId == CategoryId).ToList();
                cbxCategori.DataSource = context.Categories.ToList();
                cbxCategori.DisplayMember = "CategoryName";
                cbxCategori.ValueMember = "CategoryId";
            }

        }


    }
}
