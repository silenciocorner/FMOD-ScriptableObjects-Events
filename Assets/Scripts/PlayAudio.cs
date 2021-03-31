using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    [SerializeField]
    private PlayerAudioData playerAudio;

    void Start()
    {
        FMODUnity.RuntimeManager.PlayOneShot(playerAudio.jump);
    }
}
