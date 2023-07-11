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
    int spawnAmount;


    bool active = false;


    private void Start()
    {
        spawnduration = settings.spawnDuration;
        spawnAmount = settings.spawnAmount;
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
                SpawnObject(horizontalSpawnLocation[Random.Range(0, horizontalSpawnLocation.Length)].transform.position);
                break;
                //vertical from above
            case disasterType.vertical:
                SpawnObject(verticalSpawnLocation[Random.Range(0, verticalSpawnLocation.Length)].transform.position);
                break;
                //horizontal and vertical
            case disasterType.all:
                int num = Random.Range(0, 2);
                if (num == 0)
                {
                    SpawnObject(verticalSpawnLocation[Random.Range(0, verticalSpawnLocation.Length)].transform.position);
                }
                else
                {
                    SpawnObject(horizontalSpawnLocation[Random.Range(0, horizontalSpawnLocation.Length)].transform.position);
                }
                break;
        }
    }


    IEnumerator PlayEvent()
    {
        float delay = spawnduration / spawnAmount;
        for (int i = 0; i <= spawnAmount; i++)
        {
            SpawnManager();
            yield return new WaitForSeconds(delay);
        }
        yield return null;
    }


    void SpawnObject(Vector3 spawnLocation)
    {
        Instantiate(SpawnedObject, spawnLocation, SpawnedObject.transform.rotation);
    }


    private void Update()
    {
        if (active) 
        {

        }

    }
}
