using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class GetInfo : MonoBehaviour
{
    [SerializeField]
    private Button myButton = null, button = null;

    [SerializeField]
    private GameObject PanelUI = null;

    [SerializeField]
    private InputField MC1 = null, MC2 = null;

    private long mc1, mc2;
    private bool test = true;
    void Start()
    {
        myButton.gameObject.SetActive(test);
        PanelUI.SetActive(test);
        button.gameObject.SetActive(!test);

        test = !test;

        MC1.text = 1.ToString();
        MC2.text = 1.ToString();
    }
    public void ChangePanelState()
    {
        if (test == false)
        {
            if (!Int64.TryParse(MC1.text, out mc1))
            {
                MC1.text = null;
                return;
            }
            if (!Int64.TryParse(MC2.text, out mc2))
            {
                MC2.text = null;
                return;
            }

            GameObject.Find("Corp1").GetComponent<BlockRigidbody>().mass = mc1;
            GameObject.Find("Corp2").GetComponent<BlockRigidbody>().mass = mc2;

            PanelUI.SetActive(test);
            myButton.gameObject.SetActive(test);

            test = !test;

            gameObject.GetComponent<CollisionManager>().enabled = true;
            button.gameObject.SetActive(test);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
