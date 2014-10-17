#pragma strict

var burbuja1 : Canvas;
var burbuja2 : Canvas;
var burbuja3 : Canvas;

function Start () {

}

function Update () {


burbuja1.enabled = true;

var text = burbuja1.GetComponent(GUIText);
text.text = "Vamonos chicos";
}