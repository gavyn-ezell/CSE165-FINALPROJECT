using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MetronomeRoutine : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip clip;
    public AudioSource source;
    
    
    private bool playing = false;
    public TMP_Text bpmText;
    public float bpm = -1;

    private IEnumerator coroutine; 
    
    public void Start()
    {
        coroutine = metronomeCoroutine();
    }

    public void Update()
    {
        if (bpmText.text.Length > 4)
        {
             
            string numberString = bpmText.text.Substring(4); 
            bpm = float.Parse(numberString);
        }
        else {
            bpm = -1.0f;
        }

    }
    
    
    
    
    public void toggleMetronomeCoroutine()
    {
        if (!playing)
        {
            StartCoroutine(coroutine);
        }
        else{
            StopCoroutine(coroutine);
        }
        playing = !playing;
    }

    IEnumerator metronomeCoroutine()
    {
        while(true) 
        { 
            if (bpm >= 0.0f)
            {

                source.PlayOneShot(clip);
                yield return new WaitForSeconds(60.0f / (float)bpm );
            }
            else {
                yield return new WaitForSeconds(0.1f);
            }
        }
    }
}
