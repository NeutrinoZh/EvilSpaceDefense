using System;
using UnityEngine;

namespace EvilSpaceDefense {
    [Serializable]
    public class BulletModel
    {
        [SerializeField]
        private float velocity;

        public float Velocity { get => velocity; }

        [HideInInspector]
        public Vector3 direction;
    }
}