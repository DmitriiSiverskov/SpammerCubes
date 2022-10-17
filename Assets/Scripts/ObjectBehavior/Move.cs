using ActionScene;
using UnityEngine;

namespace ObjectBehavior
{
    public class Move : MonoBehaviour
    {
        private void Update()
        {
            Moving(InstanceCubes.StructureData._speed);
        }

        private void Moving(float speed)
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
    }
}