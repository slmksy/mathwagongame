using Assets.Codes;
using UnityEngine;
using UnityEngine.UI;

public class SetLevel : MonoBehaviour
{
    private Text txtLevel;

    void Start() 
    {
        // Get a reference to the text component
        txtLevel = GetComponent<Text>();
        txtLevel.text = ScoreModel.Instance.Level.ToString();
    }
    void Update()
    {
        txtLevel.text = ScoreModel.Instance.Level.ToString();
    }
}
