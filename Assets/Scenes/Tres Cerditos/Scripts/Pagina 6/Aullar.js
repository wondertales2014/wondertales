#pragma strict

var loboAnim: Animator;

function Start () {

}

function Update () {

}

function OnTouchDown (funcion : int) {

if (funcion == 1)
	{
	loboAnim.SetBool("aullar",true);
	audio.Play();
	}
}