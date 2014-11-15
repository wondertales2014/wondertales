#pragma strict

var loboAnim: Animator;
var  ventana : GameObject;

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
if (funcion == 2)
	{
	loboAnim.SetBool("aullar",false);
	ventana.renderer.material.color.b = 0f; 
	}
if (funcion == 3 || funcion == 4)
	{
	if(!audio.isPlaying)
		{
		audio.Play();
		}
	}
}