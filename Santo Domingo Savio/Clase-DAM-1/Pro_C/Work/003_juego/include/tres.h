#ifndef __TRES_H__
#define __TRES_H__

#include <stdio.h>
#include <stdlib.h>

#define MAX_JUG 9

struct TCoordenada {
    int x;
    int y;
};

struct TMesa{
    int localizacion;
    struct TCoordenada datos[MAX_JUG];
    struct TCoordenada j1[MAX_JUG];
    struct TCoordenada j2[MAX_JUG];
};

#ifdef __cplusplus
extern "C"{
#endif

    void mesa(struct TMesa *pos);
    void jugadas(int x, int y, struct TMesa *pos);
#ifdef __cplusplus
}
#endif

#endif
