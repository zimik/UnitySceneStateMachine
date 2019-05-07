using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SSMController : MonoBehaviour {

    [SerializeField]
    private SSMState EnterPointState;

    private SSMState CurrentState;

    public void ToProcessEvent(SSMEvent sSMEvent)
    {
        if(CurrentState != null)
        {
            SSMTransition availableTransition = CurrentState.GetFirstAvailableTransition();
            if(availableTransition != null)
            {
                SetState(availableTransition.State);
            }
        }
    }


    private void Start()
    {
        SetState(EnterPointState);
    }

    private void SetState(SSMState state)
    {
        if (CurrentState != null)
        {
            CurrentState.OnExitAction();
        }

        CurrentState = state;
        CurrentState.OnEnterAction();
    }

}
