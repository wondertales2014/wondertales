#pragma strict

var lobo : GameObject;
var crack : AudioSource;

function Start () {

}

function Update () {

}

function OnTouchDown (funcion : int) {

if (funcion == 1)
	{
	lobo.SetActive(false);
	crack.Play();
	}
if (funcion == 2)
	{
	lobo.SetActive(false);
	crack.Play();
	}
if (funcion == 3)
	{
	lobo.SetActive(false);
	crack.Play();
	}
if (funcion == 4)
	{
	lobo.SetActive(false);
	crack.Play();
	}
}