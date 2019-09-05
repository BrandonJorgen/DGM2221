using System.Collections;
using UnityEngine;

public class InstantiateObj : MonoBehaviour
{
    public GameObject instantiatedObj;
    public float delayAmount = 1f;

    private void Start()
    {
        Debug.Log("Start Function activated");
        StartCoroutine("InstatiateTimer");
    }

    IEnumerator InstatiateTimer()
    {
        Debug.Log("Coroutine activated");
        while (true)
        {
            Debug.Log("Coroutine repeated");
            yield return new WaitForSeconds(delayAmount);
            Instantiate(instantiatedObj, transform.position, transform.rotation);
        }
    }
}
