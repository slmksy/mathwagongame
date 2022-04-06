using Assets.Codes;
using UnityEngine;

public class MoveObj : MonoBehaviour
{
    public GameObject[] prerabNumbers;
    private bool isReady;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < prerabNumbers.Length; ++i)
        {
            var obj = Instantiate(prerabNumbers[i], new Vector3(0, 0, 0), Quaternion.identity);
            PositionModel.Instance.AddGameObject(obj);
        }

        PositionModel.Instance.GenerateStartPositions();
        isReady = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isReady) 
        {
            return;
        }
        if (PositionModel.Instance.IsEveryObjectIsNotActiveInScene())
        {
            PositionModel.Instance.GenerateStartPositions();
        }

        else if (PositionModel.Instance.IsEveryObjectOutOfScene()) 
        {
            PositionModel.Instance.GenerateStartPositions();
        }
        else 
        {
            PositionModel.Instance.MoveObjects();
        }
    }
}
