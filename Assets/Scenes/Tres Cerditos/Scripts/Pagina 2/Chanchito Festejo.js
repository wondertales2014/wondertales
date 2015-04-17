#pragma strict

var chanchito : Animator;

function Start () {

}

function Update () {
}

function Festejar (opcion : int)
{
if (opcion == 1)
	{
	chanchito.SetBool("festejar", true);
	chanchito.SetBool("negar", false);
	this.audio.Play();
	yield;
	chanchito.SetBool("festejar", false);
	}
else
	{	
	chanchito.SetBool("negar", true);
	yield;
	chanchito.SetBool("negar", false);	
	}
}