using System;
using System.Collections.Generic;

namespace Day_11
{
    public class TableManager
    {
        private string _tableName = string.Empty;
        private List<string> _tableColumns = new List<string>();
        private List<string> _tableRows = new List<string>();
        public TableManager(string tableName)
        {
            _tableName = tableName;
        }

        ///<summary>
        ///Добавляет столбцы в таблицу
        ///</summary>
        public void AddColumns(params string[] columnNames)
        {
            foreach(string it in columnNames)
            {
                _tableColumns.Add(it);
            }
        }

        ///<summary>
        ///Добавляет строку в таблицу (Не превышайте кол-во столбцов)
        ///</summary>
        public void AddRow(params string[] rowsData)
        {
            string _row = string.Join('|', rowsData);
            _tableRows.Add(_row);
        }

        ///<summary>
        ///Вывод таблицы
        ///</summary>
        public void Output()
        {
            string _lineStr = "-------------------------";
            string _column = string.Join('-', _tableColumns);
            Console.WriteLine("Table Name: " + _tableName);
            Console.WriteLine(_lineStr);
            Console.WriteLine(_column);
            Array.ForEach(_tableRows.ToArray(), it =>
            {
                Console.WriteLine(it);
            });
            Console.WriteLine(_lineStr);
        }
    }
}