using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class SeleniumLoginMethod
    {
        public static void loginToYoutube(string email, string password)
        {
            //Initialize the youtube page by callying its reference
           LoginPageObject youTubeLoginPage = new LoginPageObject();


            try
            {
               
                youTubeLoginPage.ClickOnTheSignInLink();
                youTubeLoginPage.TypeEmail(email);
                youTubeLoginPage.ClickOnTheNextEmailButton();
                youTubeLoginPage.typeInPassword(password);
                youTubeLoginPage.clickOnTheNextPasswordButton();

              Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                throw e;
            }



        }

    }


}
