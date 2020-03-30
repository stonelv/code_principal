using System;
using System.Text;

namespace CalendarPrinter
{
    public abstract class WeekDayPrinter
    {
        private DateTime dateToPrint;
        protected DateTime firstDate;
        protected StringBuilder title, content;

        public WeekDayPrinter(string dateToPrint)
        {
            this.dateToPrint = DateTime.Parse(dateToPrint);
            firstDate = GetFirstDate();
            title = new StringBuilder();
            content = new StringBuilder();
        }

        internal abstract void PrintDayOfWeek();

        protected DateTime GetFirstDate()
        {
            return dateToPrint.AddDays((int)dateToPrint.DayOfWeek * -1);
        }

        protected void PrintToConsole(string result)
        {
            Console.WriteLine(result);
        }

        protected string GetDayOfWeekChineseName(int dayOfWeek)
        {
            switch(dayOfWeek)
            {
                case 0:
                    return "日";
                case 1:
                    return "一";
                case 2:
                    return "二";
                case 3:
                    return "三";
                case 4:
                    return "四";
                case 5:
                    return "五";
                case 6:
                    return "六";
                default:
                    return "";
            }
        }
    }
}
