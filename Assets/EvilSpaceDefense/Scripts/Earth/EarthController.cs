using UnityEngine;
using System.Collections;

namespace EvilSpaceDefense {
    [RequireComponent(typeof(EarthView))]
    public class EarthController : MonoBehaviour {

        private void Awake() {
            //==========================================//
            m_bullet_spawner = new BulletSpawner(m_model.bullet_prefab);

            //==========================================//
            m_model.gun = transform.GetChild(0);

            //==========================================//
            m_view = GetComponent<EarthView>();
            m_view.model = m_model;

            //==========================================//
            m_view.onScreenTap.AddListener(ChangeDirection);
            m_view.onScreenTap.AddListener(SpawnBullet);

            //==========================================//
        }

        //==========================================//

        [SerializeField]
        private EarthModel m_model;
        private EarthView m_view;

        //==========================================//

        private BulletSpawner m_bullet_spawner;

        //==========================================//

        const float DELAY_BEFORE_CHANGE_DIRECTION = 0.2f;

        //==========================================//

        private void SpawnBullet() {
            m_bullet_spawner.SpawnBullet(m_model.gun.position, transform.right);
        }

        private void ChangeDirection()  {
            StartCoroutine(ChangeDirectionByDelay(-m_model.direction));
            m_model.direction = 0;
        }

        //==========================================//

        private IEnumerator ChangeDirectionByDelay(int _new_direction) {
            yield return new WaitForSeconds(DELAY_BEFORE_CHANGE_DIRECTION);
            m_model.direction = _new_direction;
        }

        //==========================================//
        
        private void Update() { 
            m_view.Rotate();
        }
    }
}