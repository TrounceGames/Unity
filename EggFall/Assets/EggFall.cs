using UnityEngine;
using System.Collections;

public class EggFall : MonoBehaviour {

   
    private BoxCollider2D Box2D;
    private Vector2 EggPos;
    public Vector2 StepMove;

   
    float yPos;
    bool firstHit;
    bool isTouching = true;
    private Rigidbody2D rgdbdy;


    //  RigidbodyConstraints constraints;
    // Use this for initialization
    void Start()
    {
        
        
        //Box2D = GameObject.FindGameObjectWithTag("Slab").GetComponent<BoxCollider2D>();
        Box2D= transform.parent.parent.gameObject.GetComponent<BoxCollider2D>();
        StepMove.x =2* Box2D.gameObject.transform.localScale.x;
        rgdbdy = gameObject.GetComponent<Rigidbody2D>();
        rgdbdy.fixedAngle = true;
        firstHit = true;
        //yield return new WaitForSeconds(4);
        //while (Box2D.IsTouching(gameObject.GetComponent<EdgeCollider2D>()) == false)
        //    yield return null;
        //isTouching = true;
          StartCoroutine("MoveEgg");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        rgdbdy.isKinematic = false;
        StopCoroutine("MoveEgg");
      //  isTouching = false;

    }


    //void FixedUpdate()
    //{
    //   // StartCoroutine("MoveEgg");
    //}



    //void OnCollisionExit2D(Collision2D coll)
    //{
    //    Egg.GetComponent<Rigidbody2D>().isKinematic = false;

    //}

    IEnumerator MoveEgg()
    {
        yield return new WaitForSeconds(4);
        while (Box2D.IsTouching(gameObject.GetComponent<PolygonCollider2D>()) == false)
            yield return null;

      //  yield return new WaitForSeconds(3);

        while (isTouching)
        {
            rgdbdy.isKinematic = true;
            if (firstHit)
            {
                EggPos = gameObject.transform.position;
                firstHit = false;
                 yPos = rgdbdy.position.y;
            }

            EggPos = EggPos + StepMove ;
            rgdbdy.MovePosition(EggPos);
            //Egg.GetComponent<Rigidbody2D>().AddForce(new Vector2(100, 0));

            yield return new WaitForSeconds(.5f);

            rgdbdy.isKinematic = true;
            yield return new WaitForSeconds(.5f);
            //if (Box2D.IsTouching(Egg.GetComponent<EdgeCollider2D>()))
            //{
            //    Egg.GetComponent<Rigidbody2D>().MovePosition(EggPos);
            //    isTouching = true;
            //    Egg.GetComponent<Rigidbody2D>().isKinematic = true;
            //    Egg.GetComponent<Rigidbody2D>().position = new Vector2(Egg.GetComponent<Rigidbody2D>().position.x, yPos);
            //}
            //else
            //{
            //    isTouching = false;
            //    Egg.GetComponent<Rigidbody2D>().isKinematic = false;

            //}
            //Debug.Log(rigidbody2);
           


            }
       
    }
}