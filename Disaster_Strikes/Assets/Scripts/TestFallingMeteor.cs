using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFallingMeteor : MonoBehaviour
{

    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(new Vector2(-1000, 100));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
