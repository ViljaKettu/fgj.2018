using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{

    public GameObject[] people;
    public Vector2[] locs;
    public string[] names;

    public GameObject convBox;
    public string activePerson;
    public Text txt;

    void Start ()
    {
        people = GameObject.FindGameObjectsWithTag("People");

        for (int i = 0; i < people.Length; i++)
        {
            locs[i] = people[i].transform.position;
        }

        txt = convBox.GetComponentInChildren<Text>();
        convBox.SetActive(false);
    }

    public void ActivateConversation(GameObject go, string line, string n)
    {
        convBox.SetActive(true);
        activePerson = n;

        foreach(GameObject gm in people)
        {
            if(gm != go)
            {
                gm.SetActive(false);
            }
        }

        go.transform.position = new Vector2(10, 10);
        go.transform.localScale = new Vector2(3, 3);
        txt.text = line;
    }

    public void CheckPerson()
    {
        if(activePerson == names[0])
        {
            txt.text = "CORRECT!!";
        }
        else
        {
            txt.text = "ERROR!!";
        }
    }

    public void ExitConversation()
    {
        convBox.SetActive(false);

        for (int i = 0; i < people.Length; i++)
        {
            people[i].SetActive(true);
            people[i].transform.position = locs[i];
            people[i].transform.localScale = new Vector2(1, 1);
        }
    }
}
