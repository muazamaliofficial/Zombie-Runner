using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWon : MonoBehaviour
{
    [SerializeField] Canvas gamewinCanvas;

    private void Start()
    {
        gamewinCanvas.enabled = false;
    }

    private void Update ()
    {
        if (GameObject.FindGameObjectsWithTag("enemy").Length == 0)
        {
            gamewinCanvas.enabled = true;
            Time.timeScale = 0;
            FindObjectOfType<WeaponSwitcher>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

    }
}
