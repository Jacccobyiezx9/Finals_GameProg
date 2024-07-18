using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform playerDestination;
    public Transform cameraDestination;
    GameObject player;
    GameObject mainCamera;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Anthony_Control playerControl = player.GetComponent<Anthony_Control>();
            if (playerControl != null && playerControl.HasList())
            {
                if (Vector2.Distance(player.transform.position, transform.position) > 0.3f)
                {
                    player.transform.position = playerDestination.transform.position;
                    mainCamera.transform.position = cameraDestination.transform.position;
                }
            }
        }
    }
}
