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
        if (Player.player.isGrounded && Input.GetKeyDown(KeyCode.Space)) 
        {
            // jump directional movement
            Player.player.rb.AddForce(new Vector2(0f, jumpForce));
        }
    }
    
    private bool isGrounded()
    {
        // RaycastHit2D raycastHit = Physics2D.Raycast(Player.player.boxcollider.bounds.center, Vector2.down, Player.player.boxcollider.bounds.extents.y + .01f, Player.player.platformLayerMask);
        RaycastHit2D hit = Physics2D.BoxCast(Player.player.boxcollider.bounds.center, Player.player.boxcollider.bounds.size, 0f, Vector2.down, 0.05f, Player.player.platformLayerMask);
        /*
        Color rayColor;
        if(raycastHit.collider != null)
        {
            rayColor = Color.green;
        }
        else
        {
            rayColor = Color.red;
        }
        Debug.DrawRay(Player.player.boxcollider.bounds.center, Vector2.down * (Player.player.boxcollider.bounds.extents.y + .01f), rayColor);
        Debug.Log(raycastHit.collider);
        */
        return hit.collider != null;
    }
}