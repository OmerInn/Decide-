using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text TrueText;
    public Text FalseText;
    public int TrueScore;
    public int FalseScore;
    public bool Produce;
    public GameObject ProducePoint;
    public List<GameObject> ObjeList;
    public GameObject failPanel;
    
    private void Awake()
    {
        if (instance == null) { instance = this; }
    }
    private void Update()
    {
        if (FalseScore>10)
        {
            failPanel.SetActive(true);
        }
        else
        {

            if (!Produce)
            {
                StartCoroutine(ObjeProduce());
            }
        }
    }
    public void TrueAnsverText()
    {
        TrueScore++;
        TrueText.text = "True Answer: " + TrueScore;
    }
    public void FalseAnsverText()
    {
        FalseScore++;
       FalseText.text = "False Answer: " + FalseScore;
    }
    public IEnumerator ObjeProduce()
    {
        Produce = true;
        GameObject obj = ObjeList[Random.Range(0, ObjeList.Count)];
        Instantiate(obj, ProducePoint.transform.position,obj.transform.rotation);
        yield return new WaitForSeconds(1.2f);
        Produce = false;
    }
    public void PlayAgainButton()       
    {
        SceneManager.LoadScene(0);
    }
 
}
