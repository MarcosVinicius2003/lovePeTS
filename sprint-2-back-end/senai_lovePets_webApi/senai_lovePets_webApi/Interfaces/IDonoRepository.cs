﻿using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface IDonoRepository
    {
        List<Dono> Listar();
        Dono BuscarPorId(int id);
        void Cadastrar(Dono novo);
        void Atualizar(int id, Dono DonoAtualizado);
        void Deletar(int id);
    }
}
