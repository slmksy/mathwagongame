using Assets.Codes;
using UnityEngine;
using UnityEngine.UI;

public class SetTargetScore : MonoBehaviour
{
    private Text txtScore;

    void Start() 
    {
        // Get a reference to the text component
        txtScore = GetComponent<Text>();
    }
    void Update()
    {       
        txtScore.text = ScoreModel.Instance.TargetScoreMin.ToString() + " - " + ScoreModel.Instance.TargetScoreMax.ToString();
    }
}
