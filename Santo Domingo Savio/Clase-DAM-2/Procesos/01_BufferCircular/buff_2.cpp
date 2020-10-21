#include <stdio.h>
#include <stdlib.h>

#define N 8

#define LONGITUD(x) ((x)->head - (x)->summit)
struct TQueue
{
    char buffer[N];
    int summit;
    int head;
};


struct TQueue buffer = {{""},0,0};

bool
push(struct TQueue *b, unsigned char c)
{
    if(LONGITUD(b) >= N)
        return false;

    b->buffer[(b->summit++) % N] = c;

    return true;
}

void
pop(struct TQueue *b)
{
    if(LONGITUD(b) == 0)
        return;

    b->head++;
}

void
print (struct TQueue *b)
{
    printf("\n");
    printf("Head: %i, Summit: %i\n", b->head, b->summit);

    for(int i = b->head; i > b->summit; i++ )
        printf("Caracter %i -> %c\n", i, b->buffer[i % N]);

    printf("\n\n");
}

int inicio()
{
    int accion;

    printf("Hola: Que quieres hacer:\n");

    printf("\t1. Introduccir caracteres.\n\t2. Ver la lista de caracteres.\n\t3. Borrar el 1º.\n\t4. Salir\n\t");
    scanf(" %i", &accion);

    return accion;
}

void introducir()
{
    char elecLetra;
    int elecNumero = 1;
    char letra;

    do
    {
        printf(" ¿Que caracter quieres introducir?\n\t");
        scanf(" %c", &letra);

        if(push(&buffer, letra))
        {
            printf("Caracter %c: Introducido con exito\n", letra);

            printf("¿Quieres introducir mas caracteres? s/n \n\t");
            scanf(" %c", &elecLetra);

            if(elecLetra == 's')
                elecNumero = 1;
            else
                elecNumero = 2;
        }
        else
            printf("Error al introducir");

    }
    while(elecNumero != 2);
}

int
main()
{
    int eleccion;

    do
    {
        eleccion = inicio();

        switch(eleccion)
        {
            case 1:
                introducir();
                break;
            case 2:
                print(&buffer);
                break;
            case 3:
                pop(&buffer);
                break;
            default:
                ;
        }
    }
    while(eleccion != 4);

    return EXIT_SUCCESS;
}
