using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    private bool startedPlaying = false;

    public void Play(string name)
    {

        AM.Instance.PlaySFX(name);
        Debug.Log("Played sound from PlaySound");
    }

    public void PlayLooped(string name)
    {
        if (!startedPlaying)
        {
            AM.Instance.PlaySFX(name);
            startedPlaying = true;
        }
        else
        {
            return;
        }
       
    }

    //Ensures the sound only plays once
    public void PlayOnce(string name)
    {
        //startedPlaying = true;
        if(!startedPlaying)
        {
            AM.Instance.PlaySFX(name);
            startedPlaying = true;
        }


    }

    public void StopLooped(string name)
    {
        startedPlaying = false;
        AM.Instance.StopSFX(name);

    }

    public void PlaySteps()
    {
        AM.Instance.PlayFootsteps();
    }

}
