function validarFormulario() {

    var textoCampoNome = document.getElementById("campo-nome").value;
    var textoCampoCPF = document.getElementById("campo-cpf").value;
    var textoCampoSalario = document.getElementById("campo-salario").value;
    var textoCampoTempoEspera = document.getElementById("campo-tempo-espera").value;

    var quatidadeCaractereCampoNome = textoCampoNome.length;

    if ((quatidadeCaractereCampoNome < 7) || (quatidadeCaractereCampoNome > 100))
    {
        alert("Campo nome deve conver no mínimo 7 caracteres e no máximo 100 caracteres");
    }
    
    var quantidadeCaracteresCampoCPF = textoCampoCPF.length;
    if (quantidadeCaracteresCampoCPF < 15) {
        alert("CPF deve conter 16 digitos");
    }

    var salario = parseFloat(textoCampoSalario);
    if (salario < 1200) {
        alert("Salário deve ser maior que R$ 1.200,00");
    } else if (salario > 100000) {
        alert("Salário deve ser menor que R$ 100.000,00")
    }


}