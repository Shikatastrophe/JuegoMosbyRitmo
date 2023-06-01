using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    public VideoPlayer video;

    public void Pause()
    {
        video.Pause();
    }

    public void Play()
    {
        video.Play();
    }
}
