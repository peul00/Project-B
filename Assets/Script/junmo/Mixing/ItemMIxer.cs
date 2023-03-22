using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemMIxer : MonoBehaviour
{
    public GameObject Firstgauge;
    public GameObject liqueurPoint;
    public GameObject IcePoint;
    public GameObject OrangePoint;
    public GameObject ice;
    public GameObject Panel;
    public int Alcohol;
    public int Spicy;
    public int Sweet;
    public int Bitter;
    public int Sour;
    public int Soda;
    public int CherryJuice;
    public int LiemJuice;
    public int CoCoJuice;
    public int ChocoJuice;
    public int TomatoJuice;
    public int OrangePrice;
    public int LiqueurPrice;
    public bool cool = false;
    public bool Cocoliqueur = false;
    public bool Cranliqueur = false;
    public bool Melonliqueur = false;
    public bool Orangeliqueur = false;
    public bool Honey = false;
    public static int Plus;
    public static int AlcoPlus;

    int buff = 0; //���� �߰�
    public void Update()
    {
        while (buff < AlcoPlus)
        {
            Drag.MaxRank += 1;
            Debug.Log("Buff + 1");
            buff++;
        }
    }
    public void cold()
    {
        Instantiate(ice);
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ice")
        {
            if (Input.GetMouseButton(0) == false)
            {
                cool = true;
                Debug.Log("Ice: IsTrue");
                IcePoint.gameObject.SetActive(true);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Alcohol")
        {
            if (Input.GetMouseButton(0) == false)
            {
                if (Plus != 10)
                    Alcohol += 1;
                Debug.Log("Alchohol: " + Alcohol);
            }
        }

        if (collision.gameObject.tag == "Spicy")
        {
            if (Input.GetMouseButton(0) == false)
            {
                if (Plus != 10)
                    Spicy += 1;
                Debug.Log("Spicy: " + Spicy);
            }
        }

        if (collision.gameObject.tag == "Sweet")
        {
            if (Input.GetMouseButton(0) == false)
            {
                if (Plus != 10)
                    Sweet += 1;
                Debug.Log("Sweet: " + Sweet);
            }
        }

        if (collision.gameObject.tag == "Bitter")
        {
            if (Input.GetMouseButton(0) == false)
            {
                if (Plus != 10)
                    Bitter += 1;
                Debug.Log("Bitter: " + Bitter);
            }
        }

        if (collision.gameObject.tag == "Sour")
        {
            if (Input.GetMouseButton(0) == false)
            {
                if (Plus != 10)
                    Sour += 1;
                Debug.Log("Sour: " + Sour);
            }
        }

        if (collision.gameObject.tag == "Soda")
        {
            if (Input.GetMouseButton(0) == false)
            {
                if (Plus != 10)
                    Soda += 1;
                Debug.Log("Soda: " + Soda);
            }
        }

        if (collision.gameObject.tag == "CherryJuice")
        {
            if (Input.GetMouseButton(0) == false)
            {
                if (Plus != 10)
                    CherryJuice += 1;
                Debug.Log("CherryJuice " + CherryJuice);
            }
        }

        if (collision.gameObject.tag == "LiemJuice")
        {
            if (Input.GetMouseButton(0) == false)
            {
                if (Plus != 10)
                    LiemJuice += 1;
                Debug.Log("LiemJuice: " + LiemJuice);
            }
        }

        if (collision.gameObject.tag == "CoCoJuice")
        {
            if (Input.GetMouseButton(0) == false)
            {
                if (Plus != 10)
                    CoCoJuice += 1;
                Debug.Log("CoCoJuice: " + CoCoJuice);
            }
        }

        if (collision.gameObject.tag == "ChocoJuice")
        {
            if (Input.GetMouseButton(0) == false)
            {
                if (Plus != 10)
                    ChocoJuice += 1;
                Debug.Log("ChocoJuice: " + ChocoJuice);
            }
        }

        if (collision.gameObject.tag == "TomatoJuice")
        {
            if (Input.GetMouseButton(0) == false)
            {
                if (Plus != 10)
                    TomatoJuice += 1;
                Debug.Log("TomatoJuice: " + TomatoJuice);
            }
        }

        if (collision.gameObject.tag == "Cocoliqueur")
        {
            if (Input.GetMouseButton(0) == false)
            {
                Cocoliqueur = true;
                liqueurPoint.gameObject.SetActive(true);
                GameManager.instance.Money -= LiqueurPrice;
                Debug.Log("Choco: true");
            }
        }

        if (collision.gameObject.tag == "Cranliqueur")
        {
            if (Input.GetMouseButton(0) == false)
            {
                Cranliqueur = true;
                liqueurPoint.gameObject.SetActive(true);
                GameManager.instance.Money -= LiqueurPrice;
                Debug.Log("Cran: true");
            }
        }

        if (collision.gameObject.tag == "Melonliqueur")
        {
            if (Input.GetMouseButton(0) == false)
            {
                Melonliqueur = true;
                liqueurPoint.gameObject.SetActive(true);
                GameManager.instance.Money -= LiqueurPrice;
                Debug.Log("Melon: true");
            }
        }

        if (collision.gameObject.tag == "Orangeliqueur")
        {
            if (Input.GetMouseButton(0) == false)
            {
                Orangeliqueur = true;
                liqueurPoint.gameObject.SetActive(true);
                GameManager.instance.Money -= LiqueurPrice;
                Debug.Log("Orange: true");
            }
        }

        if (collision.gameObject.tag == "Honey")
        {
            if (Input.GetMouseButton(0) == false)
            {
                Honey = true;
                liqueurPoint.gameObject.SetActive(true);
                GameManager.instance.Money -= LiqueurPrice;
                Debug.Log("Honey: true");
            }
        }

        if (0 < Alcohol || 0 < Sweet || 0 < Spicy || 0 < Bitter || 0 < Sour || 0 < Soda || 0 < CherryJuice || 0 < LiemJuice || 0 < CoCoJuice || 0 < ChocoJuice || 0 < TomatoJuice)
        {
            Plus = Alcohol + Spicy + Sweet + Bitter + Sour + Soda + CherryJuice + LiemJuice + CoCoJuice + ChocoJuice + TomatoJuice;
            AlcoPlus = Alcohol + Spicy + Sweet + Bitter + Sour;
            Debug.Log("Total: " + Plus);
            Firstgauge.gameObject.SetActive(true);
        }
    }

    [SerializeField] GameObject FruitBoobs;
    [SerializeField] GameObject ThePool;
    [SerializeField] GameObject Black;
    [SerializeField] GameObject Sapphire;
    [SerializeField] GameObject Ruby;
    [SerializeField] GameObject Cantabile;
    [SerializeField] GameObject DeepKatt;
    [SerializeField] GameObject fail;
    public Transform location1;
    public Transform location2;
    // ���̷� = �ܸ� �ƿ�� = ����
    public void Makingcocktail()
    {
        if (Alcohol == 0 && Spicy == 0 && Sweet == 3 && Bitter == 0 && Sour == 1 && 3 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && cool)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(FruitBoobs, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(FruitBoobs, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 0 && Spicy == 2 && Sweet == 1 && Bitter == 5 && Sour == 0 && 0 == Soda && CherryJuice == 0 && LiemJuice == 1 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && cool && Honey)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(ThePool, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(ThePool, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 2 && Spicy == 0 && Sweet == 0 && Bitter == 5 && Sour == 0 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && cool && Honey)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(Black, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(Black, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 3 && Spicy == 1 && Sweet == 0 && Bitter == 0 && Sour == 2 && 2 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && cool && Cranliqueur)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(Sapphire, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(Sapphire, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 3 && Spicy == 1 && Sweet == 2 && Bitter == 0 && Sour == 0 && 2 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && cool && Cranliqueur)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(Ruby, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(Ruby, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 0 && Spicy == 0 && Sweet == 2 && Bitter == 1 && Sour == 1 && 0 == Soda && CherryJuice == 1 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && cool)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(Cantabile, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(Cantabile, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 7 && Spicy == 0 && Sweet == 0 && Bitter == 0 && Sour == 0 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && cool)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(DeepKatt, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(DeepKatt, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(fail, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(fail, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
    }
    public void Rerecipt()
    {
        Firstgauge.gameObject.SetActive(false);
        liqueurPoint.gameObject.SetActive(false);
        IcePoint.gameObject.SetActive(false);
        OrangePoint.gameObject.SetActive(false);
        GameObject.Find("Orange").GetComponent<Toggle>().isOn = false;
        Drag.MaxRank = 0;
        Alcohol = 0;
        Spicy = 0;
        Sweet = 0;
        Bitter = 0;
        Sour = 0;
        Soda = 0;
        CherryJuice = 0;
        LiemJuice = 0;
        CoCoJuice = 0;
        ChocoJuice = 0;
        TomatoJuice = 0;
        Plus = 0;
        AlcoPlus = 0;
        buff = 0;
        Cocoliqueur = false;
        Cranliqueur = false;
        Melonliqueur = false;
        Orangeliqueur = false;
        Honey = false;
        cool = false;
        iTween.MoveTo(Panel, iTween.Hash("x", 12, "time", 2));
    }
}