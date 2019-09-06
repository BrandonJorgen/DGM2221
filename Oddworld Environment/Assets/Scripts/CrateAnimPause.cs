using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateAnimPause : MonoBehaviour
{
    private Animator animController;
    
    private void Start()
    {
        animController = GetComponent<Animator>();
    }

    IEnumerator PauseAnimTimer()
    {
        animController.speed = 0f;
        yield return new WaitForSeconds(.33f);
        animController.speed = 1f;
    }
}
