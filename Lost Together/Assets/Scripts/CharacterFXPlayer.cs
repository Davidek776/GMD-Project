using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFXPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip jumpSound;
    [SerializeField] private AudioClip[] runningSounds;

    public void PlayJumpSound(Transform spawnTransform, int playerIndex)
    {
        SoundFXManager.instance.PlayJumpSound(jumpSound, spawnTransform, 1f, playerIndex);
    }

    public void PlayRunningSound(Transform spawnTransform, int playerIndex)
    {
        SoundFXManager.instance.PlayRandomRunningSound(runningSounds, spawnTransform, 0.25f, playerIndex);
    }
}
