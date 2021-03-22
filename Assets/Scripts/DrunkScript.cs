using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrunkScript : MonoBehaviour
{
    [SerializeField] Image pointer;
    public int end1, end2, currentPoints, beerPoints;
    // Start is called before the first frame update
    void Start()
    {
        end1 = -20;
        end2 = 20;

        StartCoroutine(Timer());
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoreDrunk(int beerPoints)
    {
        pointer.GetComponent<RectTransform>().transform.position = new Vector2(pointer.GetComponent<RectTransform>().transform.position.x +
        pointer.GetComponent<RectTransform>().rect.width * beerPoints, pointer.GetComponent<RectTransform>().transform.position.y);
        currentPoints += beerPoints;
    }

    private IEnumerator Timer()
    {
        currentPoints = 0;
        while (true)
        {
            Debug.Log(pointer.GetComponent<RectTransform>().rect.width);
            Debug.Log(currentPoints);
            yield return new WaitForSeconds(3f);
            currentPoints -= 5;
            pointer.GetComponent<RectTransform>().transform.position = new Vector2(pointer.GetComponent<RectTransform>().transform.position.x -
            pointer.GetComponent<RectTransform>().rect.width, pointer.GetComponent<RectTransform>().transform.position.y);


            if (currentPoints < end1)
            {
                Debug.Log("You arent drunk at all");
                Time.timeScale = 0f;
                break;
            }
            if (currentPoints > end2)
            {
                Debug.Log("You are way too drunk");
                Time.timeScale = 0f;
                break;
            }
        }
    }
}
