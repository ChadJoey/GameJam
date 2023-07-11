using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLaser : MonoBehaviour
{
    [SerializeField] private GameObject warningLaser;

    [SerializeField] private GameObject beamSprite;
    // Start is called before the first frame update
    void Start()
    {
        warningLaser.gameObject.SetActive(true);

        beamSprite.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, 5f);
    }


}
