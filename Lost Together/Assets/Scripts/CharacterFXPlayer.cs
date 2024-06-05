using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFXPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip[] jumpSounds;
    [SerializeField] private AudioClip[] runningSounds;
    [SerializeField] private AudioClip[] deathSounds;

    public void PlayJumpSound(Transform spawnTransform, int playerIndex)
    {
        SoundFXManager.instance.PlayRandomJumpSound(jumpSounds, spawnTransform, playerIndex);
    }

    public void PlayRunningSound(Transform spawnTransform, int playerIndex)
    {
        SoundFXManager.instance.PlayRandomRunningSound(runningSounds, spawnTransform, playerIndex);
    }

    public void PlayDeathSound(Transform spawnTransform, int playerIndex)
    {
        SoundFXManager.instance.PlayRandomDeathSound(deathSounds, spawnTransform, playerIndex);
    }
}
