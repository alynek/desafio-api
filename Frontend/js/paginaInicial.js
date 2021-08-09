const peopleApi = 'https://localhost:44323/api/pessoas'

$(document).ready(function(){
    pessoa.obterTodos()
})

const pessoa = {

    obterTodos(){
        $.get(peopleApi, function(resultado){
            criarTabela(resultado)
        })
    },

    salvar(){

        let dados = pessoa.obterCamposDoInput('#modalCriar')
        
        $.ajax(peopleApi, {
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(dados),
            success: function(){
                pessoa.obterTodos()
            },
            error: function(){
                alert('Dados inválidos!')
            }
        });

        $(':input').val('')
    },

    obterCamposDoInput(idDoModal){

        let dados = {
            nome: $(`${idDoModal} #nome`).val(), 
            dataNascimento: $(`${idDoModal} #dataNascimento`).val(),
            ativo: $(`${idDoModal} #ativo`).prop('checked')
        }

        return dados
    },

    remover(id){

        $('#modalRemover').modal('show')

        $('#salvarRemover').off().on('click', (function(){
            
            $.ajax(peopleApi + '/' + id, {
                type: 'DELETE',
                contentType: 'application/json',
                data: 'json',
                success: function(dados){
                    pessoa.obterTodos()
                },
                error: function(){
                    alert('Dados inválidos!')
                }
            });
        }));
    },

    editar(id){
        $('#modalEditar').modal('show')
        $('#modalEditar :input').val('') 

        $('#salvarEditar').off().on('click', (function(){

            let dados = pessoa.obterCamposDoInput('#modalEditar')
            
            $.ajax(peopleApi + '/' + id, {
                type: 'PUT',
                contentType: 'application/json',
                data: JSON.stringify(dados),
                success: function(){
                    pessoa.obterTodos()
                },
                error: function(){
                    alert('Dados inválidos!')
                }
            });
        }));
    }
}


function criarTabela(resposta){

    $('#tbody').empty()

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
            "<td><button type='button' class='btn btn-warning editar' onclick='pessoa.editar("+elemento.id+")'><i class='fas fa-pencil-alt'></button></td>" +
            "<td><button type='button' class='btn btn-danger remover' onclick='pessoa.remover("+elemento.id+")'><i class='fas fa-trash'></i></button></td>" +
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
    




    

   




