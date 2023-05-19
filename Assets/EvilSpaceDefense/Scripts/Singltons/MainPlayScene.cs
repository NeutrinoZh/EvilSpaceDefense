using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EvilSpaceDefense {
    public class MainPlayScene : MonoBehaviour
    {
        //===============================================//

        private static MainPlayScene s_Instance = null;
        public static MainPlayScene Instance {
            get => s_Instance;
        }

        private void Awake()
        {
            if (s_Instance != null) {
                Destroy(gameObject);
                return;
            }

            s_Instance = this;
        }

        //===============================================//
  
        [SerializeField]
        private Transform m_bullet_parent = null;

        public Transform BulletParent {
            get => m_bullet_parent;
        }
    }
}