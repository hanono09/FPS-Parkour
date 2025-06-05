using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public MoneyManager moneyManager;
    public float cost;
    // Start is called before the first frame update

    private void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
    }


    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            //actualizar el dinero por compra
            moneyManager.UpdateMoney(-cost);    
            Destroy(gameObject);

        }
    }
}