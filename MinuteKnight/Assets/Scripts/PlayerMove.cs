using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float playerScaleLeft = -2;
    public float playerScaleRight = 2;
    public float playerSpeed;
    public float playerWalk = 5;
    public float playerSprint = 10f;
    private float direction = 0f;

    public Rigidbody2D player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        direction = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.LeftShift) && direction > 0f)
        {
            playerSpeed = playerSprint;

            player.velocity = new Vector2(direction * playerSpeed, player.velocity.y);
            transform.localScale = new Vector2(playerScaleRight, playerScaleRight);

        }
        else if (Input.GetKey(KeyCode.LeftShift) && direction < 0f)
        {
            playerSpeed = playerSprint;

            player.velocity = new Vector2(direction * playerSpeed, player.velocity.y);
            transform.localScale = new Vector2(playerScaleLeft, playerScaleLeft);

        }
        else if (direction > 0f)
        {
            playerSpeed = playerWalk;

            player.velocity = new Vector2(direction * playerSpeed, player.velocity.y);
            transform.localScale = new Vector2(playerScaleRight, playerScaleRight);
        }
        else if (direction < 0f)
        {
            playerSpeed = playerWalk;

            player.velocity = new Vector2(direction * playerSpeed, player.velocity.y);
            transform.localScale = new Vector2(playerScaleLeft, playerScaleRight);

        }
        else
        {
            player.velocity = new Vector2(0, player.velocity.y);
        }


    }
}





