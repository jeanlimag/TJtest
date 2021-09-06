

function RegisterNewClient() {
    debugger;
    if (!$('#txtClientName').val()) {
        let text = "To register a new customer, please enter a name!";
        alert(text);
        return;
    }

    let clientName = $('#txtClientName').val();

    $.ajax({
        type: "GET",
        url: "https://localhost:44346/Home/RegisterNewClient",
        data: {
            'clientName': clientName,
        },
        success: function (result) {
            if (!result) {
                let text = "Ocorreu um erro ao processar a informação."
                alert(text);
            }
        }
    });

    return;
}
function SearchClient() {
    debugger;
    if (!$('#txtClientName').val()) {
        let text = "To search a customer, please enter a name!";
        alert(text);
        return;
    }

    let clientName = $('#txtClientName').val(); 

    $.ajax({
        type: "GET",
        url: "https://localhost:44346/Home/SearchClient",
        data: {
            'clientName': clientName,
        },
        success: function (client) {
            
        }
    });

    return;
}
