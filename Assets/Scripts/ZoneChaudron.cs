using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneChaudron : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering object has a Rigidbody (meaning it's a droppable object)
        if (other.gameObject.GetComponent<Rigidbody>() != null)
        {
            ScoreManager.Instance.AddPoint();
            Destroy(other.gameObject);
        }
    }
}
