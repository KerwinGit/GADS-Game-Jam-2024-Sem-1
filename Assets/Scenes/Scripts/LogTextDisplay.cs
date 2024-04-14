using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogTextDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    public Text[] Display;
    public Text oneDisplay;
    public Dialog Manager;
    //int size;
    
    public void GenText()
    {
      int  size = Manager.login.Count;
       // int index = Manager.login.Count;
        // Debug.Log(size);
        //Array.Resize( ref Display, Display.Length + size);
        // Debug.Log(Display.Length);

        /*  if (Manager.counter < Display.Length)
          {
              oneDisplay = Display[Manager.counter];
              oneDisplay.text = Manager.login[Manager.counter];

              Debug.Log(Manager.login[Manager.counter]);
           //   index += 1;

          }

          else
          {
              Debug.Log("error");
          } */

        if (size > Display.Length)
        {
            Array.Resize(ref Display, size);
        }

        for (int i = 0; i < size; i++)
        {
              Display[i].text = Manager.login[i];

            Debug.Log(Manager.login[i]);

        }
    }

}
