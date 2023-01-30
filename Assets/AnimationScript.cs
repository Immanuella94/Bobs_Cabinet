using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    //Stores a referance to the waypoint system this object will use
    [SerializeField] private Waypoints waypoints;

    public float Speed = 5f;

    public float distanceThreshold = 1f;

    [SerializeField] Transform mainTransform;
    [SerializeField] Animator animator;
    [SerializeField] SpriteRenderer spriteRenderer;


    //the current waypoint target that the object is moving towards
    private Transform currentWaypoint;
    private Vector3 currentDirection;


    void Start()
    {
        //set initital position to the first waypoint
        currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        transform.position = currentWaypoint.position;

        //set the next waypoint target
        currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        transform.LookAt(currentWaypoint);
    }


    void LateUpdate()
    {
        Vector3 camFowardVector = new(Camera.main.transform.forward.x, 0f, Camera.main.transform.forward.z);

        float signedAngle = Vector3.SignedAngle(mainTransform.forward, camFowardVector, Vector3.up);

        float angle = Mathf.Abs(signedAngle);

        transform.Rotate(new Vector3(0, 0, angle));



        transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, Speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, currentWaypoint.position) < distanceThreshold)
        {
            //set the next waypoint target
            currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
            transform.LookAt(currentWaypoint);
        }

        currentDirection = (currentWaypoint.position - transform.position).normalized;

        if (currentDirection.x >= 0 && currentDirection.y == 0)
        {
            animator.SetFloat("moveX", currentDirection.x);
        }
        if (currentDirection.x <= 0 && currentDirection.y == 0)
        {
            animator.SetFloat("moveX", currentDirection.x);
        }
        if (currentDirection.y == 0 && currentDirection.z >= 0)
        {
            animator.SetFloat("moveY", currentDirection.z);
        }
        if (currentDirection.y == 0 && currentDirection.z <= 0)
        {
            animator.SetFloat("moveY", currentDirection.z);
        }
    }
}
