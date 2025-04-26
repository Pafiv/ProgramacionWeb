function enviarValor(arg) {
    var valor = arg.dataset.valor;
    var ca_texto = document.getElementById("txt_caja_texto");

    if (valor === "=") {
        try {
            ca_texto.value = eval(ca_texto.value);
        } catch {
            ca_texto.value = "Error";
        }
    } else {
        ca_texto.value += valor;
    }
}

function limpiar() {
    var ca_texto = document.getElementById("txt_caja_texto");
    ca_texto.value = "";
}

