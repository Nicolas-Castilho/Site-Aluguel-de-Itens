﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aluguel.Models
{
    public class Anuncio
    {
        [Key]
        public int id { get; set; }
        public float vlitem { get; set; }
        public int diasAluguel { get; set; }
        public string modelo { get; set; }
        public string CEP { get; set; }
        public string Rua { get; set; }
        public string? Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string? Complemento { get; set; }
        public string contato { get; set; }

        public string NomeFantasia { get; set; }

        //AspNetUsers
        public string iduser { get; set; }

        //Item
        [ForeignKey("itemid")]
        public int itemid { get; set; }

        public Item? item { get; set; }

        public int categoriaid { get; set; }
        public Categoria? categoria { get; set; }
        //Tipo
        public int tipoid { get; set; }
        public Tipo? tipo { get; set; }

        public List<Anuncio> GetAnuncios()
        {
            List<Anuncio> anuncios = new List<Anuncio>();
            return anuncios;
        }

    }
}
