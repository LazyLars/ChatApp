using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    class DataBase
    {
        //Member
        public string connectionString;
        public List<List<string>> ResultList;
        public int Rows;
        public int Cols;

        //Methoden
        //
        //Klassenmethoden werden vererbt und sind funktional in der Kindklasse zu finden.
        //Methoden sind hier definiert, da diese umbedingt benötigt werden um eine DB Anbindung und Nutzung zu schaffen
        //
        public DataBase() { ResultList = new List<List<string>>(); }
        public DataBase(string connectionString) { }

        public virtual bool Open() { return false; }
        public virtual void Close() { }
        public virtual bool Execute(string strCommand) { return false; }
        public virtual bool TableExists(string strTableName) { return false; }
        public virtual bool InsertData(string text, string text1, string text2, string text3, string text4) { return false; }

    };
}
