using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pohybMysou : MonoBehaviour
{
    //rychlost otacania
    public float speed = 2;
 
    private Camera mainCamera;

    //autom. rotacia
    float rotationTime = 3;
    float rotationTick = 0;
    float rotationSave = 0;
    float rotationSpeed = 3f;

    [SerializeField]
    private float minFov = 25, maxFov = 60;

    GameObject cameraHolder;

    // Start is called before the first frame update
    void Start()
    {

        mainCamera = Camera.main;

        print(Camera.main.transform.eulerAngles);

        //neupravene uhly necha tak a ostatne mi otoci kameru podla uhla ktory zadam
        if (GameObject.Find("Manager").GetComponent<Manager>().uhol != 0)
        {

            Camera.main.transform.eulerAngles = new Vector3(0, GameObject.Find("Manager").GetComponent<Manager>().uhol, 0);
            //cameraHolder.transform.eulerAngles = new Vector3(0, GameObject.Find("Manager").GetComponent<Manager>().uhol, 0);

        }
        
        print(Camera.main.transform.eulerAngles);


    }

    void Update()
    {
        //tahanim laveho tlacitka na mysi sa otacame okolo seba
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(Input.GetAxis("Mouse Y") * speed, -Input.GetAxis("Mouse X") * speed, 0);
            var x = transform.rotation.eulerAngles.x;
            var y = transform.rotation.eulerAngles.y;
            //transform.rotation = Quaternion.Euler(x, y, 0);
            transform.localRotation = Quaternion.Euler(transform.localRotation.eulerAngles.x, transform.localRotation.eulerAngles.y, 0);


            rotationTick = 0;
        }

        rotationSave = transform.rotation.eulerAngles.y;

        if (rotationTick >= rotationTime)
        {
            //transform.rotation = Quaternion.Euler(transform.rotation.x, (rotationSpeed * Time.deltaTime) + rotationSave, 0);

            //transform.localRotation = Quaternion.Euler(transform.localRotation.eulerAngles.x, (rotationSpeed * Time.deltaTime) + rotationSave, 0);
            rotationSave = 0;
        }

        rotationTick += Time.deltaTime;

        var delta = Input.mouseScrollDelta;
        mainCamera.fieldOfView -= delta.y;
        mainCamera.fieldOfView = Mathf.Clamp(mainCamera.fieldOfView, minFov, maxFov);

    }

}