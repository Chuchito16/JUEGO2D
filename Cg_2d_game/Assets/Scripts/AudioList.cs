using UnityEngine;
using System.Collections.Generic;

public class AudioList : MonoBehaviour
{
    public List<AudioClip> ListClips = new List<AudioClip>();
    public AudioSource audioSource;

    [SerializeField] private bool loopPlaylist = true;
    private int currentIndex = -1;

    public void PlayNext()
    {
        if (ListClips == null || ListClips.Count == 0 || audioSource == null)
            return;

        currentIndex++;

        if (currentIndex >= ListClips.Count)
        {
            if (loopPlaylist)
            {
                currentIndex = 0;
            }
            else
            {
                currentIndex = ListClips.Count - 1;
            }
        }

        audioSource.Stop();
        audioSource.clip = ListClips[currentIndex];
        audioSource.Play();
    }
}

