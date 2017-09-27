var conta = 0;
var conte = 0;

function correccion(cor, num) {
	var p;
	var v;
	var r;

	p = document.getElementById(cor);

	if (cor == "a") {
		conta++;
		p.innerHTML = "Aciertos: " + conta +" Correctas";
		num.style.backgroundColor = "green";


	} else {
		conte ++;
		p.innerHTML = "Aciertos: " + conte + " Errores";
		num.style.backgroundColor = "red";
	}
}