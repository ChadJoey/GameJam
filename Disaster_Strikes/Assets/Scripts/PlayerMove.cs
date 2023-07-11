using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 500f;
    public float jumpForce = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Player.player.isGrounded = isGrounded();
        if (Input.GetKey(KeyCode.A))
        {
            // leftwards directional movement
            Player.player.rb.AddForce(new Vector2(-speed * Time.deltaTime, 0f));
        }
        if (Input.GetKey(KeyCode.D))
        {
            // rightwards directional movement
            Player.player.rb.AddForce(new Vector2(speed * Time.deltaTime, 0f));
        }
        if (Input.GetKey(KeyCode.S))
        {
            // rightwards directional movement
            Player.player.rb.AddForce(new Vector2(0f, -speed * Time.deltaTime));
        }
        if (Player.player.isGrounded && Input.GetKeyDown(KeyCode.Space)) 
        {
            // jump directional movement
            Player.player.rb.AddForce(new Vector2(0f, jumpForce));
        }
    }
    
    private bool isGrounded()
    {
        RaycastHit2D hit = Physics2D.BoxCast(Player.player.boxcollider.bounds.center, Player.player.boxcollider.bounds.size, 0f, Vector2.down, 0.05f, Player.player.platformLayerMask);
        
        return hit.collider != null;
    }
}