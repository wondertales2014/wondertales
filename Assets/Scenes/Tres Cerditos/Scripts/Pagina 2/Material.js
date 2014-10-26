#pragma strict

var ardilla : GameObject;
var mat : int;

function Start () {

}

function Update () {

}

function OnTouchDown (valor : int) {
	
if (valor == 1)	
	{
	ardilla.SendMessage("MaterialSelected", mat);
	}	
}