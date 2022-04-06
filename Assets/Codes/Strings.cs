using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Codes
{
    public class Strings
    {
        private static Strings instance = null;
        private List<Data> lstStr = new List<Data>(); 
        public struct Data 
        {
            public string Id;
            public string Tr;
            public string En;
        }
        
        public static Strings Instance 
        {
            get
            {
                if(instance == null) 
                {
                    instance = new Strings();
                }

                return instance;

            }
        }

        private Strings() 
        {
            lstStr.Add(new Data { Id = "Devam", Tr = "Devam", En = "Continue" });
            lstStr.Add(new Data { Id = "YeniOyun", Tr = "Yeni Oyun", En = "New Game" });
            lstStr.Add(new Data { Id = "Hedef", Tr = "Hedef : ", En = "Target : " });
            lstStr.Add(new Data { Id = "YeniHedef", Tr = "Yeni Hedef :", En = "New Target :" });
            lstStr.Add(new Data { Id = "Puan", Tr = "Puan : ", En = "Score : " });
            lstStr.Add(new Data { Id = "TekrarOyna", Tr = "Tekrar Oyna", En = "Play Again" });
            lstStr.Add(new Data { Id = "SureDoldu", Tr = "Süre\nDoldu!", En = "Time's\nUp!" });
        }

        public string GetStr(string Id, bool isTurkish) 
        {
            var strData = lstStr.Find(d => d.Id == Id);
            return isTurkish ? strData.Tr : strData.En;
        }

    }
}
