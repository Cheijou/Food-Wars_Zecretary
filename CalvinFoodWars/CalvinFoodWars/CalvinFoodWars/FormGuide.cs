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
           
        }
        private void price3false()
        {
            pictureBoxtumblerpr.Visible = false;
            pictureBoxplushiepr.Visible = false;
            
            pictureBoxUndoPrice2.Visible = false;
            pictureBoxist1.Visible = false;
            pictureBoxist2.Visible = false;
            labelplushie.Visible = false;
            labeltumbler.Visible = false;
            
        }
        private void price3true()
        {
            pictureBoxtumblerpr.Visible = true;
            pictureBoxplushiepr.Visible = true;
            
            pictureBoxUndoPrice2.Visible = true;
            pictureBoxist1.Visible = true;
            pictureBoxist2.Visible = true;
            labelplushie.Visible = true;
            labeltumbler.Visible = true;

        }

        private void price2true()
        {
            pictureBoxisbev1.Visible = true;
            pictureBoxisbev2.Visible = true;
            pictureBoxisbev3.Visible = true;
            pictureBoxisbev4.Visible = true;
            pictureBoxisbev5.Visible = true;
            pictureBoxisbev6.Visible = true;
            pictureBoxlcold.Visible = true;
            pictureBoxlhot.Visible = true;
            pictureBoxmcold.Visible = true;
            pictureBoxmhot.Visible = true;
            pictureBoxshot.Visible = true;
            pictureBoxscold.Visible =true;
            pictureBoxNextPrice3.Visible = true;
            pictureBoxUndoPrice1.Visible = true;
            labelbevp1.Visible = true;
            labelbevp2.Visible = true;
            labelbevp3.Visible = true;
            labelbevp4.Visible = true;
            labelbevp5.Visible = true;
            labelbevp6.Visible = true;
            labelPrice.Visible = true;
        }
        private void price2false()
        {
            pictureBoxisbev1.Visible = false;
            pictureBoxisbev2.Visible = false;
            pictureBoxisbev3.Visible = false;
            pictureBoxisbev4.Visible = false;
            pictureBoxisbev5.Visible = false;
            pictureBoxisbev6.Visible = false;
            pictureBoxlcold.Visible = false;
            pictureBoxlhot.Visible = false;
            pictureBoxmcold.Visible = false;
            pictureBoxmhot.Visible = false;
            pictureBoxshot.Visible = false;
            pictureBoxscold.Visible = false;
            pictureBoxNextPrice3.Visible = false;
            pictureBoxUndoPrice1.Visible = false;
            labelbevp1.Visible = false;
            labelbevp2.Visible = false;
            labelbevp3.Visible = false;
            labelbevp4.Visible = false;
            labelbevp5.Visible = false;
            labelbevp6.Visible = false;
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

        private void price1true()
        {
            labelPrice.Visible = true;
            labelprice1.Visible = true;
            labelprice2.Visible = true;
            labelprice3.Visible = true;
            pictureBoxis1.Visible = true;
            pictureBoxis2.Visible = true;
            pictureBoxis3.Visible = true;
            pictureBoxprice1.Visible = true;
            pictureBoxprice2.Visible = true;
            pictureBoxprice3.Visible = true;
            pictureBoxNextprice2.Visible = true;
        }
        private void price1false()
        {
            labelPrice.Visible = false;
            labelprice1.Visible = false;
            labelprice2.Visible = false;
            labelprice3.Visible = false;
            pictureBoxis1.Visible = false;
            pictureBoxis2.Visible = false;
            pictureBoxis3.Visible = false;
            pictureBoxprice1.Visible = false;
            pictureBoxprice2.Visible = false;
            pictureBoxprice3.Visible = false;
            pictureBoxNextprice2.Visible = false;
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

        private void pictureBoxPrice_MouseClick(object sender, MouseEventArgs e)
        {
            labelGuide.Visible = false;
            formfalse();
            price1true();
        }

        private void pictureBoxNextprice2_MouseClick(object sender, MouseEventArgs e)
        {
            price1false();
            price2true();
            
        }

        private void pictureBoxUndoPrice1_MouseClick(object sender, MouseEventArgs e)
        {
            price1true();
            price2false();

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
