using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool isOneTime = false;
    public GameObject doorslam;
    public GameObject doorvanish;
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
            doorslam.gameObject.SetActive(true);
            doorvanish.gameObject.SetActive(false);
        }
        if (isOneTime == true)
        {
            Destroy(this.gameObject);
        }
    }
}
