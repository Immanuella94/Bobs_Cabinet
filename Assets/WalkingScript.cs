using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingScript : MonoBehaviour
{ 
   // [SerializeField] private bool _waiyAtTarget = false;

    enum WalkingState { WALKING, WAITING, LOOKING }
    WalkingState walkingState;

    public Transform[] wayPoints;
    public int targetPoint;
    public float speed;
    public float waitTime = 5f;
    float lateSpeed;
    bool isWaiting = false;

    private Vector3 currentDirection;

    [SerializeField] Transform mainTransform;
    [SerializeField] Animator animator;
    [SerializeField] SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        targetPoint = 0;
        lateSpeed = speed;
        walkingState = WalkingState.WALKING;
    }

    void Update()
    {
        /*
        if (isWaiting)
        {
            speed = 0f;
        }
        else
        {
            speed = lateSpeed;
        }*/
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 camFowardVector = new(Camera.main.transform.forward.x, 0f, Camera.main.transform.forward.z);
        float signedAngle = Vector3.SignedAngle(mainTransform.forward, camFowardVector, Vector3.up);
        float angle = Mathf.Abs(signedAngle);
        transform.Rotate(new Vector3(0, 0, angle));


        if (walkingState == WalkingState.WALKING)
        {            
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

            if (Vector3.Distance(transform.position, wayPoints[targetPoint].position) < 0.1f)
            {
                walkingState = WalkingState.WAITING;
                isWaiting = true;
                StartCoroutine(WaitBeforeMove());
            }
        }
        else if (walkingState == WalkingState.WAITING)
        {
            if (isWaiting == false)
            {
                walkingState = WalkingState.LOOKING;
            }
        }
        else if (walkingState == WalkingState.LOOKING)
        {
            IncreaseTargetPointInt();
            walkingState = WalkingState.WALKING;
        }

       
    }

    IEnumerator WaitBeforeMove()
    {
       // _waiyAtTarget = true;
        yield return new WaitForSeconds(waitTime);
        isWaiting = false;
       // _waiyAtTarget = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("waitHere"))
        {
            Debug.Log("is collided");
            isWaiting = true;
            StartCoroutine(WaitBeforeMove());
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