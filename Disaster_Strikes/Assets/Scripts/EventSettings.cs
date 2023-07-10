using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
[CreateAssetMenu(fileName = "eventSettings", menuName = "eventSettings", order = 1)]
public class EventSettings : ScriptableObject
{
    public int spawnAmount;
    public float spawnDuration;
}
