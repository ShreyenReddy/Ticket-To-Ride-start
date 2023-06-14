using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawDestinationCard : MonoBehaviour
{
    public GameObject[] Cards;
    public GameObject ConentPnl;
    public Transform[] AmountOfChoiceCards;
    public GameObject ChoicePnl;
    public GameObject DestinationPanels;
    public Transform panelTransform;
    public Vector2 ActivePnlPos;

    // Start is called before the first frame update
    void Start()
    {
        DestinationPanels = GameObject.Find("DestinationStuff");
        panelTransform = DestinationPanels.transform;
        ActivePnlPos = new Vector2(2.3f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDraw()
    {
        AmountOfChoiceCards = ChoicePnl.GetComponentsInChildren<Transform>();
        int numOfChoiceCards = AmountOfChoiceCards.Length;
        panelTransform.position = ActivePnlPos;
        for (int i = numOfChoiceCards; i < 4; i++)
        {
            Instantiate(Cards[Random.Range(0, 30)], ChoicePnl.transform);    
        }
    }
}
