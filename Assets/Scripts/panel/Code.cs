using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    [SerializeField]
    GameObject codePanel, closed, opened;
    public static bool isSafeOpened = false;
    void Start()
    {
        codePanel.SetActive(false);
        closed.SetActive(true);
        opened.SetActive(false);
    }

    void Update()
    {
        if (isSafeOpened)
        {
            codePanel.SetActive(false);
            closed.SetActive(false);
            opened.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name.Equals ("Door") && !isSafeOpened)
        {
            codePanel.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Door"))
        {
            codePanel.SetActive(false);
        }
    }
}
