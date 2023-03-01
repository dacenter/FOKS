using System;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using Random = UnityEngine.Random;

public class Flute : MonoBehaviour
{
    public const float Multiplier = 1.0594630944f;
    
    [SerializeField] private float AttckPitchTime;

    [SerializeField] private float AttackVolumeTime;

    [SerializeField] private float ReleaseVolumeTime;

    [SerializeField] private AudioSource AudioSource;


    public Queue<int> Last4PlayedNotes;

    private int LastHoldedNote;



    public string OwlMelody = "0;7;8;5;";

    private void Awake()
    {
        Last4PlayedNotes = new Queue<int>();
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
        {
            
            DOTween.To(() => JSAM.AudioManager.MusicVolume, JSAM.AudioManager.SetMusicVolume, 1f, 1f);
            
            AudioSource.DOFade(0, ReleaseVolumeTime);
        }
        
    }

    public string GetLastMelody()
    {
        var melodyString = String.Concat(Last4PlayedNotes.ToArray().Select(s => $"{s};"));
        switch (melodyString)
        {
            case "0;7;8;5;":
                return "owl_melody";
                break;
            default: return "none";
        }
    }

    private void PlayNote(int shift)
    {
        DOTween.To(() => JSAM.AudioManager.MusicVolume, JSAM.AudioManager.SetMusicVolume, 0.33f, 1f);
        
        float volume = 0.8f+Random.Range(-0.2f, 0.2f);
        float pitch = Mathf.Pow(Multiplier, shift-3);
        
        AudioSource.DOFade(volume, AttackVolumeTime);
        AudioSource.DOPitch(pitch, AttckPitchTime);
        
        
        if(LastHoldedNote!=shift)
            Last4PlayedNotes.Enqueue(LastHoldedNote);

        while (Last4PlayedNotes.Count > 4) Last4PlayedNotes.Dequeue();
        
        LastHoldedNote = shift;
        
    }
}