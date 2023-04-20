using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    //uhol na prenesenie rotacie do dalsej sceny
    public float uhol = 0;



    public static GameObject manager;

    //zabrabujem duplikacii manageru
    private void Start () 
    {
        DontDestroyOnLoad(gameObject);
        if (manager != null)
        {
            Destroy(this.gameObject);

        }

        else {

            manager = this.gameObject;
        
        }
    
    
    }

}
