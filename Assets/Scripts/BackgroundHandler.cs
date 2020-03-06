using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundHandler : MonoBehaviour
{
    public GameObject background;
    public GameObject bird;
    private bool call;
    // Start is called before the first frame update
    void Start()
    {
        call = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x - bird.transform.position.x   <= -5 && !call)
        {
            GameObject nextBackground = Instantiate(background, new Vector3(transform.position.x + 25.6f, transform.position.y, transform.position.z), Quaternion.identity);
            nextBackground.GetComponent<BackgroundHandler>().bird = bird;
            call = true;
        }
        if(transform.position.x - bird.transform.position.x <= -21)
        {
            Destroy(gameObject);
        }
    }
}
