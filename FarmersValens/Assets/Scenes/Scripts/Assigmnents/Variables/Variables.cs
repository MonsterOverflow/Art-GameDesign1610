using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    //Declaration
    public int cookieBox;
    public float waterBottle;
    private string firstName;
    public double rbi;
    public GameObject player; 
    
    // Start is called before the first frame update
    void Start()
    {
    public float amount;
    public float money;
    public float cost;

    // Start is called before the first frame update
    void Start()
    {
        Cookies(amount, money, cost);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Cookies(int amount, float money, float cost)
    {
        float total;

        total = amount + cost - money;

   
    
        Debug.Log(total);
    }

   

}

