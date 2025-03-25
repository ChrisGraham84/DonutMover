using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform spawnPoint;



    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")  player.position = spawnPoint.position;
  
    }
}
