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
                if (!obj) continue; //In the case of an unassigned UnityEvent, skip it
                
                var mb = obj as Component;
                if (mb != null)
                {
                    location = mb.transform.position;
                }
                else
                {
                    //If the object is not a Component, get it as a GameObject
                    var go = obj as GameObject;
                    if (go)
                    {
                        location = go.transform.position;
                    }
                }

                Gizmos.DrawLine(origin.position, location);
            }
        }
    }
}
