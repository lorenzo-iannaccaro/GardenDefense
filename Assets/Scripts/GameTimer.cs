using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [SerializeField] float levelTime = 30f;
    bool isTimeUp = false;

    public bool IsTimeUp()
    {
        return isTimeUp;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isTimeUp)
        {
            GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;
            if (Time.timeSinceLevelLoad >= levelTime)
            {
                // time's up
                Debug.Log("Level time finished");
                isTimeUp = true;
            }
        }
    }
}
