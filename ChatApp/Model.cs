using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    class Model
    {
        //Member
        public string UserValue = "Lars";
        public List<string> Person = new List<string>();

        public string TextValue = "";
        public string SendtoViewValue = "";
        public string Timestemp = "";

        public delegate void ModelHasChanged(string newTextValue);
        public ModelHasChanged DelegateModelChange;

        public delegate void ModeltoDatabase(string Time, string Absender, string Empfaenger, string Text);
        public ModeltoDatabase DelegateWriteToDatabase;


        //Methoden
        public Model()
        {
            Person.Add("Dummy");
        }

        public void UpdateModel(string viewText)
        {
            Timestemp = DateTime.Now.ToString("dd-MM-yy [HH:mm:ss]  ");
            this.SendtoViewValue = Timestemp;
            this.SendtoViewValue += UserValue;
            this.SendtoViewValue += "  :  ";
            this.SendtoViewValue += viewText;
            DelegateWriteToDatabase(Timestemp, UserValue, Person[0], viewText);
            this.SendtoViewValue += "\n";
            DelegateModelChange(SendtoViewValue);
            
        }

    }
}
