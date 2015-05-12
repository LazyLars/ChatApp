using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    class Controller
    {
        //Member
        public View ContrView = new View();
        public Model ContrModel = new Model();

        //Methoden
        public Controller()
        {
            //ContrModel.TextValue = "Hallo";
            RegisterView(ContrView);

            ContrModel.DelegateModelChange += this.WhenModelChanged;

            ContrView.Show();
            Application.Run(ContrView);
        }
        
        public void RegisterView(View newView)
        {
            newView.DelegateViewHasChanged += this.WhenViewChanged;    
        }

        private void WhenModelChanged(string viewString)
        {
            ContrView.SetNachrichtenVerlauf(viewString);
        }

        private void WhenViewChanged(View changeView)
        {
            ContrModel.UpdateModel(ContrView.valText);
        }
    }
}
