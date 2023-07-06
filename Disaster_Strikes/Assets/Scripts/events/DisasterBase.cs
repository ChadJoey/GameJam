using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisasterBase : MonoBehaviour
{

    enum disasterType {horizontal, vertical, all};
    disasterType type;
    
    GameObject SpawnedObject;




    void SpawnObjects()
    {
        switch (type)
        {
            //horizontal only from side
            case disasterType.horizontal:
                break;
                //vertical from above
            case disasterType.vertical:
                break;
                //horizontal and vertical
            case disasterType.all:
                break;
        }
    }

}
