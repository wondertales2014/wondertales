#pragma strict

var chairAnim: Animator;
function Start () {

}

function Update () {

}

function OnTouchDown (funcion : int) {

if (funcion == 1)
	{
	chairAnim.SetBool("mecer",true);
	}
if (funcion == 2)
	{
	chairAnim.SetBool("mecer",false);	
	}
}