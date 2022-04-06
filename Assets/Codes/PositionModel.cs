using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codes
{
    public class PositionModel
    {

        private static PositionModel instance = null;
        private static readonly System.Random random = new System.Random();
        private static readonly object randomLock = new object();

        public enum EnStartPosition
        {
            LeftLine1Column1,
            LeftLine1Column2,
            LeftLine1Column3,
            LeftLine2Column1,
            LeftLine2Column2,
            LeftLine2Column3,
            LeftLine3Column1,
            LeftLine3Column2,
            LeftLine3Column3,
            LeftLine4Column1,
            LeftLine4Column2,
            LeftLine4Column3,
            RightLine1Column1,
            RightLine1Column2,
            RightLine1Column3,
            RightLine2Column1,
            RightLine2Column2,
            RightLine2Column3,
            RightLine3Column1,
            RightLine3Column2,
            RightLine3Column3,
            RightLine4Column1,
            RightLine4Column2,
            RightLine4Column3
        }

        private Dictionary<EnStartPosition, Vector3> startPositions;
        private Dictionary<EnStartPosition, GameObject> objPositions;

        private List<GameObject> lstObjects;
        private List<EnStartPosition> lstAvaliableStartPos;

        public static PositionModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PositionModel();
                }

                return instance;
            }
        }

        private PositionModel()
        {
            startPositions = new Dictionary<EnStartPosition, Vector3>();
            objPositions = new Dictionary<EnStartPosition, GameObject>();

            lstObjects = new List<GameObject>();
            lstAvaliableStartPos = new List<EnStartPosition>();

            startPositions.Add(EnStartPosition.LeftLine1Column2, new Vector3(-6.5f, 2.480f, -1));
            startPositions.Add(EnStartPosition.LeftLine1Column3, new Vector3(-3.7f, 2.480f, -1));
            startPositions.Add(EnStartPosition.LeftLine1Column1, new Vector3(-9.3f, 2.480f, -1));

            startPositions.Add(EnStartPosition.LeftLine2Column2, new Vector3(-6.5f, 0.277f, -1));
            startPositions.Add(EnStartPosition.LeftLine2Column3, new Vector3(-3.7f, 0.277f, -1));
            startPositions.Add(EnStartPosition.LeftLine2Column1, new Vector3(-9.3f, 0.277f, -1));

            startPositions.Add(EnStartPosition.LeftLine3Column2, new Vector3(-6.5f, -1.788f, -1));
            startPositions.Add(EnStartPosition.LeftLine3Column3, new Vector3(-3.7f, -1.788f, -1));
            startPositions.Add(EnStartPosition.LeftLine3Column1, new Vector3(-9.3f, -1.788f, -1));

            startPositions.Add(EnStartPosition.LeftLine4Column2, new Vector3(-6.5f, -4.171f, -1));
            startPositions.Add(EnStartPosition.LeftLine4Column3, new Vector3(-3.7f, -4.171f, -1));
            startPositions.Add(EnStartPosition.LeftLine4Column1, new Vector3(-9.3f, -4.171f, -1));

            startPositions.Add(EnStartPosition.RightLine1Column1, new Vector3(3.5f, 2.480f, -1));
            startPositions.Add(EnStartPosition.RightLine1Column2, new Vector3(6.3f, 2.480f, -1));
            startPositions.Add(EnStartPosition.RightLine1Column3, new Vector3(9.1f, 2.480f, -1));

            startPositions.Add(EnStartPosition.RightLine2Column1, new Vector3(3.5f, 0.277f, -1));
            startPositions.Add(EnStartPosition.RightLine2Column2, new Vector3(6.3f, 0.277f, -1));
            startPositions.Add(EnStartPosition.RightLine2Column3, new Vector3(9.1f, 0.277f, -1));

            startPositions.Add(EnStartPosition.RightLine3Column1, new Vector3(3.5f, -1.788f, -1));
            startPositions.Add(EnStartPosition.RightLine3Column2, new Vector3(6.3f, -1.788f, -1));
            startPositions.Add(EnStartPosition.RightLine3Column3, new Vector3(9.1f, -1.788f, -1));

            startPositions.Add(EnStartPosition.RightLine4Column1, new Vector3(3.5f, -4.171f, -1));
            startPositions.Add(EnStartPosition.RightLine4Column2, new Vector3(6.3f, -4.171f, -1));
            startPositions.Add(EnStartPosition.RightLine4Column3, new Vector3(9.1f, -4.171f, -1));

            lstAvaliableStartPos.Add(EnStartPosition.LeftLine1Column1);
            lstAvaliableStartPos.Add(EnStartPosition.LeftLine1Column2);
            lstAvaliableStartPos.Add(EnStartPosition.LeftLine1Column3);
            lstAvaliableStartPos.Add(EnStartPosition.LeftLine3Column1);
            lstAvaliableStartPos.Add(EnStartPosition.LeftLine3Column2);
            lstAvaliableStartPos.Add(EnStartPosition.LeftLine3Column3);

            lstAvaliableStartPos.Add(EnStartPosition.RightLine2Column1);
            lstAvaliableStartPos.Add(EnStartPosition.RightLine2Column2);
            lstAvaliableStartPos.Add(EnStartPosition.RightLine2Column3);
            lstAvaliableStartPos.Add(EnStartPosition.RightLine4Column1);
            lstAvaliableStartPos.Add(EnStartPosition.RightLine4Column2);
            lstAvaliableStartPos.Add(EnStartPosition.RightLine4Column3);
        }

        public void AddGameObject(GameObject obj)
        {
            var firstPos = startPositions[EnStartPosition.LeftLine1Column1];
            obj.transform.position = new Vector3(firstPos.x, firstPos.y, firstPos.z);
            lstObjects.Add(obj);

        }

        public void GenerateStartPositions()
        {
            //SetStartPosition(EnStartPosition.LeftLine1Column1, lstObjects[1]);
            //SetStartPosition(EnStartPosition.LeftLine1Column2, lstObjects[0]);
            //SetStartPosition(EnStartPosition.LeftLine3Column1, lstObjects[2]);
            //SetStartPosition(EnStartPosition.LeftLine3Column2, lstObjects[3]);
            //SetStartPosition(EnStartPosition.RightLine2Column1, lstObjects[4]);
            //SetStartPosition(EnStartPosition.RightLine2Column2, lstObjects[5]);
            //SetStartPosition(EnStartPosition.RightLine4Column1, lstObjects[6]);
            //SetStartPosition(EnStartPosition.RightLine4Column2, lstObjects[7]);

            lock (lstObjects)
            {
                var indexList = GetRandomNumberList(10);
                int i = 0, posIndex = 0;
                objPositions.Clear();

                for (int row = 0; row < 4; ++row)
                {

                    var columCount = GetRandomNumber(1, 4);
                    for (int column = 0; column < columCount; ++column)
                    {
                        var obj = lstObjects[indexList[i++]];
                        var startPos = lstAvaliableStartPos[posIndex];

                        obj.SetActive(true);
                        SetStartPosition(startPos, obj);
                        posIndex++;

                        if (i == 8)
                        {
                            return;
                        }
                    }

                    posIndex += (3 - columCount);
                }
            }
        }

        public List<int> GetRandomNumberList(int count)
        {
            var indexList = new List<int>();
            var index = GetRandomNumber(0, 100) % count;

            for (int i = 0; i < count; ++i)
            {
                while (indexList.Contains(index))
                {
                    index = GetRandomNumber(0, 100) % count;
                }

                indexList.Add(index);
            }

            return indexList;

        }

        public int GetRandomNumber(int min, int max)
        {
            lock (randomLock)
            {
                return random.Next(min, max);
            }
        }

        public Dictionary<EnStartPosition, GameObject> GetDict()
        {
            lock (objPositions)
            {
                return objPositions;
            }
        }

        public List<GameObject> GetObjList()
        {
            lock (objPositions)
            {
                return lstObjects;
            }
        }

        public void MoveObjects()
        {

            foreach (PositionModel.EnStartPosition startPositions in objPositions.Keys)
            {

                switch (startPositions)
                {
                    case PositionModel.EnStartPosition.LeftLine1Column1:
                    case PositionModel.EnStartPosition.LeftLine1Column2:
                    case PositionModel.EnStartPosition.LeftLine1Column3:
                    case PositionModel.EnStartPosition.LeftLine3Column1:
                    case PositionModel.EnStartPosition.LeftLine3Column2:
                    case PositionModel.EnStartPosition.LeftLine3Column3:
                        objPositions[startPositions].transform.position = MoveToRight(objPositions[startPositions].transform.position);
                        break;
                    case PositionModel.EnStartPosition.RightLine2Column1:
                    case PositionModel.EnStartPosition.RightLine2Column2:
                    case PositionModel.EnStartPosition.RightLine2Column3:
                    case PositionModel.EnStartPosition.RightLine4Column1:
                    case PositionModel.EnStartPosition.RightLine4Column2:
                    case PositionModel.EnStartPosition.RightLine4Column3:
                        objPositions[startPositions].transform.position = MoveToLeft(objPositions[startPositions].transform.position);
                        break;
                }
            }
        }

        public bool IsEveryObjectOutOfScene()
        {
            foreach (var obj in objPositions)
            {
                var pos = obj.Value.transform.position;

                if (pos.x >= startPositions[EnStartPosition.LeftLine1Column3].x &&
                    pos.x <= startPositions[EnStartPosition.RightLine4Column1].x)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsEveryObjectIsNotActiveInScene()
        {
            foreach (var obj in objPositions)
            {
                var pos = obj.Value.transform.position;

                if (pos.x >= startPositions[EnStartPosition.LeftLine1Column3].x &&
                     pos.x <= startPositions[EnStartPosition.RightLine4Column1].x &&
                     obj.Value.active)
                {
                    return false;
                }
            }
            return true;
        }


        public Vector3 MoveToRight(Vector3 vec)
        {
            var speed = ScoreModel.Instance.Speed;
            var oldPos = vec;
            return new Vector3(oldPos.x + speed, oldPos.y, oldPos.z);
        }

        public Vector3 MoveToLeft(Vector3 obj)
        {
            var speed = ScoreModel.Instance.Speed;
            var oldPos = obj;
            return new Vector3(oldPos.x - speed, oldPos.y, oldPos.z);
        }

        private void SetStartPosition(EnStartPosition startPos, GameObject obj)
        {
            if (!objPositions.ContainsKey(startPos))
            {
                objPositions.Add(startPos, obj);
                obj.transform.position = startPositions[startPos];
            }
        }
    }
}
