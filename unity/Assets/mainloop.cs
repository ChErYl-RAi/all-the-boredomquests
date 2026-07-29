using UnityEngine;

public class mainloop : MonoBehaviour
{
    int room = 0;
    int hour=9;
    int minute=30;
    int hunger=0;
    public GameObject girl;
    public Sprite[] roomimgs;
    public Sprite[] girlimgs;
    public GameObject place;
    public GameObject[] buttons;
    public GameObject flavortext;
    public GameObject[] texts;
    bool estrogentoday=false;
    string[] placenames = new [] {"your room", "the living room", "the kitchen", "the bathroom", "a dream", "the outside"};

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(room);
        Debug.Log(hour);
        Debug.Log(minute);
        Debug.Log(placenames[room]);
    }

    // Update is called once per frame
    void Update()
    {
        texts[0].GetComponent<TMPro.TMP_Text>().text = "you are in " + placenames[room];
        if (minute<10){
            texts[1].GetComponent<TMPro.TMP_Text>().text = "it is " + hour + ":0" + minute;
        }
        else{
            texts[1].GetComponent<TMPro.TMP_Text>().text = "it is " + hour + ":" + minute;
        }
        if (hour >=20 || hour <= 4)
        {
            texts[3].GetComponent<TMPro.TMP_Text>().text = "it's your bedtime!!";
        }else{
            texts[3].GetComponent<TMPro.TMP_Text>().text = "";
        }

        if (hunger >= 4)
        {
            texts[2].GetComponent<TMPro.TMP_Text>().text = "you're hungry!!";
        }else{
            texts[2].GetComponent<TMPro.TMP_Text>().text = "";
        }

        if (room == 0)
        {
            //["Sleep", "Go to living room", "Play a game", "Pet your sleeping cat", "Jerk off"]
            //1) Go to your room\n   2) Go to kitchen\n   3) Scream\n   4) Go outside",
            //1) Eat food\n   2) Take your Estrogen\n   3) Go to living room\n   4) Go to bathroom", //kitchen
            //1) Observe tree\n   2) Go back inside",
            //1) Frolic\n   2) Frolic\n   3) Wake up!",
            //1) Suffer\n   2) Suffer\n   3) Suffer\n   4) Suffer",
            //1) Look in mirror\n   2) Shit\n   3) Piss\n   4) Go to living room"

            //"your room", "the livingroom", "the kitchen", "the bathroom", "a dream", "the outside"
            buttons[0].GetComponent<TMPro.TMP_Text>().text = "Sleep";
            buttons[1].GetComponent<TMPro.TMP_Text>().text = "Go to living room";
            buttons[2].GetComponent<TMPro.TMP_Text>().text = "Play a game";
            buttons[3].GetComponent<TMPro.TMP_Text>().text = "Pet your sleeping cat";
            buttons[4].GetComponent<TMPro.TMP_Text>().text = "Jerk off";
        } else if (room == 1)
        {
            buttons[0].GetComponent<TMPro.TMP_Text>().text = "Go to your room";
            buttons[1].GetComponent<TMPro.TMP_Text>().text = "Go to kitchen";
            buttons[2].GetComponent<TMPro.TMP_Text>().text = "Scream";
            buttons[3].GetComponent<TMPro.TMP_Text>().text = "Go outside";
            buttons[4].GetComponent<TMPro.TMP_Text>().text = "";
        } else if (room == 2)
        {
            buttons[0].GetComponent<TMPro.TMP_Text>().text = "Eat food";
            buttons[1].GetComponent<TMPro.TMP_Text>().text = "Take your Estrogen";
            buttons[2].GetComponent<TMPro.TMP_Text>().text = "Go to living room";
            buttons[3].GetComponent<TMPro.TMP_Text>().text = "Go to bathroom";
            buttons[4].GetComponent<TMPro.TMP_Text>().text = "";
        } else if (room == 3)
        {
            buttons[0].GetComponent<TMPro.TMP_Text>().text = "Look in mirror";
            buttons[1].GetComponent<TMPro.TMP_Text>().text = "Shit";
            buttons[2].GetComponent<TMPro.TMP_Text>().text = "Piss";
            buttons[3].GetComponent<TMPro.TMP_Text>().text = "Go to living room";
            buttons[4].GetComponent<TMPro.TMP_Text>().text = "";
        } else if (room == 4)
        {
            buttons[0].GetComponent<TMPro.TMP_Text>().text = "Frolic";
            buttons[1].GetComponent<TMPro.TMP_Text>().text = "Frolic";
            buttons[2].GetComponent<TMPro.TMP_Text>().text = "Wake up!";
            buttons[3].GetComponent<TMPro.TMP_Text>().text = "";
            buttons[4].GetComponent<TMPro.TMP_Text>().text = "";
        } else if (room == 5)
        {
            buttons[0].GetComponent<TMPro.TMP_Text>().text = "Observe tree";
            buttons[1].GetComponent<TMPro.TMP_Text>().text = "Go back inside";
            buttons[2].GetComponent<TMPro.TMP_Text>().text = "";
            buttons[3].GetComponent<TMPro.TMP_Text>().text = "";
            buttons[4].GetComponent<TMPro.TMP_Text>().text = "";
        }
        for (int i = 0; i < buttons.Length; i++)
        {
            if (buttons[i].GetComponent<TMPro.TMP_Text>().text == "")
            {
                buttons[i].SetActive(false);
            }
            else
            {
                buttons[i].SetActive(true);
            }
        }
    }

    public void choose(int choice)
    {
        
        girl.GetComponent<SpriteRenderer>().sprite = girlimgs[0];

            //["Sleep", "Go to living room", "Play a game", "Pet your sleeping cat", "Jerk off"]
            //1) Go to your room\n   2) Go to kitchen\n   3) Scream\n   4) Go outside",
            //1) Eat food\n   2) Take your Estrogen\n   3) Go to living room\n   4) Go to bathroom", //kitchen
            //1) Observe tree\n   2) Go back inside",
            //1) Frolic\n   2) Frolic\n   3) Wake up!",
            //1) Suffer\n   2) Suffer\n   3) Suffer\n   4) Suffer",
            //1) Look in mirror\n   2) Shit\n   3) Piss\n   4) Go to living room"

            //"your room", "the livingroom", "the kitchen", "the bathroom", "a dream", "the outside"

        if (room == 0)
        {
            if (choice == 0)
            {
                if (hour >=20 || hour <= 4)
                {
                    if (estrogentoday){
                        room=4;
                        flavortext.GetComponent<TMPro.TMP_Text>().text = "you go to sleep";
                        girl.GetComponent<SpriteRenderer>().sprite = girlimgs[1];
                    } else
                    {
                        flavortext.GetComponent<TMPro.TMP_Text>().text = "take your estrogen first!!";
                    }
                }
                else
                {
                    flavortext.GetComponent<TMPro.TMP_Text>().text = "it's not your bedtime yet!";
                }
            } else if (choice == 1)
            {
                room = 1;
                flavortext.GetComponent<TMPro.TMP_Text>().text = "You go to the living room.";
                minute+=20;
            } else if (choice == 2)
            {
                flavortext.GetComponent<TMPro.TMP_Text>().text = "You play a pointless videogame about doing nothing substantial.";
                girl.GetComponent<SpriteRenderer>().sprite = girlimgs[5];
                minute++;
                hunger++;
            } else if (choice == 3)
            {
                flavortext.GetComponent<TMPro.TMP_Text>().text = "You pet your cat.\n\"Miaouw.\"";
                girl.GetComponent<SpriteRenderer>().sprite = girlimgs[2];
                hour++;
                hour++;
                hour++;
                hunger++;
            } else if (choice == 4)
            {
                flavortext.GetComponent<TMPro.TMP_Text>().text = "You jerk your shit cutesstyle.\n+1 CUMCOINS";
                girl.GetComponent<SpriteRenderer>().sprite = girlimgs[4];
                hour++;
                hour++;
                hour++;
                hour++;
                hour++;
                hunger++;
            }
        } else if (room == 1)
        {
            if (choice == 0)
            {
                flavortext.GetComponent<TMPro.TMP_Text>().text = "You go to your room.";
                minute+=20;
                room=0;
            } else if (choice == 1)
            {
                flavortext.GetComponent<TMPro.TMP_Text>().text = "You go to the kitchen.";
                minute+=20;
                room=2;
            } else if (choice == 2)
            {
                flavortext.GetComponent<TMPro.TMP_Text>().text = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA.";
                hour+=10;
                hunger++;
                girl.GetComponent<SpriteRenderer>().sprite = girlimgs[3];
            } else if (choice == 3)
            {
                room = 3;
                flavortext.GetComponent<TMPro.TMP_Text>().text = "You go outside.\n\n";
                minute+=20;
            } 
        } else if (room == 2)
        {
            //1) Eat food\n   2) Take your Estrogen\n   3) Go to living room\n   4) Go to bathroom", //kitchen
            if (choice == 0)
            {
                if (hunger >= 4) {
                    flavortext.GetComponent<TMPro.TMP_Text>().text = "You eat.\n\n";
                    hunger = 0;
                    hour++;
                    hour++;
                    minute += 30;
                }
                else {
                    flavortext.GetComponent<TMPro.TMP_Text>().text = "You are not hungry enough.\n\n";
                }
            } else if (choice == 1)
            {
                if (!estrogentoday) 
                {
                    estrogentoday = true;
                    flavortext.GetComponent<TMPro.TMP_Text>().text = "You took your Estrogen!! Good girl.\n\n";
                    minute+=15;
                }
                else {
                    flavortext.GetComponent<TMPro.TMP_Text>().text = "You've already taken your estrogen!!\n\n";
                }
            } else if (choice == 2)
            {
                flavortext.GetComponent<TMPro.TMP_Text>().text = "You go to the living room.";
                minute+=20;
                room=1;
            } else if (choice == 3)
            {
                flavortext.GetComponent<TMPro.TMP_Text>().text = "You go to the bathroom.";
                minute+=20;
                room=3;
            }
        } else if (room == 5)
        {
            if (choice == 0)
            {
                flavortext.GetComponent<TMPro.TMP_Text>().text = "Yyyyyyup. That's a tree.\n\n";
                hour++;
                hour++;
                hour++;
                hour++;
                hunger++;
            } else if (choice == 1)
            {
                room = 1;
                flavortext.GetComponent<TMPro.TMP_Text>().text = "You go back inside.";
                minute+=20;
            }
        } else if (room == 4)
        {
            //1) Frolic\n   2) Frolic\n   3) Wake up!",
            if (choice == 0)
            {
                flavortext.GetComponent<TMPro.TMP_Text>().text = "You frolic ^_^ :D ^w^ :3.";
                        girl.GetComponent<SpriteRenderer>().sprite = girlimgs[1];
            } else if (choice == 1)
            {
                flavortext.GetComponent<TMPro.TMP_Text>().text = "You frolic ^_^ :D ^w^ :3.";
                        girl.GetComponent<SpriteRenderer>().sprite = girlimgs[1];
            } else if (choice == 2)
            {
                flavortext.GetComponent<TMPro.TMP_Text>().text = "you wake up";
                hunger++;
                room = 0;
                estrogentoday = false;
                hour = 9;
                minute = 30;
            } 
        } else if (room == 3)
        {
            //1) Look in mirror\n   2) Shit\n   3) Piss\n   4) Go to living room"
            if (choice == 0)
            {
                flavortext.GetComponent<TMPro.TMP_Text>().text = "Yyyyyyup. That's a girl.\n\n";
                minute += 15;
            } else if (choice == 1)
            {
                flavortext.GetComponent<TMPro.TMP_Text>().text = "You let out your bodily fluids grossstyle.\n\n";
                hunger++;
                hour++;
                hour++;
                hour++;
                hour++;
            } else if (choice == 2)
            {
                flavortext.GetComponent<TMPro.TMP_Text>().text = "You let out your bodily fluids grossstyle.\n\n";
                hunger++;
                hour++;
                hour++;
                hour++;
                hour++;
            } else if (choice == 3)
            {
                flavortext.GetComponent<TMPro.TMP_Text>().text = "You go to the living room.";
                minute+=20;
                room=1;
            }
        }

        place.GetComponent<SpriteRenderer>().sprite = roomimgs[room];
        

        hour=hour+Mathf.FloorToInt(minute/60);
        hour=hour%24;
        minute=minute%60;
    }
}
