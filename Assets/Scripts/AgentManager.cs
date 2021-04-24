using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    GameObject[] agents;
    void Start()
    {
        //Pegando gameobjcts que possuem ai com tag
        agents = GameObject.FindGameObjectsWithTag("ai");
    }

    void Update()
    {
        //ao clicar com botao do mouse 0 entra no if
        if (Input.GetMouseButtonDown(0))
        {
            //criando um raycasthit
            RaycastHit hit;
            
            //criar uma linha reta para verificar se o player clicou em algum local
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                foreach(GameObject a in agents)
                {
                    //setando o destino dos Navmesh aonde o player clicou na tela
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
                }
            }
        }
    }
}
