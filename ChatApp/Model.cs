//using system;
//using system.collections.generic;
//using system.linq;
//using system.text;
//using system.threading.tasks;


        
//        Wird nicht mehr benötigt !!!!!!!!!!
        




//namespace chatapp
//{
//    class model
//    {
//        //member
//        public string uservalue = "lars";
//        public list<string> person = new list<string>();

//        public string type = "msg";
//        public string textvalue = "";
//        public string sendtoviewvalue = "";
//        public string timestemp = "";

//        public delegate void modelhaschanged(string newtextvalue, string type, string content, string userfrom, string userto);
//        public modelhaschanged delegatemodelchange;

//        public delegate void modeltodatabase(string time, string absender, string empfaenger, string text);
//        public modeltodatabase delegatewritetodatabase;

//        public delegate void modeltosentmessage(string type, string content, string userfrom, string userto);
//        public modeltosentmessage delegatebuiltmessage;


//        //methoden
//        public model()
//        {
//            person.add("dummy");
//        }
        
//        public void updatemodel(string viewtext)
//        {
//            timestemp = datetime.now.tostring("dd-mm-yy [hh:mm:ss]  ");
//            this.sendtoviewvalue = timestemp;
//            this.sendtoviewvalue += uservalue;
//            this.sendtoviewvalue += "  :  ";
//            this.sendtoviewvalue += viewtext;
//            delegatewritetodatabase(timestemp, uservalue, person[0], viewtext);
//            //delegatebuiltmessage(type, viewtext, uservalue, "pascal");
//            this.sendtoviewvalue += "\n";
//            delegatemodelchange(sendtoviewvalue, type, viewtext, uservalue, "10.2.23.14");
//        }

//    }
//}
