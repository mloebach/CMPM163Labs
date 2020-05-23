using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildCity : MonoBehaviour
{
    public GameObject[] buildings;
    public int mapWidth = 1;
    public int mapHeight = 1;
    public float step = 1.0f;
    public int buildingFootprint = 5;

    public float xOffset = 0.0f;
    public float zOffset = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        int seed = Random.Range(0,200);
        float differentBuildings = buildings.Length;
        //float step = buildingCount/differentBuildings;
        for(int h= 0; h < mapHeight; h++){
            for(int w = 0; w < mapWidth; w++){
                //building is generated
                Vector3 pos = new Vector3(w*buildingFootprint+xOffset,0 ,h*buildingFootprint+zOffset);
                
                //random number is generated betwen zero and building count
                float result = (Mathf.PerlinNoise((w/differentBuildings)+seed,(h/differentBuildings)+seed) *differentBuildings);
                for(int i = 0; i < differentBuildings; i++){
                    if(result < ((i+1)*step)){
                        Instantiate(buildings[i],pos,Quaternion.identity);
                        break;
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
