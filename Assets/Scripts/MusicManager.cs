using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip BackgroundMusicIntro;
    public AudioClip BackgroundMusicGhostNormal;
    public AudioClip BackgroundMusicGhostDead;
    public AudioClip BackgroundMusicGhostScared;
    public AudioClip SoundEffectPacStudentNormalMoveSound;
    public AudioClip SoundEffectPacStudentHitWallSound;
    public AudioClip SoundEffectPacStudentEatPelletSound;
    public AudioClip SoundEffectPacStudentDeadSound;

    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayBackgroundMusicIntro();
    }

    public void PlayBackgroundMusicIntro()
    {
        audioSource.clip = BackgroundMusicIntro;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void PlayBackgroundMusicGhostNormal()
    {
        audioSource.clip = BackgroundMusicGhostNormal;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void PlayBackgroundMusicGhostDead()
    {
        audioSource.clip = BackgroundMusicGhostDead;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void PlayBackGroundMusicGhostScared()
    {
        audioSource.clip = BackgroundMusicGhostScared;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void PlaySoundEffectPacStudentNormalMoveSound()
    {
        audioSource.PlayOneShot(SoundEffectPacStudentNormalMoveSound);
    }

    public void PlaySoundEffectPacStudentHitWallSound()
    {
        audioSource.PlayOneShot(SoundEffectPacStudentHitWallSound);
    }

    public void PlaySoundEffectPacStudentEatPelletSound()
    {
        audioSource.PlayOneShot(SoundEffectPacStudentEatPelletSound);
    }

    public void PlaySoundEffectPacStudentDeadSound()
    {
        audioSource.PlayOneShot(SoundEffectPacStudentDeadSound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
