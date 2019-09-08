using System.Collections;
using UnityEngine;

public class InstantiateObj : MonoBehaviour
{
    public GameObject instantiatedObj;
    public float delayAmount = 1f;

    private void Start()
    {
        StartCoroutine("InstantiateTimer");
    }

    IEnumerator InstantiateTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(delayAmount);
            Instantiate(instantiatedObj, transform.position, transform.rotation);
        }
    }
}
