using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called before the first frame update
    public dialogue2 dialogue;

    public void triggerDiaglogue()
    {
        FindObjectOfType<Dialog>().StartDialogue(dialogue);
    }
}
