using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffinBlast : MonoBehaviour
{

    private Rigidbody lidRb;
    public float launchForce;
    private bool hasBeenFlung = false;

    // Start is called before the first frame update
    void Start()
    {
        lidRb = GetComponent<Rigidbody>();
        lidRb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    
    {
        if (other.gameObject.CompareTag("Player") && hasBeenFlung == false)
        {
            lidRb.isKinematic = false;
            lidRb.AddRelativeForce(Vector3.up * launchForce, ForceMode.Impulse);
            hasBeenFlung = true;
        }
    }
}
