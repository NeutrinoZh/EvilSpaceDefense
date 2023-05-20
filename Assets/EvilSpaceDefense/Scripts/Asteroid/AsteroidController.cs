using UnityEngine;

namespace EvilSpaceDefense {
    [RequireComponent(typeof(AsteroidView))]
    public class AsteroidController : MonoBehaviour
    {
        private void Awake()
        {
            transform.parent = MainPlayScene.Instance.AsteroidParent;

            m_view = GetComponent<AsteroidView>();
            m_view.model = m_model;

            m_view.onCreateAsteroid.AddListener(setDirection);
        }

        [SerializeField]
        private AsteroidModel m_model;
    
        private AsteroidView m_view;

        private void Update()
        {
            m_view.move();
        }

        private void setDirection(Vector2 _direction) {
            m_model.direction = _direction;
        }
    }
}