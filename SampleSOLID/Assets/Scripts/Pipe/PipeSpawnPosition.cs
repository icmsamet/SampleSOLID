using UnityEngine;

namespace Pipe
{
    public class PipeSpawnPosition
    {
        Vector3 spawnPosition;
        Transform spawnPoint;
        PipeRandomSpawnPosition pipeRandomSpawnPosition;
        public PipeSpawnPosition(Transform _spawnPoint)
        {
            spawnPoint = _spawnPoint;
        }

        public Vector3 SpawnPosition()
        {
            pipeRandomSpawnPosition = new PipeRandomSpawnPosition();
            spawnPosition = new Vector3(spawnPoint.position.x, pipeRandomSpawnPosition.RandomY(), spawnPoint.position.z);
            return spawnPosition;
        }
    }
}
