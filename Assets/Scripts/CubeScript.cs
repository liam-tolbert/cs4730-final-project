using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using SUPERCharacter;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Collider))]
public class CubeScript : MonoBehaviour, IInteractable
{
    //[SerializeField] Animator anim;
    [SerializeField] AudioSource audioData;

    public UnityEvent OnInteract;

    public bool Interact()
    {
        OnInteract.Invoke();
        Invoke("DestroySelf", audioData.clip.length + 2);
        return true;
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }
    public void playMusic()
    {
        if (!audioData.isPlaying)
        {
            audioData.Play();
        }
        
    }
    
}
