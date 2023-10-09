// Teste c++++++.cpp : Este arquivo contém a função 'main'. A execução do programa começa e termina ali.
//

#include <iostream>
using namespace std;

int main()
{
    std::cout << "Hello World!\n";
    cout << "Farei alguns testes para exercitar \n";

    int idade;

    cout << "Informe quantos anos voce tem? \n";
    cin >> idade;
    cout << "Voce tem " <<idade<<" anos de idade \n";

    string nome;

    cout << "Informe seu Nome: \n";
    cin >> nome;
    cout << "Seu nome e " << nome <<" \n";

    cout << "Entao Sr(a) " << nome << " , faremos um questinario com voce para avaliarmos, esta certo disso?\n";
    cout << "Responda com Sim ou Nao\n";
    string escolha;

    cin >> escolha;

    if (escolha == "Sim") {
        cout << "Excelente entao prossiguiremos com a entrevista \n";

    }
    
    if (escolha == "Nao") {
        cout << "Entao encerraremos sua entrevista aqui muito obrigado \n";
        //return;
    }

    int questoes[10] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

    int respostas[10] = {55, 48, 50, 50, 50, 100, 900, 40, 2451, 3892};

    int acertos[10];

    int pontos = 0;
        
    cout << "A seguir a " << questoes[0] << " questao e quanto e 22 + 44 - 11 ? \n";
    cin >> acertos[0];

    if (respostas[0] == acertos[0]) {
        cout << " Parabens voce acertou a questao!!! \n";
        pontos = pontos + 1;
    }
    else {
        cout << "Infelizmente voce errou \n";
        pontos = pontos - 1;
    }

    cout << " Para a questao " << questoes[1] << "(78 - 64 + 10) x 2? \n";
    cin >> acertos[1];

    if (respostas[1] == acertos[1]) {
        cout << "Parabens voce acertou \n";
        pontos = pontos + 1;
    }
    else {
        cout << "Infelizmente voce errou \n ";
        pontos = pontos - 1;
    }

    cout << questoes[2] << " questao (100 x 2) / 4 ? \n";
    cin >> acertos[2];

    if (respostas[2] == acertos[2]) {
        cout << "Parabens voce acertou!!! \n";
        pontos = pontos + 1;
    }
    else {
        cout << "Infelizmente voce errou a questao \n ";
        pontos = pontos - 1;
    }
    
    cout << questoes[3] << " questao (450 - 150 + 50) - 300 ? \n";
    cin >> acertos[3];

    if (respostas[3] == acertos[3]) {
        cout << "Parabens voce acertou!!! \n";
        pontos = pontos + 1;

    }
    else {
        cout << "Infelizmente voce errou a questao \n ";
        pontos = pontos - 1;
    }

    cout << questoes[4] << " questao (100 x 2) / 4 ? \n";
    cin >> acertos[4];

    if (respostas[4] == acertos[4]) {
        cout << "Parabens voce acertou!!! \n";
        pontos = pontos + 1;
    }
    else {
        cout << "Infelizmente voce errou a questao \n ";
        pontos = pontos - 1;
    }

    cout << questoes[5] << " questao 200 + 600 / 8 ? \n";
    cin >> acertos[5];

    if (respostas[5] == acertos[5]) {
        cout << "Parabens voce acertou!!! \n";
        pontos = pontos + 1;

    }
    else {
        cout << "Infelizmente voce errou a questao \n ";
        pontos = pontos - 1;
    }

    cout << questoes[6] << " questao (900/9) x (900-891) ? \n";
    cin >> acertos[6];

    if (respostas[6] == acertos[6]) {
        cout << "Parabens voce acertou!!! \n";
        pontos = pontos + 1;

    }
    else {
        cout << "Infelizmente voce errou a questao \n ";
        pontos = pontos - 1;
    }

    cout << questoes[7] << " questao (49/7) + (78 - 45) ? \n";
    cin >> acertos[7];

    if (respostas[7] == acertos[7]) {
        cout << "Parabens voce acertou!!! \n";
        pontos = pontos + 1;

    }
    else {
        cout << "Infelizmente voce errou a questao \n ";
        pontos = pontos - 1;
    }

    cout << questoes[8] << " questao (1781 - 964) x 3 ? \n";
    cin >> acertos[8];

    if (respostas[8] == acertos[8]) {
        cout << "Parabens voce acertou!!! \n";
        pontos = pontos + 1;

    }
    else {
        cout << "Infelizmente voce errou a questao \n ";
        pontos = pontos - 1;
    }

    cout << questoes[9] << " questao ((2 x 2) + (864 / 4) x (6 x 3) ) ? \n";
    cin >> acertos[9];

    if (respostas[9] == acertos[9]) {
        cout << "Parabens voce acertou!!! \n";
        pontos = pontos + 1;

    }
    else {
        cout << "Infelizmente voce errou a questao \n ";
        pontos = pontos - 1;
    }

    switch(pontos) {
    case '1':
        cout << "Voce reprovou!! \n";
        break;

    case '2':
        cout << "Voce reprovou!! \n";
        break;

    case '3':
        cout << "Voce reprovou!! \n";
        break;

    case '4':
        cout << "Voce quase chegou na media \n";
        break;

    case '5':
        cout << "Voce chegou na media \n";
        break;

    case '6':
        cout << "Voce passou por pouco da media \n";
        break;

    case '7':
        cout << "Sua media foi boa \n";
        break;

    case '8':
        cout << "Sua media foi muito boa \n";
        break;

    case '9':
        cout << "Sua media foi excelente \n";
        break;

    case '10':
        cout << "Sua media foi perfeita \n";
        break;
    }

    cout << " Sua Nota e de : " << pontos << "\n";

}

// Executar programa: Ctrl + F5 ou Menu Depurar > Iniciar Sem Depuração
// Depurar programa: F5 ou menu Depurar > Iniciar Depuração

// Dicas para Começar: 
//   1. Use a janela do Gerenciador de Soluções para adicionar/gerenciar arquivos
//   2. Use a janela do Team Explorer para conectar-se ao controle do código-fonte
//   3. Use a janela de Saída para ver mensagens de saída do build e outras mensagens
//   4. Use a janela Lista de Erros para exibir erros
//   5. Ir Para o Projeto > Adicionar Novo Item para criar novos arquivos de código, ou Projeto > Adicionar Item Existente para adicionar arquivos de código existentes ao projeto
//   6. No futuro, para abrir este projeto novamente, vá para Arquivo > Abrir > Projeto e selecione o arquivo. sln
