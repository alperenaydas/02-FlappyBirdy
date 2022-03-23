using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    public float time;
    public GameObject pipePrefab;
    
    public void StartSpawning()
    {
        InvokeRepeating("SpawnPipe", 0, time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPipe()
    {
        var obj = Instantiate(pipePrefab, transform.position, Quaternion.identity);
        obj.transform.position = obj.transform.position + Vector3.up * Random.Range(-0.3f, 0.3f);
    }
}
