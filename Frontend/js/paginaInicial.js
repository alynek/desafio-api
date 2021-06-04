let peopleApi = 'https://localhost:44323/api/pessoas'

$(document).ready(function(){
   
    obterPessoa()
    adicionarPessoa()
    
}) 


function obterPessoa(){

    $('#tbody').empty()

    $.ajax(peopleApi, {
        type: 'GET',
        success: function(resposta){
            criarTabela(resposta)
        }
    })
}



function criarTabela(resposta){

    $.each(resposta, function(indice, elemento){

        let ativo = alterarAtivo(elemento)
        let idade = calcularIdade(elemento)
        let faixaEtaria = calcularFaixaEtaria(idade)
        
        $('#tbody').append(
            "<tr>" +
            "<td class='nome'>"+elemento.nome+"</td>"+
            "<td class='dataNascimento'>"+elemento.dataNascimento+"</td>" +
            "<td class='idade'>"+idade+"</td>" +
            "<td class='faixaEtaria'>"+faixaEtaria+"</td>" +
            "<td class='ativo'>"+ativo+"</td>" +
            "<td><button type='button' class='btn btn-warning editar' onclick='editarPessoa("+elemento.id+")'><i class='fas fa-pencil-alt'></button></td>" +
            "<td><button type='button' class='btn btn-danger remover' onclick='removerPessoa("+elemento.id+")'><i class='fas fa-trash'></i></button></td>" +
            "</tr>")
    })
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

    $('#salvarCriar').click(function(){
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

function editarPessoa(id){

    $('#modalEditar').modal('show')
    $('#modalEditar :input').val('')

    $('#salvarEditar').click(function(){

        let dados = {
            id: id,
            nome: $('#modalEditar #nome').val(), 
            dataNascimento: $('#modalEditar #dataNascimento').val(),
            ativo: $('#modalEditar #ativo').prop('checked')
        }
        
        $.ajax(peopleApi + '/' + id, {
            type: 'PUT',
            contentType: 'application/json',
            data: JSON.stringify(dados),
            success: function(dados){
                obterPessoa(dados)
            },
            error: function(){
                alert('Dados inválidos!')
            }
        });
        
    })
}

function removerPessoa(id){

    $('#modalRemover').modal('show')

    $('#salvarRemover').click(function(){
        
        $.ajax(peopleApi + '/' + id, {
            type: 'DELETE',
            contentType: 'application/json',
            data: 'json',
            success: function(dados){
                obterPessoa(dados)
            },
            error: function(){
                alert('Dados inválidos!')
            }
        });
    })
}
    




    

   




