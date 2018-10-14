using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCostume : MonoBehaviour
{
    public GameObject TShirt, Coat, Helmet, Plant, Shoes, IDCard ;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "TShirt")
        {
            GameLogic.score += 10;
            TShirt.SetActive(true);
            other.transform.parent.gameObject.SetActive(false);
            Debug.Log("hitTrue");
        }
        if (other.gameObject.tag == "Coat")
        {
            GameLogic.score += 10;
            Coat.SetActive(true);
            other.transform.parent.gameObject.SetActive(false);
            Debug.Log("hitTrue");
        }
        if (other.gameObject.tag == "Helmet")
        {
            GameLogic.score += 10;
            Helmet.SetActive(true);
            other.transform.parent.gameObject.SetActive(false);
            Debug.Log("hitTrue");
        }
        if (other.gameObject.tag == "Plant")
        {
            GameLogic.score += 10;
            Plant.SetActive(true);
            other.transform.parent.gameObject.SetActive(false);
            Debug.Log("hitTrue");
        }
        if (other.gameObject.tag == "Shoes")
        {
            GameLogic.score += 10;
            Shoes.SetActive(true);
            other.transform.parent.gameObject.SetActive(false);
            Debug.Log("hitTrue");
        }
        if (other.gameObject.tag == "IDCard")
        {
            GameLogic.score += 10;
            IDCard.SetActive(true);
            other.transform.parent.gameObject.SetActive(false);
            Debug.Log("hitTrue");
        }
        if (other.gameObject.tag == "Bag")
        {
            GameLogic.score += 10;
            other.transform.parent.gameObject.SetActive(false);
            Debug.Log("hitTrue");
        }
        if (other.gameObject.tag == "Paper")
        {
            GameLogic.score += 10;
            other.transform.parent.gameObject.SetActive(false);
            Debug.Log("hitTrue");
        }
        if (other.gameObject.tag == "signaturetool")
        {
            GameLogic.score += 10;
            Coat.SetActive(true);
            other.transform.parent.gameObject.SetActive(false);
            Debug.Log("hitTrue");
        }

        if (other.gameObject.tag == "GAME1FALSE")
        {
            GameLogic.time -= 5;
            other.transform.parent.gameObject.SetActive(false);
            Debug.Log("HitFalse");
        }
    }
}
