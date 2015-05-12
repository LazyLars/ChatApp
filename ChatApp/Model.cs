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

        public delegate void ModelHasChanged(string newTextValue);
        public ModelHasChanged DelegateModelChange;


        //Methoden
        public void UpdateModel(string viewText)
        {
            this.TextValue = viewText;
            DelegateModelChange(TextValue);
        }


    }
}
