# Mega_Sena_Git


Este programa foi desenvolvido no intuito de analisar as chances, de maneira prática e visual, de se ganhar em uma loteria brasileira, tendo como modelo de estudo a loteria "Mega Sena", a maior modalidade de lotérica do Brasil.

*Este é um programa desenvolvido como um aplicativo de console, utilizando a plataforma .NET Framework versão 4.8, linguagem de programação C# e utilizando a plataforma de desenvolvimento Microsoft Visual Studio 2017.*

*Para acessar o documento do projeto para o Visual Studio 2017, acesse o arquio mega_sena.sln, presente no endereço Mega_Sena_Git/mega_sena/mega_sena.sln deste git*

*Para acessar o documento contendo o código deste programa, acesse o arquivo Program.cs, presente no endereço Mega_Sena_Git/mega_sena/mega_sena/Program.sln deste git*





FUNCIONAMENTO DO PROGRAMA

#Ao inciar o programa, será questionado se o usuário deseja utilizar as configurações padrões do programa. Essas configurações são as seguintes:

a) Dias entre cada sorteio: 3 dias

b) Preço por ticket:R$ 4,50

c) Ticke comprados: 6 tickets

d) Quantidade de números escolhidos por ticket = 6 números

e) Reserva: R$ 23000,00

f) Salário: R$ 985,00


g) Premio ao acertar 6 pontos: R$ 11323343,69

h) Premio ao acertar 5 pontos: R$ 15996,75

i) Premio ao acertar 4 pontos: R$ 458,94


j) Número mínimo na cartela do sorteio: 1

k) Número máximo na cartela do sorteio: 60

#Caso o usuário recuse utilizar as configurações padrões, será necessário que seja informado, manualmente os valores (deverá ser preenchido os valores para os itens de (a) á (i), os itens (j) e (k) permaneceram os mesmo).

#Após definidos os valores de controle, o programa entrará em uma estrutura de repetição while, que será interrompido somente se o valor contido na Reserva, for igual ou menor a 0.



#Dentro da estrutura de repetição while, o processo é dividido em 6 etapas:

I) Gerando a sequência ganhadora

II) Gerando a sequência do jogador

III) Descontando o valor do ticket

IV) Verificando se foi o vencedor do sorteio

V) Ajustando os dias

VI) Mostrando os dados
