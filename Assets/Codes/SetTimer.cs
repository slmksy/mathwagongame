using Assets.Codes;
using UnityEngine;
using UnityEngine.UI;

public class SetTimer : MonoBehaviour
{
    private Text txtTime;

    void Start() 
    {
        // Get a reference to the text component
        txtTime = GetComponent<Text>();
        txtTime.text = ScoreModel.Instance.Time.ToString();
    }
    void Update()
    {
        txtTime.text = ScoreModel.Instance.Time.ToString();
    }
}
