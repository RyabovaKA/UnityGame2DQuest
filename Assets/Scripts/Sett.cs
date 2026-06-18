using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sett : MonoBehaviour
{

    [SerializeField] Image soundOnIcon;
    [SerializeField] Image soundOffIcon;
    private bool full = false;
    void Start()
    {
        if (!PlayerPrefs.HasKey("full"))
        {
            PlayerPrefs.SetInt("full", 0);
            Load();
        }
        else
        {
            Load();
        }
        UpdateButtonIcon();
        Screen.fullScreen = full;
    }

    public void OnButtonPress()
    {
        if (full == false)
        {
            full = true;
            Screen.fullScreen = true;
        }
        else
        {
            full = false;
            Screen.fullScreen = false;
        }
        Save();
        UpdateButtonIcon();
    }
    private void UpdateButtonIcon()
    {
        if (full == false)
        {
            soundOnIcon.enabled = true;
            soundOffIcon.enabled = false;
        }
        else
        {
            soundOnIcon.enabled = false;
            soundOffIcon.enabled = true;
        }
    }
    private void Load()
    {
        full = PlayerPrefs.GetInt("full") == 1;
    }
    private void Save()
    {
        PlayerPrefs.SetInt("full", full ? 1 : 0);
    }

    /*public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }*/
}
