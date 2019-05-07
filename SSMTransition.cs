using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SSMTransition : MonoBehaviour {

    [SerializeField]
    public SSMEvent Event;

    [SerializeField]
    private SSMCondition Condition;

    [SerializeField]
    public SSMState State;

    public bool IsCanToGo()
    {
        return Condition == null || Condition.IsFulFilled();
    }



}
