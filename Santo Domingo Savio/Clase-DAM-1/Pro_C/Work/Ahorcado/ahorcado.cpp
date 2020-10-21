#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <time.h>

#define MAX 29
#define CANTIDAD(x) (sizeof( (x) ) / sizeof(char *) - 1)

//Pide al usuario una letra a buscar
char entrada(){
    char opcion;

    printf("Escribe una letra : ");
    scanf(" %c", &opcion);

    return opcion;


}

const char *palabra[] = {
    "amalgama",
    "narcolepsia",
    "alcorque",
    "suricato",
    "amapola",
    "parguela",
    "bonita",
    "shuriken",
    "hermoso",
    "panenteismo",
    "nemesis",
    "anabasis",
    "antítesis",
    "origen",
    "artropodo",
    NULL
};

int main(int argc, char *argv[]){

    const char *elegida;
    char adivinado[MAX], letra;
    int acierto = 0, aleatoria, errores = 0;

    //Elige una palabra aleatoria de la lista
    srand(time(NULL));
    aleatoria = rand() % CANTIDAD(palabra);
    elegida = palabra[aleatoria];

    //Rellena adivinado de -
    bzero(adivinado, MAX);
    for (int i=0; i<(int) strlen(elegida); i++)
        adivinado[i] = '-';

    //Busca la letra que conincida
    do{
	letra = entrada();

	for(int n=0; n<(int) strlen(elegida); n++){
            if(letra == elegida[n]){
	        adivinado[n] = letra;
	        acierto += 1;

		printf("%i\n", acierto);
	    }
	}

	printf("\t%s\n", adivinado);
        printf("\t%s\n", elegida);

	if (acierto == 0){
	    errores++;
            printf("%i\n", errores);
       }
    }while(errores<=3);

    return EXIT_SUCCESS;
}
