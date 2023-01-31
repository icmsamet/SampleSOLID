using GameManager;
using UnityEngine;
namespace Pipe
{
    public class PipePoint : MonoBehaviour
    {
        public void PointUpdate()
        {
            GameManagers.instance.point++;
            GameManagers.instance.gameManagerUI.PointUpdate(GameManagers.instance.point);
            PipeController pipeController = new PipeController(this);
            pipeController.CheckProgess(GameManagers.instance.point);
        }
    }
}
