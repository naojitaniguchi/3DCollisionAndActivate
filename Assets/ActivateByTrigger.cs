using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateByTrigger : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A key pushed");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if ( other.gameObject.tag == "Player")
        {
            target.SetActive(true);
        }
    }
}
