using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisasterBase : MonoBehaviour
{

    enum disasterType { horizontal, vertical, all };
    [SerializeField]
    disasterType type;

    [SerializeField]
    GameObject SpawnedObject;

    [SerializeField]
    Transform[] verticalSpawnLocation;
    [SerializeField]
    Transform[] horizontalSpawnLocation;


    void SpawnManager()
    {
        switch (type)
        {
            //horizontal only from side
            case disasterType.horizontal:
                //spawnLocation = 
                break;
                //vertical from above
            case disasterType.vertical:
                break;
                //horizontal and vertical
            case disasterType.all:
                break;
        }
    }



    void SpawnObject(Transform spawnLocation)
    {
        Instantiate(SpawnedObject, spawnLocation);
    }
}
