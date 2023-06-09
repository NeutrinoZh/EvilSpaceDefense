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

        //===================================================//

        [SerializeField]
        private AsteroidModel m_model;
    
        private AsteroidView m_view;

        private void Update()
        {
            setDirection(calcForce());
            m_view.move();
        }

        //===================================================//

        private void setDirection(Vector2 _direction) {
            m_model.direction = _direction;
        }

        //===================================================//

        private const float G = 1f;
        private const int EARTH_MASS = 1;

        private Vector2 calcForce() {
            float x1 = m_model.Earth.position.x,
                  x2 = transform.position.x;
 
            float y1 = m_model.Earth.position.y,
                  y2 = transform.position.y;

            float sqr_dist = (m_model.Earth.position - transform.position).sqrMagnitude;
            float dist = Mathf.Sqrt(sqr_dist);
            
            return new(
                G * (EARTH_MASS / sqr_dist) * (x1 - x2) / dist,
                G * (EARTH_MASS / sqr_dist) * (y1 - y2) / dist 
            );
        }
    }
}