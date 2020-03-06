using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilePooler : MonoBehaviour
{
    public GameObject tile;
    public GameObject[] tilePooler;
    public GameObject bird;
    public int sampleSize;
    private float positionX,positionY;
    // Start is called before the first frame update
    void Start()
    {
        positionX = -7;
        positionY = -11.35f;
        for(int x = 0; x < sampleSize;x++)
        {
            GameObject thisTile = Instantiate(tile,new Vector3(positionX,positionY,0),Quaternion.identity,transform);
            thisTile.GetComponent<TileHandler>().tilePooler = this;
            thisTile.GetComponent<TileHandler>().bird = bird;
            positionX += 1.9f;
        }
    }

    public void GivePosition(GameObject tile)
    {
        tile.transform.position = new Vector3(positionX, positionY, 0);
        positionX += 1.9f;
    }
}
