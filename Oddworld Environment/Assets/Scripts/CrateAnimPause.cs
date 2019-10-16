using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateAnimPause : MonoBehaviour
{
    public float speed = 1f;
    private bool moving = true;
    
    private void Start()
    {
        StartCoroutine(CrateMovement());
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        Debug.Log("im moving :)");
    }

    IEnumerator CrateMovement()
    {
        yield return new WaitForSeconds(1f);
        moving = false;
        yield return new WaitForSeconds(0.5f);
        moving = true;
    }

    private void Update()
    {
        if (moving)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            StartCoroutine(CrateMovement());
        }
    }
}
