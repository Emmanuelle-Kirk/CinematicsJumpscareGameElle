using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screamer : MonoBehaviour
{
    public bool isOneTime = false;
    public GameObject shreiking;

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
        if (other.CompareTag("Player"))
        {
            shreiking.gameObject.SetActive(true);
        }
        if (isOneTime == true)
        {
            Destroy(this.gameObject);
        }
    }
}
