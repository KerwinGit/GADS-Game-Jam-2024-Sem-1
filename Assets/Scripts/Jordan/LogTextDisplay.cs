using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class LogTextDisplay : MonoBehaviour
{
    // Start is called before the first frame update
   // public Text[] Display;
    public TMP_Text oneDisplay;
    public TMP_Text twoDisplay;
    public Dialog Manager;
    string Text;
    //int size;

    public void GenText()
    {
      //  Debug.Log("work");


        twoDisplay.text = Manager.nameDisplay;
        for (int i = 0; i < Manager.login.Count; i++)
        {
            
            if (i >= 1)
            {

               string temp = Text + "\n\n" + Manager.login[i];
               Text = temp;
               // Debug.Log(Text);
                

            }

            else
            {
                Text = Manager.login[i];
            }
            
            oneDisplay.text = Text;
            //Debug.Log(Text);
        }

        
        //int size = Manager.login.Count;
        //int index = Manager.login.Count;
        // Debug.Log(size);
        // Array.Resize( ref Display, Display.Length + size);
        // Debug.Log(Display.Length);

        /* if (Manager.counter < Display.Length)
         {
             oneDisplay = Display[Manager.counter];
             Text = Manager.login[Manager.counter];
             Debug.Log(Manager.login[Manager.counter]);
            // index += 1;

         }

         else
         {
             Debug.Log("error");
         } */

        /* if (size > Display.Length)
         {
             Array.Resize(ref Display, size);
         }

         for (int i = 0; i < size; i++)
         {
               Display[i].text = Manager.login[i];

             Debug.Log(Manager.login[i]);

         }*/
    }

}
