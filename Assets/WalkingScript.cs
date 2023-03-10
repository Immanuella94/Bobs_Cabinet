using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class WalkingScript : MonoBehaviour
    {
        
        enum WalkingState { WALKING, WAITING, LOOKING, RUNNINGAWAY }    //states
        WalkingState walkingState;

        public Transform[] wayPoints;   //array of waypoints
        public GameObject exclamationMarkObject;    //floats above npc
        public int targetPoint;
        public float speed;
        public float runningAwaySpeed;
        public float waitTime = 5f;
        bool isWaiting = false;
        bool canSeePlayer = false;

    //get component from quest system script
        public int Reputation;
        bool shirtOn;

        private Vector3 currentDirection;
        private Vector3 theDoor;    //destroy game object at this transform

        [SerializeField] Transform mainTransform;
        [SerializeField] Animator animator;
        [SerializeField] SpriteRenderer spriteRenderer;

        // Start is called before the first frame update
        void Start()
        {
            targetPoint = 0;    //first array index
            walkingState = WalkingState.WALKING;    //default starting state
            exclamationMarkObject.SetActive(false);
        }

    // Update is called once per frame
    private void Update()
    {
        BobIsSus();
    }

    void LateUpdate()
        {
            //npc always faces camera
            Vector3 camFowardVector = new(Camera.main.transform.forward.x, 0f, Camera.main.transform.forward.z);
            float signedAngle = Vector3.SignedAngle(mainTransform.forward, camFowardVector, Vector3.up);
            float angle = Mathf.Abs(signedAngle);
            transform.Rotate(new Vector3(0, 0, angle));

        //walking state
        if (walkingState == WalkingState.WALKING)
        {
            

            //move to new waypoint
            transform.position = Vector3.MoveTowards(transform.position, wayPoints[targetPoint].position, speed * Time.deltaTime);
            //check for direction npc is moving
            currentDirection = (wayPoints[targetPoint].position - transform.position).normalized;

            if (currentDirection.x >= 0 && currentDirection.y == 0)
            {
                animator.SetFloat("moveX", currentDirection.x);     //moving right
            }
            if (currentDirection.x <= 0 && currentDirection.y == 0)
            {
                animator.SetFloat("moveX", currentDirection.x);     //moving left
            }
            if (currentDirection.y == 0 && currentDirection.z >= 0)
            {
                animator.SetFloat("moveY", currentDirection.z);     //moving back
            }
            if (currentDirection.y == 0 && currentDirection.z <= 0)
            {
                animator.SetFloat("moveY", currentDirection.z);     //moving forward
            }

            //check if distance to next waypoint is small or if waypoint has been reached
            if (Vector3.Distance(transform.position, wayPoints[targetPoint].position) < 0.01f)
            {
                if (isWaiting == true)
                {
                    //walkingState = WalkingState.WAITING;
                    StartCoroutine(WaitBeforeMove());   //wait for 5f
                }
                else
                {
                    walkingState = WalkingState.LOOKING;
                }

            }
        }

        

        //waiting state
        //else if (walkingState == WalkingState.WAITING)
        //{
        //    if (isWaiting == false)
        //    {
        //        walkingState = WalkingState.LOOKING;
        //    }
        //}

        //looking state
        if (walkingState == WalkingState.LOOKING)
        {
           
            //Debug.Log("LOOKING STATE");
            IncreaseTargetPointInt();       //increase array index
            walkingState = WalkingState.WALKING;
        }

        //running away state
        if (walkingState == WalkingState.RUNNINGAWAY)
        {
            Debug.Log("Running state");
            exclamationMarkObject.SetActive(true);
            RunnningAway();
            //run away
        }
        else
        {
            BobIsSus();
        }

        }

        IEnumerator WaitBeforeMove()
        {
            yield return new WaitForSeconds(waitTime);
            isWaiting = false;
            walkingState = WalkingState.LOOKING;
        }

        IEnumerator WaitToSeeIfBobIsStillSus()
        {
            yield return new WaitForSeconds(0.5f);
            if(canSeePlayer)
            {
                
                walkingState = WalkingState.RUNNINGAWAY;
            }
            else
            {
                walkingState = WalkingState.WALKING;
            }
        }

        void OnTriggerEnter(Collider collision)
        {
            //Debug.Log("hey");
            if (collision.gameObject.CompareTag("waitHere"))    //waypoints with this tag and sphere collider
            {
                Debug.Log("is collided");
                isWaiting = true;
                StartCoroutine(WaitBeforeMove());
            }
          
            if (collision.gameObject.CompareTag("basement"))        //door with box collider and rigidbody
            {
                Destroy(collision.gameObject);
                Debug.Log("has escaped");
                //change reputation bar
                Reputation = GetComponent<QuestSystem>()._Reputation;     //from QuestSystemScript
                Reputation -= 1;
            }
        }

        //increase array index
        void IncreaseTargetPointInt()
        {
            targetPoint++;

            if (targetPoint >= wayPoints.Length)
            {
                targetPoint = 0;
            }
        }

        void RunnningAway()
        {
            //change new coordinates to door and get destroyed on collision
            theDoor = new Vector3((float)-4.69000006, (float)3.83999991, (float)-16.2600002);
            float v = speed + runningAwaySpeed;
            transform.position = Vector3.MoveTowards(transform.position, theDoor, v * Time.deltaTime);
        }
        
        void BobIsSus()
        {
            canSeePlayer = GetComponent<FieldOfView>().canSeePlayer;
            shirtOn = GetComponent<QuestSystem>().HasShirt;
            if (canSeePlayer  && shirtOn)
            {
                Debug.Log("can you see me?");
                StartCoroutine(WaitToSeeIfBobIsStillSus());
            }
        }

    }

