using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] private AudioSource _source;

    [SerializeField] private AudioClip _main;
    [SerializeField] private AudioClip _addPoint;
    [SerializeField] private AudioClip _applyDamage;
    [SerializeField] private AudioClip _dead;

    public void PlayMainMusic(bool isEnabled)
    {
        _source.volume = 0.5f;

        if (isEnabled)
        {
            _source.clip = _main;
            _source.Play();
        }
        else
        {
            _source.Stop();
            _source.volume = 0;
        }
    }

    public void PlayPointSound()
    {
        _source.PlayOneShot(_addPoint);
    }

    public void PlayDamageSound()
    {
        _source.PlayOneShot(_applyDamage);
    }
}
