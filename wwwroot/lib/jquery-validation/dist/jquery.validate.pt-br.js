jQuery.extend(jQuery.validator.messages, {
    required: "Este campo é obrigatório.",
    remote: "Por favor, corrija este campo.",
    email: "Por favor, forneça um endereço de email válido.",
    url: "Por favor, forneça uma URL válida.",
    date: "Por favor, forneça uma data válida.",
    number: "Por favor, forneça um número válido.",
    digits: "Por favor, forneça apenas dígitos.",
    equalTo: "Por favor, forneça o mesmo valor novamente.",
    maxlength: jQuery.validator.format("Por favor, forneça não mais que {0} caracteres."),
    minlength: jQuery.validator.format("Por favor, forneça ao menos {0} caracteres."),
    rangelength: jQuery.validator.format("Por favor, forneça um valor entre {0} e {1} caracteres."),
    range: jQuery.validator.format("Por favor, forneça um valor entre {0} e {1}."),
    max: jQuery.validator.format("Por favor, forneça um valor menor ou igual a {0}."),
    min: jQuery.validator.format("Por favor, forneça um valor maior ou igual a {0}.")
});
