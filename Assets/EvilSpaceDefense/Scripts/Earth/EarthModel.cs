using UnityEngine;
using System;

namespace EvilSpaceDefense {
    [Serializable]
    public struct EarthModel {   
        [HideInInspector]
        public Transform transform;
        
        public int direction;
    }
}