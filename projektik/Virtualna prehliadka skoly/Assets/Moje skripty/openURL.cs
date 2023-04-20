using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openURL : MonoBehaviour
{

    public string Url;

     private void OnMouseDown()
        {
            Application.OpenURL(Url);
        }
}
