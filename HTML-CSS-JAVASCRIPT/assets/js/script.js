/*
case sensitive = reconhece letras maiusculas e minusculas;

var - pode ser chamado por todo o projeto, nao se prende a um escopo, é semelhante a uma class public;
let - só pode ser chamado dentro do escopo mencionado;
const - pode ser chamado por todo o projeto, mas é uma variavel que nao pode ser alterada, uma constante;

por Tag: getElementByTagName()
por Id: getElementById()
por Nome: getElementByName()
por Classe: getElementByClassName()
Por Seletor: querySeletor()
*/
let nome = window.document.getElementById('nome')
let email = document.querySelector('#email')
let assunto = document.querySelector('#assunto')
let nomeOk = false
let emailOk = false
let assuntoOk = false
let mapa = document.querySelector('#mapa')

nome.style.width = '100%'
email.style.width = '100%'

function validaNome() {
    let txtNome = document.querySelector('#txtNome')
    if (nome.value.length < 3) {
        txtNome.innerHTML = 'Nome Invalido'
        txtNome.style.color = 'red'
    } else {
        txtNome.innerHTML = 'Nome valido'
        txtNome.style.color = 'green'
        nomeOk = true
    }
}

function validaEmail() {
    let txtEmail = document.querySelector('#txtEmail')

    if (email.value.indexOf('@') || email.value.indexOf('.') == -1) {
        txtEmail.innerHTML = 'Email invalido'
        txtEmail.style.color = 'red'
    } else {
        txtEmail.innerHTML = 'Email valido'
        txtEmail.style.color = 'green'
        emailOk = true
    }
}

function validaAssunto () {
    let txtAssunto = document.querySelector('#txtAssunto')

    if (assunto.value.length >= 100) {
        txtAssunto.innerHTML = 'Texto muito grande, digite no maximo 100 caracteres'
        txtAssunto.style.color = 'red'
        txtAssunto.style.display = 'block'
    } else {
        txtAssunto.style.display = 'none'
        assuntoOk = true
    }
}

function enviar () {
    if (nomeOk == true && emailOk == true && assuntoOk == true) {
        alert ('Formulario enviado com sucesso!')
    } else {
        alert ('Preencha o formulario corretamente!')
    }
}

function mapaZoom() {
    mapa.style.width = '800px'
    mapa.style.height = '600px'
}

function mapaNormal() {
    mapa.style.width = '400px'
    mapa.style.height = '250px'
}