#pragma strict

var chozaAnim : Animator;
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
	chozaAnim.SetBool("volar", true);
	chanchoAnim.SetBool("correr", true);
	}
}