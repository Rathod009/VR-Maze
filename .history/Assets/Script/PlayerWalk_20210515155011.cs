using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public float playerSpeed = 1f;
    private bool isWalking = true;
    private Vector3 pointVec;
    private bool isStop = false;
    
    // Update is called once per frame
    void Update()
    {   
        if(!isStop)
        {
            if (isWalking)
            {
                transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
            }

            if (transform.position.y < -10f)
            {
                transform.position = pointVec;
            }

            Ray ray = Camera.main.ViewportPointToRay(new Vector3(.5f, .5f, 0));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.name.Contains("plane"))
                    isWalking = false;
               
            }
        }
    }


    public void changeBool()
    {
        isStop = !isStop;
    }
}
