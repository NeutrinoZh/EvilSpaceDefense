using UnityEngine;

namespace EvilSpaceDefense {
    [RequireComponent(typeof(EarthView))]
    public class EarthController : MonoBehaviour {

        private void Awake() {
            m_model.gun = transform.GetChild(0);

            m_view = GetComponent<EarthView>();
            m_view.model = m_model;

            m_view.onScreenTap.AddListener(ChangeDirection);
            m_view.onScreenTap.AddListener(SpawnBullet);
        }

        [SerializeField]
        private EarthModel m_model;
        private EarthView m_view;

        private void Update() { 
            m_view.Rotate();
        }

        private void SpawnBullet() {
            BulletView bullet =
                Instantiate(m_model.bullet_prefab).GetComponent<BulletView>();
            bullet.transform.position = m_model.gun.position;
            bullet.OnCreateBullet(transform.right);
        }

        private void ChangeDirection()  {
            m_model.direction = -m_model.direction;
        }
    }
}