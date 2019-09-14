using UnityEngine;
using UnityEngine.Events;

public class AnimEvent : MonoBehaviour
{
    public UnityEvent animEvent;

    public void ExecEvent()
    {
        animEvent.Invoke();
    }
}