using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{
    [SerializeField] private AudioSource AudioSource;
    [SerializeField] private AudioClip[] bounceSounds;
    [SerializeField] private AudioClip[] breakSounds;

    public void PlayBounceSound()
    {
        var bounceSoundIndex = Random.Range(0, bounceSounds.Length);
        AudioSource.PlayOneShot(bounceSounds[bounceSoundIndex]);
    }

    public void PlayBreakSound()
    {
        var breakSoundIndex = Random.Range(0, bounceSounds.Length);
        AudioSource.PlayOneShot(breakSounds[breakSoundIndex]);
    }
}
