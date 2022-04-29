using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeController : MonoBehaviour
{
    public GameObject player;
    public GameObject NPCS;
    float currenTime = 0f;
    float startingTime = 3f;

    [SerializeField] Text countDownText;
    void Start()
    {
        currenTime = startingTime;
    }

    void Update()
    {
        currenTime -= 1 * Time.deltaTime;
        countDownText.text = currenTime.ToString("0");
        if (currenTime <= 0)
        {
            countDownText.text = "GO!!!";
            player.SetActive(true);
            NPCS.SetActive(true);
            this.gameObject.SetActive(false);
            Destroy(countDownText, 1f);
        }
    }
}
