#pragma strict

var chanchoAnim : Animator;
var loboAnim: Animator;

function Start () {

}

function Update () {

}

function OnTouchDown (funcion : int) {

if (funcion == 1)
	{
	loboAnim.SetBool("soplido",true);
	chanchoAnim.SetBool("correr", true);
	}
}