using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procu4UvsPrimavera.Utilities
{
    public class PrimaveraSqlQueries
    {
        public const string CONFIGURATIONS = "SELECT TOP 1 [CDU_Id],[CDU_Serie],[CDU_TipoDoc],[CDU_TipoEntidade],[CDU_procu4U_tenantId],[CDU_procu4U_APIKey] FROM TDU_Configuracao";
        public const string UNITS = "SELECT[Unidade],[Descricao],[CDU_Portal] FROM Unidades Where CDU_Portal = '2' or CDU_Portal = '1'";
        public const string SUPPLIERS = "SELECT[Fornecedor],[Nome],[Morada],[Tel],[NumContrib],[CDU_Portal],[CDU_Knack] FROM Fornecedores where CDU_Portal = '1' or CDU_Portal = '2'";
        public const string DEPARTMENTS = "SELECT[Centro],[Descricao],[TipoConta],[Ano],[CDU_Portal] FROM PlanoCentros where CDU_Portal = '2' or CDU_Portal = '1'";
        public const string PRODUCTS = "SELECT[Artigo],[Descricao],[STKActual],[PCUltimo], UnidadeBase,[CDU_Portal],[CDU_Knack]  FROM Artigo Where CDU_Portal = 2 Or CDU_Portal = 1";
        public const string OrederLine = "SELECT TOP 1 [Artigo],[Descricao],[STKActual],[PCUltimo],UnidadeBase,[CDU_Portal],[CDU_Knack] FROM Artigo Where CDU_Knack = producto.id &  AND Artigo =  producto.getProductIdentifier";
        public const string SUPPLIERS1 = "SELECT TOP 1 [Fornecedor],[Nome],[CDU_Portal],[CDU_Knack] FROM Fornecedores"; 
        public const string ORDERHEADER = "select distinct Filial,[Serie],[TipoDoc],[NumDoc],[Entidade],[DataDoc],[NumDocExterno],[CDU_Knack] from CabecCompras, CabecComprasStatus where CabecCompras.Id = CabecComprasStatus.IdCabecCompras and CabecComprasStatus.Fechado = 1 and CDU_Portal = 0 and TipoDoc = DocumentType and CDU_Knack is not null";
        public const string MODELS = "SELECT TOP 1 [Descricao] FROM [Modelos] WHERE Modelo";
        public const string BRAND = "SELECT TOP 1 [Descricao] FROM[Marcas]"; // WHERE Marca = '" & artigo.Marca & "'"
        //SELECT TOP 1 Descricao FROM ArtigoIdioma WHERE Artigo='{artigo.Artigo}' and Idioma='EN'"
        //SELECT Id FROM CabecCompras where CDU_Knack IS NOT NULL
        //"SELECT TOP 1 [Artigo],[Descricao],[STKActual],[PCUltimo],UnidadeBase,[CDU_Portal],[CDU_Knack] FROM Artigo Where CDU_Knack = '" & producto.id & "' AND Artigo = '" & producto.getProductIdentifier & "'"
    }
}
