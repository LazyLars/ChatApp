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
        public string TextValue = "";
        public string UserValue = "Lars";
        public string SendtoViewValue = "";

        public delegate void ModelHasChanged(string newTextValue);
        public ModelHasChanged DelegateModelChange;


        //Methoden
        public void UpdateModel(string viewText)
        {
            this.SendtoViewValue = DateTime.Now.ToString("dd-MM-yy [HH:mm:ss]  ");
            this.SendtoViewValue += UserValue;
            this.SendtoViewValue += "  :  ";
            this.SendtoViewValue += viewText;
            DelegateModelChange(SendtoViewValue);
        }

    }
}
