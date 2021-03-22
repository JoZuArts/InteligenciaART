using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InstruccionesFSM 
{
    public abstract void EnterState(TorretaEstatica torreta);

    public abstract void UpdateState(TorretaEstatica torreta);
}
