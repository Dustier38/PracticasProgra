using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReproductorAudio : MonoBehaviour
{
    public static ReproductorAudio Instance;
    public AudioSource repAudio;
    public List<AudioClip> album_01 = new List<AudioClip>();
    //Lista del segundo album
    public Transform trackContainer;
    public GameObject trackObj;
    public int currentTrack;
    public bool album01;
    public Slider volumeControl;
    private void Awake()
    {

    }


    void Start()
    {
        if (album01)
        {

        }

        for (int i = 0; i < album_01.Count; i++)
        {
            Instantiate(trackObj, trackContainer);
            trackObj.GetComponent<Track>().clip = album_01[i];
            trackObj.GetComponent<Track>().idTrack = i;
        }
    }
    //else if (!album01){ set de album 2 }

    private void Update()
    {
        repAudio.volume = volumeControl.value;
    }

    public void Forward()
    {
        if (currentTrack < album_01.Count - 1)
        {
            currentTrack++;
            repAudio.clip = album_01[currentTrack];
            repAudio.Play();
        }
        else
        {
            currentTrack = 0;
            repAudio.clip = album_01[0];
            repAudio.Play();
        }
    }


    public void Backward()
    {
        if (currentTrack > 0)
        {
            currentTrack--;
            repAudio.clip = album_01[currentTrack];
            repAudio.Play();
        }
        else
        {
            currentTrack = album_01.Count - 1;
            repAudio.clip = album_01[currentTrack];
            repAudio.Play();
        }
    }

}
