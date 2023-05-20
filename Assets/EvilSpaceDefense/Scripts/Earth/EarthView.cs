using UnityEngine;
using UnityEngine.Events;

namespace EvilSpaceDefense {
    [RequireComponent(typeof(EarthController))]
    public class EarthView : MonoBehaviour
    {
        //============================================================//
        
        [HideInInspector]
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