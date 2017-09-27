#include <string.h>
#include <unistd.h>

#include "tres.h"

#define X       1
#define O      -1

//Dibuja el tablero
void dibujar(int tablero[][3]){
    system("clear");

    for(int i=0; i<3; i++)
        printf("\t%iY",i);

    printf(" \n");

    for(int v=0; v<3; v++){
        printf("%iX {", v);

        for(int h=0; h<3; h++){
            if(tablero[v][h]== X)
                printf("\tX");
            else if(tablero[v][h]== O)
                printf("\tO");
            else
                printf("\t_");
        }

        printf("\t}\n");
        printf("   ");

        for(int l=0; l<29;l++)
            printf("-");

        printf(" \n");
    }

    printf(" \n");
}

bool conteoh(int tablero[][3]){
    struct TDato contador;
    bzero(&contador, sizeof(contador));

    //Contador Horizontal
    for(int v=0; v<3; v++){
        for(int h=0; h<3; h++){
            contador.y += tablero[v][h];
        }

        if(contador.y == -3){
            printf("El ganador es O\n");
            return false;
        }else if(contador.y == 3){
            printf("El ganador es X\n");
            return false;
        }

        contador.y = 0;
    }

    return true;
}

bool conteov(int tablero[][3]){
    struct TDato contador;
    bzero(&contador, sizeof(contador));


    //Contador Vertical
    for(int v=0; v<3; v++){
        for(int h=0; h<3; h++){
            contador.x += tablero[h][v];
        }

        if(contador.x == -3){
            printf("El ganador es O\n");
            return false;
        }else if(contador.x == 3){
            printf("El ganador es X\n");
            return false;
        }

        contador.x = 0;
    }

    return true;
}

//Contador Diagonal
bool conteod(int tablero[][3]){
    struct TDato contador;
    bzero(&contador, sizeof(contador));

    // \Contador
    int d2 = 2;
    contador.y = 0;

    for(int d1=0 ; d1<3; d1++, d2--){
        contador.x += tablero[d1][d2];

        if(contador.y == -3){
            printf("El ganador es O\n");
            return false;
        }else if(contador.y == 3){
            printf("El ganador es X\n");
            return false;
        }
    }

    // /Contador
    d2 = 2;
    contador.x = 0;

    for(int d1=0; d1<3; d1++, d2--){
        contador.x += tablero[d2][d1];

        if(contador.x == -3){
            printf("El ganador es O\n");
            return false;
        }else if(contador.x == 3){
            printf("El ganador es X\n");
            return false;
        }
    }

    return true;
}

//Guarda las jugadas
void jugadas(struct TDato ficha, struct TMesa *pos){

    pos->datos[pos->localizacion].x = ficha.x;
    pos->datos[pos->localizacion].y = ficha.y;

    pos->localizacion++;
}

struct TDato pregunta(){
    struct TDato ficha;

    printf("¿Donde pones ficha?\n ej. X Y: ");
    scanf("%i %i", &ficha.x, &ficha.y);

    return ficha;
}
