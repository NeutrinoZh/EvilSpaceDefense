using UnityEngine;

namespace EvilSpaceDefense {
    public class EarthController : MonoBehaviour {

        private void Start() {
            m_model.transform = transform;
            m_view = new EarthView(m_model);
        }

        [SerializeField]
        private EarthModel m_model;
        private EarthView m_view;

        private void Update() { 
            m_view.rotate();
        }

        public void changeDirection()  {
            m_model.direction = -m_model.direction;
        }
    }
}