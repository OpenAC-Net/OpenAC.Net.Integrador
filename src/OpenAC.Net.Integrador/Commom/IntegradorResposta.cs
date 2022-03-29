// ***********************************************************************
// Assembly         : OpenAC.Net.Integrador
// Author           : RFTD
// Created          : 05-30-2017
//
// Last Modified By : RFTD
// Last Modified On : 05-30-2017
// ***********************************************************************
// <copyright file="IntegradorResposta.cs" company="OpenAC .Net">
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
    public sealed class IntegradorResposta : GenericClone<IntegradorResposta>
    {
        #region Properties

        [DFeElement(TipoCampo.Str, "Codigo", Ocorrencia = Ocorrencia.Obrigatoria)]
        public string Codigo { get; set; }

        [DFeElement(TipoCampo.Str, "Valor", Ocorrencia = Ocorrencia.Obrigatoria)]
        public string Valor { get; set; }

        #endregion Properties
    }
}