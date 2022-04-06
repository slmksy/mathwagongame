using Assets.Codes;
using UnityEngine;
using UnityEngine.UI;

public class SetSavedLevelTxt : MonoBehaviour
{
    public Text txtLevel;
    public GameObject pnlSavedGame;

    void Start() 
    {
        
       
    }

    void Update() 
    {
        if (PlayerPrefs.HasKey("PlayerLevel"))
        {
            pnlSavedGame.SetActive(true);
            txtLevel.text = ScoreModel.Instance.Level.ToString();
        }
        else
        {
            pnlSavedGame.SetActive(false);
        }
    }
}
