using UnityEngine;
using UnityEngine.Pool;

namespace EvilSpaceDefense {
    public class BulletSpawner
    {
        public BulletSpawner(GameObject _bullet_prefab) {
            pool = new ObjectPool<BulletView>(
                () => GameObject.Instantiate(_bullet_prefab).GetComponent<BulletView>(),
                obj => obj.gameObject.SetActive(true),
                obj => obj.gameObject.SetActive(false),
                obj => GameObject.Destroy(obj.gameObject),
                false, 20, 30
            ); 
        }
        
        private ObjectPool<BulletView> pool = null; 

        public void SpawnBullet(Vector3 _position, Vector2 _direction) {
            BulletView bullet = pool.Get();
            bullet.transform.position = _position;
            bullet.OnCreateBullet(_direction);
        }
    }
}