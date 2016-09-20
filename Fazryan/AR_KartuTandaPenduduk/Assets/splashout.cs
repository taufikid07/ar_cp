using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class splashout : MonoBehaviour
{

    public float loadingTime;
    public Image loadingBar;

    void Start()
    {

        loadingBar.fillAmount = 0;

    }


    void Update()
    {

        if (loadingBar.fillAmount <= 1)
        {
            loadingBar.fillAmount += 1.0f / loadingTime * Time.deltaTime;

        }
        if (loadingBar.fillAmount == 1.0f)
        {
            Application.LoadLevel("Vuforia-3-ImageTargets");


        }


    }
}
