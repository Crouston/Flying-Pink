using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePooler : MonoBehaviour
{
    public List<PipePatternHandler> pipeList;
    public GameObject bird;
    public PipePatternHandler[] pipePatternArray;
    private int patternSum;
    // Start is called before the first frame update
    void Start()
    {
        pipePatternArray = new PipePatternHandler[100];
        patternSum = 0;
        foreach(PipePatternHandler pipePattern in pipeList)
        {
            for (int x = 0; x < 3; x++)
            {
                PipePatternHandler newPipePattern = Instantiate(pipePattern,transform);
                newPipePattern.GetComponent<PipePatternHandler>().pipePooler = this;
                newPipePattern.GetComponent<PipePatternHandler>().bird = bird;
                newPipePattern.gameObject.SetActive(false);
                pipePatternArray[patternSum] = newPipePattern;
                patternSum++;
            }
        }
        CallNextPattern();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CallNextPattern()
    {
        PipePatternHandler pipePattern = RandomPattern();
        pipePattern.GetComponent<PipePatternHandler>().bird = bird;
        pipePattern.GetComponent<PipePatternHandler>().pipePooler = this;
        pipePattern.transform.position = new Vector3(bird.transform.position.x + 10, 0, 0);
        pipePattern.call = false;
        pipePattern.gameObject.SetActive(true);
    }

    private PipePatternHandler RandomPattern()
    {
        while (true)
        {
            int rand = Random.Range(0, patternSum-1);
            if (!pipePatternArray[rand].gameObject.activeInHierarchy)
            {
                return pipePatternArray[rand];
            }
        }
    }
}
