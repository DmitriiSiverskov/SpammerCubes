using ObjectBehavior;
using Structure;
using UnityEngine;
using Task = System.Threading.Tasks.Task;

namespace ActionScene
{
    public class InstanceCubes : MonoBehaviour
    {
        [SerializeField] private GameObject _cubePrefab;
        
        public static StructureInputData StructureData;
        private bool onOff = true;
        
        private void Update()
        {
            if (onOff == true)
            {
                LifeAsyng(_cubePrefab,StructureData);
                onOff = false;
            }
        }
        private async void LifeAsyng(GameObject cubePrefab,StructureInputData structureInputData)
        {
            var instantiate = Instantiate(cubePrefab);
            instantiate.AddComponent<Move>();
            instantiate.AddComponent<DistanceDestroy>();
            await CreateCubes(structureInputData._time);
        }

        private async Task CreateCubes(float time)
        {
            var timer = 0.0f;
            while (timer < time)
            {
                timer = Mathf.Min(timer + Time.deltaTime / 1.0f, time);
                await Task.Yield();
            }
            onOff = true;
        }
    }
}