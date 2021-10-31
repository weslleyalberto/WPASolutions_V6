using System.Text;

namespace WPASolutions_V6.Helpers
{
    public class HelpersServices
    {
        private StringBuilder sb = new();
        public string InjectMetainfo(string urlSegment)
        {
            var metainfo = SEOPageMetaHelper.Collections.Where(c =>
            c.Item1.Equals(urlSegment, StringComparison.InvariantCultureIgnoreCase)).SingleOrDefault();
            if(metainfo is null)
                return string.Empty;
            sb.Append("<title>" + metainfo.Item2 + "</title>");
            sb.Append(Environment.NewLine);
            sb.Append($"<meta name='description' content='{metainfo.Item3}'/>");
            sb.Append(Environment.NewLine);
            sb.Append($"meta name='keywords' content= '{metainfo.Item4}'/>");
            string metatag = sb.ToString();
            sb = null;
            return metatag;
        }
    }
}
