using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
    internal virtual void HandleUpdate()
    {
    }

    internal virtual void HandleFixedUpdate()
    {

    }


    internal virtual void Init()
    {

    }


    internal void Update()
    {
        HandleUpdate();
    }

    internal void FixedUpdate()
    {
        HandleFixedUpdate();
    }


    internal void Awake()
    {
        Init();
    }
}
