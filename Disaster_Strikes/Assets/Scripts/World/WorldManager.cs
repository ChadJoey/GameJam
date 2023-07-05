using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class WorldManager : GameBehaviour
{
    public static WorldManager world;


    internal Rigidbody2D rb;
    internal bool Isgrounded;

    internal override void Init()
    {
        if (world == null)
        {
            DontDestroyOnLoad(gameObject);
            world = this;
        }
        else if (world != this)
        {
            GameObject.Destroy(world);
        }

    }

    internal override void HandleUpdate()
    {
        //UnityEngine.Debug.Log("working!");
    }

    internal override void HandleFixedUpdate()
    {
    }
}
