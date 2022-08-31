using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePoint : MonoBehaviour
{
    [SerializeField] private WaypointSystem waypointSystem; 
    private void OnTriggerEnter(Collider other)
    {
        waypointSystem.UpdateCurrentPoint();
    }
}
