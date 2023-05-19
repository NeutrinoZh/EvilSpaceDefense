using UnityEngine;
using System;

namespace EvilSpaceDefense {
    [Serializable]
    public class EarthModel {
        [HideInInspector]
        public Transform gun;
        public GameObject bullet_prefab;   
        public int direction;
    }
}