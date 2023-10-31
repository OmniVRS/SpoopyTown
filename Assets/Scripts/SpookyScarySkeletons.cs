using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpookyScarySkeletons : MonoBehaviour
{

    public float moveSpeed;
    public float turnSpeed;
    public AudioClip spookyNoise;
    private AudioSource spookySource;

    // Start is called before the first frame update
    void Start()
    {
        spookySource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            spookySource.PlayOneShot(spookyNoise);
        }
    }
}
