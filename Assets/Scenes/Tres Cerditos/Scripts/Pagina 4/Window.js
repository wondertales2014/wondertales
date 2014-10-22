#pragma strict

var windowAnim: Animator;
var wolfsound: AudioSource;

function Start () {

}

function Update () {

}

function OnTouchDown (funcion : int) {

if (funcion == 1)
	{
	if (!windowAnim.GetBool("Abrir"))
		{
		windowAnim.SetBool("Abrir",true);
		wolfsound.Play();
		}
	else
		{
		windowAnim.SetBool("Abrir",false);
		wolfsound.Stop();
		}
	}
}