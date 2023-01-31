using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace Pipe
{
    public class PipeRandomSpawnPosition
    {
        float randomY;
        public float RandomY()
        {
            randomY = Random.Range(-.13f, .7f);
            return randomY;
        }
    }
}