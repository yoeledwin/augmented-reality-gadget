using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trackable : DefaultObserverEventHandler
{
public AudioSource suara;
    void Awake()
    {
        suara = GetComponent<AudioSource>();
    }
    private bool marker;
    protected override void OnTrackingFound()
    {
        marker = true;
        base.OnTrackingFound();
        suara.Play();
    } 

    protected override void OnTrackingLost()
    {
        marker = false;
        base.OnTrackingLost();
        suara.Stop();
    }

    public bool GetMarker()
    {
        return marker;
    }
}