using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    // Start is called before the first frame update
    public static ItemDatabase instance;

    public int Money = 0;
    private void Awake()
    {
        instance = this;
        
    }

    
    public List<Item> itemDB = new List<Item>();

    public GameObject fieldItemPrefab;
    public Vector3[] pos;
    public void Start()
    {
        Money = 10000;
        
    }

}