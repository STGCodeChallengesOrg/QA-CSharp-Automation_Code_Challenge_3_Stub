using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;
namespace QA_CSharp_Automation_Code_Challenge_3_Stub
{
    public class SkiUtahPage
    {
        IWebDriver driver;

        #region Constructors
        public SkiUtahPage(IWebDriver Driver)
        {
            driver = Driver;
            // TODO Identify the mainMenuItems and subMenuItems, and put them into lists
        }



        #endregion
        #region METHODS

        /**
         * Hovers on a menu item, and clicks the designated sub-menu item, and verifies that the submenu link opens the expected page by matching the actual title to the
         * @param subMenuItem A String representing the text of the submenu item that you want to click, i.e. "Brighton"
         * @param expectedTitle A String representing the title of the new web page.
         * @return A boolean representing whether or not the actual title has the same value as expectedTitle.
         */
        public Boolean ClickSubmenuItem(String subMenuItem, String expectedTitle)
        {
            //TODO Hover on the main menu item to make the submenus visible
            //TODO If the subMenu entry that corresponds to menuItem is visible, click on it.
            //TODO Compare the Title of the new page to the expectedTitle, to see if they match.
            //TODO Return the results of the comparison
            return true;
        }
# endregion


    }
}
