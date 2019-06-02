using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public GameObject block;
    public Sprite[] candyList;
    public int n = 5;
    public int m = 5;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                int k = Random.Range(0, candyList.Length);
                Sprite candy = candyList[k];
                string candyName = candy.name;
                GameObject newCandy = Instantiate(block, new Vector2(i - n / 2, j - n / 2), Quaternion.identity);
                newCandy.name = candyName;
                newCandy.GetComponent<SpriteRenderer>().sprite = candy;
            }
        }
    }

    // Update is called once per frame
    void Update()
    { 
    }
}
