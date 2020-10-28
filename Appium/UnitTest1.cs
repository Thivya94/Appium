
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Appium
{

    public class UnitTest1
    {
        [Test]
        public void BL()
        {
            AppiumDriver<AppiumWebElement> driver;

            var cap = new AppiumOptions();

            cap.AddAdditionalCapability("deviceName", "Redmi");
            cap.AddAdditionalCapability("platformVersion", "9.0.0");
            cap.AddAdditionalCapability("platformName", "Android");
            cap.AddAdditionalCapability("appPackage", "com.bytelyfe");
            cap.AddAdditionalCapability("appActivity", "com.bytelyfe.MainActivity");


            driver = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

        }

        [Test]
        public void APIDemo()
        {
            AppiumDriver<AppiumWebElement> driver;

            var cap = new AppiumOptions();

            cap.AddAdditionalCapability("deviceName", "Appium_emulator");
            cap.AddAdditionalCapability("platformVersion", "9.0.0");
            cap.AddAdditionalCapability("platformName", "Android");
            cap.AddAdditionalCapability("appPackage", "io.appium.android.apis");
            cap.AddAdditionalCapability("appActivity", "io.appium.android.apis.ApiDemos");


            driver = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            //click Preference
            driver.FindElementByXPath("//android.widget.TextView[@content-desc='Preference']").Click();

            //click PreferenceDependencies
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//android.widget.TextView[@content-desc='3. Preference dependencies']"))).Click();

            //click wifi checkbox
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("android:id/checkbox"))).Click();

            //click WIFI Settings
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("(//android.widget.RelativeLayout)[2]"))).Click();

            //send keys 
            driver.FindElementByClassName("android.widget.EditText").SendKeys("hello");
            
            //use findelements if the xpath is same for many elements and choose the index and click the element
            //click ok button which is in second position with the index 1
            driver.FindElementsByClassName("android.widget.Button")[1].Click();








        }
    }
}
