using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SSMState : MonoBehaviour {

    [SerializeField]
    private UnityEvent OnEnterEvent;

    [SerializeField]
    private UnityEvent OnExitEvent;

    [SerializeField]
    private SSMTransition[] Transitions;

    public SSMTransition GetFirstAvailableTransition()
    {
        for (int i = 0; i< Transitions.Length; i++)
        {
            if(Transitions[i].IsCanToGo())
            {
                return Transitions[i];
            }
        }

        return null;
    }

    public void OnEnterAction()
    {
        OnEnterEvent.Invoke();
    }

    public void OnExitAction()
    {
        OnExitEvent.Invoke();
    }


}
