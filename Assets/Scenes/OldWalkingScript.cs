using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldWalkingScript : MonoBehaviour
{
    //[SerializeField] private bool _waiyAtTarget = false;

    public Transform[] wayPoints;
    public int targetPoint;
    public float speed;
    //public float waitTime = 5f;

    private Vector3 currentDirection;

    [SerializeField] Transform mainTransform;
    [SerializeField] Animator animator;
    [SerializeField] SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        targetPoint = 0;
    }

    // Update is called once per frame
    void LateUpdate()
    {

        Vector3 camFowardVector = new(Camera.main.transform.forward.x, 0f, Camera.main.transform.forward.z);

        float signedAngle = Vector3.SignedAngle(mainTransform.forward, camFowardVector, Vector3.up);

        float angle = Mathf.Abs(signedAngle);

        transform.Rotate(new Vector3(0, 0, angle));



        if (transform.position == wayPoints[targetPoint].position)
        {
            IncreaseTargetPointInt();
        }
        transform.position = Vector3.MoveTowards(transform.position, wayPoints[targetPoint].position, speed * Time.deltaTime);


        currentDirection = (wayPoints[targetPoint].position - transform.position).normalized;

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

    void IncreaseTargetPointInt()
    {
        targetPoint++;

        if (targetPoint >= wayPoints.Length)
        {
            targetPoint = 0;
        }      
    }
}
