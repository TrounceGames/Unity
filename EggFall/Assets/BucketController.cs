using UnityEngine;
using System.Collections;

public class BucketController : MonoBehaviour {

    public Camera cam;

    private float maxWidth;
    private Renderer bucketDimentions;
    public float bucketYPos;
    public GameObject[] slabs;
    public Vector2[] BucketStepPos;
    private int counter;

	// Use this for initialization
	void Start ()
    {
        if (cam == null)  cam = Camera.main;
        //bucketDimentions = GetComponent<Renderer>();
        //Vector3 upperCorner = new Vector3(Screen.width,Screen.height,0.0f);
        //Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);
        //maxWidth = targetWidth.x;

        BucketStepPos = new Vector2[slabs.Length];

        for (int i = 0; i < slabs.Length; i++)
        {
            BucketStepPos[i] = new Vector2(slabs[i].transform.position.x, slabs[6].transform.position.y);
        }
       
        StartCoroutine("MoveBucket", .1f);
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        //Vector3 rawPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        //Vector3 targetPosition = new Vector3(rawPosition.x,bucketYPos,0.0f);
        //float x=bucketDimentions.bounds.extents.x;
        //float targetWidth = Mathf.Clamp(targetPosition.x, -maxWidth+x, maxWidth-x);
        //targetPosition = new Vector3(targetWidth,targetPosition.y,targetPosition.z);
        //GetComponent<Rigidbody2D>().MovePosition(targetPosition);
       

        

	}

    IEnumerator MoveBucket(float bucketMoveTime)
    {
        while (true)
        {
            if (counter > 3) counter = 3;
            else if(counter<-3) counter = -3;
            if (Input.GetAxisRaw("Horizontal") == 1) 
            {
                counter++;
                switch (counter)
                {
                    case 0:
                        {
                            //  Vector2 targetPos = new Vector2(BucketStepPos[4].x,BucketStepPos[6].y);
                            GetComponent<Rigidbody2D>().MovePosition(BucketStepPos[6]);
                            yield return new WaitForSeconds(bucketMoveTime);
                        }
                        break;
                    case -1:
                        {
                            //  Vector2 targetPos = new Vector2(BucketStepPos[4].x,BucketStepPos[6].y);
                            GetComponent<Rigidbody2D>().MovePosition(BucketStepPos[2]);
                            yield return new WaitForSeconds(bucketMoveTime);
                        }
                        break;
                    case -2:
                        {
                            //  Vector2 targetPos = new Vector2(BucketStepPos[4].x,BucketStepPos[6].y);
                            GetComponent<Rigidbody2D>().MovePosition(BucketStepPos[1]);
                            yield return new WaitForSeconds(bucketMoveTime);
                        }
                        break;
                    case -3:
                        {
                            //  Vector2 targetPos = new Vector2(BucketStepPos[4].x,BucketStepPos[6].y);
                            GetComponent<Rigidbody2D>().MovePosition(BucketStepPos[0]);
                            yield return new WaitForSeconds(bucketMoveTime);
                        }
                        break;
                    case 1:
                        {
                            //  Vector2 targetPos = new Vector2(BucketStepPos[4].x,BucketStepPos[6].y);
                            GetComponent<Rigidbody2D>().MovePosition(BucketStepPos[3]);
                            yield return new WaitForSeconds(bucketMoveTime);
                        }
                        break;
                    case 2:
                        {
                            //  Vector2 targetPos = new Vector2(BucketStepPos[4].x,BucketStepPos[6].y);
                            GetComponent<Rigidbody2D>().MovePosition(BucketStepPos[4]);
                            yield return new WaitForSeconds(bucketMoveTime);
                        }
                        break;
                    case 3:
                        {
                            //  Vector2 targetPos = new Vector2(BucketStepPos[4].x,BucketStepPos[6].y);
                            GetComponent<Rigidbody2D>().MovePosition(BucketStepPos[5]);
                            yield return new WaitForSeconds(bucketMoveTime);
                        }
                        break;
                }
            }
            else if (Input.GetAxisRaw("Horizontal") == -1)
            {
                counter--;
                switch (counter)
                {
                    case 0:
                        {
                            //  Vector2 targetPos = new Vector2(BucketStepPos[4].x,BucketStepPos[6].y);
                            GetComponent<Rigidbody2D>().MovePosition(BucketStepPos[6]);
                            yield return new WaitForSeconds(bucketMoveTime);
                        }
                        break;
                    case -1:
                        {
                            //  Vector2 targetPos = new Vector2(BucketStepPos[4].x,BucketStepPos[6].y);
                            GetComponent<Rigidbody2D>().MovePosition(BucketStepPos[2]);
                            yield return new WaitForSeconds(bucketMoveTime);
                        }
                        break;
                    case -2:
                        {
                            //  Vector2 targetPos = new Vector2(BucketStepPos[4].x,BucketStepPos[6].y);
                            GetComponent<Rigidbody2D>().MovePosition(BucketStepPos[1]);
                            yield return new WaitForSeconds(bucketMoveTime);
                        }
                        break;
                    case -3:
                        {
                            //  Vector2 targetPos = new Vector2(BucketStepPos[4].x,BucketStepPos[6].y);
                            GetComponent<Rigidbody2D>().MovePosition(BucketStepPos[0]);
                            yield return new WaitForSeconds(bucketMoveTime);
                        }
                        break;
                    case 1:
                        {
                            //  Vector2 targetPos = new Vector2(BucketStepPos[4].x,BucketStepPos[6].y);
                            GetComponent<Rigidbody2D>().MovePosition(BucketStepPos[3]);
                            yield return new WaitForSeconds(bucketMoveTime);
                        }
                        break;
                    case 2:
                        {
                            //  Vector2 targetPos = new Vector2(BucketStepPos[4].x,BucketStepPos[6].y);
                            GetComponent<Rigidbody2D>().MovePosition(BucketStepPos[4]);
                            yield return new WaitForSeconds(bucketMoveTime);
                        }
                        break;
                    case 3:
                        {
                            //  Vector2 targetPos = new Vector2(BucketStepPos[4].x,BucketStepPos[6].y);
                            GetComponent<Rigidbody2D>().MovePosition(BucketStepPos[5]);
                            yield return new WaitForSeconds(bucketMoveTime);
                        }
                        break;
                }
            }
            yield return null;
            
        }
    }
}
