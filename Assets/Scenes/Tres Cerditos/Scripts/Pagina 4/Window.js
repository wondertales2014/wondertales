#pragma strict

var windowAnim: Animator;
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
		}
	else
		{
		windowAnim.SetBool("Abrir",false);
		}
	}
}