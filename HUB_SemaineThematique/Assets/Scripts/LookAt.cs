using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform head;
    public bool InTrigger = false;
    public Transform LookTarget;

    public void OnTriggerStay(Collider other)
    {
        InTrigger = true;
    }

    public void OnTriggerExit(Collider other)
    {
        InTrigger = false;
    }

    private void LateUpdate()
    {
        if (InTrigger == true)
            head.LookAt(LookTarget);
    }
}