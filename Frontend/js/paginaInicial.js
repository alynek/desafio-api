let peopleApi = 'https://localhost:44323/api/pessoas'

$(document).ready(function(){
   
    obterPessoa()
    adicionarPessoa()
})    

function obterPessoa(){
    $('#tbody').empty()
    $.get(peopleApi, function(resposta){
        $.each(resposta, function(indice, elemento){
            criarTabela(elemento)
        })
    })
}

function criarTabela(elemento){
    
    let ativo = alterarAtivo(elemento)
    let idade = calcularIdade(elemento)
    let faixaEtaria = calcularFaixaEtaria(idade)
    

    $('#tbody').append(
        "<tr>" +
        "<td>"+elemento.nome+"</td>"+
        "<td>"+elemento.dataNascimento+"</td>" +
        "<td>"+idade+"</td>" +
        "<td>"+faixaEtaria+"</td>" +
        "<td>"+ativo+"</td>" +
        "</tr>"
    
    )           
}

function alterarAtivo(elemento){

    if(elemento.ativo == true){
        return 'Sim'
    }else{
        return 'Não'
    }
}

function calcularIdade(elemento){

    let anoAtual = new Date().getFullYear()
    let arrayIdade = elemento.dataNascimento.split('-')
    return anoAtual - parseInt(arrayIdade[0])
}

function calcularFaixaEtaria(idade){
    switch(true){
        case  (idade <=9) :
            return '0-9';
        case (idade <=19):
            return '10-19';
        case (idade <= 29):
            return '20-29';
        case (idade <= 39):
            return '30-39';
        case (idade <= 49):
            return '40-49';
        case (idade <= 59):
            return '50-59';
        case (idade <= 69):
            return '60-69';
        case (idade <= 79):
            return '70-79';
        case (idade <= 89):
            return '80-89';
        case (idade <= 99):
            return '90-99';
        case (idade <= 109):
            return '100-109';
        case (idade <= 119):
            return '110-119';
        case (idade <= 129):
            return '120-129';
    }
}

function adicionarPessoa(){
    $('#salvar').click(function(){

        let dados = {
            nome: $('#nome').val(), 
            dataNascimento: $('#dataNascimento').val(),
            ativo: $('#ativo').prop('checked')
        }
        
         $.ajax(peopleApi, {
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(dados),
            success: function(){
                obterPessoa()
            },
            error: function(){
                alert('Dados inválidos!')
            }
        });
            
        $(':input').val('')
    })
}




    

   




