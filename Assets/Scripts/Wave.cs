using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Wave : MonoBehaviour
{

    //Este script se encarga de los estados de las oleadas, cuando inician, cuando están en activo y cuando acaban

    public enum State
    {
        Setup,
        Begin,
        Run,
        End
    }
    public State CurrentState
    {
        get { return _state; }
    }


    public abstract void Setup();
    public abstract bool Begin();

    public abstract bool Run();

    public abstract void End();

    public void ChangeState(State nexState)
    {
        _state = nexState;
    }
    private State _state;


}
