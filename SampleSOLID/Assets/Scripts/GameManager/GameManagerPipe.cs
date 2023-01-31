using Pipe;
using UnityEngine;

namespace GameManager
{
    public class GameManagerPipe
    {
        PipeSpawner pipeSpawner;
        float delay;
        float distance;
        float speed;
        public GameManagerPipe(PipeSpawner _pipeSpawner)
        {
            pipeSpawner = _pipeSpawner;
        }
        public void StartGame()
        {
            SetSpawner(1,.5f,3);
            pipeSpawner.StartGame();
        }
        public void SetSpawner(float _delay,float _distance,float _speed)
        {
            pipeSpawner.SetProperties(_delay, _distance, _speed);
        }
        public void StartSpawn()
        {
            pipeSpawner.StartGame();
        }
    }
}
