using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DrunkScript : MonoBehaviour
{
    [SerializeField] PlayerController player;
    [SerializeField] Image pointer;
    [SerializeField] RectTransform _end, _end2;
    public int end1, end2, currentPoints, beerPoints;
    // Start is called before the first frame update
    void Start()
    { 
        end1 = -140;
        end2 = 140;
        StartCoroutine(Timer());
    }

    private void Update()
    {
        if (player.playerAlive == false)
        {
            SceneManager.LoadScene("EndScreen");
        }
    }

    public void MoreDrunk(int beerPoints)
    {
        pointer.GetComponent<RectTransform>().transform.position = new Vector2(pointer.GetComponent<RectTransform>().transform.position.x +
        pointer.GetComponent<RectTransform>().rect.width * beerPoints, pointer.GetComponent<RectTransform>().transform.position.y);
        currentPoints += beerPoints * 5;
    }

    public IEnumerator Timer()
    {
        currentPoints = 0;
        while (true)
        {
            yield return new WaitForSeconds(1f);
            currentPoints -= 5;
            pointer.GetComponent<RectTransform>().transform.position = new Vector2(pointer.GetComponent<RectTransform>().transform.position.x -
            pointer.GetComponent<RectTransform>().rect.width, pointer.GetComponent<RectTransform>().transform.position.y);


            if (currentPoints < end1)
            {
                player.playerAlive = false;
                pointer.GetComponent<RectTransform>().transform.position = _end.transform.position;
                break;
            }
            if (currentPoints > end2)
            {
                player.playerAlive = false;
                pointer.GetComponent<RectTransform>().transform.position = _end2.transform.position;
                break;
            }           
        }
    }
}
