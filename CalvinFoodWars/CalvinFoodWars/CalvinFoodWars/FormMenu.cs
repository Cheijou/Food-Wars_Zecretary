using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using WMPLib;
using System.Runtime.Serialization.Formatters.Binary;

namespace CalvinFoodWars
{
    public partial class FormMenu : Form
    {
        #region Declarations
        public List<Players> listPlayer = new List<Players>();
        FormCreatePlayer registeredPlayer;
        public string playerFileName = "player.dat";
        Players displayCurrent;
        Time recordedTime;
        Time remainingTime;
        Time powerCooldown;
        Time freezeTime;
        Time boostTime;
        Customers customer;
        public Players player;
        public Buff boost = new Buff("boost", 100000, Properties.Resources.doublemoney);
        public Buff freeze = new Buff("freeze", 50000, Properties.Resources.freeze);
        //public Skin merchZeta = new Skin("merchZeta", 10000, kasih gambar merch zeta);
        //public Skin tumblerZeta = new Skin("tumblerZeta", 10000, kasih gambar tumbler zeta);
        //untuk mengaktifkan ski nzeta
        //public bool merchActive
        //public bool tumblerActive
        private int selectedIngCount = 0;
        private int remainingCustomer = 0;
        private int dialogTime = 0;
        private int delayTime = 0;
        private int incomePerGame = 0;
        public int currentIncome = 0;
        public string playerName = "";
        public Image playerPicture = null;  
        int temp2 = 0;
        //untuk mengganti stok dan inisialisasi
        Merchandise tumbler;
        Merchandise plushie;
        Merchandise zetaMerch;
        Merchandise zetaTumbler;
        //untuk random
        Random random = new Random();
        WindowsMediaPlayer sound1 = new WindowsMediaPlayer();
        WindowsMediaPlayer sound2 = new WindowsMediaPlayer();
        WindowsMediaPlayer sound3 = new WindowsMediaPlayer();
        bool boostActivated;
            
  
        public FormMenu()
        {
            InitializeComponent();
        }
        #endregion

        #region Game Beginning
        private void StartMenu()
        {
            
            temp2++;
            if (temp2 == 1)
            {
                PlaySound("play");
            }
            this.Size = new Size(857,644);
            remainingCustomer = 10;
            panelStall.Visible = false;
            panelPlayer.Visible = false;
            panelDialog.Visible = false;
            panelGuideBook.Visible = true;
            panelTimeAndRemain.Visible = false;
            pictureBoxCustomer.Visible = false;
            panelShop.Visible = true;
            panelNotif.Visible = false;
            panelBuff.Visible = false;
            panelEdit.Visible = true;
            panelEdit.Enabled = true;
            panelCredits.Visible = true;
            panelCredits.Enabled = true;
            timerCustomer.Interval = 800;
            timerGame.Interval = 1000;
            timerDelay.Interval = 800;
            this.BackgroundImage = Properties.Resources.background;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (listPlayer.Count == 0)
            {
                FormCreatePlayer formCreate = new FormCreatePlayer();
                formCreate.Owner = this;
                formCreate.ShowDialog();
            }
                StartMenu();
                displayCurrent = new Players(null, 0, null, new Time());
        }
        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        private void NewGame()
        {
            boostActivated = false;
            timerActual.Start();
            this.Size = new Size(865, 644);
            remainingCustomer = 10;
            Merchandise merch;
            incomePerGame = 0;
            merch = new Merchandise(null, null, 0);
            merch.ResetStock();
            tumbler = new Merchandise("tumbler", Properties.Resources.tumbler, 30000);
            plushie = new Merchandise("plushie", Properties.Resources.plushie, 20000);
            //zetaMerch = new Merchandise("zetaMerch",path gambar,10000)
            //zetaTumbler = new Merchdise("zetaTumbler",path gambar,10000)
            //if (merchActive == true)
            //pictureBoxPlushie.Image = path merch zeta
            //else
            //pictureBoxPlushie.Image = path plushie biasa
            //if (tumblerActive == true)
            //pictureBoxTumbler.Image = path tumbler zeta
            //else
            //pictureBoxTumbler.Image = path tumbler biasa
            dialogTime = 0;
            remainingTime = new Time(0,0,40);
            recordedTime = new Time();
            labelTime.Text = "Remaining time:\n " + "  " + remainingTime.Display();
            labelStockTumb.Text = "Stock: " + merch.Stock;  /*+(item as Merchandise).StockTumbler.ToString();*/
            labelStockPlushie.Text = "Stock: " + merch.Stock;  /*+(item as Merchandise).StockPlushie.ToString();*/
            labelRemainingCust.Text = "Remaining Customers: " + remainingCustomer;
            timerGame.Start();
            panelNotif.Visible = false;
            this.BackgroundImage = null;
            panelStall.Visible = true;
            panelGuideBook.Visible = false;
            panelPlayer.Visible = true;
            panelDialog.Visible = true;
            panelEdit.Visible = false;
            panelEdit.Enabled = false;
            panelCredits.Visible = false;   
            panelCredits.Enabled = false;
            panelTimeAndRemain.Visible = true;
            pictureBoxCustomer.Visible = true;
            pictureBoxOrderedItem.Visible = false;
            pictureBoxPlayer.Visible = true;
            panelShop.Visible = false;
            panelBuff.Visible = true;
            labelSisaBoost.Text = boost.Stock.ToString()+"x";
            labelSisaFreeze.Text = freeze.Stock.ToString()+"x"; 
            if (boost.Stock == 0)
            {
                pictureBoxBoost.Image = Properties.Resources.moneyDis;
            }
            else
            {
                pictureBoxBoost.Image = Properties.Resources.doublemoney;
            }
            if (freeze.Stock == 0)
            {
                pictureBoxFreeze.Image = Properties.Resources.freezeDis;
            }
            else
            {
                pictureBoxFreeze.Image = Properties.Resources.freeze;
            }
            CreateCustomer();
            CreatePlayer();
        }
        #endregion

        #region Creations
        private void CreatePlayer()
        {
            player = new Players(playerName, currentIncome, playerPicture, recordedTime);
            if (listPlayer.Count == 0)
            {
                listPlayer.Add(player);
            }
            else
            {
                listPlayer[0] = player;
            }
            labelName.Text = player.DisplayName();
            labelIncome.Text = player.DisplayIncome();
            labelPrevTime.Text = displayCurrent.DisplayTime();
            labelCurrentIncome.Text = "Prev Income: " + incomePerGame.ToString();
            pictureBoxPlayer.Image = player.Picture;
        }
        private void CreateCustomer()
        {
            PlaySound("hi");
            int type = random.Next(0, 3);
            // 0 = male, 1 = female, 2 = kid, 
            if (type == 0)
            {
                customer = new Customers("David", "male", Properties.Resources.david, null);
            }
            else if (type == 1)
            {
                customer = new Customers("Anna", "female", Properties.Resources.anna, null);
            }
            else if (type == 2)
            {
                customer = new Customers("Bryan", "kid", Properties.Resources.bryan, null);
            }
            pictureBoxCustomer.Image = customer.Picture;
            labelDialog.Visible = true;
            labelDialog.Text = customer.Display();
            //labelDialog.Text = customer.Display();
            pictureBoxServedItem.Visible = false;
            pictureBoxCheck.Image = null;
            pictureBoxServedItem.Image = null;
            timerCustomer.Start();
        }
        private void CreateOrder()
        {
            pictureBoxCheck.Image = null;
            pictureBoxServedItem.Visible = false;
            int type = random.Next(0, 3);
            // 0 = food, 1 = beverages, 2 = merchandise, 
            if (type == 0)
            {
                OrderFoods();
            }
            else if (type == 1)
            {
                OrderBeverages();
            }
            else if (type == 2)
            {
                OrderMerchandise();
            }
            pictureBoxOrderedItem.Image = customer.Item.Picture;
        }
        #endregion

        #region Customer Orders
        private void OrderFoods()
        {
            int type = random.Next(0,3);
            //type 0 = burger, 1 = salad, 2 = ice cream
            if (type == 0)
            {
                customer.Item = new Foods("burger", Properties.Resources.burger, 50000);
                (customer.Item as Foods).AddIngredients("plate", Properties.Resources.plate);
                (customer.Item as Foods).AddIngredients("bottompan", Properties.Resources.bottompan);
                (customer.Item as Foods).AddIngredients("patty", Properties.Resources.patty);
                (customer.Item as Foods).AddIngredients("lettuce", Properties.Resources.lettuce);
                (customer.Item as Foods).AddIngredients("toppan", Properties.Resources.mayo);
            }
            else if (type == 1)
            {
                customer.Item = new Foods("salad", Properties.Resources.salad, 25000);
                (customer.Item as Foods).AddIngredients("plate", Properties.Resources.plate);
                (customer.Item as Foods).AddIngredients("lettuce", Properties.Resources.lettuce);
                (customer.Item as Foods).AddIngredients("mayo", Properties.Resources.mayo);
            }
            else if (type == 2) 
            {
                customer.Item = new Foods("ice cream", Properties.Resources.icecream, 10000);
                (customer.Item as Foods).AddIngredients("cone", Properties.Resources.cone);
                (customer.Item as Foods).AddIngredients("ice", Properties.Resources.ice);
            }
        }
        private void OrderBeverages()
        {
            int type = random.Next(0,6);
            //0 = S Hot, 1 = M Hot, 2 = L Hot, 3 = S Cold, 4 = M Cold, 5 = L Cold
            if (type == 0)
            {
                customer.Item = new Beverages("coffee", Properties.Resources.coffee_S_hot, 15000, false, "S");
            }
            else if (type == 1)
            {
                customer.Item = new Beverages("coffee", Properties.Resources.coffee_M_hot, 20000, false, "M");
            }
            else if (type == 2)
            {
                customer.Item = new Beverages("coffee", Properties.Resources.coffee_L_hot, 25000, false, "L");
            }
            else if (type == 3)
            {
                customer.Item = new Beverages("coffee", Properties.Resources.coffee_S_cold, 15000, true, "S");
            }
            else if (type == 4)
            {
                customer.Item = new Beverages("coffee", Properties.Resources.coffee_M_cold, 20000, true, "M");
            }
            else if (type == 5)
            {
                customer.Item = new Beverages("coffee", Properties.Resources.coffee_L_cold, 25000, true, "L");
            }
        }
        private void OrderMerchandise()
        {
            int type = random.Next(0,2);
            //0 = tumbler, 1 = plushie
            if (type == 0)
            {
                //if (tumblerActive == false)
                //
                customer.Item = tumbler;
                //else if (tumblerActive == true)
                //customer.Item = tumblerZeta
            }
            else if (type == 1)
            {
                customer.Item = plushie;
            }
        }
        #endregion

        #region Order Desicion
        private void ServeOrder(PictureBox pictureBox, string itemType)
        {
            try
            {
                if (itemType == "food")
                {
                    if (customer.Item is Foods)
                    {
                        Foods foodOrder = (Foods)customer.Item;
                        if (pictureBox.Tag.ToString() == foodOrder.ListIngredients[selectedIngCount].Name)
                        {
                            selectedIngCount++;
                            pictureBoxCheck.Image = pictureBox.Image;
                            if (selectedIngCount == foodOrder.ListIngredients.Count)
                            {
                                CorrectOrder(foodOrder);
                                selectedIngCount = 0;
                            }
                        }
                        else
                        {
                            WrongOrder();
                        }
                    }
                    else
                    {
                        WrongOrder();
                    }
                }
                else if (itemType == "merchant")
                {
                    if (customer.Item is Merchandise)
                    {
                        Merchandise merchTumbler = (Merchandise)customer.Item;
                        Merchandise merchPlushie = (Merchandise)customer.Item;
                        if (merchTumbler.Name == "tumbler")
                        {
                            if (pictureBox.Tag.ToString() == merchTumbler.Name)
                            {
                                merchTumbler.Sell();
                                int stockTumbler = merchTumbler.Stock;
                                pictureBoxCheck.Image = pictureBox.Image;
                                labelStockTumb.Text = "Stock: " + stockTumbler;
                                CorrectOrder(merchTumbler);
                            }
                            else
                            {
                                WrongOrder();
                            }
                        }
                        if (merchPlushie.Name == "plushie")
                        {
                            if (pictureBox.Tag.ToString() == merchPlushie.Name)
                            {
                                merchPlushie.Sell();
                                int stockPlushie = merchPlushie.Stock;
                                pictureBoxCheck.Image = pictureBox.Image;
                                labelStockPlushie.Text = "Stock: " + stockPlushie;
                                CorrectOrder(merchPlushie);
                            }
                            else
                            {
                                WrongOrder();
                            }
                        }
                    }
                    else
                    {
                        WrongOrder();
                    }
                }
                else if (itemType == "beverages")
                {
                    if (customer.Item is Beverages)
                    {
                        Beverages beveragesOrder = (Beverages)customer.Item;
                        if ((pictureBox.Tag.ToString() == "1" && beveragesOrder.IsCold == false && beveragesOrder.Size == "L") ||
                            (pictureBox.Tag.ToString() == "2" && beveragesOrder.IsCold == false && beveragesOrder.Size == "M") ||
                            (pictureBox.Tag.ToString() == "3" && beveragesOrder.IsCold == false && beveragesOrder.Size == "S") ||
                            (pictureBox.Tag.ToString() == "4" && beveragesOrder.IsCold == true && beveragesOrder.Size == "L") ||
                            (pictureBox.Tag.ToString() == "5" && beveragesOrder.IsCold == true && beveragesOrder.Size == "M") ||
                            (pictureBox.Tag.ToString() == "6" && beveragesOrder.IsCold == true && beveragesOrder.Size == "S"))
                        {
                            pictureBoxCheck.Image = pictureBox.Image;
                            CorrectOrder(beveragesOrder);
                        }
                        else
                        {
                            WrongOrder();
                        }
                    }
                    else
                    {
                        WrongOrder();
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void WrongOrder()
        {
            PlaySound("incorrect");
            pictureBoxCheck.Image = Properties.Resources.wrong;
            selectedIngCount = 0;
        }
        private void CorrectOrder(Items orderType)
        {
            PlaySound("correct");
            panelNotif.Visible = true;
            pictureBoxServedItem.Visible = true;
            pictureBoxServedItem.Image = customer.Item.Picture;
            pictureBoxServedItem.Tag = "done";
            pictureBoxOrderedItem.Image = Properties.Resources.money;
            if (boostActivated == true)
            {
                incomePerGame = player.AddWithPrice(incomePerGame, (2*customer.Item.Price));
                labelNotif.Text = "+" + (2*customer.Item.Price) + " (boosted!!!)";
            }
            else if(boostActivated == false)
            {
                incomePerGame = player.AddWithPrice(incomePerGame, customer.Item.Price);
                labelNotif.Text = "+" + customer.Item.Price;
            }
            selectedIngCount = 0;
            remainingCustomer--;
            labelRemainingCust.Text = "Remaining Customers : " + remainingCustomer;
            labelCurrentIncome.Text = "Prev Income: " + incomePerGame.ToString();
            labelIncome.Text = player.DisplayIncome();
            dialogTime = 0;
            timerDelay.Start();
        }
        #endregion

        #region Timers & Ending Game
        private void TimerCustomer_Tick(object sender, EventArgs e)
        {
            dialogTime++;
            panelNotif.Visible = false;
            labelDialog.Visible = true;
            pictureBoxOrderedItem.Visible = false;
            if (dialogTime == 1)
            {
                CreateOrder();
                labelDialog.Visible = false;
                pictureBoxOrderedItem.Visible = true;
                timerCustomer.Stop();
            }
        }
        private void TimerGame_Tick(object sender, EventArgs e)
        {
            remainingTime.Add(-1);
            recordedTime.Add(1);
            labelTime.Text = "Remaining time:\n " +"  "+ remainingTime.Display();
            ShowGameOverDialog();
        }
        private void timerDelay_Tick(object sender, EventArgs e)
        {
            delayTime++;
            if (delayTime == 1)
            {
                timerDelay.Stop();
                pictureBoxOrderedItem.Visible = false;
                panelNotif.Visible = false;
                timerCustomer.Start();               
                CreateCustomer();
                delayTime = 0;
            }
        }
        #endregion

        #region Dialog After Game
        private void ShowGameOverDialog()
        {
            //lose
            
            if (remainingTime.Hour == 0 && remainingTime.Minute == 0 && remainingTime.Second == 0)
            {
                timerActual.Stop();
                timerFreeze.Stop();
                timerBoost.Stop();
                PlaySound("lose");
                timerGame.Stop();
                timerCustomer.Stop();
                timerDelay.Stop();
                incomePerGame = 0;
                currentIncome = player.Income;
                
                var result = MessageBox.Show("Time is up, you lost all your income in this try.\nDo you want to try again?","Game Over",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) 
                {
                    NewGame();
                    PlaySound("play");
                }
                else
                {
                    StartMenu();
                    PlaySound("play");
                }
            }
            //win
            if (remainingCustomer == 0)
            {
                timerActual.Stop();
                timerFreeze.Stop();
                timerBoost.Stop();
                PlaySound("win");
                player.AddIncome(incomePerGame);
                currentIncome = player.Income;
                displayCurrent = player;
                labelPrevTime.Text = displayCurrent.DisplayTime();
                timerGame.Stop();
                timerCustomer.Stop();
                timerDelay.Stop();
                var result = MessageBox.Show("You served all the customers in " + recordedTime.Second+ " seconds.\nWant to try again? ","Congratulations",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) 
                {
                    NewGame();
                    PlaySound("play");          
                }
                else
                {
                    StartMenu();
                    PlaySound("play");
                }
                incomePerGame = 0;
                labelCurrentIncome.Text = "Prev Income: " + incomePerGame.ToString();
            }
        }
        #endregion

        #region Play Sound

        private void PlaySound(string type)
        {
            string tempFile = "";
            if (type == "play")
            {
                tempFile = Path.GetTempFileName() + ".mp3";
                File.WriteAllBytes(tempFile, Properties.Resources.sound_play);
                sound1.URL = tempFile;
                sound1.controls.play();
            }
            else if (type == "correct")
            {
                tempFile = Path.GetTempFileName() + ".mp3";
                File.WriteAllBytes(tempFile, Properties.Resources.sound_money);
                sound2.URL = tempFile;
                sound2.controls.play();
            }
            else if (type == "incorrect")
            {
                tempFile = Path.GetTempFileName() + ".mp3";
                File.WriteAllBytes(tempFile, Properties.Resources.sound_fail);
                sound2.URL = tempFile;
                sound2.controls.play();
            }
            else if (type == "win")
            {
                tempFile = Path.GetTempFileName() + ".mp3";
                File.WriteAllBytes(tempFile, Properties.Resources.sound_win);
                sound1.URL = tempFile;
                sound1.controls.play();
            }
            else if (type == "lose")
            {
                tempFile = Path.GetTempFileName() + ".mp3";
                File.WriteAllBytes(tempFile, Properties.Resources.sound_lose);
                sound1.URL = tempFile;
                sound1.controls.play();
            }
            else if (type == "hi")
            {
                tempFile = Path.GetTempFileName() + ".mp3";
                File.WriteAllBytes(tempFile, Properties.Resources.sound_hi);
                sound2.URL = tempFile;
                sound2.controls.play();
            }
            else if (type == "freeze")
            {
                tempFile = Path.GetTempFileName() + ".mp3";
                File.WriteAllBytes(tempFile, Properties.Resources.freezeEffect);
                sound3.URL = tempFile;
                sound3.controls.play();
            }
            else if (type == "boost")
            {
                tempFile = Path.GetTempFileName() + ".mp3";
                File.WriteAllBytes(tempFile, Properties.Resources.boostEffect);
                sound3.URL = tempFile;
                sound3.controls.play();
            }

        }
        #endregion

        #region Menu Clicks
        private void pictureBoxTumbler_Click(object sender, EventArgs e)
        {
            ServeOrder(pictureBoxTumbler, "merchant");
        }
        private void pictureBoxPlate_Click(object sender, EventArgs e)
        {
            ServeOrder(pictureBoxPlate, "food");
        }

        private void pictureBoxBottom_Click(object sender, EventArgs e)
        {
            ServeOrder(pictureBoxBottom, "food");
        }

        private void pictureBoxPatty_Click(object sender, EventArgs e)
        {
            ServeOrder(pictureBoxPatty, "food");
        }

        private void pictureBoxLettuce_Click(object sender, EventArgs e)
        {
            ServeOrder(pictureBoxLettuce, "food");
        }

        private void pictureBoxTop_Click(object sender, EventArgs e)
        {
            ServeOrder(pictureBoxTop, "food");
        }

        private void pictureBoxMayo_Click(object sender, EventArgs e)
        {
            ServeOrder(pictureBoxMayo, "food");
        }

        private void pictureBoxCone_Click(object sender, EventArgs e)
        {
            ServeOrder(pictureBoxCone, "food");
        }

        private void pictureBoxIce_Click(object sender, EventArgs e)
        {
            ServeOrder(pictureBoxIce, "food");
        }

        private void pictureBoxPlushie_Click(object sender, EventArgs e)
        {
            ServeOrder(pictureBoxPlushie, "merchant");
        }

        private void pictureBoxLHot_Click(object sender, EventArgs e)
        {
            ServeOrder(pictureBoxLHot, "beverages");
        }

        private void pictureBoxMHot_Click(object sender, EventArgs e)
        {
            ServeOrder(pictureBoxMHot, "beverages");
        }

        private void pictureBoxSHot_Click(object sender, EventArgs e)
        {
            ServeOrder(pictureBoxSHot, "beverages");
        }

        private void pictureBoxLCold_Click(object sender, EventArgs e)
        {
            ServeOrder(pictureBoxLCold, "beverages");
        }

        private void pictureBoxMCold_Click(object sender, EventArgs e)
        {
            ServeOrder(pictureBoxMCold, "beverages");
        }

        private void pictureBoxSCold_Click(object sender, EventArgs e)
        {
            ServeOrder(pictureBoxSCold, "beverages");
        }
        #endregion

        #region Mouse Hovering
        private void ChangePictureBoxColor(PictureBox pictureBox, string status)
        {
            if (status == "enter")
            {
                pictureBox.BackColor = Color.White;
            }
            else if (status == "leave")
            {
                pictureBox.BackColor = Color.Transparent;
            }
        }

        private void pictureBoxTumbler_MouseEnter(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxTumbler, "enter");
        }

        private void pictureBoxTumbler_MouseLeave(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxTumbler, "leave");
        }

        private void pictureBoxPlate_MouseEnter(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxPlate, "enter");
        }

        private void pictureBoxPlate_MouseLeave(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxPlate, "leave");
        }

        private void pictureBoxBottom_MouseEnter(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxBottom, "enter");
        }

        private void pictureBoxBottom_MouseLeave(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxBottom, "leave");
        }

        private void pictureBoxPatty_MouseEnter(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxPatty, "enter");
        }

        private void pictureBoxPatty_MouseLeave(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxPatty, "leave");
        }

        private void pictureBoxLettuce_MouseEnter(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxLettuce, "enter");
        }

        private void pictureBoxLettuce_MouseLeave(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxLettuce, "leave");
        }

        private void pictureBoxTop_MouseEnter(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxTop, "enter");
        }

        private void pictureBoxTop_MouseLeave(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxTop, "leave");
        }

        private void pictureBoxMayo_MouseEnter(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxMayo, "enter");
        }
        private void pictureBoxMayo_MouseLeave(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxMayo, "leave");
        }
        private void pictureBoxCone_MouseEnter(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxCone, "enter");
        }
        private void pictureBoxCone_MouseLeave(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxCone, "leave");
        }

        private void pictureBoxIce_MouseEnter(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxIce, "enter");
        }

        private void pictureBoxIce_MouseLeave(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxIce, "leave");
        }

        private void pictureBoxPlushie_MouseEnter(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxPlushie, "enter");
        }

        private void pictureBoxPlushie_MouseLeave(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxPlushie, "leave");
        }
        private void pictureBoxMayo_MouseLeave_1(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxMayo, "leave");
        }

        private void pictureBoxCone_MouseEnter_1(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxCone, "enter");
        }
        private void pictureBoxCone_MouseLeave_1(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxCone, "leave");
        }
        private void pictureBoxLHot_MouseEnter(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxLHot, "enter");
        }

        private void pictureBoxLHot_MouseLeave(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxLHot, "leave");
        }

        private void pictureBoxMHot_MouseEnter(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxMHot, "enter");
        }

        private void pictureBoxMHot_MouseLeave(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxMHot, "leave");
        }

        private void pictureBoxSHot_MouseEnter(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxSHot, "enter");
        }

        private void pictureBoxSHot_MouseLeave(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxSHot, "leave");
        }

        private void pictureBoxLCold_MouseEnter(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxLCold, "enter");
        }

        private void pictureBoxLCold_MouseLeave(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxLCold, "leave");
        }
        private void pictureBoxMCold_MouseEnter(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxMCold, "enter");
        }

        private void pictureBoxMCold_MouseLeave(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxMCold, "leave");
        }

        private void pictureBoxSCold_MouseEnter(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxSCold, "enter");
        }

        private void pictureBoxSCold_MouseLeave(object sender, EventArgs e)
        {
            ChangePictureBoxColor(pictureBoxSCold, "leave");
        }

        #endregion

        #region Shop
        private void pictureBoxShop_MouseClick(object sender, MouseEventArgs e)
        {
            if (listPlayer.Count > 0)
            {
                FormShop form = new FormShop();
                form.Owner = this;
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must create a player first before accessing shop.");
            }
        }
        #endregion

        #region Exit Shop

        #endregion

        #region Save and Load
        public void SaveToFilePlayers(string filename)
        {
            FileStream myFile = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(myFile, listPlayer);
            myFile.Close();
        }
        public void LoadFromFilePlayers(string filename)
        {
            if (File.Exists(filename))
            {
                FileStream myFile = new FileStream(filename, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                listPlayer = (List<Players>)formatter.Deserialize(myFile);
                myFile.Close();
            }
        }
        #endregion

        #region Exit menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartMenu();
            timerGame.Stop();
            remainingTime = new Time(0, 0, 40);
        }

        #endregion

        #region Open Guide Book
        private void pictureBoxGuideBook_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.Owner = this;
            formGuide.ShowDialog();
        }
        #endregion

        #region Use Power Ups
        private void pictureBoxFreeze_Click(object sender, EventArgs e)
        {
            try
            {
                freeze.Stock--;
                if (freeze.Stock == 0)
                {
                    pictureBoxFreeze.Image = Properties.Resources.freezeDis;
                }
                BackgroundImage = Properties.Resources.efekFreeze;
                timerFreeze.Interval = 1000;
                timerCd.Interval = 1000;
                freezeTime = new Time(0, 0, 7);
                powerCooldown = new Time(0, 0, 10);
                timerFreeze.Start();
                timerGame.Stop();
                timerCd.Start();
                PlaySound("freeze");
                labelSisaBoost.Text = boost.Stock.ToString() + "x";
                labelSisaFreeze.Text = freeze.Stock.ToString() + "x";
                pictureBoxFreeze.Image = Properties.Resources.freezeDis;
                pictureBoxBoost.Image = Properties.Resources.moneyDis;
                pictureBoxFreeze.Enabled = false;
                pictureBoxBoost.Enabled = false;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pictureBoxBoost_Click(object sender, EventArgs e)
        {
            try
            {
                boost.Stock--;
                if (boost.Stock == 0)
                {
                    pictureBoxBoost.Image = Properties.Resources.moneyDis;
                }
                BackgroundImage = Properties.Resources.efekBoost;
                timerBoost.Interval = 1000;
                timerCd.Interval = 1000;
                timerBoost.Start();
                timerCd.Start();
                boostActivated = true;
                boostTime = new Time(0, 0, 10);
                powerCooldown = new Time(0, 0, 10);
                PlaySound("boost");
                labelSisaBoost.Text = boost.Stock.ToString() + "x";
                labelSisaFreeze.Text = freeze.Stock.ToString() + "x";
                pictureBoxFreeze.Image = Properties.Resources.freezeDis;
                pictureBoxBoost.Image = Properties.Resources.moneyDis;
                pictureBoxFreeze.Enabled = false;
                pictureBoxBoost.Enabled = false;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void timerFreeze_Tick(object sender, EventArgs e)
        {
            freezeTime.Add(-1);
            if (freezeTime.Second == 0)
            {
                timerGame.Start();
                timerFreeze.Stop();
                BackgroundImage = null;
            }
        }
        private void timerBoost_Tick(object sender, EventArgs e)
        {
            boostTime.Add(-1);
            if(boostTime.Second == 0)
            {
                timerBoost.Stop();
                boostActivated = false;
                BackgroundImage = null;
            }
        }
        private void buttonBuyFreeze_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            StartMenu();
            
        }
        #region Credits
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Edit
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void timerCd_Tick(object sender, EventArgs e)
        {
            powerCooldown.Add(-1);
           
            if (powerCooldown.Second == 0)
            {
                timerCd.Stop();
                pictureBoxFreeze.Image = Properties.Resources.freeze;
                pictureBoxBoost.Image = Properties.Resources.doublemoney;
                if(freeze.Stock == 0)
                {
            
                    pictureBoxFreeze.Image = Properties.Resources.freezeDis;
                }
                if (boost.Stock == 0)
                {
                    pictureBoxBoost.Image = Properties.Resources.moneyDis;
                }
                pictureBoxFreeze.Enabled = true;
                pictureBoxBoost.Enabled = true;
            }
        }

        private void panelStall_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelNotif_Click(object sender, EventArgs e)
        {

        }

        private void timerActual_Tick(object sender, EventArgs e)
        {
            ShowGameOverDialog();
        }
    }
}
