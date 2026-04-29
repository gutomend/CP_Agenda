# FIAP

## Engenharia de Software (3ESPG)

### HandsOn 04 – Agenda com Fuso Horário

---

## 👥 Integrantes

| Nome             | RM     |
| ---------------- | ------ |
| Augusto Mendonça | 558371 |
| Gabriel Vasquez  | 557056 |
| Gustavo Oliveira | 559163 |

---

## 📚 Descrição do Projeto

Este projeto consiste no desenvolvimento de uma aplicação console em C# para gerenciamento de compromissos, com suporte a diferentes fusos horários.

A aplicação permite o cadastro e consulta de compromissos considerando a conversão correta de datas e horários entre diferentes regiões.

---

## 🎯 Objetivo

Aplicar conceitos de manipulação de datas e horários em C#, utilizando fusos horários (`TimeZoneInfo`) e estruturas básicas de programação.

---

## 🛠️ Tecnologias Utilizadas

* Linguagem: C#
* Plataforma: .NET
* Ambiente de Desenvolvimento: Visual Studio

---

## ⚙️ Funcionalidades

* Cadastro de compromissos contendo:

  * Descrição
  * Data e hora
  * Timezone

* Exibição de compromissos:

  * Do dia atual (com base em um timezone informado ou padrão do sistema)
  * De uma data específica informada pelo usuário

---

## ▶️ Execução do Projeto

1. Abrir o projeto no Visual Studio
2. Compilar e executar (F5)
3. Utilizar o menu interativo no console para navegar entre as opções

---

## 🧪 Exemplos de Entrada

### Cadastro de compromisso:

* Descrição: Reunião
* Data e hora: 2026-04-28 14:00
* Timezone: E. South America Standard Time

---

## 🌎 Observações sobre Timezone

A aplicação utiliza identificadores de fuso horário do Windows.

Exemplos:

* E. South America Standard Time (Brasil)
* UTC
* Pacific Standard Time

---

## ⚠️ Observações

* O formato de data deve ser obrigatoriamente: `yyyy-MM-dd HH:mm`
* Os dados são armazenados apenas em memória (não persistem após o encerramento da aplicação)
* É necessário informar corretamente o timezone para evitar erros

---

## 📌 Considerações Finais

O projeto atende aos requisitos propostos, demonstrando o uso de estruturas básicas da linguagem C# e manipulação de datas com suporte a fusos horários.
