﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
	//Busca o NavMeshAgent dentro do GameObject em que o script está
        agent = this.GetComponent<NavMeshAgent>();
    }
}