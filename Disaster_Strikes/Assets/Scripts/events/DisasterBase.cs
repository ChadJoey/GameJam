using System.Collections;
using System.Collections.Generic;
using UnityEditor;
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


    float spawnduration;


    bool active = false;


    private void Start()
    {
        spawnduration = settings.spawnDuration;
        StartCoroutine(PlayEvent());
        spawnduration = 2;
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
                SpawnObject(verticalSpawnLocation[Random.Range(0, verticalSpawnLocation.Length)].transform);
                break;
                //horizontal and vertical
            case disasterType.all:
                break;
        }
    }


    
    IEnumerator PlayEvent()
    {
        float delay = settings.spawnDuration / settings.spawnAmount;
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
