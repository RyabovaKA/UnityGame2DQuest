using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DA2 : MonoBehaviour
{
     public Animator startAnim;
    public DM2 dm;

    public void OnTriggerEnter2D(Collider2D other)
    {
        startAnim.SetBool("startOpen", true);
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        startAnim.SetBool("startOpen", false);
        dm.EndDialogue();
    }
}
