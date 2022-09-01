using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float offset;
    public float cameraSpeed;
    private Vector3 playerPosition;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // gets player position for the camera to move with
        playerPosition = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);

        // moves the camera in the direction of the player
        if (player.transform.localScale.x > 0f)
        {
            playerPosition = new Vector3(playerPosition.x + offset, playerPosition.y, playerPosition.z);
        }
        else
        {
            playerPosition = new Vector3(playerPosition.x - offset, playerPosition.y, playerPosition.z);

        }


       
       transform.position = Vector3.Lerp(transform.position, playerPosition, cameraSpeed * Time.deltaTime);
    }
}



