using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class prechody : MonoBehaviour
{

    public string SceneName;
    public int cameraRotation = 0;

    Animator transition;

private void OnMouseDown()
    {
        //uhol pre otocenie rotacie kamery
        GameObject.Find("Manager").GetComponent<Manager>().uhol = cameraRotation;

        //spustenie animacie prechodu
        transition = GameObject.Find("Animacia").GetComponent<Animator>();
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()

    {

        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(SceneName);


    }
}