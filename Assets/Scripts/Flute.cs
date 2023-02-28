using DG.Tweening;
using UnityEngine;

public class Flute : MonoBehaviour
{
    public const float Multiplier = 1.0594630944f;
    
    [SerializeField] private float AttckPitchTime;

    [SerializeField] private float AttackVolumeTime;

    [SerializeField] private float ReleaseVolumeTime;

    [SerializeField] private AudioSource AudioSource;


    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.Keypad0))
            PlayNote(0);

        else if (Input.GetKey(KeyCode.Keypad1))
            PlayNote(1);

        else if (Input.GetKey(KeyCode.Keypad2))
            PlayNote(3);

        else if (Input.GetKey(KeyCode.Keypad3))
            PlayNote(4);

        else if (Input.GetKey(KeyCode.Keypad4))
            PlayNote(5);

        else if (Input.GetKey(KeyCode.Keypad5))
            PlayNote(7);

        else if (Input.GetKey(KeyCode.Keypad6))
            PlayNote(8);

        else if (Input.GetKey(KeyCode.Keypad7))
            PlayNote(10);

        else if (Input.GetKey(KeyCode.Keypad8))
            PlayNote(12);
        else
            GetComponent<AudioSource>().DOFade(0, ReleaseVolumeTime);
    }

    private void PlayNote(int shift)
    {
        float volume = 0.8f+Random.Range(-0.2f, 0.2f);
        float pitch = Mathf.Pow(Multiplier, shift);
        
        AudioSource.DOFade(volume, AttackVolumeTime);
        AudioSource.DOPitch(pitch, AttckPitchTime);
        
    }
}