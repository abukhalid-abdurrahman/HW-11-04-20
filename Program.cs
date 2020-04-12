using System;

namespace Day_11
{
    class Program
    {
        static void Main(string[] args)
        {
            TableManager tM = new TableManager("dbo.students");
            tM.AddColumns("ID", "Name", "Surname", "PhoneNumber", "HomeAdress");
            tM.AddRow("1", "Фаридун", "Бердиев", "+992901915905", "Дехоти 45/3");
        }
    }
}
