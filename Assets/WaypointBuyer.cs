using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointBuyer : MonoBehaviour
{
    public bool clothsTaken = false;
    //Stores a referance to the waypoint system this object will use
    [SerializeField] private Waypoints waypoints;

    [SerializeField] private float moveSpeed = 5f;

    [SerializeField] private float distanceThreshold = 1f;

    float lastMoveSpeed = 0f;

    //the current waypoint target that the object is moving towards
    private Transform currentWaypoint;

    void Start()
    {
        lastMoveSpeed = moveSpeed;
        //set initital position to the first waypoint
        currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        transform.position = currentWaypoint.position;

        //set the next waypoint target
        currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        transform.LookAt(currentWaypoint);
    }


    void Update()
    {
        Run1();
        Run2();
        Run3();

        //then stop
        BuySomething();

        Run1();
        Run2();
        Run3();

        //then destroy self
        //Destroy(this.gameObject);

    }

    void BuySomething()
    {
        moveSpeed = 0f;
        if(clothsTaken == true)
        {
            moveSpeed = lastMoveSpeed;
        }
    }

    void Run1()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, moveSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, currentWaypoint.position) < distanceThreshold)
        {
            //set the next waypoint target
            currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
            transform.LookAt(currentWaypoint);
        }
    }

    void Run2()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, moveSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, currentWaypoint.position) < distanceThreshold)
        {
            //set the next waypoint target
            currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
            transform.LookAt(currentWaypoint);
        }
    }

    void Run3()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, moveSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, currentWaypoint.position) < distanceThreshold)
        {
            //set the next waypoint target
            currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
            transform.LookAt(currentWaypoint);
        }
    }
}