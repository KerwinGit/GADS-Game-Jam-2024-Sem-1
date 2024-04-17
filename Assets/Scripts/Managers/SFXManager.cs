using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public static SFXManager Instance;

    [SerializeField] private AudioSource aSource;
    [SerializeField] private List<AudioClip> clips;
    [SerializeField] private HashMap<string, AudioClip> audioHashMap;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        aSource = GetComponent<AudioSource>();

        audioHashMap = new HashMap<string, AudioClip>();
        foreach (AudioClip clip in clips)
        {
            audioHashMap.Put(clip.name, clip);
        }

    }

    public void PlayAudio(string name)
    {
        aSource.PlayOneShot(audioHashMap.Get(name));
    }
}
