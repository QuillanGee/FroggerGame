using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreen : MonoBehaviour
{
    public GameObject UI;
    public GameObject Game;
    public GameObject Canvas;
    public GameObject Saws;
    
    public void OnButtonClick()
    {
        UI.SetActive(true);
        Game.SetActive(true);
        Saws.SetActive(true);
        Canvas.SetActive(false);
    }
}
