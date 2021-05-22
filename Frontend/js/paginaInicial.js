
$(document).ready(function(){

    $.get("https://localhost:44323/api/pessoas", function(resposta){
        criarTabela(resposta)
        $('#tabela').DataTable();
    })

    function criarTabela(resposta){

        let ativo = alteraAtivo(resposta)
        let idade = calculaIdade(resposta)

        $('#tbody').append(
            "<tr>" +
            "<td>"+resposta[0].nome+"</td>"+
            "<td>"+resposta[0].dataNascimento+"</td>" +
            "<td>"+resposta[0].faixaEtaria.faixa+"</td>" +
            "<td>"+idade+"</td>" +
            "<td>"+ativo+"</td>" +
            "</tr>"
        
        )           
    }

    function alteraAtivo(resposta){

        if(resposta[0].ativo == true){
            return 'Sim'
        }else{
            return 'Não'
        }
    }

    function calculaIdade(resposta){

        let anoAtual = new Date().getFullYear()
        let arrayIdade = resposta[0].dataNascimento.split('-')
        return anoAtual - parseInt(arrayIdade[0])
    }
})




