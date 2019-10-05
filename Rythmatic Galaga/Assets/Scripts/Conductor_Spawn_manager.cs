using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conductor_Spawn_manager : MonoBehaviour
{
    public float songBpm; //Songs beats per minute
    public float secPerBeat; //The number of seconds for each song beat
    public float songPosition; //Current song position, in seconds
    public float songPositionInBeats; //Current song position in beats
    public float dspSongTime; //How many seconds have passed since the song started
    public AudioSource[] musicSource; //an AudioSource attached ot this GameObject that will play the music

    // Start is called before the first frame update
    void Start()
    {
        //Loads one of the 5 songs
        musicSource = Random.Range(0, 5);

        //Calculate the number of seconds in each beat
        secPerBeat = 60f / songBpm;

        //record the time when the music start 
        dspSongTime = (float)AudioSettings.dspTime;

        //start the song
        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        songPosition = (float)(AudioSettings.dspTime - dspSongTime);
        songPositionInBeats = songPosition / secPerBeat;

     }
}
