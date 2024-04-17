using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    // Start is called before the first frame update
    public string movement;
    public float speed = 10f;
    public float rotationSpeed = -0.5f;
    public string confirmUI;
    //public GameDirection boolean;
    public Vector3 LeftPos = new Vector3(0, 0, 0);
    public Vector3 LeftRotation = new Vector3(0, 0, 0);
    public Vector3 BacktoMain = new Vector3(0, 0, 0);
    public Vector3 BacktoMainRotation = new Vector3(0, 0, 0);
    public Vector3 BackToMain2 = new Vector3(0, 0, 0);
    public Vector3 RightPos = new Vector3(0, 0, 0);
    // Update is called once per frame
    void Update()
    {
        /* switch (movement)
         {

             case "left": EvidenceDisplay(); break;
             case "right": SuspectDisplay(); break;
                 default: break;

         }*/
        
        
            if (transform.position != LeftPos && movement == "left")
            {
                transform.position = Vector3.MoveTowards(transform.position, LeftPos, speed * Time.deltaTime);
                transform.eulerAngles = LeftRotation;
               // transform.eulerAngles += LeftRotation * rotationSpeed;


            }

        if (transform.position != BacktoMain && movement == "main")
        {
            transform.position = Vector3.MoveTowards(transform.position, BacktoMain, speed * Time.deltaTime);
            transform.eulerAngles =  BacktoMainRotation;
            //transform.eulerAngles += BacktoMainRotation * rotationSpeed;


        }

        if (transform.position != RightPos && movement == "right")
        {
            transform.position = Vector3.MoveTowards(transform.position, RightPos, speed * Time.deltaTime);
        }

        if (transform.position != BackToMain2 && movement == "main2")
        {
            transform.position = Vector3.MoveTowards(transform.position, BackToMain2, speed * Time.deltaTime);
        }




        // EvidenceDisplay(); 
    }

    public string EvidenceDisplay()
    {
        movement = "left";
        return movement;
    }

    public string MainCamera()
    {
        movement = "main";
        
        return movement;

    }

    public string SuspectDisplay()
    {
        movement = "right";
        return movement;
    }

    public string MainCamera2()
    {
        movement = "main2";
        return movement;
    }
}
