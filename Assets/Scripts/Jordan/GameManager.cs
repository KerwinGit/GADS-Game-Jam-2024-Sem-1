using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

     public GameObject Bobby;
    public Dialog noMoreBobby;
    float time = 0f;
    public bool heAppears; 
    // Start is called before the first frame update
    void Start()
    {
        Bobby.SetActive(false);
        heAppears = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(time < 2f)
        {
            time++;
        }

        else
        {
            Bobby.SetActive(true);
            heAppears=true; 

        }

        if (noMoreBobby.end is true)
        {
            Bobby.SetActive(false);
        }
    }
}
