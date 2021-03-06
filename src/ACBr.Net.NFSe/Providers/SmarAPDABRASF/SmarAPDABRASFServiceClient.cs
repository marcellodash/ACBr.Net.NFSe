// ***********************************************************************
// Assembly         : ACBr.Net.NFSe
// Author           : Rafael Dias
// Created          : 21-01-2020
//
// Last Modified By : Rafael Dias
// Last Modified On : 23-01-2020
// ***********************************************************************
// <copyright file="SmarAPDABRASFServiceClient.cs" company="ACBr.Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2016 Grupo ACBr.Net
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

using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;
using ACBr.Net.Core.Extensions;
using ACBr.Net.DFe.Core;
using ACBr.Net.DFe.Core.Common;

namespace ACBr.Net.NFSe.Providers
{
    internal sealed class SmarAPDABRASFServiceClient : NFSeSOAP11ServiceClient, IABRASF2Client
    {
        #region Constructors

        public SmarAPDABRASFServiceClient(ProviderSmarAPDABRASF provider, TipoUrl tipoUrl, X509Certificate2 certificado) : base(provider, tipoUrl, certificado)
        {
        }

        #endregion Constructors

        #region Methods

        public string CancelarNFSe(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<e:CancelarNfseRequest>");
            message.Append("<nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</nfseCabecMsg>");
            message.Append("<nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</nfseDadosMsg>");
            message.Append("</e:CancelarNfseRequest>");

            return Execute("http://nfse.abrasf.org.br/CancelarNfse", message.ToString(), "CancelarNfseResponse");
        }

        public string SubstituirNFSe(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<e:SubstituirNfseRequest>");
            message.Append("<nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</nfseCabecMsg>");
            message.Append("<nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</nfseDadosMsg>");
            message.Append("</e:SubstituirNfseRequest>");

            return Execute("http://nfse.abrasf.org.br/SubstituirNfse", message.ToString(), "SubstituirNfseResponse");
        }

        public string ConsultarLoteRps(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<e:ConsultarLoteRpsRequest>");
            message.Append("<nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</nfseCabecMsg>");
            message.Append("<nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</nfseDadosMsg>");
            message.Append("</e:ConsultarLoteRpsRequest>");

            return Execute("http://nfse.abrasf.org.br/ConsultarLoteRps", message.ToString(), "ConsultarLoteRpsResponse");
        }

        public string ConsultarNFSeFaixa(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<e:ConsultarNfseFaixaRequest>");
            message.Append("<nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</nfseCabecMsg>");
            message.Append("<nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</nfseDadosMsg>");
            message.Append("</e:ConsultarNfseFaixaRequest>");

            return Execute("http://nfse.abrasf.org.br/ConsultarNfseFaixa", message.ToString(), "ConsultarNfseFaixaResponse");
        }

        public string ConsultarNFSeServicoTomado(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<e:ConsultarNfseServicoTomadoRequest>");
            message.Append("<nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</nfseCabecMsg>");
            message.Append("<nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</nfseDadosMsg>");
            message.Append("</e:ConsultarNfseServicoTomadoRequest>");

            return Execute("http://nfse.abrasf.org.br/ConsultarNfseServicoTomado", message.ToString(), "ConsultarNfseServicoTomadoResponse");
        }

        public string ConsultarNFSePorRps(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<e:ConsultarNfsePorRpsRequest>");
            message.Append("<nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</nfseCabecMsg>");
            message.Append("<nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</nfseDadosMsg>");
            message.Append("</e:ConsultarNfsePorRpsRequest>");

            return Execute("http://nfse.abrasf.org.br/ConsultarNfsePorRps", message.ToString(), "ConsultarNfsePorRpsResponse");
        }

        public string ConsultarNFSeServicoPrestado(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<e:ConsultarNfseServicoPrestadoRequest>");
            message.Append("<nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</nfseCabecMsg>");
            message.Append("<nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</nfseDadosMsg>");
            message.Append("</e:ConsultarNfseServicoPrestadoRequest>");

            return Execute("http://nfse.abrasf.org.br/ConsultarNfseServicoPrestado", message.ToString(), "ConsultarNfseServicoPrestadoResponse");
        }

        public string RecepcionarLoteRps(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<e:RecepcionarLoteRpsRequest>");
            message.Append("<nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</nfseCabecMsg>");
            message.Append("<nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</nfseDadosMsg>");
            message.Append("</e:RecepcionarLoteRpsRequest>");

            return Execute("http://nfse.abrasf.org.br/RecepcionarLoteRps", message.ToString(), "RecepcionarLoteRpsResponse");
        }

        public string RecepcionarLoteRpsSincrono(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<e:RecepcionarLoteRpsSincronoRequest>");
            message.Append("<nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</nfseCabecMsg>");
            message.Append("<nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</nfseDadosMsg>");
            message.Append("</e:RecepcionarLoteRpsSincronoRequest>");

            return Execute("http://nfse.abrasf.org.br/RecepcionarLoteRpsSincrono", message.ToString(), "RecepcionarLoteRpsSincronoResponse");
        }

        private string Execute(string soapAction, string message, string responseTag)
        {
            return Execute(soapAction, message, responseTag, "xmlns:e=\"http://nfse.abrasf.org.br\"");
        }

        protected override bool ValidarCertificadoServidor()
        {
            return Provider.Configuracoes.WebServices.Ambiente != DFeTipoAmbiente.Homologacao;
        }

        protected override string TratarRetorno(XDocument xmlDocument, string[] responseTag)
        {
            var element = xmlDocument.ElementAnyNs("Fault");
            if (element != null)
            {
                var exMessage = $"{element.ElementAnyNs("faultcode").GetValue<string>()} - {element.ElementAnyNs("faultstring").GetValue<string>()}";
                throw new ACBrDFeCommunicationException(exMessage);
            }

            return xmlDocument.ElementAnyNs(responseTag[0]).ElementAnyNs("outputXML").Value;
        }

        #endregion Methods
    }
}