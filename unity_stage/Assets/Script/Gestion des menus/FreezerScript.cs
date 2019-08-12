using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezerScript : MonoBehaviour
{
    
    public float duration = 1f;

    private bool isFrozen = false;
    
    private float pendingFreezeDuration = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pendingFreezeDuration < 0 && !isFrozen)
        {
            StartCoroutine(DoFreeze());
        }    
    }

   

    public void Freeze()
    {
        pendingFreezeDuration = duration;
    }

    IEnumerator DoFreeze()
    {
        isFrozen = true;
        var original = Time.timeScale;
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(duration);
        Time.timeScale = original;
        pendingFreezeDuration = 0;
        isFrozen = false;
    }
}
