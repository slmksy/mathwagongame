using Assets.Codes;
using UnityEngine;
using UnityEngine.UI;

public class SetMyScore : MonoBehaviour
{
    private Text txtScore;

    void Start() 
    {
        // Get a reference to the text component
        txtScore = GetComponent<Text>();
        txtScore.text = ScoreModel.Instance.CurrentScore.ToString();
    }
    void Update()
    {       
        txtScore.text = ScoreModel.Instance.CurrentScore.ToString();
    }
}
