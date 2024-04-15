using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    // 8.9 4.5 -5.5
    // Start is called before the first frame update
    public float speed = 10f;
    public Vector3 FirstPos = new Vector3 (0, 0, 0);
    public Vector3 endPos = new Vector3(0, 0, 0);
    float count = 0.0f;
    int timer = 0;
    public bool switching;

    // Update is called once per frame
    void Update()
    {
        if(timer != 5)
        {

            BeginingCameraMovement();
            count += Time.deltaTime;
            timer = (int)(count);

        }
        

        if (timer == 5){ 
        
            EndingCameraMovement();
            //timer = 0;
        
        }
        
           
        

        
    }

    public void BeginingCameraMovement()
    {
        
        if (transform.position != FirstPos)
        {
            transform.position = Vector3.MoveTowards(transform.position, FirstPos, speed * Time.deltaTime);

        }

        
    }

    public void EndingCameraMovement() {
        if (transform.position != endPos)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPos, speed * Time.deltaTime);

        }
        else
        {
            switching = true;
            
        }
    }
}
