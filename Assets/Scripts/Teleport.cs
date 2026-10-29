using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("teleportTarget" + teleportTarget);
        Debug.Log("player" + thePlayer);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CharacterController controller = thePlayer.GetComponent<CharacterController>();
            controller.enabled = false;
            thePlayer.transform.position = teleportTarget.position;
            controller.enabled = true;

            Debug.Log("Teleported to: " + teleportTarget.position);

   
        }
    }
}