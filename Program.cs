using System;

namespace Day_11
{
    class Program
    {
        static void Main(string[] args)
        {
            TableManager tM = new TableManager("dbo.students");
            tM.AddColumns("ID", "Name", "Surname", "PhoneNumber", "HomeAdress");
            tM.AddRow("1", "Фаридун", "Бердиев", "+992906908008", "Дехоти 45/3");
            tM.AddRow("2", "Мичгона", "Чумаева", "+992988000111", "Дехоти 42/1");
            tM.AddRow("3", "Андрей", "Васильевич", "+992778877777", "Дехоти 48/1");
            tM.AddRow("4", "Рухсора", "Рухсоровна", "+992666888999", "Сино 15/9");
            tM.Output();
        }
    }
}
