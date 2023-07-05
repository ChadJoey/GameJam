using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : GameBehaviour
{
    public static Player player;

    [SerializeField]
    internal Rigidbody2D rb;
    internal bool Isgrounded;



    internal override void Init()
    {
        if (player == null)
        {
            DontDestroyOnLoad(gameObject);
            player = this;
        }
        else if (player != this)
        {
            GameObject.Destroy(player);
        }
    }

    internal override void HandleUpdate()
    {

    }

    internal override void HandleFixedUpdate()
    {
        
    }
}
