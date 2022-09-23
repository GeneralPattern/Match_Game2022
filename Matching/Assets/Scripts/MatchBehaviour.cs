using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : IDContainerBehaviour
{

    public UnityEvent matchEvent, NoMatchEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehaviour>();
        if (tempObj == null)
        {
            return;
        }
        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            matchEvent.Invoke();
            Debug.Log("MATCH");
        }
        else
        {
            NoMatchEvent.Invoke();
            Debug.Log("NO MATCH");
        }
    }
}
