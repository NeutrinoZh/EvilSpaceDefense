using UnityEngine;
using UnityEngine.Events;

namespace EvilSpaceDefense {
    [RequireComponent(typeof(AsteroidController))]
    public class AsteroidView : MonoBehaviour
    {
        //============================================================//
       
        [HideInInspector]
        public AsteroidModel model;

        public void move() {
            transform.position += model.direction * model.Velocity * Time.deltaTime;
        }
    
        //============================================================//

        public UnityEvent<Vector2> onCreateAsteroid;

        public void OnCreateAsteroid(Vector2 _direction) {
            onCreateAsteroid?.Invoke(_direction);
        }
    }
}