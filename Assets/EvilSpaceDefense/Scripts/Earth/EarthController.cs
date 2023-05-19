using UnityEngine;

namespace EvilSpaceDefense {
    [RequireComponent(typeof(EarthView))]
    public class EarthController : MonoBehaviour {

        private void Awake() {
            m_view = GetComponent<EarthView>();
            m_view.model = m_model;

            m_view.onScreenTap.AddListener(ChangeDirection);
        }

        [SerializeField]
        private EarthModel m_model;
        private EarthView m_view;

        private void Update() { 
            m_view.Rotate();
        }

        public void ChangeDirection()  {
            m_model.direction = -m_model.direction;
        }
    }
}