using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StepEvents : MonoBehaviour
{

    [SerializeField] private UnityEvent OnStart;
    [SerializeField] private UnityEvent OnFinish;

    void OnAwake()
    {
        OnStart.Invoke();
    }

    private void OnDisable()
    {
        OnFinish.Invoke();
    }

}
