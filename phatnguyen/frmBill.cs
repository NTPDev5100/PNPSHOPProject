﻿using Microsoft.SqlServer.Server;
using phatnguyen.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phatnguyen
{
    public partial class frmBill : Form
 
    { 
        public frmBill()
        {
            InitializeComponent();
        }

        public void Display()
        {
            using (PNPdataEntities _entity = new PNPdataEntities())
            {
                List<BillDetailsInfo> _billdetailsList = new List<BillDetailsInfo>();
                _billdetailsList = _entity.tbBillDetails_.Select(x => new BillDetailsInfo
                {
                     ID=x.ID,
                    //BillCode = x.BillCode,
                    ProductCode = x.ProductCode,
                    ProductName = x.ProductName,
                    Amount = x.Amount,
                    UnitPrice = x.UnitPrice,
                    Discount = x.Discount,
                    IntoMoney = x.IntoMoney
                }).ToList();
                dgvwBillDetails.DataSource = _billdetailsList;
            }
        }
        private void DataGridViewLoad()
        {
            dgvwBillDetails.Columns[0].Visible = false;
            dgvwBillDetails.Columns["UnitPrice"].DefaultCellStyle.Format = "0,00.## VND";
            dgvwBillDetails.Columns["IntoMoney"].DefaultCellStyle.Format = "0,00.## VND";
        }
        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtUnitPrice.Text, System.Globalization.NumberStyles.AllowThousands);
            txtUnitPrice.Text = String.Format(culture, "{0:N0}", value);
            txtUnitPrice.Select(txtUnitPrice.Text.Length, 0);
        }
        private void txtIntoMoney_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtIntoMoney.Text, System.Globalization.NumberStyles.AllowThousands);
            txtIntoMoney.Text = String.Format(culture, "{0:N0}", value);
            txtIntoMoney.Select(txtIntoMoney.Text.Length, 0);
        }
        public void SetValueStaff()
        {
            using (PNPdataEntities _entity = new PNPdataEntities())
            {
                List<tbStaff_> _staff = new List<tbStaff_>();
                _staff = _entity.tbStaff_.ToList();
                cbxStaffCode.DataSource = _staff;
                cbxStaffCode.DisplayMember = "StaffCode";
                cbxStaffCode.ValueMember = "ID";
            }
        }

        private void cbxStaffCode_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            using (PNPdataEntities _entity = new PNPdataEntities())
                if (cb.SelectedValue != null)
                {
                    tbStaff_ tbs = new tbStaff_();
                    tbs = cb.SelectedItem as tbStaff_;
                    txtStaffName.Text = tbs.Name;
                }
        }


        public void SetValueCustomer()
        {
            using (PNPdataEntities _entity = new PNPdataEntities())
            {
                List<tbCustomer_> _customer = new List<tbCustomer_>();
                _customer = _entity.tbCustomer_.ToList();
                cbxCustomerCode.DataSource = _customer;
                cbxCustomerCode.DisplayMember = "CustomerCode";
                cbxCustomerCode.ValueMember = "ID";
            }
        }


        private void cbxCustomerCode_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            using (PNPdataEntities _entity = new PNPdataEntities())
                if (cb.SelectedValue != null)
                {
                    tbCustomer_ tbc = new tbCustomer_();
                    tbc = cb.SelectedItem as tbCustomer_;
                    txtCustomerName.Text = tbc.Name;
                    txtAddressCustomer.Text = tbc.Address;
                    txtPhoneCustomer.Text = tbc.PhoneNumber;
                }
        }


        public void SetValueProduct()
        {
            using (PNPdataEntities _entity = new PNPdataEntities())
            {
                List<tbProduct_> _product = new List<tbProduct_>();
                _product = _entity.tbProduct_.ToList();
                cbxProductCode.DataSource = _product;
                cbxProductCode.DisplayMember = "ProductCode";
                cbxProductCode.ValueMember = "ID";
            }
        }


        private void cbxProductCode_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            using (PNPdataEntities _entity = new PNPdataEntities())
                if (cb.SelectedValue != null)
                {
                    tbProduct_ tbp = new tbProduct_();
                    tbp = cb.SelectedItem as tbProduct_;
                    txtProductName.Text = tbp.ProductName;
                    txtUnitPrice.Text = tbp.Price.ToString();
                }
        }
        private void frmBill_Load(object sender, EventArgs e)
        {
            btnAddBill.Enabled = true;
            btnAddProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
            txtBillCode.ReadOnly = true;
            txtStaffName.ReadOnly = true;
            txtCustomerName.ReadOnly = true;
            txtAddressCustomer.ReadOnly = true;
            txtPhoneCustomer.ReadOnly = true;
            txtProductName.ReadOnly = true;
            txtUnitPrice.ReadOnly = true;
            txtIntoMoney.ReadOnly = true;
           // txtTotal.Text = "0";
            txtDiscount.Text ="0";
            SetValueStaff();
            cbxStaffCode.SelectedIndex = -1;
            txtStaffName.Text = "";
            SetValueCustomer();
            cbxCustomerCode.SelectedIndex = -1;
            txtCustomerName.Text = "";
            txtAddressCustomer.Text = "";
            txtPhoneCustomer.Text = "";
            SetValueProduct();
            cbxProductCode.SelectedIndex = -1;
            txtProductName.Text = "";
            txtUnitPrice.Text= "0";
            //Display();
            
        }



        public void ClearFields()
        {

            cbxProductCode.SelectedIndex = -1;
            txtProductName.Text = "";
            txtUnitPrice.Text = "";
            txtAmount.Text = "";
            txtDiscount.Text = "";
            txtIntoMoney.Text = "";
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture started by the mouse down.
                panel2.Capture = false;

                // Create and send a WM_NCLBUTTONDOWN message.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }

        // Khoi tao 2 bien va tao hem co chua nang thu nho form khi click vao icon duoi thanh taskbar cua windows
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        private void btnOffBill_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReloadForm_Click(object sender, EventArgs e)
        {
            txtIntoMoney.Text = "0";
            frmBill_Load(sender, e);
        }


        public bool SaveBillDetails(tbBillDetails_ tbBillDetails_)
        {
            bool result = false;
            using (PNPdataEntities _entity = new PNPdataEntities())
            {
                _entity.tbBillDetails_.Add(tbBillDetails_);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }

        public void Total()
        {
            txtTotal.Text = "0";
            for(int i=0;i<dgvwBillDetails.Rows.Count;i++)
            {
                txtTotal.Text = Convert.ToString(double.Parse(txtTotal.Text) + double.Parse(dgvwBillDetails.Rows[i].Cells[6].Value.ToString()));
            }   
        }

        public void checktotal()
        {
            if (dgvwBillDetails.Rows.Count == 0)
            {
                txtTotal.Text = "0";
            }
            else
            {
                //txtTotal.Text = "0";
                for (int i = 0; i < dgvwBillDetails.Rows.Count; i++)
                {
                    txtTotal.Text = Convert.ToString(double.Parse(txtTotal.Text) + double.Parse(dgvwBillDetails.Rows[i].Cells[6].Value.ToString()));
                }
            }
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            tbBillDetails_ tbbilldetails = new tbBillDetails_();
            tbbilldetails.ProductCode = cbxProductCode.Text;
            tbbilldetails.ProductName = txtProductName.Text;
            tbbilldetails.Amount = Convert.ToInt32(txtAmount.Text);
            tbbilldetails.UnitPrice = Convert.ToDouble(txtUnitPrice.Text);
            tbbilldetails.Discount = Convert.ToDouble(txtDiscount.Text);
            tbbilldetails.IntoMoney = Convert.ToDouble(txtIntoMoney.Text);
            bool result = SaveBillDetails(tbbilldetails);
            if (result == true)
            {
                MessageBox.Show("Saved successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Display();
                Total();
            }
            else
            {
                MessageBox.Show("Save failed!, Please try again?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            double unitprice, discount, intomoney;
            int Am;
            if (txtAmount.Text == "")

                Am = 0;

            else

                Am = Convert.ToInt32(txtAmount.Text);

            if (txtDiscount.Text == "")

                discount = 0;

            else

                discount = Convert.ToDouble(txtDiscount.Text);

            if (txtUnitPrice.Text == "")

                unitprice = 0;

            else
            {
                unitprice = Convert.ToDouble(txtUnitPrice.Text);
                intomoney = Am * unitprice - Am * unitprice * discount/100;
                txtIntoMoney.Text = intomoney.ToString();
               //txtIntoMoney.Text=intomoney.ToString("N3").Replace(".000","");
            }

        }

        public void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            double unitprice, discount, intomoney;
            int Am;
            if (txtAmount.Text == "")

                Am = 0;

            else

                Am = Convert.ToInt32(txtAmount.Text);

            if (txtDiscount.Text == "")

                discount = 0;

            else

                discount = Convert.ToDouble(txtDiscount.Text);

            if (txtUnitPrice.Text == "")

                unitprice = 0;

            else
            {
                unitprice = Convert.ToDouble(txtUnitPrice.Text);
                intomoney = Am * unitprice - Am * unitprice * discount/100;
                txtIntoMoney.Text = intomoney.ToString();
                //txtIntoMoney.Text=intomoney.ToString("N3").Replace(".000","");
            }
        }


        private void dgvwBillDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvwBillDetails.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvwBillDetails.SelectedRows)
                {
                    lblID.Text = row.Cells[0].Value.ToString();
                    cbxProductCode.Text = row.Cells[1].Value.ToString();
                    txtProductName.Text = row.Cells[2].Value.ToString();
                    txtAmount.Text = row.Cells[3].Value.ToString();
                    txtUnitPrice.Text = row.Cells[4].Value.ToString();
                    txtDiscount.Text = row.Cells[5].Value.ToString();
                    txtIntoMoney.Text = row.Cells[6].Value.ToString();
                }
            }
        }
        //DELETE
        public bool DeleteProduct(int id)
        {
            bool result = false;
            try
            {
                using (PNPdataEntities _entity = new PNPdataEntities())
                {
                    tbBillDetails_ _billdetails = _entity.tbBillDetails_.Find(id);
                    if (_billdetails != null)
                    {
                        _entity.tbBillDetails_.Remove(_billdetails);
                        _entity.SaveChanges();
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }

        private void Resetvalue()
        {
            txtBillCode.Text = "";
            dtpDOS.Value = DateTime.Now;
            cbxStaffCode.Text = "";
            cbxCustomerCode.Text = "";
            txtTotal.Text = "0";
            cbxProductCode.Text = "";
            txtAmount.Text = "";
            txtDiscount.Text = "0";
            txtIntoMoney.Text = "0";
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int idproduct = Convert.ToInt32(lblID.Text);
                bool result = DeleteProduct(idproduct);
                if (result == true)
                {
                    MessageBox.Show("Deleted successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Display();
                    Total();
                }
                else
                {
                    MessageBox.Show("Deletion failed!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deletion failed!,Please try again?\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadDataGridView()
        {
            /*string sql;
            sql = "SELECT a.ProductName, b.ProductCode, a.Amount, b.UnitPrice, a.Discount,a.IntoMoney FROM [tbBillDetails*] AS a,[tbProduct*] AS b Where a.BillCode=N'" + txtBillCode.Text + "' AND a.ProductCode=b.ProductCode";
            DataTable tbbilldts;
            tbbilldts = Functions.GetDataToTable(sql);
            dgvwBillDetails.DataSource = tbbilldts;
            dgvwBillDetails.Columns[2].HeaderText = "ProductName";
            dgvwBillDetails.Columns[3].HeaderText = "ProductCode";
            dgvwBillDetails.Columns[6].HeaderText = "Amount"; 
            dgvwBillDetails.Columns[7].HeaderText = "UnitPrice";
            dgvwBillDetails.Columns[8].HeaderText = "Discount";
            dgvwBillDetails.Columns[9].HeaderText = "Intomoney";
            dgvwBillDetails.AllowUserToAddRows = false;
            dgvwBillDetails.EditMode = DataGridViewEditMode.EditProgrammatically;*/
        }
        private void btnAddBill_Click(object sender, EventArgs e)
        {

            //Resetvalue();
            txtBillCode.Text = Functions.CreateKey("BILL");
            btnAddProduct.Enabled = true;
            btnDeleteProduct.Enabled = true;
            //LoadDataGridView();
            Display();
            DataGridViewLoad();
            Total();

        }

        
    }
}
