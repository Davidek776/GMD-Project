using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundMixerManager : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    public void SetMasterVolume(float volume)
    {
        audioMixer.SetFloat("masterVolume", Mathf.Log10(volume) * 20);
    }

    public void SetSoundEffectsVolume(float volume)
    {
        audioMixer.SetFloat("soundEffectsVolume", Mathf.Log10(volume) * 20);
    }

    public void SetBackgroundMusicVolume(float volume)
    {
        audioMixer.SetFloat("backgroundMusicVolume", Mathf.Log10(volume) * 20);
    }
}
