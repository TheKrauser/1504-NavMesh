using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    //Array de GameObjects
    GameObject[] agents;
    // Start is called before the first frame update
    void Start()
    {
	//Busca todos os GameObjects com a tag "AI"
        agents = GameObject.FindGameObjectsWithTag("AI");
    }

    // Update is called once per frame
    void Update()
    {
	//Se apertar o botão esquerdo do mouse
        if (Input.GetMouseButtonDown(0)) 
        {
	    //Cria variável Raycast
            RaycastHit hit;

	    //Faz um Raycast da posição da Câmera até uma distância de 100 e guarda o que acertou na variável hit
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                foreach (GameObject a in agents)
		    //Move todos os Agentes para essa localização
                    a.GetComponent<AIController>().agent.SetDestination(hit.point);
            }
        }
    }
}