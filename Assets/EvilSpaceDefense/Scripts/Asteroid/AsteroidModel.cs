using UnityEngine;
using System;

namespace EvilSpaceDefense {
    [Serializable]
    public class AsteroidModel
    {
        [HideInInspector]
        public Vector3 direction;

        //=============================//

        [SerializeField]
        private float velocity;

        public float Velocity { get => velocity; }

        //=============================//

        [SerializeField]
        private Transform earth;

        public Transform Earth { get => earth; }
    }
}