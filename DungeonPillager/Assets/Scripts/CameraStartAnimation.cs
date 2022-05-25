using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStartAnimation : MonoBehaviour
{
    
    public PlayerMovement playerMovement;
    public CameraFollow cameraFollow;
    public float animTime;

    private IEnumerator coroutine;

    void Start()
    {
        playerMovement.enabled = false;
        cameraFollow.enabled = false;
        // - After 0 seconds, prints "Starting 0.0"
        // - After 0 seconds, prints "Before WaitAndPrint Finishes 0.0"
        // - After 2 seconds, prints "WaitAndPrint 2.0"
        //print("Starting " + Time.time);

        // Start function WaitAndPrint as a coroutine.

        coroutine = WaitAndPrint(animTime);
        StartCoroutine(coroutine);

        //print("Before WaitAndPrint Finishes " + Time.time);
    }

    // every 2 seconds perform the print()
    private IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        //print("WaitAndPrint " + Time.time);
        playerMovement.enabled = true;
        cameraFollow.enabled = true;
    }

}