// ***********************************************************************
// Assembly         : OpenAC.Net.Integrador
// Author           : marcosgerene
// Created          : 07-17-2017
//
// Last Modified By : marcosgerene
// Last Modified On : 07-17-2017
// ***********************************************************************
// <copyright file="IntegradorMetodo.cs" company="OpenAC .Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2014 - 2021 Projeto OpenAC .Net
//
//	 Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//	 The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//	 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary></summary>
// ***********************************************************************

using OpenAC.Net.Core.Generics;
using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;

namespace OpenAC.Net.Integrador.Commom
{
    public sealed class IntegradorMetodo : GenericClone<IntegradorMetodo>
    {
        #region Constructors

        public IntegradorMetodo()
        {
            Construtor = null;
            Parametros = new IntegradorParametroCollection();
        }

        #endregion Constructors

        #region Properties

        [DFeAttribute(TipoCampo.Str, "Nome", Ocorrencia = Ocorrencia.Obrigatoria)]
        public string Nome { get; set; }

        [DFeElement("Construtor", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public IntegradorConstrutor Construtor { get; set; }

        [DFeCollection("Parametros")]
        [DFeItem(typeof(IntegradorParametro), "Parametro")]
        public IntegradorParametroCollection Parametros { get; set; }

        #endregion Properties
    }
}