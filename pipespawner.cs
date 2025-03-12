using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 2;
    private float timer = 0;
    public float hightoffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        // this sees if timer is lower then spawnrate
        if (timer < spawnrate)
        {
            // this can also be writen as "timer =+ time.deltatime". this "+" time by frame rate( a variable that
            // represents the time (in seconds) that passed between the last frame and the current frame)
            timer = timer + Time.deltaTime;
        }
        else
        {
            // if timer lower then spawnrate then spawn a pipe and restart timer by 0
            spawnpipe();
            timer = 0;
        }
    }
    void spawnpipe()
    {
        //this will give up and down value of the map
        float lowestpoint = transform.position.y - hightoffset;
        float higestpoint = transform.position.y + hightoffset;

        //thi makes it spawn randomly in lowest and higestpoint for the y,x is fix so it wont span just anywhere,z is also 0 since we dont want our pipe to go back words
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint, higestpoint), 0), transform.rotation);
    }
}
