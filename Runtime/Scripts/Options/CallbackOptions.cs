using System;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class CallbackOptions
{
    [Tooltip("This callback is invoked when the async fracturing/slicing process has been completed.")]
    public UnityEvent onCompleted;

    public delegate void OnFractureHandler(Collider instigator, GameObject fracturedObject, Vector3 point);
    public event OnFractureHandler onFracture;

    public CallbackOptions()
    {
        this.onCompleted = null;
    }

    public void CallOnFracture(Collider instigator, GameObject fracturedObject, Vector3 point)
    {
        onFracture?.Invoke(instigator, fracturedObject, point);
    }
}