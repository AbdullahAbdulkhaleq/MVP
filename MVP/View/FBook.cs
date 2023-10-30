using MVP.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP.View
{
    public partial class FBook : Form, IBook
    {
        private BookPresenter presenter = null;

        public string Title { get => TxtTitle.Text; set => TxtTitle.Text = value; }
        public string Author { get => TxtAuthor.Text; set => TxtAuthor.Text = value; }
        public DateTime Year { get => DTBYear.Value; set => DTBYear.Value = value; }

        public FBook()
        {
            InitializeComponent();
            presenter = new BookPresenter(this);
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if(presenter.Insert())
            {
                MessageBox.Show("Insert Successfully");
            }
            else
            {
                MessageBox.Show("Error in Insert");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (presenter.Update())
            {
                MessageBox.Show("Update Successfully");
            }
            else
            {
                MessageBox.Show("Update in Insert");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (presenter.Delete())
            {
                MessageBox.Show("Delete Successfully");
            }
            else
            {
                MessageBox.Show("Delete in Insert");
            }
        }
    }
}
