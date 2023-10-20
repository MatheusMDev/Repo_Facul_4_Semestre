/* Matheus Augusto Pongelupi Miranda 
Curso: Ciencia da Computação

*/
#include <stdio.h>
#include <stdlib.h>

typedef struct No {
    int info;
    struct No *prox;
} Lista;

Lista *insereFim(Lista *p, int x) {
    Lista *aux, *novo;
    novo = (Lista*)malloc(sizeof(Lista));
    novo->info = x;
    novo->prox = NULL;
    
    if (p == NULL) {
        p = novo;
    } else {
        aux = p;
        while (aux->prox != NULL) {
            aux = aux->prox;
        }
        aux->prox = novo;
    }
    return p;
}

void mostraLista(Lista *p) {
    Lista *aux;
    
    if (p == NULL) {
        printf("\nLista Vazia!");
    } else {
        aux = p;
        while (aux != NULL) {
            printf("%d-> ", aux->info);
            aux = aux->prox; 
        }
    }
}

void liberaLista(Lista *p) {
    while (p != NULL) {
        Lista *aux = p;
        p = p->prox;
        free(aux);
    }
}

Lista *unirListas(Lista *lista1, Lista *lista2) {
    Lista *lista3 = NULL;
    Lista *aux1 = lista1;
    Lista *aux2 = lista2;
    
    while (aux1 != NULL) {
        lista3 = insereFim(lista3, aux1->info);
        aux1 = aux1->prox;
    }
    
    while (aux2 != NULL) {
        lista3 = insereFim(lista3, aux2->info);
        aux2 = aux2->prox;
    }
    
    return lista3;
}

int main() {
    Lista *lista1 = NULL;
    Lista *lista2 = NULL;
    Lista *lista3 = NULL;
    int i, x;
    
    printf("Digite a Lista 1 :\n");
    for(i = 0; i < 3; i++) {
        scanf("%d", &x);
        lista1 = insereFim(lista1, x);
    }
    
    printf("Digite a Lista 2 :\n");
    for(i = 0; i < 3; i++) {
        scanf("%d", &x);
        lista2 = insereFim(lista2, x);
    }
    
    // Unir as listas e armazenar o resultado em lista3
    lista3 = unirListas(lista1, lista2);
    
    // Mostra as listas
    printf("-------- Lista 1 --------\n");
    mostraLista(lista1);
    printf("\n-------- Lista 2 --------\n");
    mostraLista(lista2);
    printf("\n-------- Lista 3 --------\n");
    mostraLista(lista3);
    
    // Liberar a memória alocada para as listas
    liberaLista(lista1);
    liberaLista(lista2);
    liberaLista(lista3);
    
    return 0;
}
