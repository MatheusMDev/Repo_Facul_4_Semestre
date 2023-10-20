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

// fun��o para inserir o n� no inicio da lista
Lista * insereInicio(Lista *p, int x){
	Lista *novo;
	
	// alocar memoria para o novo n�
	novo = (Lista *) malloc(sizeof(Lista));
	
	// armazenar a info no novo n� (novo que aponta para info recebe x)
	
	novo->info = x;
	
	// conectar o novo n� na lista
	novo->prox = p; //(p � o inicio da lista)
	
	// apontar o ponteiro p para o novo elemento jogando o elemento para o o inicio da lista
	p->novo;
	return p;
}

// fun��o para mostrar cada um dos elementos (n�s) da lista
void mostrarLista(Lista *p) { 
	
	//	(ponteiro auxiliar para percorrer a lista)
	Lista *aux;  
	
	// testar se est� vazio ou com elementos
	bool vazio; 
	vazio = isEmpty(p);
	
	if(vazio == NULL){
		printf("Lista Vazia!!\n");
	} else{
		aux = p;
		// o loop s� para quando aux � null, ou seja quando chega no fim da lista
		while(aux != null){
			// (vai mostrar o valor que esta armazenado na info)
			printf("%d -> ", aux->info); 
			//(pra apontar para o proximo elemento da lista)
			aux = aux->prox; 
		}
	}
}

int main(){
	int op = 0, info;
	
	// p � o ponteiro que aponta para o inicio da lista
	Lista *p = NULL; //iniciando a lista vazia (SEMPRE INICIAR VAZIA)
	
	do{
		printf("1 - Inserir no Inicio da Lista\n");
		printf("2 - Mostrar os Elementos da Lista\n");
		printf("3 - Fim do Programa\n");
		printf("Escolha sua Op��o: ");
		scanf("%d", &op);
		
		switch(op){
			case 1:
				printf("\nDigite um Novo Elemento da Lista: ");
				scanf("%d" &info);
				p = insereInicio(p, info); // (recebendo no inicio e enviando para a fun��o)
				break;
			case 2:
				system("cls"); // limpando a tela
				printf("\n ------- Lista -------");
				mostrarLista(p);
				printf("\n ---------------------- ");
				getch();
				break;
			case 3:
				printf("\n Saindo do Programa...");
				break;
			default:
				printf("\n Op��o Inv�lida!! Tente Novamente");
				break;
		}
	} while(op != 3);
	return 0;
}
