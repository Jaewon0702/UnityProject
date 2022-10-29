using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float TimeDiff;
    // Start is called before the first frame update
    float timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > TimeDiff)
        {
            GameObject newpipe = Instantiate(pipe); //pipe를 매 프레임마다 생성
            newpipe.transform.position = new Vector3(3, Random.Range(-3.0f, 3.0f), 0);
            timer = 0;
            Destroy(newpipe, 10.0f);
        }
        
    }
}
