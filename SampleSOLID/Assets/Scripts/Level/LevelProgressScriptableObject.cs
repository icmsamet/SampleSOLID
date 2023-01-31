using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level 
{
    [CreateAssetMenu(fileName = "Level Progress")]
    public class LevelProgressScriptableObject : ScriptableObject
    {
        public List<LevelProgressSituation> levelProgressSituations = new List<LevelProgressSituation>();
    }
}
