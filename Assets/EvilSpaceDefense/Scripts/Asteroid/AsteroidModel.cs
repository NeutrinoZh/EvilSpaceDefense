using UnityEngine;
using System;

namespace EvilSpaceDefense {
    [Serializable]
    public class AsteroidModel
    {
        [SerializeField]
        private float velocity;

        public float Velocity { get => velocity; }

        [HideInInspector]
        public Vector3 direction;
    }
}