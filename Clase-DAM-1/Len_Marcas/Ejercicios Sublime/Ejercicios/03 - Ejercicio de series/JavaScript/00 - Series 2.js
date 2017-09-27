var conta = 0;
var conte = 0;

function correccion(cor, i, num) {
	var p;
	var c;

	p = document.getElementById(cor);

	if (cor == "a") {
		//p.innerHTML = "Preguntas:" + conta +" Correctas";
		conta = parseInt(p.innerHTML);
		conta ++;
		p.innerHTML = conta;
		num.style.backgroundColor = "green";
		c = document.getElementById('imagen'+i);
		c.src = "Imagenes/like.png"
	} else {
		//p.innerHTML = "Preguntas: " + conte + " Errores";
		conte = parseInt(p.innerHTML);
		conte ++;
		p.innerHTML = conte;
		num.style.backgroundColor = "red";
		c = document.getElementById('imagen'+i);
		c.src = "Imagenes/unlike.png"
	}
}