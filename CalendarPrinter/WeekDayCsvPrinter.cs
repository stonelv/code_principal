using System;
using System.Text;

namespace CalendarPrinter
{
    internal class WeekDayCsvPrinter : WeekDayPrinter
    {
        public WeekDayCsvPrinter(string dateToPrint) : base(dateToPrint)
        {
        }

        internal override void PrintDayOfWeek()
        {
            for (var i = 0; i < 7; i++)
            {
                title
                    .Append(GetDayOfWeekChineseName(i))
                    .Append("\t");
                content
                    .Append(firstDate.AddDays(i).Day)
                    .Append("\t");

            }
            PrintToConsole(title + "\n" + content);
        }
    }
}