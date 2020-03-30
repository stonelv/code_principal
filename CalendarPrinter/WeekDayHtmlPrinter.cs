using System;
using System.Text;

namespace CalendarPrinter
{
    internal class WeekDayHtmlPrinter : WeekDayPrinter
    {
        public WeekDayHtmlPrinter(string dateToPrint) : base(dateToPrint)
        {
        }

        internal override void PrintDayOfWeek()
        {
            for (var i = 0; i < 7; i++)
            {
                title
                    .Append("<td>")
                    .Append(GetDayOfWeekChineseName(i))
                    .Append("</td>");
                content
                    .Append("<td>")
                    .Append(firstDate.AddDays(i).Day)
                    .Append("</td>");

            }
            PrintToConsole("<table><thead><tr>" + title + "</tr></thead>" +
                "<tbody><tr>" + content + "</tr><tbody></table>");
        }
    }
}