namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        int TotalCost = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void mainbox_Enter(object sender, EventArgs e)
        {
            if (rdoHamBurger.Checked)
            {
                TotalCost += 5000;
            }
            else if (rdoBulgogiBurger.Checked)
            {
                TotalCost += 4000;
            }
            else if (rdoChickenBurger.Checked)
            {
                TotalCost += 3000;
            }
        }

        private void subbox_Enter(object sender, EventArgs e)
        {
            if (chkPotato.Checked)
            {
                TotalCost += 3500;
            }
            if (chkCola.Checked)
            {
                TotalCost += 2500;
            }
            if (chkCheese.Checked)
            {
                TotalCost += 1500;
            }
            if (chkSauce.Checked)
            {
                TotalCost += 500;
            }
        }

        private void lstOrder_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (rdoHamBurger.Checked)
            {
                TotalCost += 5000;
                lstOrder.Items.Add("햄버거5,000원");
            }
            if (rdoBulgogiBurger.Checked)
            {
                TotalCost += 4000;
                lstOrder.Items.Add("불고기버거4,000원");
            }
            if (rdoChickenBurger.Checked)
            {
                TotalCost += 3000;
                lstOrder.Items.Add("치킨버거3,000원");
            }
            if (chkPotato.Checked)
            {
                TotalCost += 3500;
                lstOrder.Items.Add("감자튀김: 3,500원");
            }
            if (chkCola.Checked)
            {
                TotalCost += 2500;
                lstOrder.Items.Add("콜라: 2,500원");
            }
            if (chkCheese.Checked)
            {
                TotalCost += 1500;
                lstOrder.Items.Add("치즈추가1,500원");
            }
            if (chkSauce.Checked)
            {
                TotalCost += 500;
                lstOrder.Items.Add("소스500원");
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            TotalCost = 0;
            lstOrder.Items.Clear();

            if (rdoHamBurger.Checked)
            {
                TotalCost += 5000;
                lstOrder.Items.Add("햄버거: 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                TotalCost += 4000;
                lstOrder.Items.Add("불고기버거: 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                TotalCost += 3000;
                lstOrder.Items.Add("치킨버거: 3,000원");
            }

            if (chkPotato.Checked)
            {
                TotalCost += 3500;
                lstOrder.Items.Add("감자튀김: 3,500원");
            }
            if (chkCola.Checked)
            {
                TotalCost += 2500;
                lstOrder.Items.Add("콜라: 2,500원");
            }
            if (chkCheese.Checked)
            {
                TotalCost += 1500;
                lstOrder.Items.Add("치즈추가1,500원");
            }
            if (chkSauce.Checked)
            {
                TotalCost += 500;
                lstOrder.Items.Add("소스추가500원");
            }


            lblTotal.Text = "총 금액: " + TotalCost.ToString() + "원";
        }

        private void rstbtn_Click(object sender, EventArgs e)
        {
            TotalCost = 0;
            lstOrder.Items.Clear();
            lblTotal.Text = "총 금액: " + TotalCost.ToString() + "원";
        }
    }
}
