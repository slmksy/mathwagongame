using Assets.Codes;
using System.Collections.Generic;
using UnityEngine;

public class TouchNumberDetect
{
    private static TouchNumberDetect instance = null;
    public enum EnNumberArea
    {
        Line1Left,
        Line1Right,
        Line2Left,
        Line2Right,
        Line3Left,
        Line3Right,
        Line4Left,
        Line4Right,

    }

    public static TouchNumberDetect Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new TouchNumberDetect();
            }

            return instance;
        }
    }

    private Dictionary<EnNumberArea, Rect> dictRect = new Dictionary<EnNumberArea, Rect>();

    private TouchNumberDetect()
    {
        dictRect.Add(EnNumberArea.Line1Left, new Rect(-2.763f, 1.9f, 2.663f, 2.1f));
        dictRect.Add(EnNumberArea.Line1Right, new Rect(0.04f, 1.9f, 2.663f, 2.1f));
        dictRect.Add(EnNumberArea.Line2Left, new Rect(-2.763f, -0.255f, 2.663f, 2.1f));
        dictRect.Add(EnNumberArea.Line2Right, new Rect(0.04f, -0.255f, 2.663f, 2.1f));
        dictRect.Add(EnNumberArea.Line3Left, new Rect(-2.763f, -2.325f, 2.663f, 2.1f));
        dictRect.Add(EnNumberArea.Line3Right, new Rect(0.04f, -2.325f, 2.663f, 2.1f));
        dictRect.Add(EnNumberArea.Line4Left, new Rect(-2.763f, -4.724f, 2.663f, 2.1f));
        dictRect.Add(EnNumberArea.Line4Right, new Rect(0.04f, -4.724f, 2.663f, 2.1f));

    }

    public int FindNumberInArea(EnNumberArea area)
    {
        var objList = PositionModel.Instance.GetObjList();

        for (int i = 0; i< objList.Count; ++i)
        {
            var objPos = objList[i].transform.position;
            if (objList[i].active && dictRect[area].Contains(new Vector2(objPos.x, objPos.y)))
            {
                objList[i].SetActive(false);
                return i;
            }
        }

        return -1;
    }
}
