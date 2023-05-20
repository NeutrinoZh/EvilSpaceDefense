using UnityEngine;

namespace EvilSpaceDefense {
    [RequireComponent(typeof(BulletView))]
    public class BulletController : MonoBehaviour
    {
        private void Awake()
        {
            transform.parent = MainPlayScene.Instance.BulletParent;

            m_view = GetComponent<BulletView>();
            m_view.model = m_model;

            m_view.onCreateBullet.AddListener(setDirection);
        }

        [SerializeField]
        private BulletModel m_model;

        private BulletView m_view;

        private void Update()
        {
            m_view.move();
        }

        private void setDirection(Vector2 _direction) {
            m_model.direction = _direction;
        }
    }
}