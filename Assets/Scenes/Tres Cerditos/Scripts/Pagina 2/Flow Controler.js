#pragma strict

var estado : int;
var mensages : UnityEngine.UI.Text;
var chachitoVerde : GameObject;
var chachitoRojo  : GameObject;
var chachitoTraje : GameObject;

function Start () {

estado = 0;
}

function Update () {

switch (estado)
	{
	case 0:
	mensages.text = "Que material uso el chanchito rojo?";
	break;
	
	case 1:
	mensages.text = "Que material uso el chanchito verde?";
	break;
	
	case 2:
	mensages.text = "Que material uso el chanchito negro?";
	break;
	case 3:
	mensages.text = "Muy bien, veo que has leido el cuento hasta ahora";
	break;
	} 
}

function MaterialSelected (mat : int) {
	
switch (estado)
	{
	case 0:
	if (mat == 1)
		{
		chachitoRojo.SendMessage("Festejar", 1);
		estado = estado + 1;
		}
	else
		{
		chachitoRojo.SendMessage("Festejar", 0);		
		}
	break;
	case 1:
	if (mat == 3)
		{
		chachitoVerde.SendMessage("Festejar", 1);	
		estado = estado + 1;	
		}
	else
		{
		chachitoVerde.SendMessage("Festejar", 0);		
		}
	break;
	case 2:
	if (mat == 2)
		{
		chachitoTraje.SendMessage("Festejar", 1);
		estado = estado + 1;
		}
	else
		{
		chachitoTraje.SendMessage("Festejar", 0);		
		}	
	break;
	} 
}