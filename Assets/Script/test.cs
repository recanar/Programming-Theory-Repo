using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Oyunlar.PlayerDesign
{

    public class test : MonoBehaviour
    {
        Rigidbody rb;
        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //rb.AddForce(Vector3.up * factor);
                rb.velocity = Vector3.up * 10;
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                //rb.AddForce(Vector3.down * factor);
                rb.velocity = Vector3.zero;
            }

        }

        //private void FixedUpdate()
        //{
        //    //if(Input.GetKeyDown(KeyCode.Space))
        //    //{
        //    //    rb.AddForce(Vector3.up * factor * Time.fixedDeltaTime);
        //    //    //rb.velocity = Vector3.up  ;
        //    //}
        //    //if (Input.GetKeyUp(KeyCode.Space))
        //    //{
        //    //    rb.AddForce(Vector3.down * factor * 10 * Time.fixedDeltaTime);
        //    //    //rb.velocity = Vector3.down;
        //    //}

        //    //if (Input.GetKeyDown(KeyCode.Space))
        //    //{
        //    //    rb.AddForce(Vector3.up * factor * Time.fixedDeltaTime);
        //    //    //rb.velocity = Vector3.up  ;
        //    //}
        //    //if (Input.GetKeyUp(KeyCode.Space))
        //    //{
        //    //    rb.AddForce(Vector3.down * factor * 10 * Time.fixedDeltaTime);
        //    //    //rb.velocity = Vector3.down;
        //    //}

        //}
    }
}


// Transform ile jump iki konumlu + havada kalýþ
//// Update is called once per frame
//void Update()
//{
//    if (Input.GetKeyDown(KeyCode.Space) && !jumping)
//    {
//        jumping = true;
//        transform.Translate(Vector3.up * maxJump);
//        Invoke("JumpDown", jumpTime);
//    }

//    //if(Input.GetKeyUp(KeyCode.Space))
//    //{
//    //    //transform.Translate(Vector3.down * maxJump * Time.deltaTime);
//    //    //transform.position = baslangicPos;
//    //}

//}

//private void JumpDown()
//{
//    transform.position = baslangicPos;
//    jumping = false;
//}


// Transform ile jump + max jump kendi düþer 
//private float maxJump; // maksimum sicrama
//private float maxSeviye;
//private float stepJump;
//private float jumpTime;
//private Vector3 baslangicPos;
//private bool jumping;

//// Start is called before the first frame update
//void Start()
//{
//    maxJump = 3f;
//    maxSeviye = 6f;
//    jumpTime = 1f;
//    stepJump = 0.04f;
//    baslangicPos = GetComponent<Transform>().position; // baslangic pozisyonu 

//}

//// Update is called once per frame
//void Update()
//{
//    if (Input.GetKey(KeyCode.Space) && !MaksErisildi() && !jumping)
//    {
//        transform.Translate(Vector3.up * stepJump);
//    }

//    else
//    {
//        jumping = true;
//        if (transform.position.y >= 1)
//        {
//            transform.position = new Vector3(0, transform.position.y - 0.02f, 0);
//        }
//        else
//        {
//            jumping = false;
//        }
//    }
//}

//private void JumpDown()
//{
//    transform.position = baslangicPos;
//    jumping = false;
//}

//private bool MaksErisildi()
//{
//    return transform.position.y >= maxSeviye;
//}
//    }