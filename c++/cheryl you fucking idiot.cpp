#include <iostream>
#include <string>

using namespace std;
int hour = 9;
int mins = 30;
int curract = 0;
int location = 0;
int eepysleepy = 0;
int hungy = 0;
bool estrogentoday = false;
string NM = "";

string places[7] = { "your room", "the living room", "the kitchen", "the outside", "dreamworld", ":(", "the bathroom"};
string actions[7] = {
    "\n   1) Sleep\n   2) Go to living room\n   3) Play a game\n   4) Pet your sleeping cat\n   5) Jerk off", 
    "\n   1) Go to your room\n   2) Go to kitchen\n   3) Scream\n   4) Go outside",
    "\n   1) Eat food\n   2) Take your Estrogen\n   3) Go to living room\n   4) Go to bathroom", //kitchen
    "\n   1) Observe tree\n   2) Go back inside",
    "\n   1) Frolic\n   2) Frolic\n   3) Wake up!",
    "\n   1) Suffer\n   2) Suffer\n   3) Suffer\n   4) Suffer",
    "\n   1) Look in mirror\n   2) Shit\n   3) Piss\n   4) Go to living room" };
bool bweh = true;

int main()
{

    while (bweh) {
        cout << "\n\n";
        cout << " BoredomQuest\n\n";
        cout << "________________\n"+NM+ "You're in " + places[location] + ". \n";
        cout << "It is currently " + to_string(hour) + ":" + to_string(mins) + ".\n";
        if (hour >= 20 or hour <= 4) {
            cout << "It's your bedtime!!!\n\n";
        }
        if (hungy >= 4) {
            cout << "You're hungry!!!\n\n";
        }
        cout << "What do you do?" + actions[location] + "\n";
        cout << ">>> ";
        cin >> curract;
        if (location == 0) { //room
            if (curract == 1) { //sleep
                if (hour >=20 or hour <=4){
                    if (estrogentoday) {
                        NM = "You go to sleep.\n\n";
                        location = 4;
                    }
                    else {
                        NM = "Take your estrogen first!!!!!!!!!!!!!!!!\n\n";
                    }
                } else {
                        NM = "It is still not your sleepy time yet.\n\n";
                }
            } else if (curract == 2) { //goto living
                location = 1;
                NM = "You go to the living room.\n\n";
                mins+=20;
            }
            if (curract == 3) { //vidoe game
                NM = "You play a pointless videogame about doing nothing substantial.\n\n";
                mins++;
                hungy++;
            }
            else if (curract == 4) { //petpet
                NM = "You pet your cat.\n\"Miaouw.\"\n\n";
                hour++;
                hour++;
                hour++;
                hungy++;
            }
            else if (curract == 5) { //fappies
                NM = "You jerk your shit cutesstyle.\n+1 CUMCOINS\n\n";
                hour++;
                hour++;
                hour++;
                hour++;
                hour++;
                hungy++;
            }
            else if (curract == 67) {
                location = 5;
            }
        } else if (location == 1) { //living
            if (curract == 1) { //goto room
                location = 0;
                NM = "You go to your room.\n\n";
                mins+=20;
            }
            else if (curract == 2) { //goto kitchen
                location = 2;
                NM = "You go to the kitchen.\n\n";
                mins+=20;
            }
            if (curract == 3) { //sounds
                NM = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA.\n\n";
                hour++;
                hour++;
                hour++;
                hour++;
                hour++;
                hour++;
                hour++;
                hour++;
                hour++;
                hour++;
                hungy++;
            }
            else if (curract == 4) { //goto outside
                location = 3;
                NM = "You go outside.\n\n";
                mins+=20;
            }
            else if (curract == 67) {
                location = 5;
            }
        }
        else if (location == 2) { //kitchen
            if (curract == 1) { //food
                if (hungy >= 4) {
                    NM = "You eat.\n\n";
                    hungy = 0;
                    hour++;
                    hour++;
                    mins += 30;
                }
                else {
                    NM = "You are not hungry enough.\n\n";
                }
            }
            else if (curract == 2) { //Estro
                if (!estrogentoday) 
                {
                    estrogentoday = true;
                    NM = "You took your Estrogen!! Good girl.\n\n";
                    mins+=15;
                }
                else {
                    NM = "You've already taken your estrogen!!\n\n";
                }
            }
            if (curract == 3) { //goto living
                location = 1;
                NM = "You go to the living room.\n\n";
                mins+=20;
            }
            if (curract == 4) { //goto bath
                location = 6;
                NM = "You go to the bathroom.\n\n";
                mins+=20;
            }
            else if (curract == 67) {
                location = 5;
            }
        }
        else if (location == 3) { //outside
            if (curract == 1) { //tree
                NM = "Yyyyyyup. That's a tree.\n\n";
                hour++;
                hour++;
                hour++;
                hour++;
                hungy++;
            }
            else if (curract == 2) { //goto inside
                location = 1;
                NM = "You go back inside.\n\n";
                mins+=20;
            }
            else if (curract == 67) {
                location = 5;
            }
        }
        else if (location == 4) { // 1) Frolic\n   2) Frolic\n   3) Wake up!",
            if (curract == 1 or curract == 2) { //tree
                NM = "You frolic ^_^ :D ^w^ :3.\n\n";
            }
            else if (curract == 3) { //wakey
                location = 0;
                NM = "You wake up.\n\n";
                hungy++;
                hour = 9;
                mins = 30;
            }
            else if (curract == 67) {
                location = 5;
            }
        }
        else if (location == 6) { // 1) Look in mirror\n   2) Shit\n   3) Piss\n
            if (curract == 2 or curract == 3) { //peepeepoopoo
                NM = "You let out your bodily fluids grossstyle.\n\n";
                hungy++;
                hour++;
                hour++;
                hour++;
                hour++;
            }
            else if (curract == 1) { //mirror
                NM = "Yyyyyyup. That's a girl.\n\n";
                mins += 15;
            }
            if (curract == 4) { //goto living
                location = 1;
                NM = "You go to the living room.\n\n";
                mins+=20;
            }
            else if (curract == 67) {
                location = 5;
            }
        }

        if (mins >= 60) {
            mins -= 60;
            hour++;
        }
        if (hour >= 24) {
            hour -= 24;
        }

    }
}
