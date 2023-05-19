using UnityEngine;

namespace EvilSpaceDefense {
    public class EarthView
    {
        public EarthView(EarthModel _model) {
            m_model = _model;
        }

        private EarthModel m_model;

        public void rotate() {
            m_model.transform.Rotate(Vector3.forward * m_model.direction);
        } 
    }
}