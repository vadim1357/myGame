using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGeneration : MonoBehaviour
{
    public float XSize = 13.8f;
    public float ZSize = 8.8f;
    public GameObject foodPrefab;

    public GameObject curFood;
    public Vector3 curPos;

    void Start()
    {

    }
    void AddNewFood()
    {
        RandomPos();
        // зачем as?
        curFood = GameObject.Instantiate(foodPrefab, curPos, Quaternion.identity) as GameObject;
    }
    void RandomPos()
    {
        curPos = new Vector3(Random.Range(XSize*-1,XSize), 0.5f, Random.Range(ZSize * -1, ZSize));
    }
    
    void Update()
    {
        if (!curFood)
        {
            AddNewFood();
        }
        else
        {
            return;
        }
    }
}
