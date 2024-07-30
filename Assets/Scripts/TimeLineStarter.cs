using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class TimeLineStarter : MonoBehaviour
{
    private PlayableDirector timeLine;

     void Start()
    {
        timeLine = GetComponent<PlayableDirector>();
    }

    private void Update()
    {
        StartTimeLine();
    }

    private void StartTimeLine()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            timeLine.Play();
        }
    }

}
