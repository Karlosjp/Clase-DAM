#ifndef __TRES_H__
#define __TRES_H__

#include <stdio.h>
#include <stdlib.h>

#define MAX_JUG 9

struct TDato {
    int x;
    int y;
};

struct TMesa{
    int localizacion;
    struct TDato datos[MAX_JUG];
};

#ifdef __cplusplus
extern "C"{
#endif

    void dibujar(int tablero[][3]);
    void jugadas(struct TDato ficha, struct TMesa *pos);
    struct TDato pregunta();
    bool conteoh(int tablero[][3], struct TDato *contador);
    bool conteov(int tablero[][3], struct TDato *contador);
    bool conteod(int tablero[][3], struct TDato *contador);


#ifdef __cplusplus
}
#endif

#endif
