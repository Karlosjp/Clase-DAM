

#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    double x, num, pot;
    double e = 1;

    printf("Escribe el numero, valor de X y potencia: ");
    scanf( " %lf, %lf, %lf", &num, &x, &pot);

    for (int i = 1; i <= pot; i++)
        e = e * x; 
    num = e * num;

    printf("%.2lf, %.2lf %.2lf, %lf \n", num, x, pot, e);

    return EXIT_SUCCESS;

}
