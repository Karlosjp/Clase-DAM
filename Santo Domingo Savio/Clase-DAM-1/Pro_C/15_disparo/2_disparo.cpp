
#include <stdio.h>
#include <stdlib.h>

#define X 0
#define Y 1
#define AX 0
#define AY -9.8
#define DELTA 0.01

#define DIM 2
#define DELTA .1

#define X 0
#define Y 1

int main(int argc, char *argv[]){
    double t = 0;
    double a[DIM] = { 0., -10. },
           v[DIM] = { 20., 40. },
           s[DIM] = { 0., 0. };

/*    for(int i = 0; v[Y]>0; i++){
        v[X] += AX * DELTA;
        v[Y] += AY * DELTA;

        printf("%.2lf, %.2lf | ", v[X], v[Y]);
    }

    printf("\n");
*/
    return EXIT_SUCCESS;

}
