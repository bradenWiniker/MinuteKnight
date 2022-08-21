using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBarrier : MonoBehaviour
{


    public float barrierSpeed = 3f;
    public float barrierDistance = 15f;
    private Rigidbody2D barrier;

    public float barrierVerticalOffset = 2f;

    PlayerMove playerMove;
    public Rigidbody2D player;

    // Start is called before the first frame update
    private void Awake()
    {
        playerMove = player.GetComponent<PlayerMove>();
    }
    void Start()
    {
        barrier = GetComponent<Rigidbody2D>();

        barrier.transform.position = new Vector2(player.transform.position.x - barrierDistance, player.transform.position.y);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        barrier.velocity = new Vector2(barrierSpeed, player.velocity.y);
        barrier.transform.position = new Vector2 (barrier.transform.position.x, player.transform.position.y+ barrierVerticalOffset);


    }
}


