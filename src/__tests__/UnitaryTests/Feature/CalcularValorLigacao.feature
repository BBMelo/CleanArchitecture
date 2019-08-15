#language: pt-br
Funcionalidade: Eu, enquanto usuário quero saber quanto irei pagar em uma ligação.                

@basic
Cenário: Calcular o valor de uma ligação com o ddd origem 11 e destino 16 sem nenhum plano FaleMais da VxTel
Dados Quando eu informar corretamente os dados de origem|destino|duracao|plano 11|16|20|0
Então O resultado do calculo deve ser 38,00

Cenário: Calcular o valor de uma ligação com o ddd origem 11 e destino 17 sem nenhum plano FaleMais da VxTel
Dados Quando eu informar corretamente os dados de origem|destino|duracao|plano 11|17|80|0
Então O resultado do calculo deve ser 136,00

Cenário: Calcular o valor de uma ligação com o ddd origem 18 e destino 11 sem nenhum plano FaleMais da VxTel
Dados Quando eu informar corretamente os dados de origem|destino|duracao|plano 18|11|200|0
Então O resultado do calculo deve ser 380,00

Cenário: Calcular o valor de uma ligação com o ddd origem 18 e destino 17 sem nenhum plano FaleMais da VxTel
Dados Quando eu informar corretamente os dados de origem|destino|duracao|plano 18|17|100|0
Então O resultado do calculo deve ser 0,00

Cenário: Calcular o valor de uma ligação com o ddd origem 11 e destino 16 com o plano FaleMais30 VxTel
Dados Quando eu informar corretamente os dados de origem|destino|duracao|plano 11|16|20|1
Então O resultado do calculo deve ser 0,00

Cenário: Calcular o valor de uma ligação com o ddd origem 11 e destino 17 com o plano FaleMais60 VxTel
Dados Quando eu informar corretamente os dados de origem|destino|duracao|plano 11|17|80|2
Então O resultado do calculo deve ser 37,40

Cenário: Calcular o valor de uma ligação com o ddd origem 18 e destino 11 com o plano x FaleMais120 VxTel
Dados Quando eu informar corretamente os dados de origem|destino|duracao|plano 18|11|200|3
Então O resultado do calculo deve ser 167,20

Cenário: Calcular o valor de uma ligação com o ddd origem 18 e destino 17 com o plano x FaleMais30 VxTel
Dados Quando eu informar corretamente os dados de origem|destino|duracao|plano 18|17|100|1
Então O resultado do calculo deve ser 0,00