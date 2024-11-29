using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class QuestScript : MonoBehaviour
{
    public Quest MyQuest { get; set;}

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Select()
    {
        GetComponent<TextMeshProUGUI>().color = Color.red;
        Questlog.MyInstance.ShowDescription(MyQuest);
    }

    public void DeSelect()
    {
        GetComponent<TextMeshProUGUI>().color = Color.white;
    }




}