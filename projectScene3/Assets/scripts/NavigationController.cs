using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationController : MonoBehaviour
{

    public void GoToIntroScene()
    {
        Application.LoadLevel(0);
    }
    public void GoToCutScene()
    {
        Application.LoadLevel(1);
    }
    public void GoToCharacterScene()
    {
        Application.LoadLevel(2);
    }
    public void GoToHiddenObjectsScene()
    {
        Application.LoadLevel(3);
    }
    public void GoToEvilQueenScene()
    {
        Application.LoadLevel(4);
    }
    public void GoToPrinceScene()
    {
        Application.LoadLevel(5);
    }
    
    public void Quit()
    {
        Application.Quit();
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
