using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "SpawnPoint", menuName = "SpawnPoint", order = 1)]
public class SpawnPoints : ScriptableObject
{

    [SerializeField]
    GameObject[] VecticalSpawnPoint;
    [SerializeField]
    Transform[] HorizontalSpawnPoint;
}
