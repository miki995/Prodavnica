using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prodavnica
{
    public partial class ShopForm : Form
    {
        List<Item> items;
        private const string FILE_PATH = @".\.\items.txt";
        private bool isDataChanged;

        public ShopForm()
        {
            InitializeComponent();
       
            items = new List<Item>();

            CenterToParent();
            isDataChanged = false;
        }

        private void showItemDetails()
        {
            NameLabel.Visible = true;
            PriceLabel.Visible = true;
            pdvLabel.Visible = true;
            kmLabel.Visible = true;
            kmLabel1.Visible = true;
        }

        public void loadItems()
        {
            string[] serializedItems = File.ReadAllLines(FILE_PATH);
            Item[] deserializedItems = new Item[serializedItems.Length];

            for (int i = 0; i < serializedItems.Length; i++)
            {
                deserializedItems[i] = Item.Deserialize(serializedItems[i]);
            }
            items.AddRange(deserializedItems); 
        }


        public void saveItems()
        {
            string[] serializedItems = new string[items.Count];

            for (int i = 0; i < items.Count; i++)
            {
                serializedItems[i] = items[i].Serialize();
            }
            File.WriteAllLines(FILE_PATH,serializedItems);
        }

        private void shopListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item current = selectedItem();
            showItemDetails();
            fillShopItems(current);

        }


        private void fillShopItems(Item shop)
        {
            NameLabel.Text = shop.Name;
            PriceLabel.Text = shop.Price.ToString();
            pdvLabel.Text = shop.PDV(shop);

        }
        private void clearShopItems()
        {
            NameTextBox.Text = "";
            QuantityTextBox.Text = "";
            PriceTextBox.Text = "";
            NameWarning.Visible = false;
            QuantityWarning.Visible = false;
            PriceWarning.Visible = false;
        }


        private Item selectedItem()
        {
            return items[itemsListBox.SelectedIndex];
        }

        private void okButton_Click(object sender, EventArgs e)
        {

            if (NameTextBox.Text.Length == 0) { NameWarning.Visible = true; } else NameWarning.Visible = false;
            if (QuantityTextBox.Text.Length == 0) { QuantityWarning.Visible = true; } else QuantityWarning.Visible = false;
            if (PriceTextBox.Text.Length == 0) { PriceWarning.Visible = true; } else PriceWarning.Visible = false;

            try
            {

             string name = NameTextBox.Text;
             string quantity = QuantityTextBox.Text;
             double price = Double.Parse(PriceTextBox.Text);

          
                Item newShop = new Item(name, quantity, price);
                
                itemsListBox.Items.Add(newShop);
                items.Add(newShop);
                MessageBox.Show("Uspjesno dodat artikal");

                clearShopItems();
                isDataChanged = true;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
          
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            loadItems();
            itemsListBox.Items.AddRange(items.ToArray());
        }

        private void ShopForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isDataChanged)
            {
                DialogResult result = MessageBox.Show("Da li zelite da sacuvate promene?","Upozorenje",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    saveItems();
                }
                else if(result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Length == 0) { NameWarning.Visible = true; } else NameWarning.Visible = false;
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (QuantityTextBox.Text.Length == 0) { QuantityWarning.Visible = true; } else QuantityWarning.Visible = false;
        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PriceTextBox.Text.Length == 0) { PriceWarning.Visible = true; } else PriceWarning.Visible = false;
        }
    }
}
