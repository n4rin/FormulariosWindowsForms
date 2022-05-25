# Colégio Técnico de Limeira - COTIL/UNICAMP
# Curso Técnico em Desenvolvimento de Sistemas
# Disciplina de Desenvolvimento de Aplicações Desktop
# Prof. José Alberto Matioli


# SISFIN - Sistema Simplificado de Gestão Financeira

* Colocar aqui os requisitos mínimos do sistema

## CATEGORIA
Categoria é o recurso que permitira agregar as contas segundo sua natureza.
O cadastro de categoria deverá possuir as seguintes informações:
- NOME (texto (50), obrigatório)
- DESCRIÇÃO (texto (100), opcional)
- TIPO (1 = Receita, 2 = Despesa, obrigatório)
- STATUS (1 = Ativa, 0 = Inativa, obrigatório)

Cada conta do plano de contas pertencerá, obrigatóriamente, a UMA e APENAS A UMA CATEGORIA.

Aula03 - DataGridView
* Acrescentar um controle DataGridView
* Criar uma classe Categoria
** Criar um método para gerar uma coleção de itens do tipo categoria, que irão preencher o grid
