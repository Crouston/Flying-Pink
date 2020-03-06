using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePatternHandler : MonoBehaviour
{
    public PipePooler pipePooler;
    public GameObject bird;
    public bool call;
    // Start is called before the first frame update
    void Start()
    {
        call = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (bird != null)
        {
            if (bird.transform.position.x - transform.position.x >= 18 && !call)
            {
                pipePooler.CallNextPattern();
                call = true;
            }
            if (bird.transform.position.x - transform.position.x >= 40)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
