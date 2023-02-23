using DG.Tweening;
using UnityEngine;
using UnityEngine.Serialization;

public class Flute : MonoBehaviour
{
    public const float MULTIPLIER = 1.0594630944f;
    
    [SerializeField] private float AttckPitchTime;

    [SerializeField] private float AttackVolumeTime;

    [SerializeField] private float ReleaseVolumeTime;

    // Start is called before the first frame update
    private void Start()
    {
    }

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
            GetComponent<AudioSource>().DOFade(0.8f+Random.Range(-0.2f, 0.2f), AttackVolumeTime);

            GetComponent<AudioSource>().DOPitch(Mathf.Pow(MULTIPLIER, shift), AttckPitchTime);
        
    }
}