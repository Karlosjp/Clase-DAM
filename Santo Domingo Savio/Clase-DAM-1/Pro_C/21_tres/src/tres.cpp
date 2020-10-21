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

bool contx(struct TDato *contador, int tablero[][3]){
    if(contador->x == -3){
        dibujar(tablero);

        printf("El ganador es O\n");

        return true;

    }else if(contador->x == 3){
        dibujar(tablero);

        printf("El ganador es X\n");

        return true;
    }

    contador->x = 0;

    return false;
}

bool conty(struct TDato *contador, int tablero[][3]){
    if(contador->y == -3){
        dibujar(tablero);

        printf("El ganador es O\n");

        return true;

    }else if(contador->y == 3){
        dibujar(tablero);

        printf("El ganador es X\n");

        return true;
    }

    contador->y = 0;

    return false;
}

//Contador Horizontal
bool conteoh(int tablero[][3], struct TDato *contador){
    for(int v=0; v<3; v++){
        for(int h=0; h<3; h++){
            contador->y += tablero[v][h];
        }

        if(contx(contador, tablero))
            return false;
    }

    return true;
}

//Contador Vertical
bool conteov(int tablero[][3], struct TDato *contador){
    for(int v=0; v<3; v++){
        for(int h=0; h<3; h++){
            contador->x += tablero[h][v];
        }

        if(contx(contador, tablero))
            return false;
    }

    return true;
}

//Contador Diagonal
bool conteod(int tablero[][3], struct TDato *contador){
    // \Contador
    int d2 = 2;

    for(int d1=0 ; d1<3; d1++, d2--){
        contador->y += tablero[d1][d2];

        if(conty(contador, tablero))
            return false;
    }


    // /Contador
    d2 = 2;

    for(int d1=0; d1<3; d1++, d2--){
        contador->x += tablero[d2][d1];

        if(contx(contador, tablero))
            return false;
    }

    return true;
}

//Guarda las jugadas
void jugadas(struct TDato ficha, struct TMesa *pos){
    pos->datos[pos->localizacion].x = ficha.x;
    pos->datos[pos->localizacion].y = ficha.y;

    pos->localizacion++;
}

//Si posisión correcta
bool comprobar(struct TDato *ficha){
    if (ficha->x >=0 && ficha->x <=2){
        if(ficha->y >=0 && ficha->y <=2)
            return false;
    }

    printf("No existe esa posición\n");

    return true;
}

//Pregunta hasta posición correcta
struct TDato pregunta(){
    struct TDato ficha;

    do{
        printf("¿Donde pones ficha?\n ej. X Y: ");
        scanf("%i %i", &ficha.x, &ficha.y);
    }while(comprobar(&ficha));

    return ficha;
}
