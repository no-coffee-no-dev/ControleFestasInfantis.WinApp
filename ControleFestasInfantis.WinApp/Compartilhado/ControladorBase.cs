﻿using ControleFestasInfantis.Dominio.Compartilhado;
using ControleFestasInfantis.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFestasInfantis.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }
        public abstract string ToolTipEditar { get; }
        public abstract string ToolTipExcluir { get; }

      
        public abstract bool BotaoInserirAtivado { get; }
        public abstract bool BotaoDeletarAtivado { get; }
        public abstract bool BotaoEditarAtivado { get; }
        public abstract bool BotaoInserirItemAtivado { get; }



        public abstract void Inserir();
        public abstract void Editar();
        public abstract void Deletar();


        public abstract UserControl ObterListagem();


        public virtual void VisualizarItem(){}


        public abstract string ObterTipoCadastro();
        public abstract void CarregarEntidades();
    }
}
