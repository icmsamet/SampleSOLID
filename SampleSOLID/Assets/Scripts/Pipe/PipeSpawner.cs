using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameManager;

namespace Pipe
{
    public class PipeSpawner : MonoBehaviour
    {
        [SerializeField] GameManagers m_gameManagers;
        [SerializeField] Pipe m_Pipe;
        [SerializeField] Transform spawnPoint;
        PipeSpawnPosition pipeSpawnPosition;
        public float delay;
        public float distance;
        public float speed;
        public IEnumerator SpawnPipe()
        {
            while (m_gameManagers.isPlaying)
            {
                pipeSpawnPosition = new PipeSpawnPosition(spawnPoint);
                Pipe pipe = Instantiate(m_Pipe, pipeSpawnPosition.SpawnPosition(), Quaternion.identity);
                pipe.SetDistance(distance, speed);
                yield return new WaitForSeconds(delay);
            }
        }
        public void StartGame()
        {
            StartCoroutine(SpawnPipe());
        }
        public void SetProperties(float _delay, float _distance, float _speed)
        {
            delay = _delay;
            distance = _distance;
            speed = _speed;
        }
    }
}
