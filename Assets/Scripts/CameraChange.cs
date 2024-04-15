using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    // Start is called before the first frame update
    string movement = "main";
    public float speed = 10f;
    public float rotationSpeed = -0.5f;
    //public GameDirection boolean;
    public Vector3 LeftPos = new Vector3(0, 0, 0);
    public Vector3 LeftRotation = new Vector3(0, 0, 0);
    private Vector3 RightPos = new Vector3(0, 0, 0);
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
                transform.eulerAngles = transform.eulerAngles + LeftRotation;
                transform.eulerAngles += LeftRotation * rotationSpeed;


            }
        
            else
        {

        }
       

        

        EvidenceDisplay(); 
    }

    public string EvidenceDisplay()
    {
        movement = "left";
        return movement;
    }

    public void SuspectDisplay()
    {
        if (transform.position != RightPos)
        {
            transform.position = Vector3.MoveTowards(transform.position, LeftPos, speed * Time.deltaTime);

        }
    }
}
