namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            name = new Label();
            rdoChickenBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoHamBurger = new RadioButton();
            chkPotato = new CheckBox();
            chkCola = new CheckBox();
            chkCheese = new CheckBox();
            chkSauce = new CheckBox();
            subbox = new GroupBox();
            mainbox = new GroupBox();
            lstOrder = new ListBox();
            lblTotal = new Label();
            endbox = new GroupBox();
            btnOrder = new Button();
            rstbtn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            subbox.SuspendLayout();
            mainbox.SuspendLayout();
            endbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("맑은 고딕", 25F);
            name.ForeColor = SystemColors.HotTrack;
            name.Location = new Point(47, 46);
            name.Name = "name";
            name.Size = new Size(391, 57);
            name.TabIndex = 0;
            name.Text = "버거 주문 키오스크";
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.ForeColor = Color.Purple;
            rdoChickenBurger.Location = new Point(17, 194);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(136, 109);
            rdoChickenBurger.TabIndex = 1;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "\r\n치킨버거\r\n\r\n";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.ForeColor = Color.Purple;
            rdoBulgogiBurger.Location = new Point(17, 146);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(161, 39);
            rdoBulgogiBurger.TabIndex = 2;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.ForeColor = Color.Purple;
            rdoHamBurger.Location = new Point(17, 57);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(111, 39);
            rdoHamBurger.TabIndex = 3;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.ForeColor = Color.Purple;
            chkPotato.Location = new Point(6, 60);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(91, 24);
            chkPotato.TabIndex = 4;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.ForeColor = Color.Purple;
            chkCola.Location = new Point(6, 94);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(61, 24);
            chkCola.TabIndex = 5;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.ForeColor = Color.Purple;
            chkCheese.Location = new Point(6, 124);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(91, 24);
            chkCheese.TabIndex = 6;
            chkCheese.Text = "치즈추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.ForeColor = Color.Purple;
            chkSauce.Location = new Point(6, 154);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(91, 24);
            chkSauce.TabIndex = 7;
            chkSauce.Text = "소스추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // subbox
            // 
            subbox.Controls.Add(chkPotato);
            subbox.Controls.Add(chkSauce);
            subbox.Controls.Add(chkCola);
            subbox.Controls.Add(chkCheese);
            subbox.ForeColor = Color.Red;
            subbox.Location = new Point(390, 151);
            subbox.Name = "subbox";
            subbox.Size = new Size(161, 197);
            subbox.TabIndex = 8;
            subbox.TabStop = false;
            subbox.Text = "추가옵션";
            subbox.Enter += subbox_Enter;
            // 
            // mainbox
            // 
            mainbox.Controls.Add(pictureBox3);
            mainbox.Controls.Add(pictureBox2);
            mainbox.Controls.Add(pictureBox1);
            mainbox.Controls.Add(rdoHamBurger);
            mainbox.Controls.Add(rdoBulgogiBurger);
            mainbox.Controls.Add(rdoChickenBurger);
            mainbox.Font = new Font("맑은 고딕", 15F);
            mainbox.ForeColor = Color.Red;
            mainbox.Location = new Point(12, 114);
            mainbox.Name = "mainbox";
            mainbox.Size = new Size(356, 324);
            mainbox.TabIndex = 9;
            mainbox.TabStop = false;
            mainbox.Text = "메뉴 선택";
            mainbox.Enter += mainbox_Enter;
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(17, 38);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(150, 104);
            lstOrder.TabIndex = 10;
            lstOrder.SelectedIndexChanged += lstOrder_SelectedIndexChanged_1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.Purple;
            lblTotal.Location = new Point(17, 177);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(90, 20);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "총 금액: 0원";
            // 
            // endbox
            // 
            endbox.Controls.Add(lstOrder);
            endbox.Controls.Add(lblTotal);
            endbox.ForeColor = Color.Red;
            endbox.Location = new Point(589, 131);
            endbox.Name = "endbox";
            endbox.Size = new Size(187, 217);
            endbox.TabIndex = 12;
            endbox.TabStop = false;
            endbox.Text = "주문내역";
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("맑은 고딕", 15F);
            btnOrder.Location = new Point(554, 369);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(123, 47);
            btnOrder.TabIndex = 13;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // rstbtn
            // 
            rstbtn.Font = new Font("맑은 고딕", 15F);
            rstbtn.Location = new Point(683, 369);
            rstbtn.Name = "rstbtn";
            rstbtn.Size = new Size(105, 47);
            rstbtn.TabIndex = 14;
            rstbtn.Text = "초기화";
            rstbtn.UseVisualStyleBackColor = true;
            rstbtn.Click += rstbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.chickenbuger;
            pictureBox1.Location = new Point(200, 240);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bulbuger;
            pictureBox2.Location = new Point(200, 146);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.hambuger;
            pictureBox3.Location = new Point(200, 55);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 66);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rstbtn);
            Controls.Add(btnOrder);
            Controls.Add(endbox);
            Controls.Add(mainbox);
            Controls.Add(subbox);
            Controls.Add(name);
            Name = "Form1";
            Text = "BugerKiosk v2.0";
            subbox.ResumeLayout(false);
            subbox.PerformLayout();
            mainbox.ResumeLayout(false);
            mainbox.PerformLayout();
            endbox.ResumeLayout(false);
            endbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private RadioButton rdoChickenBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoHamBurger;
        private CheckBox chkPotato;
        private CheckBox chkCola;
        private CheckBox chkCheese;
        private CheckBox chkSauce;
        private GroupBox subbox;
        private GroupBox mainbox;
        private ListBox lstOrder;
        private Label lblTotal;
        private GroupBox endbox;
        private Button btnOrder;
        private Button rstbtn;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
