using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;
using System;
public class WaypointSystem : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    private NavMeshAgent _navMeshAgent;
    private int _currentPoint = 0;
    private void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {

    }
    public void MoveAgent()
    {
        Transform target = _points[_currentPoint];
        _navMeshAgent.destination = target.position;
    }
    public void UpdateCurrentPoint()
    {
        _currentPoint++;
        if(_currentPoint >= _points.Length)
        {
            _currentPoint = 0;
        }
    }
    public void PauseAgent()
    {
        _navMeshAgent.destination = transform.position;
    }
}
