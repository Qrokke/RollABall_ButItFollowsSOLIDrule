using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Item : MonoBehaviour, IItem
{
    [Inject]
    public void Construct(Vector3 position)
    {
        transform.position = position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Deleted");
        }
    }
}
