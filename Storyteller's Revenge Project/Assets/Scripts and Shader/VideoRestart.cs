using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoRestart : MonoBehaviour {
	private UnityEngine.Video.VideoPlayer videoPlayer;
	public GameObject restartButton;

	void Start () {
		videoPlayer = GetComponent<UnityEngine.Video.VideoPlayer> ();
	}
		
		public void Stop()
	{

		if (videoPlayer.isPlaying)
			videoPlayer.frame = 0;
	}
		
	public void Restart()
	{
		videoPlayer.Play();
	}
}
