#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <time.h>

#define MAX 29
#define CANTIDAD(x) (sizeof( (x) ) / sizeof(char *) - 1)

const char *palabra[] = {
    "amalgama", "narcolepsia", "alcorque", "suricato", "amapola",
    "parguela", "bonita", "shuriken", "hermoso", "panenteismo",
    "nemesis", "anabasis", "antítesis", "origen", "artropodo", NULL
};

//Pide al usuario una letra a buscar
char entrada(){

    char opcion;

    printf("Escribe una letra : ");
    scanf(" %c", &opcion);

    return opcion;
}

//Incrementa errores
int errores(int acierto){

    int fallo = 0;

    if(acierto == 0)
        fallo++;

    return fallo;
}

//Mensaje final
void fin(int fallo){

    if(fallo > 3)
        printf("Has cometido %i fallos, se termino el juego\n", fallo);
    else
        printf("El juego se ha terminado\n");
}

int main(int argc, char *argv[]){

    const char *elegida;
    char adivinado[MAX], introducida[MAX], letra;
    int longitud, acierto = 0, aleatoria,
	fallo = 0, cambio = 0, nl_intro = 0;

    //Elige una palabra aleatoria de la lista
    srand(time(NULL));
    aleatoria = rand() % CANTIDAD(palabra);
    elegida = palabra[aleatoria];
    longitud = (int) strlen(elegida);

    //Rellena adivinado de -
    bzero(adivinado, MAX);

    for (int i=0; i<longitud; i++)
        adivinado[i] = '-';

    //Busca la letra que conincida
    do{

        letra = entrada();
	acierto = 0;
	longitud = (int) strlen(elegida);

	for(int n=0; n<longitud; n++){

            if(letra == elegida[n]){

	        adivinado[n] = letra;
	        acierto ++;
	    }
	}

        introducida[nl_intro] = letra;
	fallo += errores(acierto);
	cambio += acierto;

	printf("\t%s\n", adivinado);
	
	printf("Has introducido las letras : ");
	for(int n=0; n<=nl_intro; n++)
	    printf("%c, ", introducida[n]);
        
	nl_intro++;

	printf("\n");

    }while(fallo <= 3 && cambio < longitud);

    fin(fallo);

    return EXIT_SUCCESS;
}
