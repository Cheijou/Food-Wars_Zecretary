using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CalvinFoodWars
{
    public partial class FormGuide : Form
    {
        public FormGuide()
        {
            InitializeComponent();
        }


        //ini form load  aka form guide
        private void Recipe_Load(object sender, EventArgs e)
        {
            backbutton();
            recipeburgerfalse();
            recipesaladfalse();
            recipeicecreamfalse();
            composition1false();
            composition2false();
            composition3false();
            price1false();
            price2false();
            price3false();
        }
        private void formguide()
        {
            labelGuide.Text = "GUIDE";
            pictureBoxHowtoplay.Visible = true;
            pictureBoxRecipe.Visible = true;
            pictureBoxExit.Visible = true;
            pictureBoxPrice.Visible = true;
            
        }
        #region Recipe
        private void backbutton()
        {
            pictureBoxBack.Visible = false;
            pictureBoxNextRecipe2.Visible = false;
            pictureBoxNextRecipe3.Visible = false;
            pictureBoxUndoRecipe1.Visible = false;
            pictureBoxUndoRecipe2.Visible = false;
            pictureBoxNextComp2.Visible = false;
            pictureBoxUndoComp1.Visible = false;
            pictureBoxNextComp3.Visible = false;
            pictureBoxNextRecipe2.Visible = false;
            //

           
        }
     

        private void recipeburgerfalse()
        {
            pictureBoxRecipeBurger.Visible = false;
            pictureBoxButtomPan.Visible = false;
            pictureBoxEqualBurger.Visible = false;
            pictureBoxLettuce.Visible = false;
            pictureBoxPatty.Visible = false;
            pictureBoxPlate.Visible = false;
            pictureBoxTopPan.Visible = false;
            pictureBoxarb1.Visible = false;
            pictureBoxarb2.Visible = false;
            pictureBoxarb3.Visible = false;
            pictureBoxarb4.Visible = false;
            pictureBoxNextRecipe2.Visible = false;
        }
        private void recipeburgertrue()
        {
            pictureBoxNextRecipe2.Visible = true;
            pictureBoxRecipeBurger.Visible = true;
            pictureBoxButtomPan.Visible = true;
            pictureBoxEqualBurger.Visible = true;
            pictureBoxLettuce.Visible = true;
            pictureBoxPatty.Visible = true;
            pictureBoxPlate.Visible = true;
            pictureBoxTopPan.Visible = true;
            pictureBoxarb1.Visible = true;
            pictureBoxarb2.Visible = true;
            pictureBoxarb3.Visible = true;
            pictureBoxarb4.Visible = true;
        }

        private void composition1false()
        {
            labelText1.Visible = false;
            pictureBoxComp.Visible = false;
            pictureBoxComp11.Visible = false;
            pictureBoxComp12.Visible = false;
            pictureBoxComp13.Visible = false;
            pictureBoxComp14.Visible = false;
            pictureBoxCompBot1.Visible = false;
            pictureBoxCompPlate1.Visible = false;
            pictureBoxCorrect.Visible = false;
            pictureBoxWrong.Visible = false;
            labelComposition.Visible = false;
            pictureBoxNextComp2.Visible = false;
            labelWrong.Visible = false;
            labelTrue.Visible = false;
            
        }

        private void composition1true()
        {
            labelText1.Visible = true;
            pictureBoxComp.Visible = true;
            pictureBoxComp11.Visible = true;
            pictureBoxComp12.Visible = true;
            pictureBoxComp13.Visible = true;
            pictureBoxComp14.Visible = true;
            pictureBoxCompBot1.Visible = true;
            pictureBoxCompPlate1.Visible = true;
            pictureBoxCorrect.Visible = true;
            pictureBoxWrong.Visible = true;
            labelComposition.Visible = true;
            pictureBoxNextComp2.Visible = true;
            labelWrong.Visible = true;
            labelTrue.Visible = true;
        }

        private void composition2true()
        {
            pictureBoxUndoComp1.Visible = true;
            pictureBoxNextComp3.Visible = true;
            labelText2.Visible = true;
            pictureBoxDisplay.Visible = true;

        }
        private void composition2false()
        {
            pictureBoxUndoComp1.Visible = false;
            pictureBoxNextComp3.Visible = false;
            pictureBoxDisplay.Visible = false;
            labelText2.Visible = false;
            
            
        }
        


        private void recipesaladtrue()
        {
            pictureBoxUndoRecipe1.Visible = true;
            pictureBoxRecipeSalad.Visible = true;
            pictureBoxPlate2.Visible = true;
            pictureBoxLettuce2.Visible = true;
            pictureBoxmayo.Visible = true;
            pictureBoxNextRecipe3.Visible = true;
            pictureBoxars1.Visible = true;
            pictureBoxars2.Visible = true;
            pictureBoxEqualSalad.Visible = true;
        }
        private void recipesaladfalse()
        {
            pictureBoxUndoRecipe1.Visible = false;
            pictureBoxRecipeSalad.Visible = false;
            pictureBoxRecipeSalad.Visible = false;
            pictureBoxPlate2.Visible = false;
            pictureBoxLettuce2.Visible = false;
            pictureBoxmayo.Visible = false;
            pictureBoxars1.Visible = false;
            pictureBoxars2.Visible = false;
            pictureBoxEqualSalad.Visible = false;
            pictureBoxNextRecipe3.Visible = false;
        }
        

        private void recipeicecreamfalse()
        {
            pictureBoxUndoRecipe2.Visible = false;
            pictureBoxEqualIcecream.Visible = false;
            pictureBoxcream.Visible = false;
            pictureBoxIcecream.Visible = false;
            pictureBoxcone.Visible = false;
            pictureBoxari1.Visible = false;
        }
        private void recipeicecreamtrue()
        {
            pictureBoxUndoRecipe2.Visible = true;
            pictureBoxEqualIcecream.Visible = true;
            pictureBoxcream.Visible = true;
            pictureBoxIcecream.Visible = true;
            pictureBoxcone.Visible = true;
            pictureBoxari1.Visible = true;
        }
        private void formfalse()
        {
            pictureBoxHowtoplay.Visible = false;
            pictureBoxRecipe.Visible = false;
            pictureBoxExit.Visible = false;
            pictureBoxPrice.Visible = false;
            pictureBoxBack.Visible = true;
        }

        private void composition3true()
        {
            labelText3.Visible = true;
            labelSuccess.Visible = true;
            labelFailed.Visible = true;
            labelTime.Visible = true;
            pictureBoxFailed.Visible = true;
            pictureBoxSuccess.Visible = true;
            pictureBoxUndoComp2.Visible = true;

        }
        private void composition3false()
        {
            labelText3.Visible = false;
            labelSuccess.Visible = false;
            labelFailed.Visible =false;
            labelTime.Visible = false;
            pictureBoxFailed.Visible = false;
            pictureBoxSuccess.Visible = false;
            pictureBoxUndoComp2.Visible = false;
        }


        #endregion

        private void pictureBoxRecipe_MouseClick(object sender, MouseEventArgs e)
        {
            labelGuide.Text = "BURGER";
            formfalse();
            pictureBoxNextRecipe2.Visible = true;
            recipeburgertrue();
        }

        private void pictureBoxNextRecipe2_MouseClick(object sender, MouseEventArgs e)
        {
            recipeburgerfalse();
            recipesaladtrue();
            labelGuide.Text = "SALAD";
        }

        private void pictureBoxNextRecipe3_MouseClick(object sender, MouseEventArgs e)
        {
            recipesaladfalse();
            recipeicecreamtrue();
            labelGuide.Text = "ICE CREAM";
        }

        private void pictureBoxUndoRecipe2_MouseClick(object sender, MouseEventArgs e)
        {
            labelGuide.Text = "SALAD";
            recipesaladtrue();
            recipeicecreamfalse();
        }

        private void pictureBoxUndoRecipe1_MouseClick(object sender, MouseEventArgs e)
        {
            labelGuide.Text = "BURGER";
            recipeburgertrue();
            recipesaladfalse();
        }

        private void pictureBoxBack_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxBack.Visible = false;
            labelGuide.Visible = true;
            //
            labelPrice.Visible = false;
            formguide();
            recipeburgerfalse();
            recipesaladfalse();
            recipeicecreamfalse();
            composition1false();
            composition2false();
            composition3false();
            price1false();
            price2false();
            price3false();
        }

        private void pictureBoxHowtoplay_MouseClick(object sender, MouseEventArgs e)
        {
            labelGuide.Visible = false;
            formfalse();
            composition1true();
            
        }

        private void price1true()
        {
            pictureBoxFoodBurger.Visible = true;
            pictureBoxFoodIceCream.Visible = true;
            pictureBoxFoodSalad.Visible = true;
            pictureBoxNextRecipe2.Visible = true;
            labelPriceBurger.Visible = true;
            labelPriceIceCream.Visible = true;
            labelPriceSalad.Visible = true;
            pictureBoxis1.Visible = true;
            pictureBoxis2.Visible = true;
            pictureBoxis3.Visible = true;
            pictureBoxNextPrice2.Visible = true;
            labelPrice.Visible = true;
        }

        private void price1false()
        {
            pictureBoxFoodBurger.Visible = false;
            pictureBoxFoodIceCream.Visible = false;
            pictureBoxFoodSalad.Visible = false;
            pictureBoxNextRecipe2.Visible = false;
            labelPriceBurger.Visible = false;
            labelPriceIceCream.Visible = false;
            labelPriceSalad.Visible = false;
            pictureBoxis1.Visible = false;
            pictureBoxis2.Visible = false;
            pictureBoxis3.Visible = false;
            pictureBoxNextPrice2.Visible = false;
            
            
        }

        private void price2false()
        {
            labellhot.Visible = false;
            labelmhot.Visible = false;
            labelshot.Visible = false;
            labellcold.Visible =false;
            labelmcold.Visible = false;
            labelscold.Visible = false;
            pictureBoxscold.Visible = false;
            pictureBoxmcold.Visible = false;
            pictureBoxlcold.Visible = false;
            pictureBoxmhot.Visible = false;
            pictureBoxlhot.Visible = false;
            pictureBoxshot.Visible = false;
            pictureBoxismhot.Visible = false;
            pictureBoxislhot.Visible = false;
            pictureBoxishot.Visible = false;
            pictureBoxislcold.Visible = false;
            pictureBoxisscold.Visible = false;
            pictureBoxismcold.Visible = false;
            pictureBoxNextPrice3.Visible = false;
            pictureBoxUndoPrice1.Visible = false;
        }


        private void price2true()
        {
            labellhot.Visible = true;
            labelmhot.Visible = true;
            labelshot.Visible = true;
            labellcold.Visible = true;
            labelmcold.Visible = true;
            labelscold.Visible = true;
            pictureBoxscold.Visible = true;
            pictureBoxmcold.Visible = true;
            pictureBoxlcold.Visible = true;
            pictureBoxmhot.Visible = true;
            pictureBoxlhot.Visible = true;
            pictureBoxshot.Visible = true;
            pictureBoxismhot.Visible = true;
            pictureBoxislhot.Visible = true;
            pictureBoxishot.Visible = true;
            pictureBoxislcold.Visible = true;
            pictureBoxisscold.Visible = true;
            pictureBoxismcold.Visible = true;
            pictureBoxNextPrice3.Visible = true;
            pictureBoxUndoPrice1.Visible = true;

        }

        private void price3true()
        {
            pictureBoxzmerch.Visible = true;
            pictureBoxztum.Visible = true;
            pictureBoxtumbler.Visible = true;
            pictureBoxplushie.Visible = true;
            pictureBoxiszmerch.Visible = true;
            pictureBoxisztum.Visible = true;
            pictureBoxistum.Visible = true;
            pictureBoxiszmerch.Visible = true;
            pictureBoxismerch.Visible = true;
            pictureBoxtumbler.Visible = true;
            pictureBoxplushie.Visible = true;
            labelzmerchprice.Visible = true;
            labelztumprice.Visible = true;
            labelpluprice.Visible = true;
            labeltumprice.Visible = true;
            pictureBoxUndoPrice2.Visible = true;

        }

        private void price3false()
        {
            pictureBoxzmerch.Visible = false;
            pictureBoxztum.Visible = false;
            pictureBoxtumbler.Visible = false;
            pictureBoxplushie.Visible = false;
            pictureBoxiszmerch.Visible = false;
            pictureBoxisztum.Visible = false;
            pictureBoxistum.Visible = false;
            pictureBoxiszmerch.Visible = false;
            pictureBoxismerch.Visible = false;
            pictureBoxtumbler.Visible = false;
            pictureBoxplushie.Visible = false;
            labelzmerchprice.Visible = false;
            labelztumprice.Visible = false;
            labelpluprice.Visible = false;
            labeltumprice.Visible = false;
            pictureBoxUndoPrice2.Visible =false;
        }


        private void pictureBoxExit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void pictureBoxNextComp2_MouseClick(object sender, MouseEventArgs e)
        {
            
            composition1false();
            composition2true();
        }

        private void pictureBoxUndoComp1_MouseClick(object sender, MouseEventArgs e)
        {
            composition2false();
            composition1true();
        }

        private void pictureBoxNextComp3_MouseClick(object sender, MouseEventArgs e)
        {
            labelComposition.Visible = false;
            labelTime.Visible = true;
            composition3true();
            composition2false();
        }

        private void pictureBoxUndoComp2_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxNextComp3_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxUndoComp2_MouseClick(object sender, MouseEventArgs e)
        {
            composition3false();
            composition2true();
        }

        private void labelFailed_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxNextPrice2_MouseClick(object sender, MouseEventArgs e)
        {
            price1false();
            price2true();
        }

        private void pictureBoxPrice_MouseClick(object sender, MouseEventArgs e)
        {
            labelGuide.Visible = false;
            price1true();
            formfalse();
        }

        private void pictureBoxUndoPrice1_MouseClick(object sender, MouseEventArgs e)
        {
            price2false();
            price1true();
        }

        private void pictureBoxNextPrice3_MouseClick(object sender, MouseEventArgs e)
        {
            price3true();
            price2false();
        }

        private void pictureBoxUndoPrice2_MouseClick(object sender, MouseEventArgs e)
        {
            price3false();
            price2true();
        }
    }
}
