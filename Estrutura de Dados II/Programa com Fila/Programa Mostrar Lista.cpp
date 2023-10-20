// inclusao das bibliotecas
#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

// definir a estrutura do n� da lista (encadeada dinamica simples)
typedef struct No{
	int info;
	struct No *prox;
} Lista; // lista � o tipo da estrutura do n� (toda vez que declararmos o tipo lista, ele segue com a estrutura definida)

// fun��o para verificar se a lista est� vazia ou n�o (p � o ponteiro que aponta para a lista)

bool isEmpty(Lista *p){
	
	if(p == NULL){
		// lista vazia
		return true;
	} else{
		//lista com elementos
		return false;
	}
}

// fun��o para inserir um novo elemento no inicio da lista
Lista * insereInicio(Lista *p, int x){
	Lista *novo;
	
	// alocar memoria para o novo n�
	novo = (Lista *) malloc(sizeof(Lista));
	
	// armazenar a info no novo n� (novo que aponta para info recebe x)
	
	novo->info = x;
	
	// conectar o novo n� na lista
	novo->prox = p; //(p � o inicio da lista)
	
	// apontar o ponteiro p para o novo elemento jogando o elemento para o o inicio da lista
	p = novo;
	return p;
}

// fun��o para inserir um novo elemento no final da lista
Lista * insereFinal(Lista *p, int x){
	
	// declarar dois ponteiros para a lista
	// o ponteiro novo aponta para o novo elemento da lista
	// o ponteiro aux percorre a lista para encontrar seu fim
	Lista *novo, *aux;
	
	//alocar memoria para o ponteiro novo
	novo = (Lista *) malloc(sizeof(Lista));
	
	// armazenar a informa��o no novo n� da lista
	novo->info = x;
	
	// o ponteiro prox do n� novo apontar para null (ser� o ultimo elemento da lista)
	novo->prox = NULL;
	
	// considerar lista vazia
	if(isEmpty(p)){
		p = novo;
	} else{
		aux = p;
		while(aux->prox != NULL){
			aux = aux->prox;
		}
		aux->prox = novo;
	}
	return p;	
}
// fun��o para mostrar cada um dos elementos (n�s) da lista
void mostrarLista(Lista *p) { 
	
	//	(ponteiro auxiliar para percorrer a lista)
	Lista *aux;  
	
	if(isEmpty(p)){
		printf("Lista Vazia!!\n");
	} else{
		aux = p;
		// o loop s� para quando aux � null, ou seja quando chega no fim da lista
		while(aux != NULL){
			// (vai mostrar o valor que esta armazenado na info)
			printf("%d -> ", aux->info); 
			//(pra apontar para o proximo elemento da lista)
			aux = aux->prox; 
		}
	}
}

// funcao pra localizar um elemento da lista
// caso o elemento perten�a a lista, ser� retornado seu endereco
// caso contrario retornara NULL
Lista * buscaElemento(Lista *p, int x){
	// declarar o ponteiro aux pra percorrer a lista, caso ela tenha elementos
	Lista *aux;
	aux = p; // p � o inicio da lista
	
	while(aux != NULL && aux->info != x){
		aux = aux->prox;
	}
	
	// aux aponta para null significa lista vazia ou o
	// elemento nao pertence a lista
	//aux aponta para o elemento significa que o elemento
	// pertence a lista. portanto, aux retorna null ou o end do elemento
	return aux;
}

Lista * buscaInsere(Lista *p, int x){
	Lista *ant = NULL, *aux, *novo;
	novo = (Lista *) malloc(sizeof(Lista));
	novo->info;
	
	// lista vazia
	if(p == NULL){
		novo->prox = p;
		p = novo;
	} else{
		aux = p;
		while(aux != NULL && aux->info !=x){
			ant = aux;
			aux = aux->prox;
		} if (ant == NULL){
			novo->prox = NULL;
 			p = novo;
		} else{
			novo->prox = aux;
			ant->prox = novo;
		}
	}
	return p;
}

Lista *removeInicio(Lista *p){
	Lista *aux;
	
	if(p != NULL){
		aux = p;
		p = p->prox;
		free(aux);
	}
	return p;
}

Lista *removeFim(Lista *p){
	Lista *aux, *ant = NULL;
	
	if(p != NULL){
		aux = p;
		while(aux->prox != NULL){
			ant = aux;
			aux = aux->prox;
		} if(ant == NULL){
			p = aux->prox;
		} else{
			ant->prox = aux->prox;
			free(aux);
		}
		return p;
	}
}


// busca o anterior
Lista *buscaAnt(Lista *p, intx){
	Lista *aux, *ant = NULL;
	aux = p;
	
	while(aux != NULL && aux->prox !=x){
		ant = aux;
		aux = aux->prox;
	} if(aux == NULL){
		ant = NULL;
		return ant;
	}
	
}

int main(){
	int op = 0, info, e;
	
	// p � o ponteiro que aponta para o inicio da lista
	Lista *p = NULL; //iniciando a lista vazia (SEMPRE INICIAR VAZIA)
	
	do{
		printf("\n1 - Inserir no Inicio da Lista\n");
		printf("2 - Inserir no Fim da Lista\n");
		printf("3 - Mostrar os Elementos da Lista\n");
		printf("4 - Buscar Elemento da Lista\n");
		printf("5 - Buscar e Inserir um Elemento\n");
		printf("6 - Remover Elemento do Inicio\n");
		printf("7 - Remover Elemento do Fim\n");
		printf("8 - Remover No da Lista\n");
		printf("9 - Fim do Programa\n");
		printf("Escolha sua Opcao: ");
		scanf("%d", &op);
		
		switch(op){
			case 1:
				printf("\nDigite um Novo Elemento da Lista: ");
				scanf("%d", &info);
				p = insereInicio(p, info); // (recebendo no inicio e enviando para a fun��o)
				break;
			case 2:
				printf("\nDigite um Novo Elemento da Lista: ");
				scanf("%d", &info);
				p = insereFinal(p, info);
				break;
			case 3:
				system("cls"); // limpando a tela
				printf("\n ------- Lista -------\n");
				mostrarLista(p);
				printf("\n ----------------------\n");
				getch();
				break;
			case 4:
				printf("\nDigite o Elemento que Deseja Buscar: ");
				scanf("%d", &info);
				p = buscaElemento(p, info);
				printf("\nEndereco do Elemento: %d", p);
				break;
			case 5:
				printf("\nDigite o Elemento que Deseja Buscar e Inserir no Lugar: ");
				scanf("%d", &info);
				p = buscaInsere(p, info);
				printf("\nElemento Inserido com Sucesso!");
				break;
			case 6:
				p = removeInicio(p);
				printf("\nElemento Removido do Inicio\n");
				break;
			case 7:
				p = removeFim(p);
				printf("\nElemento Removido do Fim!\n");
				break;
			case 8:
				break;
			case 9:
				printf("\nSaindo do Programa...\n");
				break;
			default:
				printf("\nOpcao Invalida!! Tente Novamente\n");
				break;
		}
	} while(op != 9);
	return 0;
}
