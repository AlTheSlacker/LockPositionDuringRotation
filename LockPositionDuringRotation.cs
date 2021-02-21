using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

#if UNITY_EDITOR

namespace tools
{
    [ExecuteInEditMode]

    public class LockPositionDuringRotation : MonoBehaviour
    {
        private Transform[] transformAll;
        private List<Vector3> originalPosition = new List<Vector3>();


        void Start()
        {
            transformAll = GetComponentsInChildren<Transform>();
            for (int i = 0; i < transformAll.Length; i++)
            {
                originalPosition.Add(transformAll[i].position);
            }
        }


        void OnEnable()
        {
            Start();
        }


        void Update()
        {
            for (int i = 0; i < transformAll.Length; i++)
            {
                transformAll[i].position = originalPosition[i];
            }
        }
    }
}
#endif