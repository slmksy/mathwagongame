using System.Timers;
using UnityEngine;

namespace Assets.Codes
{

    public class ScoreModel
    {
        private static ScoreModel instance = null;
        private const int MaxScore = 99999;
        private int currentScore;

        public int CurrentScore
        {
            get 
            {
                return currentScore;
            }
            private set 
            {
                currentScore = value;
            }
        }

        public void GoNextLevel() 
        {
            Level++;

            var levelData = LevelModel.Instance.GetLevelData(Level);
            PlayerPrefs.SetInt("PlayerLevel", Level);
            PlayerPrefs.Save();

            TargetScoreMin = levelData.MinPoint;
            TargetScoreMax = levelData.MaxPoint;
            Time = levelData.Time;
            Speed = levelData.Speed;
            CurrentScore = 0;
        }

        public void RestartLevel() 
        {
            var levelData = LevelModel.Instance.GetLevelData(Level);

            TargetScoreMin = levelData.MinPoint;
            TargetScoreMax = levelData.MaxPoint;
            Time = levelData.Time;
            Speed = levelData.Speed;
            CurrentScore = 0;

            StartLevel();
        }

        public void StartNewGame() 
        {
            Level = 1;
            RestartLevel();
        }

        public void StartLevel() 
        {
            foreach(var obj in PositionModel.Instance.GetObjList()) 
            {
                obj.active = false;
            }

            var levelData = LevelModel.Instance.GetLevelData(Level);
            Time = levelData.Time;
        }

        public int TargetScoreMin
        {
            get;
            private set;
        }

        public int TargetScoreMax
        {
            get;
            private set;
        }

        public int Time
        {
            get;
            private set;
        }
        public int Level 
        {
            get;
            private set;
        }

        public float Speed
        {
            get;
            private set;
        }


        public static ScoreModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ScoreModel();
                }

                return instance;
            }
        }

        private ScoreModel()
        {
            Level = PlayerPrefs.GetInt("PlayerLevel", 1);

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if(Time > 0) 
            {
                Time--;
            }
        }

        public void Sum(int value)
        {
            if (value == -1)
            {
                return;
            }

            if (CurrentScore + value > MaxScore )
            {
                CurrentScore = MaxScore;
                return;
            }

            CurrentScore += value;
        }

        public void Diff(int value)
        {
            if (value == -1)
            {
                return;
            }

            if (CurrentScore - value < -MaxScore)
            {
                CurrentScore = -MaxScore;
                return;
            }

            CurrentScore -= value;
        }

        public void Mult(int value)
        {
            if (value == -1)
            {
                return;
            }

            if (CurrentScore * value > MaxScore)
            {
                CurrentScore = MaxScore;
                return;
            }

            if (CurrentScore * value < -MaxScore)
            {
                CurrentScore = -MaxScore;
                return;
            }

            CurrentScore *= value;
        }

        public void Dvide(int value)
        {
            if (value == 0 || value == -1)
            {
                return;
            }

            CurrentScore /= value;
        }
    }
}
