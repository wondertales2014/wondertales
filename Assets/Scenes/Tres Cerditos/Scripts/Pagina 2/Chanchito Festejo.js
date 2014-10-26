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
	}
}