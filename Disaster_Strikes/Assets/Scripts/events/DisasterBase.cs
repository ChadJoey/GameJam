using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisasterBase : MonoBehaviour
{

    enum disasterType { horizontal, vertical, all };
    [SerializeField]
    disasterType type;

    [SerializeField]
    EventSettings settings;


    [SerializeField]
    GameObject SpawnedObject;

    [SerializeField]
    Transform[] verticalSpawnLocation;
    [SerializeField]
    Transform[] horizontalSpawnLocation;

    Coroutine StartEvent;


    float delay;
    bool active = false;


    private void Start()
    {
        StartCoroutine(PlayEvent());
    }

    void SpawnManager()
    {
        switch (type)
        {
            //horizontal only from side
            case disasterType.horizontal:
                SpawnObject(horizontalSpawnLocation[Random.Range(0, horizontalSpawnLocation.Length)].transform);
                break;
                //vertical from above
            case disasterType.vertical:
                break;
                //horizontal and vertical
            case disasterType.all:
                break;
        }
    }


    
    IEnumerator PlayEvent()
    {
        delay = settings.spawnDuration / settings.spawnAmount;
        for (int i = 0; i <= settings.spawnAmount; i++)
        {
            SpawnManager();
            yield return new WaitForSeconds(delay);
        }
        yield return null;
    }


    void SpawnObject(Transform spawnLocation)
    {
        Instantiate(SpawnedObject, spawnLocation);
    }


    private void Update()
    {
        if (active) 
        {

        }

    }
}
