using System;

namespace CalendarPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            WeekDayPrinter textPrinter = new WeekDayTextPrinter("2020-2-2");
            WeekDayPrinter htmlPrinter = new WeekDayHtmlPrinter("2020-4-5");
            WeekDayPrinter csvPrinter = new WeekDayCsvPrinter("2020-6-5");
            textPrinter.PrintDayOfWeek();
            htmlPrinter.PrintDayOfWeek();
            csvPrinter.PrintDayOfWeek();
        }
    }
}
