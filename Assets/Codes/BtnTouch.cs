using Assets.Codes;
using UnityEngine;

public class BtnTouch : MonoBehaviour
{
    public GameObject pnlLevel;
    public GameObject pnlGameArea;
    public GameObject pnlFirstScreen;
    public GameObject pnlTimeOut;

    public void Line1LeftClick() 
    {
        var value = TouchNumberDetect.Instance.FindNumberInArea(TouchNumberDetect.EnNumberArea.Line1Left);
        ScoreModel.Instance.Dvide(value);
    }

    public void BtnNextLevelClick() 
    {
        ScoreModel.Instance.StartLevel();

        pnlLevel.SetActive(false);
        pnlGameArea.SetActive(true);
    }

    public void BtnPlayAgain() 
    {
        ScoreModel.Instance.StartLevel();
        pnlTimeOut.SetActive(false);
        pnlGameArea.SetActive(true);
       
    }

    public void BtnContinueSavedClick() 
    {
        ScoreModel.Instance.RestartLevel();
        pnlFirstScreen.SetActive(false);
        pnlGameArea.SetActive(true);
    }

    public void BtnNewGameClick() 
    {
        ScoreModel.Instance.StartNewGame();
        pnlFirstScreen.SetActive(false);
        pnlGameArea.SetActive(true);
    }

    public void Line1RightClick()
    {
        var value = TouchNumberDetect.Instance.FindNumberInArea(TouchNumberDetect.EnNumberArea.Line1Right);
        ScoreModel.Instance.Sum(value);
    }
    public void Line2LeftClick()
    {
        var value = TouchNumberDetect.Instance.FindNumberInArea(TouchNumberDetect.EnNumberArea.Line2Left);
        ScoreModel.Instance.Dvide(value);
    }
    public void Line2RightClick()
    {
        var value = TouchNumberDetect.Instance.FindNumberInArea(TouchNumberDetect.EnNumberArea.Line2Right);
        ScoreModel.Instance.Sum(value);
    }
    public void Line3LeftClick()
    {
        var value = TouchNumberDetect.Instance.FindNumberInArea(TouchNumberDetect.EnNumberArea.Line3Left);
        ScoreModel.Instance.Mult(value);
    }
    public void Line3RightClick()
    {
        var value = TouchNumberDetect.Instance.FindNumberInArea(TouchNumberDetect.EnNumberArea.Line3Right);
        ScoreModel.Instance.Diff(value);
    }
    public void Line4LeftClick()
    {
        var value = TouchNumberDetect.Instance.FindNumberInArea(TouchNumberDetect.EnNumberArea.Line4Left);
        ScoreModel.Instance.Mult(value);
    }
    public void Line4RightClick()
    {
        var value = TouchNumberDetect.Instance.FindNumberInArea(TouchNumberDetect.EnNumberArea.Line4Right);
        ScoreModel.Instance.Diff(value);
    }
}
