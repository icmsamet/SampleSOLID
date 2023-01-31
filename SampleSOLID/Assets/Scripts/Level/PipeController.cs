using Pipe;
using UnityEngine;
using GameManager;
using Level;

namespace Pipe
{
    public class PipeController
    {
        PipePoint pipePoint;
        LevelProgressScriptableObject levelProgress;
        public PipeController(PipePoint _pipePoint)
        {
            pipePoint = _pipePoint;
            levelProgress = (LevelProgressScriptableObject)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/Resources/Level/Level Progress.asset", typeof(LevelProgressScriptableObject));
        }

        public void CheckProgess(int point)
        {
            foreach (var item in levelProgress.levelProgressSituations)
            {
                if (point == item.TargetPoint)
                {
                    GameManagers.instance.gameManagerPipe.SetSpawner(item.Delay, item.Distance, item.Speed);
                    //GameManagers.instance.gameManagerPipe.StartSpawn();
                }
            }
        }
    }
}
