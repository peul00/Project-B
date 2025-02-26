using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemMix : MonoBehaviour
{
    public GameObject Firstgauge;
    public GameObject G1;
    public GameObject G2;
    public GameObject G3;
    public GameObject G4;
    public GameObject G5;
    public GameObject G6;
    public GameObject G7;
    public GameObject G8;
    public GameObject liqueurPoint;
    public GameObject IcePoint;
    public GameObject OrangePoint;
    public GameObject ice;
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
    public bool Orange = false;
    public bool Strewbarry = false;
    public bool Kiwi = false;
    public bool Apple = false;
    public bool Grape = false;
    public bool Liem = false;
    public bool Cocoliqueur = false;
    public bool Cranliqueur = false;
    public bool Melonliqueur = false;
    public bool Orangeliqueur = false;
    public bool Honey = false;
    public bool Salt = false;
    public bool Sugar = false;
    public static int Plus;
    public static int AlcoPlus;
    public static int Plus1;
    bool fruitBoobs = false;
    bool thePool = false;
    bool black = false;
    bool sapphire = false;
    bool ruby = false;
    bool cantabile = false;
    bool deepKatt = false;
    bool alcohoRaid = false;
    bool noDog = false;
    bool freya = false;
    bool scorchingSun = false;
    bool heatWave = false;
    bool emeraldBeach = false;
    bool lost = false;
    bool harmony = false;
    bool herbBuble = false;
    public GameObject Tuto;
    private AudioSource audioSource;
    public AudioClip Sound;
    public AudioClip WaterSound;

    public void Start()
    {
        this.audioSource = this.gameObject.AddComponent<AudioSource>();
        this.audioSource.loop = false;
    }
    public void Tutorial(bool isOn)
    {
        if (isOn)
        {
            Tuto.gameObject.SetActive(true);
        }
        else
        {
            Tuto.gameObject.SetActive(false);
        }
    }

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

    public void orange(bool isOn)
    {
        if (isOn)
        {
            Orange = true;
            Debug.Log("Orange true");
            OrangePoint.gameObject.SetActive(true);
            GameManager.instance.Money -= OrangePrice;
        }
        else
        {
            Orange = false;
            Debug.Log("Orange false");
            OrangePoint.gameObject.SetActive(false);
        }
    }

    public void strewbarry(bool isOn)
    {
        if (isOn)
        {
            Strewbarry = true;
            Debug.Log("Strewbarry true");
            OrangePoint.gameObject.SetActive(true);
            GameManager.instance.Money -= OrangePrice;
        }
        else
        {
            Strewbarry = false;
            Debug.Log("Strewbarry false");
            OrangePoint.gameObject.SetActive(false);
        }
    }

    public void kiwi(bool isOn)
    {
        if (isOn)
        {
            Kiwi = true;
            Debug.Log("Kiwi true");
            OrangePoint.gameObject.SetActive(true);
            GameManager.instance.Money -= OrangePrice;
        }
        else
        {
            Kiwi = false;
            Debug.Log("Kiwi false");
            OrangePoint.gameObject.SetActive(false);
        }
    }

    public void apple(bool isOn)
    {
        if (isOn)
        {
            Apple = true;
            Debug.Log("Apple true");
            OrangePoint.gameObject.SetActive(true);
            GameManager.instance.Money -= OrangePrice;
        }
        else
        {
            Apple = false;
            Debug.Log("Apple false");
            OrangePoint.gameObject.SetActive(false);
        }
    }

    public void liem(bool isOn)
    {
        if (isOn)
        {
            Liem = true;
            Debug.Log("Liem true");
            OrangePoint.gameObject.SetActive(true);
            GameManager.instance.Money -= OrangePrice;
        }
        else
        {
            Liem = false;
            Debug.Log("Liem false");
            OrangePoint.gameObject.SetActive(false);
        }
    }

    public void grape(bool isOn)
    {
        if (isOn)
        {
            Grape = true;
            Debug.Log("Grape true");
            OrangePoint.gameObject.SetActive(true);
            GameManager.instance.Money -= OrangePrice;
        }
        else
        {
            Grape = false;
            Debug.Log("Grape false");
            OrangePoint.gameObject.SetActive(false);
        }
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
        else if(collision.gameObject.tag == "fruitBoobs")
        {
            fruitBoobs = true;
            this.audioSource.clip = this.WaterSound;
            this.audioSource.Play();
        }
        else if (collision.gameObject.tag == "thePool")
        {
            thePool = true;
            this.audioSource.clip = this.WaterSound;
            this.audioSource.Play();
        }
        else if (collision.gameObject.tag == "black")
        {
            black = true;
            this.audioSource.clip = this.WaterSound;
            this.audioSource.Play();
        }
        else if (collision.gameObject.tag == "sapphire")
        {
            sapphire = true;
            this.audioSource.clip = this.WaterSound;
            this.audioSource.Play();
        }
        else if (collision.gameObject.tag == "ruby")
        {
            ruby = true;
            this.audioSource.clip = this.WaterSound;
            this.audioSource.Play();
        }
        else if (collision.gameObject.tag == "cantabile")
        {
            cantabile = true;
            this.audioSource.clip = this.WaterSound;
            this.audioSource.Play();
        }
        else if (collision.gameObject.tag == "deepKatt")
        {
            deepKatt = true;
            this.audioSource.clip = this.WaterSound;
            this.audioSource.Play();
        }
        else if (collision.gameObject.tag == "alcohoRaid")
        {
            alcohoRaid = true;
            this.audioSource.clip = this.WaterSound;
            this.audioSource.Play();
        }
        else if (collision.gameObject.tag == "noDog")
        {
            noDog = true;
            this.audioSource.clip = this.WaterSound;
            this.audioSource.Play();
        }
        else if (collision.gameObject.tag == "freya")
        {
            freya = true;
            this.audioSource.clip = this.WaterSound;
            this.audioSource.Play();
        }
        else if (collision.gameObject.tag == "scorchingSun")
        {
            scorchingSun = true;
            this.audioSource.clip = this.WaterSound;
            this.audioSource.Play();
        }
        else if (collision.gameObject.tag == "heatWave")
        {
            heatWave = true;
            this.audioSource.clip = this.WaterSound;
            this.audioSource.Play();
        }
        else if (collision.gameObject.tag == "emeraldBeach")
        {
            emeraldBeach = true;
            this.audioSource.clip = this.WaterSound;
            this.audioSource.Play();
        }
        else if (collision.gameObject.tag == "lost")
        {
            lost = true;
            this.audioSource.clip = this.WaterSound;
            this.audioSource.Play();
        }
        else if (collision.gameObject.tag == "harmony")
        {
            harmony = true;
            this.audioSource.clip = this.WaterSound;
            this.audioSource.Play();
        }
        else if (collision.gameObject.tag == "herbBuble")
        {
            herbBuble = true;
            this.audioSource.clip = this.WaterSound;
            this.audioSource.Play();
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
                if(Plus != 10)
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
                this.audioSource.clip = this.WaterSound;
                this.audioSource.Play();
            }
        }

        if (collision.gameObject.tag == "CherryJuice")
        {
            if (Input.GetMouseButton(0) == false)
            {
                if (Plus != 10)
                    CherryJuice += 1;
                Debug.Log("CherryJuice " + CherryJuice);
                this.audioSource.clip = this.WaterSound;
                this.audioSource.Play();
            }
        }

        if (collision.gameObject.tag == "LiemJuice")
        {
            if (Input.GetMouseButton(0) == false)
            {
                if (Plus != 10)
                    LiemJuice += 1;
                Debug.Log("LiemJuice: " + LiemJuice);
                this.audioSource.clip = this.WaterSound;
                this.audioSource.Play();
            }
        }

        if (collision.gameObject.tag == "CoCoJuice")
        {
            if (Input.GetMouseButton(0) == false)
            {
                if (Plus != 10)
                    CoCoJuice += 1;
                Debug.Log("CoCoJuice: " + CoCoJuice);
                this.audioSource.clip = this.WaterSound;
                this.audioSource.Play();
            }
        }

        if (collision.gameObject.tag == "ChocoJuice")
        {
            if (Input.GetMouseButton(0) == false)
            {
                if (Plus != 10)
                    ChocoJuice += 1;
                Debug.Log("ChocoJuice: " + ChocoJuice);
                this.audioSource.clip = this.WaterSound;
                this.audioSource.Play();
            }
        }

        if (collision.gameObject.tag == "TomatoJuice")
        {
            if (Input.GetMouseButton(0) == false)
            {
                if (Plus != 10)
                    TomatoJuice += 1;
                Debug.Log("TomatoJuice: " + TomatoJuice);
                this.audioSource.clip = this.WaterSound;
                this.audioSource.Play();
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

        if (collision.gameObject.tag == "Salt")
        {
            if (Input.GetMouseButton(0) == false)
            {
                Salt = true;
                liqueurPoint.gameObject.SetActive(true);
                Debug.Log("Salt: true");
            }
        }

        if (collision.gameObject.tag == "Sugar")
        {
            if (Input.GetMouseButton(0) == false)
            {
                Sugar = true;
                liqueurPoint.gameObject.SetActive(true);
                Debug.Log("Sugar: true");
            }
        }

        if (collision.gameObject.tag == "Stirring")
        {
            if (Alcohol == 0 && Spicy == 0 && Sweet == 3 && Bitter == 1 && Sour == 2 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 1 && TomatoJuice == 0 && Salt == false && Sugar == false && cool == false)
            {
                if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(Witch, location1.position, location1.rotation);
                    Rerecipt();
                    Firstgauge.GetComponent<Gauage>().ReSet();
                    G1.GetComponent<Gauage>().ReSet();
                    G2.GetComponent<Gauage>().ReSet();
                    G3.GetComponent<Gauage>().ReSet();
                    G4.GetComponent<Gauage>().ReSet();
                    G5.GetComponent<Gauage>().ReSet();
                    G6.GetComponent<Gauage>().ReSet();
                    G7.GetComponent<Gauage>().ReSet();
                    G8.GetComponent<Gauage>().ReSet();

                }
                else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
                {
                    if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                    {
                        Instantiate(Witch, location2.position, location2.rotation);
                        Rerecipt();
                        Firstgauge.GetComponent<Gauage>().ReSet();
                        G1.GetComponent<Gauage>().ReSet();
                        G2.GetComponent<Gauage>().ReSet();
                        G3.GetComponent<Gauage>().ReSet();
                        G4.GetComponent<Gauage>().ReSet();
                        G5.GetComponent<Gauage>().ReSet();
                        G6.GetComponent<Gauage>().ReSet();
                        G7.GetComponent<Gauage>().ReSet();
                        G8.GetComponent<Gauage>().ReSet();
                    }
                    else
                        Debug.Log("no");
                }
            }
            else if (Alcohol == 1 && Spicy == 0 && Sweet == 3 && Bitter == 2 && Sour == 0 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar && cool == false && Honey)
            {
                if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(Imoogi, location1.position, location1.rotation);
                    Rerecipt();
                    Firstgauge.GetComponent<Gauage>().ReSet();
                    G1.GetComponent<Gauage>().ReSet();
                    G2.GetComponent<Gauage>().ReSet();
                    G3.GetComponent<Gauage>().ReSet();
                    G4.GetComponent<Gauage>().ReSet();
                    G5.GetComponent<Gauage>().ReSet();
                    G6.GetComponent<Gauage>().ReSet();
                    G7.GetComponent<Gauage>().ReSet();
                    G8.GetComponent<Gauage>().ReSet();

                }
                else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
                {
                    if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                    {
                        Instantiate(Imoogi, location2.position, location2.rotation);
                        Rerecipt();
                        Firstgauge.GetComponent<Gauage>().ReSet();
                        G1.GetComponent<Gauage>().ReSet();
                        G2.GetComponent<Gauage>().ReSet();
                        G3.GetComponent<Gauage>().ReSet();
                        G4.GetComponent<Gauage>().ReSet();
                        G5.GetComponent<Gauage>().ReSet();
                        G6.GetComponent<Gauage>().ReSet();
                        G7.GetComponent<Gauage>().ReSet();
                        G8.GetComponent<Gauage>().ReSet();
                    }
                    else
                        Debug.Log("no");
                }
            }
            else if (Alcohol == 1 && Spicy == 1 && Sweet == 0 && Bitter == 1 && Sour == 1 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar == false && cool == false)
            {
                if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(Peace, location1.position, location1.rotation);
                    Rerecipt();
                    Firstgauge.GetComponent<Gauage>().ReSet();
                    G1.GetComponent<Gauage>().ReSet();
                    G2.GetComponent<Gauage>().ReSet();
                    G3.GetComponent<Gauage>().ReSet();
                    G4.GetComponent<Gauage>().ReSet();
                    G5.GetComponent<Gauage>().ReSet();
                    G6.GetComponent<Gauage>().ReSet();
                    G7.GetComponent<Gauage>().ReSet();
                    G8.GetComponent<Gauage>().ReSet();

                }
                else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
                {
                    if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                    {
                        Instantiate(Peace, location2.position, location2.rotation);
                        Rerecipt();
                        Firstgauge.GetComponent<Gauage>().ReSet();
                        G1.GetComponent<Gauage>().ReSet();
                        G2.GetComponent<Gauage>().ReSet();
                        G3.GetComponent<Gauage>().ReSet();
                        G4.GetComponent<Gauage>().ReSet();
                        G5.GetComponent<Gauage>().ReSet();
                        G6.GetComponent<Gauage>().ReSet();
                        G7.GetComponent<Gauage>().ReSet();
                        G8.GetComponent<Gauage>().ReSet();
                    }
                    else
                        Debug.Log("no");
                }
            }
            else if (Alcohol == 2 && Spicy == 0 && Sweet == 1 && Bitter == 0 && Sour == 1 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 1 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar == false && cool == false)
            {
                if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(Killer, location1.position, location1.rotation);
                    Rerecipt();
                    Firstgauge.GetComponent<Gauage>().ReSet();
                    G1.GetComponent<Gauage>().ReSet();
                    G2.GetComponent<Gauage>().ReSet();
                    G3.GetComponent<Gauage>().ReSet();
                    G4.GetComponent<Gauage>().ReSet();
                    G5.GetComponent<Gauage>().ReSet();
                    G6.GetComponent<Gauage>().ReSet();
                    G7.GetComponent<Gauage>().ReSet();
                    G8.GetComponent<Gauage>().ReSet();

                }
                else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
                {
                    if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                    {
                        Instantiate(Killer, location2.position, location2.rotation);
                        Rerecipt();
                        Firstgauge.GetComponent<Gauage>().ReSet();
                        G1.GetComponent<Gauage>().ReSet();
                        G2.GetComponent<Gauage>().ReSet();
                        G3.GetComponent<Gauage>().ReSet();
                        G4.GetComponent<Gauage>().ReSet();
                        G5.GetComponent<Gauage>().ReSet();
                        G6.GetComponent<Gauage>().ReSet();
                        G7.GetComponent<Gauage>().ReSet();
                        G8.GetComponent<Gauage>().ReSet();
                    }
                    else
                        Debug.Log("no");
                }
            }
            else if (Alcohol == 4 && Spicy == 0 && Sweet == 3 && Bitter == 0 && Sour == 0 && 1 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar == false && cool == false)
            {
                if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(RuMilk, location1.position, location1.rotation);
                    Rerecipt();
                    Firstgauge.GetComponent<Gauage>().ReSet();
                    G1.GetComponent<Gauage>().ReSet();
                    G2.GetComponent<Gauage>().ReSet();
                    G3.GetComponent<Gauage>().ReSet();
                    G4.GetComponent<Gauage>().ReSet();
                    G5.GetComponent<Gauage>().ReSet();
                    G6.GetComponent<Gauage>().ReSet();
                    G7.GetComponent<Gauage>().ReSet();
                    G8.GetComponent<Gauage>().ReSet();

                }
                else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
                {
                    if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                    {
                        Instantiate(RuMilk, location2.position, location2.rotation);
                        Rerecipt();
                        Firstgauge.GetComponent<Gauage>().ReSet();
                        G1.GetComponent<Gauage>().ReSet();
                        G2.GetComponent<Gauage>().ReSet();
                        G3.GetComponent<Gauage>().ReSet();
                        G4.GetComponent<Gauage>().ReSet();
                        G5.GetComponent<Gauage>().ReSet();
                        G6.GetComponent<Gauage>().ReSet();
                        G7.GetComponent<Gauage>().ReSet();
                        G8.GetComponent<Gauage>().ReSet();
                    }
                    else
                        Debug.Log("no");
                }
            }
            else if (Alcohol == 0 && Spicy == 0 && Sweet == 2 && Bitter == 0 && Sour == 0 && 0 == Soda && CherryJuice == 0 && LiemJuice == 1 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar && cool == false && Honey)
            {
                if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(RoyalJelly, location1.position, location1.rotation);
                    Rerecipt();
                    Firstgauge.GetComponent<Gauage>().ReSet();
                    G1.GetComponent<Gauage>().ReSet();
                    G2.GetComponent<Gauage>().ReSet();
                    G3.GetComponent<Gauage>().ReSet();
                    G4.GetComponent<Gauage>().ReSet();
                    G5.GetComponent<Gauage>().ReSet();
                    G6.GetComponent<Gauage>().ReSet();
                    G7.GetComponent<Gauage>().ReSet();
                    G8.GetComponent<Gauage>().ReSet();

                }
                else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
                {
                    if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                    {
                        Instantiate(RoyalJelly, location2.position, location2.rotation);
                        Rerecipt();
                        Firstgauge.GetComponent<Gauage>().ReSet();
                        G1.GetComponent<Gauage>().ReSet();
                        G2.GetComponent<Gauage>().ReSet();
                        G3.GetComponent<Gauage>().ReSet();
                        G4.GetComponent<Gauage>().ReSet();
                        G5.GetComponent<Gauage>().ReSet();
                        G6.GetComponent<Gauage>().ReSet();
                        G7.GetComponent<Gauage>().ReSet();
                        G8.GetComponent<Gauage>().ReSet();
                    }
                    else
                        Debug.Log("no");
                }
            }
            else if (Alcohol == 1 && Spicy == 0 && Sweet == 2 && Bitter == 0 && Sour == 4 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar && cool == false && Orangeliqueur)
            {
                if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(RoyalOrange, location1.position, location1.rotation);
                    Rerecipt();
                    Firstgauge.GetComponent<Gauage>().ReSet();
                    G1.GetComponent<Gauage>().ReSet();
                    G2.GetComponent<Gauage>().ReSet();
                    G3.GetComponent<Gauage>().ReSet();
                    G4.GetComponent<Gauage>().ReSet();
                    G5.GetComponent<Gauage>().ReSet();
                    G6.GetComponent<Gauage>().ReSet();
                    G7.GetComponent<Gauage>().ReSet();
                    G8.GetComponent<Gauage>().ReSet();

                }
                else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
                {
                    if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                    {
                        Instantiate(RoyalOrange, location2.position, location2.rotation);
                        Rerecipt();
                        Firstgauge.GetComponent<Gauage>().ReSet();
                        G1.GetComponent<Gauage>().ReSet();
                        G2.GetComponent<Gauage>().ReSet();
                        G3.GetComponent<Gauage>().ReSet();
                        G4.GetComponent<Gauage>().ReSet();
                        G5.GetComponent<Gauage>().ReSet();
                        G6.GetComponent<Gauage>().ReSet();
                        G7.GetComponent<Gauage>().ReSet();
                        G8.GetComponent<Gauage>().ReSet();
                    }
                    else
                        Debug.Log("no");
                }
            }
            else if (Alcohol == 0 && Spicy == 1 && Sweet == 0 && Bitter == 0 && Sour == 4 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar == false && cool == false && Cocoliqueur)
            {
                if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(KiKi, location1.position, location1.rotation);
                    Rerecipt();
                    Firstgauge.GetComponent<Gauage>().ReSet();
                    G1.GetComponent<Gauage>().ReSet();
                    G2.GetComponent<Gauage>().ReSet();
                    G3.GetComponent<Gauage>().ReSet();
                    G4.GetComponent<Gauage>().ReSet();
                    G5.GetComponent<Gauage>().ReSet();
                    G6.GetComponent<Gauage>().ReSet();
                    G7.GetComponent<Gauage>().ReSet();
                    G8.GetComponent<Gauage>().ReSet();

                }
                else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
                {
                    if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                    {
                        Instantiate(KiKi, location2.position, location2.rotation);
                        Rerecipt();
                        Firstgauge.GetComponent<Gauage>().ReSet();
                        G1.GetComponent<Gauage>().ReSet();
                        G2.GetComponent<Gauage>().ReSet();
                        G3.GetComponent<Gauage>().ReSet();
                        G4.GetComponent<Gauage>().ReSet();
                        G5.GetComponent<Gauage>().ReSet();
                        G6.GetComponent<Gauage>().ReSet();
                        G7.GetComponent<Gauage>().ReSet();
                        G8.GetComponent<Gauage>().ReSet();
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
                    Rerecipt();
                    Firstgauge.GetComponent<Gauage>().ReSet();
                    G1.GetComponent<Gauage>().ReSet();
                    G2.GetComponent<Gauage>().ReSet();
                    G3.GetComponent<Gauage>().ReSet();
                    G4.GetComponent<Gauage>().ReSet();
                    G5.GetComponent<Gauage>().ReSet();
                    G6.GetComponent<Gauage>().ReSet();
                    G7.GetComponent<Gauage>().ReSet();
                    G8.GetComponent<Gauage>().ReSet();

                }
                else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
                {
                    if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                    {
                        Instantiate(fail, location2.position, location2.rotation);
                        Rerecipt();
                        Firstgauge.GetComponent<Gauage>().ReSet();
                        G1.GetComponent<Gauage>().ReSet();
                        G2.GetComponent<Gauage>().ReSet();
                        G3.GetComponent<Gauage>().ReSet();
                        G4.GetComponent<Gauage>().ReSet();
                        G5.GetComponent<Gauage>().ReSet();
                        G6.GetComponent<Gauage>().ReSet();
                        G7.GetComponent<Gauage>().ReSet();
                        G8.GetComponent<Gauage>().ReSet();
                    }
                    else
                        Debug.Log("no");
                }
            }
        }

        if (0 < Alcohol || 0 < Sweet || 0 < Spicy || 0 < Bitter || 0 < Sour || 0 < Soda || 0 < CherryJuice || 0 < LiemJuice || 0 < CoCoJuice || 0 < ChocoJuice || 0 < TomatoJuice || 0 < Plus1)
        {
            Plus = Alcohol + Spicy + Sweet + Bitter + Sour + Soda + CherryJuice + LiemJuice + CoCoJuice + ChocoJuice + TomatoJuice + Plus1;
            AlcoPlus = Alcohol + Spicy + Sweet + Bitter + Sour + Plus1;
            Debug.Log("Total: " + Plus);
            Firstgauge.gameObject.SetActive(true);
        }
    }

    [SerializeField] GameObject Seogyang;
    [SerializeField] GameObject RoyalMorning;
    [SerializeField] GameObject KattCock;
    [SerializeField] GameObject AurumCock;
    [SerializeField] GameObject RoyalCock;
    [SerializeField] GameObject AirenCock;
    [SerializeField] GameObject BrgikyCock;
    [SerializeField] GameObject K2C;
    [SerializeField] GameObject Souren;
    [SerializeField] GameObject BrgikyFloat;
    [SerializeField] GameObject BeeRoyal;
    [SerializeField] GameObject FruitBoobs;
    [SerializeField] GameObject ThePool;
    [SerializeField] GameObject Black;
    [SerializeField] GameObject Sapphire;
    [SerializeField] GameObject Ruby;
    [SerializeField] GameObject Cantabile;
    [SerializeField] GameObject DeepKatt;
    [SerializeField] GameObject AlcohoRaid;
    [SerializeField] GameObject NoDog;
    [SerializeField] GameObject Freya;
    [SerializeField] GameObject ScorchingSun;
    [SerializeField] GameObject HeatWave;
    [SerializeField] GameObject EmeraldBeach;
    [SerializeField] GameObject Lost;
    [SerializeField] GameObject Harmony;
    [SerializeField] GameObject HerbBuble;
    [SerializeField] GameObject Witch;
    [SerializeField] GameObject Imoogi;
    [SerializeField] GameObject Peace;
    [SerializeField] GameObject Killer;
    [SerializeField] GameObject RuMilk;
    [SerializeField] GameObject RoyalJelly;
    [SerializeField] GameObject RoyalOrange;
    [SerializeField] GameObject KiKi;
    [SerializeField] GameObject fail;
    public Transform location1;
    public Transform location2;
    // ���̷� = �ܸ� �ƿ�� = ����
    public void Makingcocktail()
    {
        this.audioSource.clip = this.Sound;
        this.audioSource.Play();
        if (Alcohol == 0 && Spicy == 0 && Sweet == 3 && Bitter == 1 && Sour == 0 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 1 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar == false && cool == false && Cranliqueur)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(Seogyang, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(Seogyang, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 0 && Spicy == 2 && Sweet == 0 && Bitter == 0 && Sour == 1 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 3 && Salt && Sugar == false && cool == false)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(RoyalMorning, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(RoyalMorning, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 2 && Spicy == 0 && Sweet == 0 && Bitter == 0 && Sour == 0 && 4 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar == false && cool)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(KattCock, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(KattCock, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 0 && Spicy == 0 && Sweet == 0 && Bitter == 2 && Sour == 0 && 4 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar == false && cool)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(AurumCock, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(AurumCock, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 0 && Spicy == 0 && Sweet == 0 && Bitter == 0 && Sour == 2 && 4 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar == false && cool)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(RoyalCock, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(RoyalCock, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 0 && Spicy == 0 && Sweet == 2 && Bitter == 0 && Sour == 0 && 4 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar == false && cool)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(AirenCock, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(AirenCock, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 0 && Spicy == 2 && Sweet == 0 && Bitter == 0 && Sour == 0 && 4 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar == false && cool)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(BrgikyCock, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(BrgikyCock, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 0 && Spicy == 4 && Sweet == 0 && Bitter == 0 && Sour == 5 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar == false && cool == false)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(K2C, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(K2C, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 0 && Spicy == 0 && Sweet == 2 && Bitter == 0 && Sour == 4 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar == false && cool && Orangeliqueur)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(Souren, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(Souren, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 1 && Spicy == 3 && Sweet == 0 && Bitter == 0 && Sour == 0 && 1 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar && cool)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(BrgikyFloat, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(BrgikyFloat, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 0 && Spicy == 2 && Sweet == 0 && Bitter == 1 && Sour == 2 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar && cool)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(BeeRoyal, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(BeeRoyal, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (fruitBoobs == true && Alcohol == 0 && Spicy == 0 && Sweet == 0 && Bitter == 0 && Sour == 0 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar == false && cool == false)
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
        else if (thePool == true && Alcohol == 0 && Spicy == 0 && Sweet == 0 && Bitter == 0 && Sour == 0 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt && Sugar == false && cool == false)
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
        else if (black == true && Alcohol == 0 && Spicy == 0 && Sweet == 0 && Bitter == 0 && Sour == 0 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt && Sugar == false && cool == false)
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
        else if (sapphire == true && Alcohol == 0 && Spicy == 0 && Sweet == 0 && Bitter == 0 && Sour == 0 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar == false && cool == false)
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
        else if (ruby == true && Alcohol == 0 && Spicy == 0 && Sweet == 0 && Bitter == 0 && Sour == 0 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar == false && cool == false)
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
        else if (cantabile == true && Alcohol == 0 && Spicy == 0 && Sweet == 0 && Bitter == 0 && Sour == 0 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar == false && cool == false)
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
        else if (deepKatt == true && Alcohol == 0 && Spicy == 0 && Sweet == 0 && Bitter == 0 && Sour == 0 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar == false && cool == false)
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
        else if (alcohoRaid == true && Alcohol == 0 && Spicy == 0 && Sweet == 0 && Bitter == 0 && Sour == 0 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt && Sugar == false && cool == false)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(AlcohoRaid, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(AlcohoRaid, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (noDog == true && Alcohol == 0 && Spicy == 0 && Sweet == 0 && Bitter == 0 && Sour == 0 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar && cool == false)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(NoDog, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(NoDog, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (freya == true && Alcohol == 0 && Spicy == 0 && Sweet == 0 && Bitter == 0 && Sour == 0 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar && cool == false)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(Freya, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(Freya, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (scorchingSun == true && Alcohol == 0 && Spicy == 0 && Sweet == 0 && Bitter == 0 && Sour == 0 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt && Sugar == false && cool == false)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(ScorchingSun, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(ScorchingSun, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (heatWave == true && Alcohol == 0 && Spicy == 0 && Sweet == 0 && Bitter == 0 && Sour == 0 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt && Sugar == false && cool == false)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(HeatWave, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(HeatWave, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (emeraldBeach == true && Alcohol == 0 && Spicy == 0 && Sweet == 0 && Bitter == 0 && Sour == 0 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar == false && cool == false)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(EmeraldBeach, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(EmeraldBeach, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (lost == true && Alcohol == 0 && Spicy == 0 && Sweet == 0 && Bitter == 0 && Sour == 0 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar == false && cool == false)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(Lost, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(Lost, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (harmony == true && Alcohol == 0 && Spicy == 0 && Sweet == 0 && Bitter == 0 && Sour == 0 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar == false && cool == false)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(Harmony, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(Harmony, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (herbBuble == true && Alcohol == 0 && Spicy == 0 && Sweet == 0 && Bitter == 0 && Sour == 0 && 0 == Soda && CherryJuice == 0 && LiemJuice == 0 && CoCoJuice == 0 && ChocoJuice == 0 && TomatoJuice == 0 && Salt == false && Sugar == false && cool == false)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(HerbBuble, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(HerbBuble, location2.position, location2.rotation);
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
        Orange = false;
        Strewbarry = false;
        Kiwi = false;
        Apple = false;
        Grape = false;
        Liem = false;
        Salt = false;
        Sugar = false;
        fruitBoobs = false;
        thePool = false;
        black = false;
        sapphire = false;
        ruby = false;
        cantabile = false;
        deepKatt = false;
        alcohoRaid = false;
        noDog = false;
        freya = false;
        scorchingSun = false;
        heatWave = false;
        emeraldBeach = false;
        lost = false;
        harmony = false;
        herbBuble = false;
    }
}