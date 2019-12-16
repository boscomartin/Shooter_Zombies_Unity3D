using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieController : MonoBehaviour
{


    //OBJETO AL CUAL VA A SEGUIR EL PREFAB
    private Transform _target;

    private NavMeshAgent agent;

    //Utilizamos el navmeshagent para que el zombieno se choque con las paredes a la hora de seguir al usuario
    private void Awake()
    {
        _target = PlayerController.Player;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    //EN EL UPDATE EJECUTAMOS LA ACCIÓN QUE VA A SEGUIR EL PREFAB A LA HORA DE PERSEGUIR AL TARGET
    void Update()
    {
        agent.SetDestination(_target.position);

    }




}
