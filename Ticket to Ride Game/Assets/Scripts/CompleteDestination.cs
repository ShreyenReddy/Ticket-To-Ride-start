using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CompleteDestination : MonoBehaviour
{
    public int AmountToAdd;
    public TotalPoints totalPoints;
    public TextMeshProUGUI PointsTxt;
    public GameObject Card;
    public GameObject ContentPnl;
    public GameObject ChoicePnl;
    public Transform[] ChoiceCards;
    public GameObject DestinationPanels;
    public Transform panelTransform;
    public Vector2 HidePnlPos;

    // Start is called before the first frame update
    void Start()
    {
        PointsTxt = GameObject.Find("PlayerPoints").GetComponent<TextMeshProUGUI>();
        totalPoints = GameObject.Find("DestinationCardPnl").GetComponent<TotalPoints>();
        ContentPnl = GameObject.Find("Content");
        ChoicePnl = GameObject.Find("ChoicePnl");
        DestinationPanels = GameObject.Find("DestinationStuff");
        panelTransform = DestinationPanels.transform;
        HidePnlPos = new Vector2(-15, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCompleteClick()
    {
        ChoiceCards = ChoicePnl.GetComponentsInChildren<Transform>();
        Card = gameObject;
        if (Card.transform.parent.name == "ChoicePnl")
        {
            Instantiate(Card, ContentPnl.transform);
            foreach (Transform f in ChoiceCards)
            {
                if (f.gameObject.name != "ChoicePnl")
                {
                    Destroy(f.gameObject);
                    panelTransform.position = HidePnlPos;
                }
            }
        }
        else
        {
            totalPoints.PlayerTotalPoints += AmountToAdd;
            PointsTxt.text = totalPoints.PlayerTotalPoints.ToString();
            Destroy(Card);
        }
    }
}
