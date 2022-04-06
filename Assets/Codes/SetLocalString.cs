using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Codes
{
    public class SetLocalString : MonoBehaviour
    {
        private Text txtLevel;
        public string strId;

        void Start()
        {
            // Get a reference to the text component
            txtLevel = GetComponent<Text>();
            var isTurkısh = Application.systemLanguage == SystemLanguage.Turkish;
            txtLevel.text = Strings.Instance.GetStr(strId, isTurkısh);
        }
    }
}
