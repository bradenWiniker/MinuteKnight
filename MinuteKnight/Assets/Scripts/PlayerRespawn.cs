using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{

    public float barrierDistance = 15f;

    private Vector3 respawnPoint;
    public GameObject fallDetector;

    PlayerMove playerMove;
    public GameObject player;

    MovingBarrier movingBarrier;
    public GameObject barrier;



    // Start is called before the first frame update
    private void Awake()
    {
        playerMove = player.GetComponent<PlayerMove>();
        movingBarrier = barrier.GetComponent<MovingBarrier>();
    }

    void Start()
    {
        respawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.tag == "Checkpoint")
        {
            respawnPoint = transform.position;

        }
        else if (collision.tag == "FallDetector" || collision.tag == "Barrier")
        {
            player.transform.position = respawnPoint;
            barrier.transform.position = new Vector2(player.transform.position.x - barrierDistance, transform.position.y);
        }


    }

}