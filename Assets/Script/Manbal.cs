using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manbal : MonoBehaviour
{
    public GameObject[] spawn;
    public GameObject ball,panel;
    float timer = 5;
    [SerializeField]
    int bola,limit;
    public int satu, dua, tiga, empat,win = 4;
    public GameObject p1,p2,p3,p4;
    public Text skor1, skor2, skor3, skor4, pemenang;
    bool one = true, two = true, three = true, four = true;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        skor1.text = satu.ToString();
        skor2.text = dua.ToString();
        skor3.text = tiga.ToString();
        skor4.text = empat.ToString();
        if (timer < 5 && bola < 5)
            timer += Time.deltaTime;
        else if (bola < 5)
        {
            timer = 0;
            Generateboll();
        }

        if (satu == limit)
        {
            p1.GetComponent<addle>().aktif();
            win -= 1;
            satu += 1;
            one = false;
        }

        if (dua == limit)
        {
            p2.GetComponent<addle>().aktif();
            win -= 1;
            dua += 1;
            two = false;
        }

        if(tiga == limit)
        {
            p3.GetComponent<addle>().aktif();
            tiga += 1;
            win -= 1;
            three = false;
        }

        if(empat == limit )
        {
            p4.GetComponent<addle>().aktif();
            empat += 1;
            win -= 1;
            four = false;
        }
        checkwin();
    }

    public void spawns()
    {
        int A = Random.Range(spawn.Length - (spawn.Length - 1), spawn.Length);
        Instantiate(ball, spawn[A].transform.position, spawn[A].transform.rotation);
        bola += 1;
    }

    public void Generateboll()
    {


        int A = Random.Range(spawn.Length -spawn.Length , spawn.Length);

        GameObject Ball= Instantiate(ball, spawn[A].transform.position, spawn[A].transform.rotation); ;
        Ball.SetActive(true);
        bola += 1;

    }

    public void destrr(GameObject powerUp)
    {
        
        Destroy(powerUp);
    }

    public void addskor(string a, int b)
    {
        if (a == "satu")
        {
            satu += b;
        }
        else if (a == "dua")
        {
            dua += b;
        }
        else if (a == "dua")
        {
            dua += b;
        }
        else if  (a == "tiga")
        {
            tiga += b;
        }
        else if (a == "empat")
        {
            empat += b;
        }
        bola -= 1;
    }

    public void checkwin()
    {
        if (win == 1)
        {
            if (one)
            {
                panel.SetActive(true);
                pemenang.text = "Player1";
            }
            else if (two)
            {
                panel.SetActive(true);
                pemenang.text = "Player2";
            }
            else if (three)
            {
                panel.SetActive(true);
                pemenang.text = "Player3";
            }
            else if (four)
            {
                panel.SetActive(true);
                pemenang.text = "Player4";
            }
            return;
        }
    }


    public void Resetscene()
    {
        SceneManager.LoadScene(0);
    }

    public void mainmenu()
    {
        SceneManager.LoadScene(1);
    }
}
