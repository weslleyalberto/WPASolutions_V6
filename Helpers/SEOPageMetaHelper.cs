using System;

namespace WPASolutions_V6.Helpers
{
    public static class SEOPageMetaHelper
    {
        public static IEnumerable<Tuple<string, string, string, string>> Collections
        {
            get
            {
                return new List<Tuple<string, string, string, string>>
                {
                    new Tuple<string, string, string, string>("Home/Index", " WPA Solutions - Soluções em Tecnologia e Publicidade - Paraíso do Tocantins -TO",
                    "Site Institucional, E-Commerce , Apps para Android e IOS, Designer Gráfico , Comunicação Visual e Marketing Digital",
                    "Desenvolvimento de sites Desenvolvimento de aplicativos para android  iphone Designer Gráfico  Comunicação Visual  Marketing Digital Paraíso do Tocantins")
                };
            }
        }
    }
}
