using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource effectAudioSource;
    [SerializeField] private AudioSource defautAudioSource;
    [SerializeField] private AudioSource bossAudioSource;
    [SerializeField] private AudioClip shootClip;
    [SerializeField] private AudioClip reloadClip;
    [SerializeField] private AudioClip energyClip;

    public void PlayShotSound()
    {
        effectAudioSource.PlayOneShot(shootClip);
    }

    public void PlayReloadSound()
    {
        effectAudioSource.PlayOneShot(reloadClip);
    }

    public void PlayEnergySound()
    {
        effectAudioSource.PlayOneShot(energyClip);
    }

    public void PlayDefautAudio()
    {
        bossAudioSource.Stop();
        defautAudioSource.Play();
    }

    public void PlayBossAudio()
    {
        defautAudioSource.Stop();
        bossAudioSource.Play();
    }

    public void StopAudioGame()
    {
        effectAudioSource.Stop();
        bossAudioSource.Stop();
        defautAudioSource.Stop();
    }
}
