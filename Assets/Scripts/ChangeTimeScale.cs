using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;

public class ChangeTimeScale : MonoBehaviour
{
    [Range(0.1f, 2) ]public float modifiedScale;
    public float updateInterval = 0.5F;
    private double lastInterval;
    private int frames;
    private float fps;

    // Start is called before the first frame update
    void Start()
    {
        lastInterval = Time.realtimeSinceStartup;
        frames = 0;
    }

    IEnumerator Seconds()
    {
        yield return new WaitForSeconds(30.0f);
        modifiedScale = 0.75f;
        yield return new WaitForSeconds(30.0f);
        modifiedScale = 1.0f;
        yield return new WaitForSeconds(30.0f);
        modifiedScale = 1.25f;
        yield return new WaitForSeconds(30.0f);
        modifiedScale = 1.50f;
        yield return new WaitForSeconds(30.0f);
        modifiedScale = 1.75f;
        yield return new WaitForSeconds(30.0f);
        modifiedScale = 2.0f;

    }

    // Update is called once per frame
    void Update()
    {
        ++frames;
        float timeNow = Time.realtimeSinceStartup;
        if (timeNow > lastInterval + updateInterval)
        {
            fps = (float)(frames / (timeNow - lastInterval));
            StartCoroutine(Seconds());
            lastInterval = timeNow;
        }
        Time.timeScale = modifiedScale;

    }
}
