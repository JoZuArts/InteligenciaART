using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* este codigo es importante recordar ya que es 
  el estado de atacar y no se puede olvidar
 */

public class EstadoAtacar : InstruccionesFSM    //codigo estado atacar instrucciones 
{
    float nextFire;                          // metodo para saber el siguiente disparo
    float rateFire = 1f;                         // dejar de disparar

    public override void EnterState(TorretaEstatica torreta)               
    {
        Debug.Log("Entro estado atacar!");                               //metodo para entrar en estado de ataque 
        torreta.currentState = AgentState.Attack;                    // ataque hacia agente

    }

    public override void UpdateState(TorretaEstatica torreta)
    {
        if(torreta.playerDetected == true)                                       // cuando detecta el jugador
        {
            var lookRotation = Quaternion.LookRotation(torreta.playerTarget.transform.position - torreta.transform.position);
            torreta.transform.rotation = Quaternion.Slerp(torreta.transform.rotation, lookRotation, torreta.speedRotation * Time.deltaTime);

            //Disparar
        }
        else     // si no
        {
            torreta.TransitionToState(torreta.idleState);          //movimiento de torreta 
        }
    }
}
