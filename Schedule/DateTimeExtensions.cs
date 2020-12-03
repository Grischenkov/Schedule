using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Schedule
{
    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            return dt.AddDays(-1 * ((7 + (dt.DayOfWeek - startOfWeek)) % 7)).Date;
        }

        public static bool IsEvenWeek(this DateTime dt)
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("http://technolog.edu.ru");
            bool isEven = webDriver.FindElement(By.Id("nedelya")).Text == "Чётная учебная неделя";

            if (dt.Date >= DateTime.Today.StartOfWeek(DayOfWeek.Monday).Date && dt <= DateTime.Today.StartOfWeek(DayOfWeek.Sunday).AddDays(7).Date) return isEven;

            DateTime tmpDate = dt;
            int step = dt < DateTime.Today.StartOfWeek(DayOfWeek.Monday) ? 7 : -7,
                count = 0;

            do
            {
                count++;
                tmpDate = tmpDate.Date.AddDays(step);
            } while (tmpDate.Date < DateTime.Today.StartOfWeek(DayOfWeek.Monday).Date || tmpDate > DateTime.Today.StartOfWeek(DayOfWeek.Sunday).AddDays(7).Date);

            return count % 2 == 0 ? isEven : !isEven;
        }
    }
}
