
$(document).ready(function(){

    $.get("https://localhost:44323/api/pessoas", function(resposta){
        criarTabela(resposta)
    })

    function criarTabela(resposta){

        let ativo = alterarAtivo(resposta)
        let idade = calcularIdade(resposta)
        let faixaEtaria = calcularFaixaEtaria(idade)

        $('#tbody').append(
            "<tr>" +
            "<td>"+resposta[0].nome+"</td>"+
            "<td>"+resposta[0].dataNascimento+"</td>" +
            "<td>"+idade+"</td>" +
            "<td>"+faixaEtaria+"</td>" +
            "<td>"+ativo+"</td>" +
            "</tr>"
        
        )           
    }

    function alterarAtivo(resposta){

        if(resposta[0].ativo == true){
            return 'Sim'
        }else{
            return 'Não'
        }
    }

    function calcularIdade(resposta){

        let anoAtual = new Date().getFullYear()
        let arrayIdade = resposta[0].dataNascimento.split('-')
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
})

function adicionaPessoa(){
    $('#salvar').click(function(){
        console.log($('#inputNome').val())
        console.log($('#inputData').val())
        console.log($('#inputCheckbox').prop('checked'))
        $(':input').val('')
    })
}

adicionaPessoa()

    

   




