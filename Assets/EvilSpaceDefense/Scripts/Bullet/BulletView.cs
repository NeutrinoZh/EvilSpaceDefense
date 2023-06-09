using UnityEngine;
using UnityEngine.Events;

namespace EvilSpaceDefense {
    [RequireComponent(typeof(BulletController))]
    public class BulletView : MonoBehaviour
    {
        //============================================================//
       
        public BulletModel model;

        public void move() {
            transform.position += model.direction * model.Velocity * Time.deltaTime;
        }
         
        //============================================================//
    
        public UnityEvent<Vector2> onCreateBullet;

        public void OnCreateBullet(Vector2 _velocity) {
            onCreateBullet?.Invoke(_velocity);
        }
    }
}