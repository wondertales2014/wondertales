#pragma strict

var altura : UI.Text;

function Start () {

}

function Update () {

altura.text = "altura: " + transform.position.y;
}