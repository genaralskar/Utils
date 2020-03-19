using UnityEngine;
using UnityEngine.Events;

namespace genaralskar
{
    public static class DrawEventLines
    {
        public static void Draw(UnityEvent e, Transform origin)
        {
            int c = e.GetPersistentEventCount();
            Vector3 location = origin.position;
            for (int i = 0; i < c; i++)
            {
                var obj = e.GetPersistentTarget(i);
                if (!obj) continue;
                
                MonoBehaviour mb = obj as MonoBehaviour;
                if (mb == null)
                {
                    //If the object is not a MonoBehaviour, try to find its object by name
                    GameObject go = GameObject.Find(obj.name);
                    if (go)
                    {
                        Gizmos.color = Color.red;
                        location = go.transform.position;
                    }
                }
                else
                {
                    Gizmos.color = Color.green;
                    location = mb.transform.position;
                }
            
                Gizmos.DrawLine(origin.position, location);
            }
        }
    }
}
