using Assets.Codes;
using UnityEngine;
using UnityEngine.UI;

public class PanelWindowScrpit : MonoBehaviour
{
    private GameObject panelLvl,
        panelGameArea, panelFirstScreen, panelTimeOut;

    void Start() 
    {
        Canvas canvas = FindObjectOfType<Canvas>();

        var rect = canvas.GetComponent<RectTransform>();
        rect.localScale = new Vector3(0.275f, 0.2125f, 1f);
        //rect.localScale = new Vector3(0.2444f, 0.2125f, 1f);

        var baseHeightRate = 16.0f;
        var baseWidthRate = 9.0f; 
        var rate = Screen.height / (float)Screen.width;

        if(rate > 1.78)         //18 : 9
        {
            rect.localScale = new Vector3(0.2444f, 0.2125f, 1f);
        }
        else if (rate < 1.35f)  //4:3 = 12:9
        {
            var widthRate = 4 * (baseWidthRate / 3);
            var scaleX = baseHeightRate * rect.localScale.x / widthRate;
            rect.localScale = new Vector3(scaleX, 0.2125f, 1f);
        }

        else if (rate < 1.67f)  //5:3 = 15:9
        {
            var widthRate = 5 * (baseWidthRate / 3);
            var scaleX = baseHeightRate * rect.localScale.x / widthRate;
            rect.localScale = new Vector3(scaleX, 0.2125f, 1f);
        }

       
        panelLvl = GameObject.Find("pnlLevel");
        panelGameArea = GameObject.Find("pnlGameArea");
        panelFirstScreen = GameObject.Find("pnlFirstScreen");
        panelTimeOut = GameObject.Find("pnlTimeOut");

        panelFirstScreen.SetActive(true);
        panelGameArea.SetActive(false);
        panelLvl.SetActive(false);
        panelTimeOut.SetActive(false);


    }
    void Update()
    {
        var currentScore = ScoreModel.Instance.CurrentScore;
        var levelData = LevelModel.Instance.GetLevelData(ScoreModel.Instance.Level);
        var time = ScoreModel.Instance.Time;

        if(time == 0 && panelGameArea.active) 
        {
            panelGameArea.SetActive(false);
            panelTimeOut.SetActive(true);
            ScoreModel.Instance.RestartLevel();                     
        }

        else if (currentScore <= levelData.MaxPoint &&
            currentScore >= levelData.MinPoint &&
            panelGameArea.active)
        {
            ScoreModel.Instance.GoNextLevel();
            panelGameArea.SetActive(false);
            panelLvl.SetActive(true);
        }
    }
}
