using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VictorJOlivoRamirez_InventoryManagementSystem2
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            PaintDgvs();
            
        }


        //Populates the Data Grid Views with the lists data
        public void PaintDgvs()
        {
            mainPartsDgv.DataSource = Inventory.AllParts;
            mainProductsDgv.DataSource = Inventory.Products;
            
        }

        //Part search/lookup
        private void mainPartSearchButton_Click(object sender, EventArgs e)
        {
            ClearSelection();
            bool found = false;

            if (!(string.IsNullOrWhiteSpace(mainPartSearchTextBox.Text)))
            {
                for(int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(mainPartSearchTextBox.Text.ToUpper()) ||
                        Convert.ToString(Inventory.AllParts[i].PartID).Contains(mainPartSearchTextBox.Text))
                    {
                        found = true;
                        mainPartsDgv.Rows[i].Selected = true;
                        mainPartsDgv.CurrentCell = mainPartsDgv[0, i];
                        Program.mainPartsRowSelectionIdx = i;
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }
        }

        //Product search/lookup
        private void mainProductSearchButton_Click(object sender, EventArgs e)
        {
            ClearSelection();
            bool found = false;

            if (!(string.IsNullOrWhiteSpace(mainProductSearchTextBox.Text)))
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(mainProductSearchTextBox.Text.ToUpper()) ||
                        Convert.ToString(Inventory.Products[i].ProductID).Contains(mainProductSearchTextBox.Text))
                    {
                        found = true;
                        mainProductsDgv.Rows[i].Selected = true;
                        mainProductsDgv.CurrentCell = mainProductsDgv[0, i];
                        Program.mainProductsRowSelectionIdx = i;
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }
        }

        //Add Part Screen launches
        private void mainAddPartButton_Click(object sender, EventArgs e)
        {
            Program.modifyPart = false;
            this.Hide();
            PartScreen pS = new PartScreen();
            pS.Show();
        }

        //Modify Part Screen launches
        //Ensures the user has made a selection first
        private void mainModifyPartButton_Click(object sender, EventArgs e)
        {
            if(mainPartsDgv.CurrentCell == null)
            {
                MessageBox.Show("Please make a selection");
            }
            else
            {
                //Closes Main Screen and opens Modify Part Screen
                Program.modifyPart = true;
                this.Hide();
                PartScreen pS = new PartScreen();
                pS.Show();
            }
        }

        //Deletes a part by calling the Inventory DeletePart method.
        //Ensures the user has made a selection first
        private void mainDeletePartButton_Click(object sender, EventArgs e)
        {
            if (mainPartsDgv.CurrentCell == null)
            {
                MessageBox.Show("Please make a selection");
            }
            else
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this part?",
                    "",MessageBoxButtons.YesNo);
                if(confirm == DialogResult.Yes)
                {
                    Inventory.DeletePart(Inventory.AllParts[Program.mainPartsRowSelectionIdx]);
                    ClearSelection();
                }
                
            }

           
        }

        //Add Product Screen launches
        private void mainAddProductButton_Click(object sender, EventArgs e)
        {
            Program.currentProductIdx = Program.mainProductsRowSelectionIdx;
            //Closes Main Screen and opens Add Product Screen
            Program.modifyProduct = false;
            this.Hide();
            ProductScreen pS = new ProductScreen();
            pS.Show();
        }

        //Modify Product Screen launches
        //Ensures the user has made a selection first
        private void mainModifyProductButton_Click(object sender, EventArgs e)
        {
            if (mainProductsDgv.CurrentCell == null)
            {
                MessageBox.Show("Please make a selection");
            }
            else
            {
                //Closes Main Screen and opens Product Screen with 'Modify Product' as title
                Program.modifyProduct = true;
                Program.currentProductIdx = Program.mainProductsRowSelectionIdx;
                this.Hide();
                ProductScreen pS = new ProductScreen();
                pS.Show();
            }
        }

        //Attemps to delete a product by calling the Inventory RemoveProduct method.
        //Ensures the user has made a selection first
        private void mainDeleteProductButton_Click(object sender, EventArgs e)
        {
            if (mainProductsDgv.CurrentCell == null)
            {
                MessageBox.Show("Please make a selection");
            }
            //Checks that the product selected for deletion has no associated parts
            else if (Inventory.Products[Program.mainProductsRowSelectionIdx].AssociatedParts.Count != 0)
            {
                MessageBox.Show("Cannot delete a product with associated parts. Please delete any associated parts first.");
            }
            else
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this product?",
                    "", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    Inventory.RemoveProduct(Program.mainProductsRowSelectionIdx);
                    ClearSelection();
                }
            }

            
        }


        //Closes the aplication (ends program) using the 'Exit' button
        private void mainExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        //Closes the aplication (ends program) using the 'X' button
        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }



        //Determine index of current selection for both Data Grid Views
        private void mainPartsDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.mainPartsRowSelectionIdx = e.RowIndex;
        }

        private void mainProductsDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.mainProductsRowSelectionIdx = e.RowIndex;
        }



        //Clears the default selection of both Data Grid Views when form loads
        private void MainScreen_Shown(object sender, EventArgs e)
        {
            ClearSelection();
        }

        //Helper method: Custom ClearSelection() method; Clears any selection on the DGVs
        private void ClearSelection()
        {
            mainPartsDgv.ClearSelection();
            mainProductsDgv.ClearSelection();
            mainPartsDgv.CurrentCell = null;
            mainProductsDgv.CurrentCell = null;
        }

        private void mainPartSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ClearSelection();
        }

        private void mainProductSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ClearSelection();
        }
    }
}
