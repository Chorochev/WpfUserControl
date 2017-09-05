using System;
using System.Collections.Generic;

namespace WpfUserControl
{
    /// <summary>
    /// Модель данных для контекста
    /// </summary>
    public class MyDataContext
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public List<String> ListMessage { get; set; }
    }
}
