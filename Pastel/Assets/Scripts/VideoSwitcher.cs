using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoSwitcher : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Referencia al componente VideoPlayer
    public VideoClip[] videoClips; // Array de VideoClips locales

    void Start()
    {
        if (videoPlayer == null)
        {
            videoPlayer = GetComponent<VideoPlayer>();
        }

        // Reproduce el primer video al iniciar (opcional)
        if (videoClips.Length > 0)
        {
            videoPlayer.clip = videoClips[0];
            videoPlayer.Play();
        }
    }

    public void PlayVideo(int index)
    {
        if (index >= 0 && index < videoClips.Length)
        {
            videoPlayer.clip = videoClips[index];
            videoPlayer.Play();
        }
        else
        {
            Debug.LogError("Video index out of range");
        }
    }
}
