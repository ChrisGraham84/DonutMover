using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        player.position = spawnPoint.position;
    }
}
