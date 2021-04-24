using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{
    //crinado a variavel NavMeshAgent
    public NavMeshAgent agent;

    void Start()
    {
        //Ao iniciar o script, pega o componente NavMeshAgent do Gameobject
        agent = this.GetComponent<NavMeshAgent>();
    }
}
