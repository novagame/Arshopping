using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerFurnitures : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Homepage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sofa()
    {
        SceneManager.LoadScene("Sofa");

    }
    public void chair()
    {
        SceneManager.LoadScene("Chair");
    }
    public void table()
    {
        SceneManager.LoadScene("Table");
    }
    public void TableDetails()
    {
        SceneManager.LoadScene("TableDetail");
    }
    public void SofaDetails()
    {
        SceneManager.LoadScene("SofaDetail");
    }
    public void ChairDetails()
    {
        SceneManager.LoadScene("ChairDetail");
    }
    public void Homepage()
    {
        SceneManager.LoadScene("Furnitures");
    }
    public void ordersPage()
    {
        SceneManager.LoadScene("OrdersPage");
    }
    public void cart()
    {
        SceneManager.LoadScene("Cart");
    }
}
