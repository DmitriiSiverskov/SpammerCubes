using UnityEngine.Events;

namespace Event
{
    public class GlabalEventManager
    {
        public static UnityEvent<int,int,int> OnInputData = new UnityEvent<int, int, int>();
    }
    
}