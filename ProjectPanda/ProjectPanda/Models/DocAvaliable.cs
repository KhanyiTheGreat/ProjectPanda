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



        public static ObservableCollection<DocAvaliable> ToEnumerableASync()
        {


            // need to add some code.
            return DocList;
        }




        internal static Task GetList()
        {
            throw new NotImplementedException();
        }
        #region ObservableCOllectionCOllection=>DocAvaliable
        public static ObservableCollection<DocAvaliable> DocList = new ObservableCollection<DocAvaliable>
        {
            new DocAvaliable {ID=1,Name="Dr Zulu", Varsity="MBchB(Ukzn)" },
            new DocAvaliable {ID=2,Name="Dr Naidoo", Varsity="MBchB(Wits)" },
            new DocAvaliable {ID=3,Name="Dr Duma", Varsity="MBchB(UWC),FC Orth(SA),Mmed Ortho(Natal)" },
            new DocAvaliable {ID=4,Name="Dr McGhee", Varsity="MBchB(UCT)" },
            new DocAvaliable {ID=5,Name="Dr Nobody", Varsity="MBchB(UL)" },
            new DocAvaliable {ID=6,Name="Dr 50Cent", Varsity="MBchB(Stellenbosch)" }


        };
        #endregion

    }
}