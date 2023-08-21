using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace _Project.SOs
{
    [CreateAssetMenu(menuName = "_Project/SOs/ClickSO", fileName = "ClickSO")]
    public class ClickSO : ScriptableObject
    {
        [HideInInspector] 
        public Vector3 clickPosition;
        
        [HideInInspector] 
        public Quaternion clickRotation;
    }
}
