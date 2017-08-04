using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Door : MonoBehaviour 
{
	public AudioClip doorLockedAndClickedAudio;
	public AudioClip doorUnlockedAndClickedAudio;
	public Animator doorAnimator;
	public Animator barrierAnimator;

	private AudioSource doorAudioSource;
	private bool locked = true;
	private bool barrierOpening = false;
	private bool doorOpening = false;
	private bool barrierOpen = false;
	private bool doorOpen = false;

	void Start() {
		doorAudioSource = gameObject.GetComponent<AudioSource> ();
		doorAudioSource.clip = doorLockedAndClickedAudio;
	}

    void Update() {

		barrierOpen = barrierAnimator.GetCurrentAnimatorStateInfo (0).IsName ("BarrierOpened");
		doorOpen = doorAnimator.GetCurrentAnimatorStateInfo (0).IsName ("DoorOpened");

		print ("This is door open = " + doorOpen);

		if (barrierOpening && !barrierOpen) {
			barrierOpening = !barrierOpen ? false : true;
			barrierAnimator.SetTrigger ("raiseBarrier");
		} else if (doorOpening && !doorOpen) {
			doorOpening = !doorOpen ? false : true;
			doorAnimator.SetTrigger ("openDoor");
			disableCollider ();
		}
    }

	void disableCollider() {
		BoxCollider colliderObject = gameObject.GetComponent<BoxCollider> ();
		colliderObject.enabled = false;
	}

    public void OnDoorClicked() {
		if (barrierOpen && doorOpen) {
			return;
		}

		if (barrierOpen) {
			if (!locked) {
				doorOpening = true;
			}
			doorAudioSource.Play ();
		}
    }

    public void Unlock()
    {
		barrierOpening = true;
		locked = false;
		doorAudioSource.clip = doorUnlockedAndClickedAudio;
	}
}
