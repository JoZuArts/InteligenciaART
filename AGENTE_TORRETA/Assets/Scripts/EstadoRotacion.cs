using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoRotacion : InstruccionesFSM           //rotar la torreta chevere 
{
    public override void EnterState(TorretaEstatica torreta)         // es el iniciador de la torreta
    {
        Debug.Log("Entro a estado de rotación");                            // codigo de inicio 
        torreta.currentState = AgentState.Rotation;                      // un codigo de current 
    }

    public override void UpdateState(TorretaEstatica torreta)                  //nombre del codigo
    {
        torreta.transform.rotation = Quaternion.Slerp(torreta.transform.rotation,              
        Quaternion.Euler(torreta.angles[torreta.angleIndex]), Time.deltaTime * torreta.speedRotation);           //un codigo de rotacion 

        if(torreta.transform.eulerAngles.y >= (torreta.angles[torreta.angleIndex].y - 1))                         //transformacion de torreta 
        {
            Debug.Log("Llegue al angulo destino");                                 //codigo de angulo destino 
            torreta.angleIndex = (torreta.angleIndex + 1) % torreta.angles.Length;                                    //importante recordar esto
        }
    }
}
