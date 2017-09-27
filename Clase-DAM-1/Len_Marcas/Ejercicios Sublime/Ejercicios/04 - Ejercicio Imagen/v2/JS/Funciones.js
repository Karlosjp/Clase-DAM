function incrementa(id) {
	var p = document.getElementById(id);
	p.width += 10;
	p.height += 10;
}

function retorna(ancho, alto, id) {
	var p = document.getElementById(id);
	p.width = ancho;
	p.height = alto;
}

function cambioTamanho(cambio) {
	var p = document.getElementsByTagName('img');

	for(var i= 0; i < p.length; i++){
		p[i].width += cambio;
		p[i].height += cambio;
	}
}

function retornaTodo(ancho, alto) {
	var p = document.getElementsByTagName('img');

	for(var i= 0; i < p.length; i++){
 		p[i].width = ancho;
		p[i].height = alto;
	}
}

function cambio(imagen) {
	imagen.src = "Imagen/Neutro.jpg";
}

function retorno(imagen, id) {
	imagen.src = "Imagen/" + id + ".jpg";
}