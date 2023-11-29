#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

typedef struct No
{
    char info;
    struct No *prox;
} ListaC; // Lista circular

// Função para inserir um nó no final da lista
ListaC *inserirFim(ListaC **p, char x)
{
    ListaC *novoNo = (ListaC *)malloc(sizeof(ListaC));
    novoNo->info = x;

    if (*p == NULL)
    {
        *p = novoNo;
        novoNo->prox = *p;
    }
    else
    {
        ListaC *temp = *p;
        while (temp->prox != *p)
        {
            temp = temp->prox;
        }
        temp->prox = novoNo;
        novoNo->prox = *p;
    }
}

// Função para mostrar a lista
void exibirLista(ListaC *p)
{
    if (p == NULL)
        return;

    ListaC *temp = p;
    do
    {
        printf("%c", temp->info);
        temp = temp->prox;
    } while (temp != p);
    printf("\n");
}

// Função para criptografar a frase
void criptografia(ListaC **p, int x)
{
    if (*p == NULL)
        return;

    ListaC *temp = *p;
    do
    {
        if (temp->info >= 'A' && temp->info <= 'Z')
        {
            temp->info = (temp->info - 'A' - x + 26) % 26 + 'A';
        }
        temp = temp->prox;
    } while (temp != *p);
}

// Função para liberar a memória alocada para a lista
void liberaMemoria(ListaC **p)
{
    if (*p == NULL)
        return;

    ListaC *a = *p;
    ListaC *b = *p;

    do
    {
        b = a->prox;
        free(a);
        a = b;
    } while (a != *p);

    *p = NULL;
}

int main()
{
    ListaC *p = NULL;
    char frase[100];
    int y;


    printf("[SISTEMA] Frase inserida: ");
    scanf("%99[^\n]", frase);

    for (int i = 0; i < strlen(frase); i++)
    {
            inserirFim(&p, frase[i]);
    }

    // Recebe o valor de N
    printf("[SISTEMA] Valor de N: ");
    scanf("%d", &y);

    // Criptografa a frase
    criptografia(&p, y)	;

    // Mostra a frase original e a frase criptografada
    printf("[SISTEMA] Frase criptografada: ");
    exibirLista(p);

    // Libera a memória alocada para a lista
    liberaMemoria(&p);

    return 0;
}
