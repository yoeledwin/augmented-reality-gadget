using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class close_btn : MonoBehaviour
{
public void CloseApp()
{
    UnityEngine.Debug.LogError("Close App");
    Application.Quit();
}

}