using UnityEngine;
using UnityEngine.Events;

namespace EvilSpaceDefense {
    public class EarthView : MonoBehaviour
    {
        //============================================================//
        public EarthModel model;

        public void Rotate() {
            transform.Rotate(Vector3.forward * model.direction);
        } 

        //============================================================//

        public UnityEvent onScreenTap;

        public void OnScreenTap() {
            onScreenTap?.Invoke();
        }

        //============================================================//
    }
}