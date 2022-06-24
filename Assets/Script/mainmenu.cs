using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public GameObject play, howto;
    // Start is called before the first frame update
    public void plays()
    {
        SceneManager.LoadScene(1);
    }

    public void howtos()
    {
        play.SetActive(false);
        howto.SetActive(true);
    }

    public void back()
    {
        play.SetActive(true);
        howto.SetActive(false);
    }
}
