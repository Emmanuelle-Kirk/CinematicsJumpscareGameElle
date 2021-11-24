using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class wall1script : MonoBehaviour
{
    public bool isOneTime = false;

    public PlayableDirector timeline;

    // Start is called before the first frame update
    void Start()
    {
        timeline.GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            //Plays the timeline
            timeline.Play();
          
        }
        if(isOneTime == true)
        {
            Destroy(this.gameObject);
        }
    }
}
