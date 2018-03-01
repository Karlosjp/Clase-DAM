#include <stdio.h>
#include <stdlib.h>
#include <pthread.h>

#define N 80000
#define M 100000

struct TPila{
    int primos[N];
    int cima;
};

struct TPila pila = {{}, 0};

int push (int n){

    if(pila.cima < N)
        pila.primos[pila.cima] = n;
    else
        return 1;

    return 0;
}

void* busca_primo(void* argu)
{
    int inicio = 2 + (*(int*)argu) - M;
    int candidato = inicio;
    int num = *((int*) argu);
    int cantidad = 0;

    while(1){
        int factor;
        int is_prime = 1;

        for(factor = inicio; factor < candidato; ++factor)
            if(candidato % factor == 0){
                is_prime = 0;
                break;
            }

        if(is_prime)
        {
            push(candidato);
            ++cantidad;
        }

        if(--num == (inicio-2))
            return (void*) cantidad;

        ++candidato;
    }

    return NULL;
}

int main(int argc, char *argv[])
{
    pthread_t threads[2];
    int which_prime = M;
    int prime;

    for(int i = 0; i<2; i++){
        pthread_create(&threads[i], NULL, &busca_primo, &which_prime);
        which_prime += M;
    }

    for(int j = 0; j<2; j++){
        pthread_join(threads[j], (void*)&prime);
        printf("El hilo %ith ha sacado %i numeros.\n", j, prime);
    }

    return EXIT_SUCCESS;
}
