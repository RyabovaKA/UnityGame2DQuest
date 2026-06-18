using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DT2 : MonoBehaviour
{
    public D dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DM2>().StartDialogue(dialogue);
    }
}
