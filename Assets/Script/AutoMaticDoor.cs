using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMaticDoor : MonoBehaviour
{
    public GameObject movingDoor;
    public float maximumOpening=3f;
    public float maximumClosing = 0f;

    public float movementSpeed = 1f;

    bool playerIsHere;
    bool opening;
    // Start is called before the first frame update
    void Start()
    {
        playerIsHere = false;
        opening = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsHere && movingDoor.transform.position.x < maximumOpening)
        {
            movingDoor.transform.position += Vector3.forward * Time.deltaTime;
        }
        else if (!playerIsHere&&movingDoor.transform.position.x > maximumClosing)
        {
            movingDoor.transform.position += -Vector3.forward * Time.deltaTime;
        }

    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag =="Player")
        {
            playerIsHere = true;
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            playerIsHere = false;
        }
    }
}
