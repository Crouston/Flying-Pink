using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileHandler : MonoBehaviour
{
    public TilePooler tilePooler;
    public GameObject bird;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x - bird.transform.position.x <= -8)
        {
            tilePooler.GivePosition(gameObject);
        }
    }
}
