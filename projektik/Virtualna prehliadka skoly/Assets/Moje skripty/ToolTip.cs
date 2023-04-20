using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTip : MonoBehaviour
{

    public string message;

    private void OnMouseEnter ()
    {
        ToolBox._instance.SetAndShowToolTip(message);
    }

    private void OnMouseExit()
    {
        ToolBox._instance.HideToolTip();
    }

}
