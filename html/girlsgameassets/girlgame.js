// VARIABLES AND SUCH
let hour = 9;
let minute = 30;
let curract = 0;
let locatio = 0;
let eepysleepy = 0;
let hungy = 0;
let estrogentoday = false;


let places = [
	"your room",
	"the living room",
	"the kitchen",
	"the outside",
	"dreamworld",
	":(",
	"the bathroom",
];

let musics = [
	new Howl({
      src: ['girlsgameassets/inthehouse.mp3'],
  autoplay: false,
  loop: true
    }),
    new Howl({
      src: ['girlsgameassets/inthehouse.mp3'],
  autoplay: false,
  loop: true
    }),
    new Howl({
      src: ['girlsgameassets/inthekitchen.mp3'],
  autoplay: false,
  loop: true
    }),
    new Howl({
      src: ['girlsgameassets/intheoutside.mp3'],
  autoplay: false,
  loop: true
    }),
    new Howl({
      src: ['girlsgameassets/inthedream.mp3'],
  autoplay: false,
  loop: true
    }),
    new Howl({
      src: ['girlsgameassets/ohno.mp3'],
  autoplay: false,
  loop: true
    }),
    new Howl({
      src: ['girlsgameassets/inthebath.mp3'],
  autoplay: false,
  loop: true
    })
];

var meowsong=new Howl({
      src: ['girlsgameassets/catroom.mp3'],
  autoplay: false,
  loop: true
});

for (let i = 0; i < 7; i++) {
  musics[i].mute(true);
}
meowsong.mute(true);

let actions = [
	[
		"Sleep",
		"Go to living room",
		"Play a game",
		"Pet your sleeping cat",
		"Jerk off",
	],
	["Go to your room", "Go to kitchen", "Scream", "Go outside", ""],
	[
		"Eat food",
		"Take your Estrogen",
		"Go to living room",
		"Go to bathroom",
		"",
	],
	["Observe tree", "Go back inside", "", "", ""],
	["Frolic", "Frolic", "Frolic", "Frolic", "Wake up!"],
	["Suffer", "Suffer", "Suffer", "Suffer", "Suffer"],
	["Look in mirror", "Shit", "Piss", "Go to living room", ""],
];



// DECLARING THE INITIAL FUNCTION :3
function information() {
	
	
	document.getElementById("locationtext").innerHTML =
		"You're in " +
		places[locatio] +
		"<br>It is currently " +
		hour +
		":" +
		minute;
	document.getElementById("butt1").innerText = actions[locatio][0];
	document.getElementById("butt2").innerText = actions[locatio][1];
	document.getElementById("butt3").innerText = actions[locatio][2];
	document.getElementById("butt4").innerText = actions[locatio][3];
	document.getElementById("butt5").innerText = actions[locatio][4];

	switch (locatio) {
		case 0:
			document.getElementById("bground").src = "girlsgameassets/room.png";
			break;
		case 1:
			document.getElementById("bground").src =
				"girlsgameassets/living.png";
			break;
		case 2: //kitchen
			document.getElementById("bground").src =
				"girlsgameassets/kitchen.png";
			break;
		case 3: //outside
			document.getElementById("bground").src = "girlsgameassets/tree.png";
			break;
		case 4: //dreamworld
			document.getElementById("bground").src =
				"girlsgameassets/dream.gif";
			break;
		case 5: //:(
			document.getElementById("bground").src = "girlsgameassets/bad.png";
			break;
		case 6: //bathroom
			document.getElementById("bground").src =
				"girlsgameassets/bathroom.png";
			break;
	}

	if (minute >= 60) {
		minute -= 60;
		hour++;
	}
	if (hour >= 24) {
		hour -= 24;
	}
	if (minute >= 60) {
		minute -= 60;
		hour++;
	}
	if (hour >= 24) {
		hour -= 24;
	}
	if (minute >= 60) {
		minute -= 60;
		hour++;
	}
	if (hour >= 24) {
		hour -= 24;
	}

	if (hour <= 4 || hour >= 20) {
		document.getElementById("eepytime").innerText = "It's your bedtime!!";
	} else {
		document.getElementById("eepytime").innerText = "";
	}
	if (hungy >= 4) {
		document.getElementById("hungriness").innerText = "You're hungry!!";
	} else {
		document.getElementById("hungriness").innerText = "";
	}
	
	for (let i = 0; i < 7; i++) {
		if (i!= locatio){
			musics[i].mute(true);
		}else{
			musics[i].mute(false);
		}
	}
	if (document.getElementById("girls").src =="girlsgameassets/girl0003.png"){
			meowsong.mute(false);
			musics[0].mute(true);
		} else {
			meowsong.mute(true);
		}
}

information();

function button(number) {
	document.getElementById("flavtext").innerText = "";
	if (locatio == 0) {
		//room

		if (number == 0) {
			//sleep

			if (hour <= 4 || hour >= 20) {
				if (estrogentoday) {
					document.getElementById("flavtext").innerText =
						"You go to sleep.\n\n";
					document.getElementById("girls").src =
						"girlsgameassets/girl0002.png";
					locatio = 4;
				} else {
					document.getElementById("flavtext").innerText =
						"Take your estrogen first!!!!!!!!!!!!!!!!\n\n";
					document.getElementById("girls").src =
						"girlsgameassets/girl0001.png";
				}
			} else {
				document.getElementById("flavtext").innerText =
					"It is still not your sleepy time yet.\n\n";
				document.getElementById("girls").src =
					"girlsgameassets/girl0001.png";
			}
		} else if (number == 1) {
			document.getElementById("girls").src =
				"girlsgameassets/girl0001.png";
			minute += 20;
			locatio = 1;
		} else if (number == 2) {
			document.getElementById("girls").src =
				"girlsgameassets/girl0006.png";
			document.getElementById("flavtext").innerText =
				"You play a pointless videogame about doing nothing substantial.";
			minute++;
			hungy++;
		} else if (number == 3) {
			document.getElementById("girls").src =
				"girlsgameassets/girl0003.png";
			hour += 3;
			hungy++;
			document.getElementById("flavtext").innerText =
				'"Miaouw."\nYou pet your sleeping cat.';
		} else if (number == 4) {
			document.getElementById("girls").src =
				"girlsgameassets/girl0005.png";
			hour += 5;
			hungy++;
			document.getElementById("flavtext").innerText =
				"You jerk your shit cutesstyle.\n+1 CUMCOINS";
		}
	} else if (locatio == 1) {
		if (number == 0) {
			document.getElementById("girls").src =
				"girlsgameassets/girl0001.png";
			minute += 20;
			locatio = 0;
		} else if (number == 1) {
			document.getElementById("girls").src =
				"girlsgameassets/girl0001.png";
			minute += 20;
			locatio = 2;
		} else if (number == 2) {
			document.getElementById("flavtext").innerText =
				"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
			document.getElementById("girls").src =
				"girlsgameassets/girl0004.png";
			hour += 10;
		} else if (number == 3) {
			document.getElementById("girls").src =
				"girlsgameassets/girl0001.png";
			locatio = 3;
			minute += 20;
		} else {
			locatio = 5;
			document.getElementById("flavtext").innerText =
				"curiosity meowed the kbity.";
		}
	} else if (locatio == 2) {
		if (number == 0) {
			if (hungy >= 4) {
				document.getElementById("flavtext").innerText = "You eat.";
				hungy = 0;
			} else {
				document.getElementById("flavtext").innerText =
					"You're not hungry enough.";
			}
		} else if (number == 1) {
			if (!estrogentoday) {
				estrogentoday = true;
				document.getElementById("flavtext").innerText =
					"You take your estrogen. Good girl!!";
			} else {
				document.getElementById("flavtext").innerText =
					"You already took your estrogen, silly!!";
			}
		} else if (number == 2) {
			document.getElementById("girls").src =
				"girlsgameassets/girl0001.png";
			minute += 20;
			locatio = 1;
		} else if (number == 3) {
			document.getElementById("girls").src =
				"girlsgameassets/girl0001.png";
			minute += 20;
			locatio = 6;
		} else {
			locatio = 5;
			document.getElementById("flavtext").innerText =
				"curiosity meowed the kbity.";
		}
	} else if (locatio == 3) {
		if (number == 0) {
			hour += 4;
			hungy++;
			document.getElementById("flavtext").innerText =
				"Yyyyyyup. That's a tree.";
		} else if (number == 1) {
			document.getElementById("girls").src =
				"girlsgameassets/girl0001.png";
			minute += 20;
			locatio = 1;
		} else {
			locatio = 5;
			document.getElementById("flavtext").innerText =
				"curiosity meowed the kbity.";
		}
	} else if (locatio == 4) {
		if (number == 4) {
			document.getElementById("girls").src =
				"girlsgameassets/girl0001.png";
			document.getElementById("flavtext").innerText = "You wake up.";
			estrogentoday = false;
			hungy++;
			hour = 9;
			minute = 30;
			locatio = 0;
		} else {
			document.getElementById("flavtext").innerText =
				"You frolic ^_^ :D ^w^ :3.";
		}
	} else if (locatio == 6) {
		//"Look in mirror","Shit","Piss","Go to living room",""
		if (number == 0) {
			document.getElementById("flavtext").innerText =
				"Yyyyyyup. That's a girl.";
			minute += 15;
		} else if (number == 1 || number == 2) {
			document.getElementById("flavtext").innerText =
				"You let out your bodily fluids grosslystyle.";
			hour += 4;
		} else if (number == 3) {
			minute += 20;
			locatio = 1;
		} else {
			locatio = 5;
			document.getElementById("flavtext").innerText =
				"curiosity meowed the kbity.";
		}
	} else {
		hour = 9;
		minute = 30;
		curract = 0;
		locatio = 0;
		eepysleepy = 0;
		hungy = 0;
		estrogentoday = false;
	}

	if (minute >= 60) {
		minute -= 60;
		hour++;
	}
	if (hour >= 24) {
		hour -= 24;
	}
	if (minute >= 60) {
		minute -= 60;
		hour++;
	}
	if (hour >= 24) {
		hour -= 24;
	}
	if (minute >= 60) {
		minute -= 60;
		hour++;
	}
	if (hour >= 24) {
		hour -= 24;
	}
	information();
	if (number == 3 & locatio==0){
			meowsong.mute(false);
			musics[0].mute(true);
		} else {
			meowsong.mute(true);
		}
}



function playgame(){
	musics[0].stop();
	musics[1].stop();
	musics[2].stop();
	musics[3].stop();
	musics[4].stop();
	musics[5].stop();
	musics[6].stop();
	meowsong.stop();
	
	musics[0].play();
	musics[1].play();
	musics[2].play();
	musics[3].play();
	musics[4].play();
	musics[5].play();
	musics[6].play();
	meowsong.play();
	
	document.getElementById("gamediv").style.display = "block"
	document.getElementById("playbutt").style.display = "none"
}