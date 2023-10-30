using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioClip coinCollectSound;
    [SerializeField] AudioClip niceSoundEffect;
    [SerializeField] AudioClip lossingSoundEfect;

    public void PlayCoinSoundPickUP()
    {
        GetComponent<AudioSource>().PlayOneShot(coinCollectSound);
    }

    public void PlayNiceSoundEffect()
    {
        GetComponent<AudioSource>().PlayOneShot(niceSoundEffect);
    }

    public void PlayLossingSoundEffect()
    {
        GetComponent<AudioSource>().PlayOneShot(lossingSoundEfect);
    }
}
