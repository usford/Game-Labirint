using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Guard : MonoBehaviour
{
    public GameObject player;
    private NavMeshAgent navmesh;
    void Start()
    {
        navmesh = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        navmesh.destination = player.transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("level3");
        }
        
    }
}
