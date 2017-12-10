using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.Models;
using ProjectPanda.Helpers;
namespace ProjectPanda.Models
{
    public class DocAvaliable : BaseDataObject
    {

        #region Declirations

        public int ID { get; set; }
        public String Name { get; set; }
        public String Varsity { get; set; }
        public string DocsImageUrl { get; set; } // must add images to database
        #endregion
      
        
        
        #region DocOnCall
        string text = string.Empty;
        string Varsity1 = string.Empty;

        public string Name1
        {
            get { return Name1; }
            set { SetProperty(ref text, value); }
        }
        public string DocVarsity
        {
            get { return DocVarsity; }
            set { SetProperty(ref Varsity1, value); }
        }

        #endregion



                

       

    }
}