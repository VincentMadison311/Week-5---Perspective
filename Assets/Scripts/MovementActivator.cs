using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;
    [SerializeField] GameObject otherObjectToActivate;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Is triggered");
        objectToActivate.GetComponent<MoveObject>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject>().enabled = true;
    }
    private void OnTriggerExit(Collider other)
    {
        objectToActivate.GetComponent<MoveObject>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject>().enabled = true;
    }
}
