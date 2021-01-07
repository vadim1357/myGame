using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SnakeMovment : MonoBehaviour
{
    public float Speed;
    public float z_offSet = 0.9f;
    public List<GameObject> tailObjects =  new List<GameObject>();

    public float RotationSpeed;

    public Text scoreText;
    public int score=0;

    public GameObject TailPrefab;
    void Start()
    {
        tailObjects.Add(gameObject);
    }

    
    void Update()
    {
        scoreText.text = "SCORE-"+score.ToString()+ "\nTime-"+Time.time;

        // почему в моей игре использовался Quaternion а не такой способ?
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * RotationSpeed * Time.deltaTime);
        }
    }


    // пояснение всего метода AddTail
    public void AddTail()
    {
        score++;
        Vector3 newTailPos = tailObjects[tailObjects.Count-1].transform.position;

        tailObjects.Add(GameObject.Instantiate(TailPrefab, newTailPos, Quaternion.identity) as GameObject);
    }
}
