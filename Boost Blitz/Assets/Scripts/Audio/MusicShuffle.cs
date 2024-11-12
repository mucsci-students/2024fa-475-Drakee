using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to POV Cam (Player 1)
public class MusicShuffle : MonoBehaviour
{
    public GameManager gameManager;
    public AudioClip[] musicTracks;
    private AudioSource theAudioSource;
    private int trackIndex = -1;

    //*************************************************************************

    // Start is called before the first frame update
    void Start()
    {
        theAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //next track starts after the current one is over.
        if (!theAudioSource.isPlaying)
        {
            theAudioSource.clip = GetNextClip();
            theAudioSource.Play();
        }
    }

    public AudioClip GetNextClip()
    {
        if (trackIndex < musicTracks.Length)
        {
            trackIndex++;
        }
        else
        {
            trackIndex = 0;
        }
        return musicTracks[trackIndex];
    }
}
