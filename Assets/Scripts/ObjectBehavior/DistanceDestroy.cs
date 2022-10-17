using System;
using ActionScene;
using UnityEngine;

namespace ObjectBehavior
{
    public class DistanceDestroy : MonoBehaviour
    {
        private void Update()
        {
            Destroy(InstanceCubes.StructureData._distance);
        }

        private void Destroy(float distance)
        {
          
            if (transform.position.z > distance)
            {
              
                Destroy(gameObject);
            }
        }
    }
}