using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinecraftController : MonoBehaviour
{
    private IEnumerator coroutine;
    // taken from: https://docs.unity3d.com/ScriptReference/MonoBehaviour.StartCoroutine.html
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("one time");
        GetComponent<Animator>().enabled = false;
        // - After 0 seconds, prints "Starting 0.0"
        // - After 0 seconds, prints "Before WaitAndPrint Finishes 0.0"
        // - After 2 seconds, prints "WaitAndPrint 2.0"
        print("Starting " + Time.time);

        // Start function WaitAndPrint as a coroutine.

        coroutine = WaitAndPrint(2.0f);
        StartCoroutine(coroutine);

        print("Before WaitAndPrint Finishes " + Time.time);
 
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("several times");
    }

    // every 2 seconds perform the print()
    private IEnumerator WaitAndPrint(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            GetComponent<Animator>().enabled = true;
        }
    }
}
