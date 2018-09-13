function criarValidador(idjqForm, regras) {
    return $(idjqForm).validate({
        rules: regras,
        errorPlacement: function (erro, elemento) {
            var idErro = "#grupo" + $(elemento).attr("id");
            var idMensagem = "#msg" + $(elemento).attr("id");

            $(idErro).addClass("has-error");
            $(idMensagem).html(erro.text());
        },
        success: function (label, element) {
            var idErro = "#grupo" + $(element).attr("id");
            var idMensagem = "#msg" + $(element).attr("id");

            if ($(idErro).hasClass("has-error"))
                $(idErro).removeClass("has-error");
            $(idMensagem).html("");
        }
    });
}

function iniciaModalColunas(idModalColunas) {
    $(idModalColunas+" input[type='checkbox']").click();

    $("#btnModalColunas").click(function () {
        var lista = $("#ModalColunas input[type='checkbox']");
        var coluna = null;
        for (x = 0; x < lista.length; x++) {
            coluna = table.column(x);
            if ($(lista[x]).prop("checked")) {
                if (!coluna.visible())
                    coluna.visible(true);
            }
            else {
                if (coluna.visible())
                    coluna.visible(false);
            }
        }
    });


}

function iniciaDataTable(idjqtabela,idModalColunas) {

    var tabela = $(idjqtabela).DataTable({
        dom: 'Blfrtip',
        buttons: [
            {
                text: "<span class='glyphicon glyphicon-list-alt'></span> Colunas",
                action: function (e, dt, node, config) {
                    $(idModalColunas).modal();
                }
            }/*,
                    { extend: 'copy', text: "Copiar" }, 'csv', 'excel', 'pdf',*/
        ],
        "language": {
            "sEmptyTable": "Nenhum registro encontrado",
            "sInfo": "Mostrando de _START_ até _END_ de _TOTAL_ registros",
            "sInfoEmpty": "Mostrando 0 até 0 de 0 registros",
            "sInfoFiltered": "(Filtrados de _MAX_ registros)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "_MENU_ resultados por página",
            "sLoadingRecords": "Carregando...",
            "sProcessing": "Processando...",
            "sZeroRecords": "Nenhum registro encontrado",
            "sSearch": "Pesquisar",
            "oPaginate": {
                "sNext": "Próximo",
                "sPrevious": "Anterior",
                "sFirst": "Primeiro",
                "sLast": "Último"
            },
            "oAria": {
                "sSortAscending": ": Ordenar colunas de forma ascendente",
                "sSortDescending": ": Ordenar colunas de forma descendente"
            },                    
            buttons: {
                copyTitle: 'Copiar tabela',
                copyKeys: 'Presione <i>ctrl</i> ou <i>\u2318</i> + <i>C</i> para copiar as linhas da tablea. <br><br>Por favor, clique na mensagem para fechá-la.',
                copySuccess: {
                    _: '%d linhas copiadas',
                    1: '1 linha copiada'
                }
            }            
        },
        //"bDestroy": true
    });
    iniciaModalColunas(idModalColunas);
    return tabela;
}

function preencheDataTable(tabela, dados) {
    tabela.clear().draw();
    if (dados.constructor == Array) {
        for (x = 0; x < dados.length; x++)
            table.row.add(dados[x]).draw();
    }
    else
        throw new Error("preencheDataTable: dados deve ser um Array !");
}


