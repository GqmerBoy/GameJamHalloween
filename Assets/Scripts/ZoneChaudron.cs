using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneChaudron : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource1;
    [SerializeField] private AudioSource audioSource2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Rigidbody>() != null)
        {
            ScoreManager.Instance.AddPoint();
            audioSource1.Play();
            audioSource2.Play();
            Destroy(other.gameObject);
        }
    }
}
