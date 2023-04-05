using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    [SerializeField]
    private AudioSource _audio;
    [SerializeField]
    private AudioClip _Mission1Complete;
    [SerializeField]
    private AudioClip _Mission2Complete;
    [SerializeField]
    private AudioClip _onJump;
    [SerializeField]
    private AudioClip _LevelStart;

    private void OnEnable()
    {
        Subject.OnJumpingEvent += PlayJumpingAudio;
        Subject.OnMission1CompleteEvent += PlayMission1completeAudio;
        Subject.OnMission2CompleteEvent += PlayMission2completeAudio;
        Subject.OnLevelStartsEvent += PlayLevelStartAudio;
    }

    private void OnDisable()
    {
        Subject.OnJumpingEvent -= PlayJumpingAudio;
        Subject.OnMission1CompleteEvent -= PlayMission1completeAudio;
        Subject.OnMission2CompleteEvent -= PlayMission2completeAudio;
        Subject.OnLevelStartsEvent -= PlayLevelStartAudio;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void PlayMission1completeAudio()
    {
        //_audio.PlayOneShot(_Mission1Complete);
        _audio.clip = _Mission1Complete;
        _audio.Play();
    }

    void PlayMission2completeAudio()
    {
        _audio.PlayOneShot(_Mission2Complete);
        //   _audio.clip = _Mission2Complete;
        //  _audio.Play();
    }

    void PlayLevelStartAudio()
    {
        _audio.Stop();
        _audio.clip = _LevelStart;
        _audio.Play();
    }

    void PlayJumpingAudio()
    {
        //_audio.PlayOneShot(_onJump);
        _audio.clip = _onJump;
        _audio.Play();
    }

}
