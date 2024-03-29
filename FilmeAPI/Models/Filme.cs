﻿using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace FilmeAPI.Models;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O título do filme é obrigatório")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [MaxLength(50, ErrorMessage = "Você excedeu o limite de caracteres para g~enero")]
    public string Genero { get; set; }

    [Required]
    [Range(70, 600 ,ErrorMessage = "A duração deve ser entre 70 e 600 minutos")]
    public int Duracao { get; set; }

}
