using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBehaviour : MonoBehaviour {

    public AudioSource music;

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.F))
        {
            //start sound
            if (music)
            {
                if (!music.isPlaying)
                {
                    music.Play();
                }
                else
                {
                    music.Stop();
                }
            }
        }
	}
}
