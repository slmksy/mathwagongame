using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Codes
{
    public class LevelModel
    {
        private static LevelModel instance = null;
        private Dictionary<int, LevelData> dictLevel = new Dictionary<int, LevelData>();

        public struct LevelData
        {
            public int MinPoint;
            public int MaxPoint;
            public int Time;
            public float Speed;
        }
        public static LevelModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LevelModel();
                }

                return instance;
            }
        }

        private LevelModel() 
        {
            CreateLevelData();
        }

        private void CreateLevelData() 
        {
            dictLevel.Add(1, new LevelData { MinPoint = 20, MaxPoint = 40, Speed = 0.01f, Time = 120 });
            dictLevel.Add(2, new LevelData { MinPoint = 30, MaxPoint = 50, Speed = 0.0103f, Time = 115 });
            dictLevel.Add(3, new LevelData { MinPoint = 40, MaxPoint = 50, Speed = 0.0106f, Time = 110 });
            dictLevel.Add(4, new LevelData { MinPoint = 50, MaxPoint = 60, Speed = 0.0109f, Time = 105 });
            dictLevel.Add(5, new LevelData { MinPoint = 60, MaxPoint = 70, Speed = 0.0112f, Time = 100 });
            dictLevel.Add(6, new LevelData { MinPoint = 70, MaxPoint = 80, Speed = 0.0115f, Time = 95 });
            dictLevel.Add(7, new LevelData { MinPoint = 80, MaxPoint = 90, Speed = 0.0118f, Time = 90 });
            dictLevel.Add(8, new LevelData { MinPoint = 90, MaxPoint = 100, Speed = 0.0121f, Time = 90 });
            dictLevel.Add(9, new LevelData { MinPoint = 100, MaxPoint = 105, Speed = 0.0124f, Time = 90 });
            dictLevel.Add(10, new LevelData { MinPoint = 110, MaxPoint = 115, Speed = 0.0127f, Time = 85 });
            dictLevel.Add(11, new LevelData { MinPoint = 120, MaxPoint = 125, Speed = 0.0130f, Time = 85 });
            dictLevel.Add(12, new LevelData { MinPoint = 130, MaxPoint = 135, Speed = 0.0133f, Time = 85 });
            dictLevel.Add(13, new LevelData { MinPoint = 140, MaxPoint = 145, Speed = 0.0136f, Time = 80 });
            dictLevel.Add(14, new LevelData { MinPoint = 150, MaxPoint = 155, Speed = 0.0139f, Time = 80 });
            dictLevel.Add(15, new LevelData { MinPoint = 160, MaxPoint = 163, Speed = 0.0142f, Time = 80 });
            dictLevel.Add(16, new LevelData { MinPoint = 164, MaxPoint = 167, Speed = 0.0145f, Time = 75 });
            dictLevel.Add(17, new LevelData { MinPoint = 168, MaxPoint = 171, Speed = 0.0148f, Time = 75 });
            dictLevel.Add(18, new LevelData { MinPoint = 174, MaxPoint = 177, Speed = 0.0151f, Time = 75 });
            dictLevel.Add(19, new LevelData { MinPoint = 178, MaxPoint = 181, Speed = 0.0154f, Time = 70 });
            dictLevel.Add(20, new LevelData { MinPoint = 184, MaxPoint = 187, Speed = 0.0157f, Time = 70 });
            dictLevel.Add(21, new LevelData { MinPoint = 190, MaxPoint = 193, Speed = 0.0160f, Time = 70 });
            dictLevel.Add(22, new LevelData { MinPoint = 194, MaxPoint = 197, Speed = 0.0163f, Time = 65 });
            dictLevel.Add(23, new LevelData { MinPoint = 200, MaxPoint = 203, Speed = 0.0166f, Time = 65 });
            dictLevel.Add(24, new LevelData { MinPoint = 204, MaxPoint = 207, Speed = 0.0169f, Time = 65 });
            dictLevel.Add(25, new LevelData { MinPoint = 208, MaxPoint = 210, Speed = 0.0172f, Time = 60 });
            dictLevel.Add(26, new LevelData { MinPoint = 211, MaxPoint = 213, Speed = 0.0175f, Time = 60 });
            dictLevel.Add(27, new LevelData { MinPoint = 214, MaxPoint = 216, Speed = 0.0178f, Time = 55 });
            dictLevel.Add(28, new LevelData { MinPoint = 217, MaxPoint = 219, Speed = 0.0181f, Time = 50 });
            dictLevel.Add(29, new LevelData { MinPoint = 220, MaxPoint = 222, Speed = 0.0184f, Time = 45 });
            dictLevel.Add(30, new LevelData { MinPoint = 223, MaxPoint = 225, Speed = 0.0187f, Time = 45 });
            dictLevel.Add(31, new LevelData { MinPoint = 226, MaxPoint = 228, Speed = 0.019f, Time = 45 });
            dictLevel.Add(32, new LevelData { MinPoint = 229, MaxPoint = 231, Speed = 0.0193f, Time = 45 });
            dictLevel.Add(33, new LevelData { MinPoint = 232, MaxPoint = 234, Speed = 0.0196f, Time = 45 });
            dictLevel.Add(34, new LevelData { MinPoint = 235, MaxPoint = 237, Speed = 0.0199f, Time = 45 });
            dictLevel.Add(35, new LevelData { MinPoint = 238, MaxPoint = 240, Speed = 0.0202f, Time = 45 });
            dictLevel.Add(36, new LevelData { MinPoint = 241, MaxPoint = 243, Speed = 0.0205f, Time = 45 });
            dictLevel.Add(37, new LevelData { MinPoint = 244, MaxPoint = 246, Speed = 0.0208f, Time = 45 });
            dictLevel.Add(38, new LevelData { MinPoint = 247, MaxPoint = 249, Speed = 0.0211f, Time = 45 });
            dictLevel.Add(39, new LevelData { MinPoint = 250, MaxPoint = 252, Speed = 0.0214f, Time = 45 });
            dictLevel.Add(40, new LevelData { MinPoint = 253, MaxPoint = 256, Speed = 0.0217f, Time = 45 });
        }

        public LevelData GetLevelData(int levelNo) 
        {
            if (dictLevel.ContainsKey(levelNo)) 
            {
                return dictLevel[levelNo];
            }

            return dictLevel[0];
        }
    }
}
