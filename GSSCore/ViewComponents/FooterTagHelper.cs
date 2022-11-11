using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.Text.Encodings.Web;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GSSCore.ViewComponents
{
    [HtmlTargetElement("footer")]
    public class FooterTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = null;

            outputFooter(output);
        }

        private void outputFooter(TagHelperOutput output)
        {
            var footer = new TagBuilder("footer");

            var aGSS = new TagBuilder("a");
            aGSS.InnerHtml.AppendHtml("GSS");
            aGSS.AddCssClass("without-link");

            var spanFaCopyRight = new TagBuilder("span");
            spanFaCopyRight.AddCssClass("far fa-copyright");

            var spanFooter = new TagBuilder("span");
            spanFooter.InnerHtml.AppendHtml("Criado por ");

            footer.InnerHtml.AppendHtml(spanFooter);
            spanFooter.InnerHtml.AppendHtml(aGSS);
            spanFooter.InnerHtml.AppendHtml(" | ");
            spanFooter.InnerHtml.AppendHtml(spanFaCopyRight);
            spanFooter.InnerHtml.AppendHtml($" {DateTime.Now.Year} Todos os direitos reservados.");

            output.Content.AppendHtml(footer);
        }
    }
}