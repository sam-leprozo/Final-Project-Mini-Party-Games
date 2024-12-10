using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Selector : MonoBehaviour
{
    public bool birb;
    public bool axol;
    public bool doge;
    public bool capy;
    public bool cyat;
    public bool freg;

    public bool gameStart;
    public bool isSelectorCheck;

    public List<GameObject> checkList;

    public GameObject character0;
    public GameObject character1;
    public GameObject character2;
    public GameObject character3;
    public GameObject character4;
    public GameObject character5;

    void Start()
    {
        if (!PlayerPrefs.HasKey("birb"))
        {
            birb = true;
        }

        if (gameStart == true)
        {
            if (birb == true)
            {
                character0.SetActive(true);

                character1.SetActive(false);
                character2.SetActive(false);
                character3.SetActive(false);
                character4.SetActive(false);
                character5.SetActive(false);
            }

            if (axol == true)
            {
                character1.SetActive(true);

                character0.SetActive(false);
                character2.SetActive(false);
                character3.SetActive(false);
                character4.SetActive(false);
                character5.SetActive(false);
            }

            if (doge == true)
            {
                character2.SetActive(true);

                character1.SetActive(false);
                character3.SetActive(false);
                character4.SetActive(false);
                character5.SetActive(false);
                character0.SetActive(false);
            }

            if (capy == true)
            {
                character3.SetActive(true);

                character0.SetActive(false);
                character1.SetActive(false);
                character2.SetActive(false);
                character4.SetActive(false);
                character5.SetActive(false);
            }

            if (cyat == true)
            {
                character4.SetActive(true);

                character0.SetActive(false);
                character1.SetActive(false);
                character2.SetActive(false);
                character3.SetActive(false);
                character5.SetActive(false);
            }

            if (freg == true)
            {
                character5.SetActive(true);

                character0.SetActive(false);
                character1.SetActive(false);
                character2.SetActive(false);
                character3.SetActive(false);
                character4.SetActive(false);
            }
        }
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BackScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    private void Awake()
    {
        int value = PlayerPrefs.GetInt("birb");
        birb = value == 1;

        int value1 = PlayerPrefs.GetInt("axol");
        axol = value1 == 1;

        int value2 = PlayerPrefs.GetInt("doge");
        doge = value2 == 1;

        int value3 = PlayerPrefs.GetInt("capy");
        capy = value3 == 1;

        int value4 = PlayerPrefs.GetInt("cyat");
        cyat = value4 == 1;

        int value5 = PlayerPrefs.GetInt("freg");
        freg = value5 == 1;
    }

    public void Selectbirb()
    {
        birb = true;
        axol = false;
        doge = false;
        capy = false;
        cyat = false;
        freg = false;
    }

    public void Selectaxol()
    {
        birb = false;
        axol = true;
        doge = false;
        capy = false;
        cyat = false;
        freg = false;
    }

    public void Selectdoge()
    {
        birb = false;
        axol = false;
        doge = true;
        capy = false;
        cyat = false;
        freg = false;
    }

    public void Selectcapy()
    {
        birb = false;
        axol = false;
        doge = false;
        capy = true;
        cyat = false;
        freg = false;
    }

    public void Selectcyat()
    {
        birb = false;
        axol = false;
        doge = false;
        capy = false;
        cyat = true;
        freg = false;
    }

    public void Selectfreg()
    {
        birb = false;
        axol = false;
        doge = false;
        capy = false;
        cyat = false;
        freg = true;
    }

    public void SaveBools()
    {

        PlayerPrefs.SetInt("birb", birb ? 1 : 0);
        PlayerPrefs.SetInt("axol", axol ? 1 : 0);
        PlayerPrefs.SetInt("doge", doge ? 1 : 0);
        PlayerPrefs.SetInt("capy", capy ? 1 : 0);
        PlayerPrefs.SetInt("cyat", cyat ? 1 : 0);
        PlayerPrefs.SetInt("freg", freg ? 1 : 0);
    }

    private void Update()
    {
        if (isSelectorCheck == true)
        {
            if (birb == true)
            {
                checkList[0].SetActive(true);
            }
            else
            {
                checkList[0].SetActive(false);
            }

            if (axol == true)
            {
                checkList[1].SetActive(true);
            }
            else
            {
                checkList[1].SetActive(false);
            }

            if (doge == true)
            {
                checkList[2].SetActive(true);
            }
            else
            {
                checkList[2].SetActive(false);
            }

            if (capy == true)
            {
                checkList[3].SetActive(true);
            }
            else
            {
                checkList[3].SetActive(false);
            }

            if (cyat == true)
            {
                checkList[4].SetActive(true);
            }
            else
            {
                checkList[4].SetActive(false);
            }

            if (freg == true)
            {
                checkList[5].SetActive(true);
            }
            else
            {
                checkList[5].SetActive(false);
            }
        }
    }
}