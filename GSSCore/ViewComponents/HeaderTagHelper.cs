using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace GSSCore.ViewComponents
{
    [HtmlTargetElement("header")]
    public class HeaderTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = null;

            outputHeader(output);
            outputHome(output);
        }
        private void outputHeader(TagHelperOutput output)
        {
            var navHeader = new TagBuilder("nav");
            navHeader.AddCssClass("header");

            var divMaxWidth = new TagBuilder("div");
            divMaxWidth.AddCssClass("max-width");

            var divLogo = new TagBuilder("div");
            divLogo.AddCssClass("logo");

            var aGSS = new TagBuilder("a");
            aGSS.Attributes.Add("href", "#");
            aGSS.InnerHtml.AppendHtml("GSS");

            var ulMenu = new TagBuilder("ul");
            ulMenu.AddCssClass("menu");

            var liHome = new TagBuilder("li");

            var liAbout = new TagBuilder("li");

            var liHistoryProfessional = new TagBuilder("li");

            var liProject = new TagBuilder("li");

            var liSkill = new TagBuilder("li");

            var liContact = new TagBuilder("li");

            var aHome = new TagBuilder("a");
            aHome.Attributes.Add("href", "#home");
            aHome.InnerHtml.AppendHtml("Início");

            var aAbout = new TagBuilder("a");
            aAbout.Attributes.Add("href", "#about");
            aAbout.InnerHtml.AppendHtml("Sobre Mim");

            var aHistoryProfessional = new TagBuilder("a");
            aHistoryProfessional.Attributes.Add("href", "#history-professional");
            aHistoryProfessional.InnerHtml.AppendHtml("História Profissional");

            var aProject = new TagBuilder("a");
            aProject.Attributes.Add("href", "#project");
            aProject.InnerHtml.AppendHtml("Projetos");

            var aSkill = new TagBuilder("a");
            aSkill.Attributes.Add("href", "#skill");
            aSkill.InnerHtml.AppendHtml("Habilidades");

            var aContact = new TagBuilder("a");
            aContact.Attributes.Add("href", "#contact");
            aContact.InnerHtml.AppendHtml("Contata-me");

            var divMenuButton = new TagBuilder("div");
            divMenuButton.AddCssClass("menu-button");

            var iFasFaBars = new TagBuilder("i");
            iFasFaBars.AddCssClass("fas fa-bars");

            navHeader.InnerHtml.AppendHtml(divMaxWidth);
            divMaxWidth.InnerHtml.AppendHtml(divLogo);
            divMaxWidth.InnerHtml.AppendHtml(ulMenu);
            divMaxWidth.InnerHtml.AppendHtml(divMenuButton);
            divLogo.InnerHtml.AppendHtml(aGSS);
            ulMenu.InnerHtml.AppendHtml(liHome);
            liHome.InnerHtml.AppendHtml(aHome);
            ulMenu.InnerHtml.AppendHtml(liAbout);
            liAbout.InnerHtml.AppendHtml(aAbout);
            ulMenu.InnerHtml.AppendHtml(liHistoryProfessional);
            liHistoryProfessional.InnerHtml.AppendHtml(aHistoryProfessional);
            ulMenu.InnerHtml.AppendHtml(liProject);
            liProject.InnerHtml.AppendHtml(aProject);
            ulMenu.InnerHtml.AppendHtml(liSkill);
            liSkill.InnerHtml.AppendHtml(aSkill);
            ulMenu.InnerHtml.AppendHtml(liContact);
            liContact.InnerHtml.AppendHtml(aContact);
            divMenuButton.InnerHtml.AppendHtml(iFasFaBars);

            output.Content.AppendHtml(navHeader);
        }
        private void outputHome(TagHelperOutput output)
        {
            var sectionHome = new TagBuilder("section");
            sectionHome.AddCssClass("home");
            sectionHome.Attributes.Add("id", "home");

            var divMaxWidth = new TagBuilder("div");
            divMaxWidth.AddCssClass("max-width");

            var divHomeContainer = new TagBuilder("div");
            divHomeContainer.AddCssClass("home-container");

            var divTitle1 = new TagBuilder("div");
            divTitle1.AddCssClass("title-1");
            divTitle1.InnerHtml.AppendHtml("Olá, meu nome é");

            var spanG = new TagBuilder("span");
            spanG.InnerHtml.AppendHtml("G");

            var spanS = new TagBuilder("span");
            spanS.InnerHtml.AppendHtml("S");

            var divTitle2 = new TagBuilder("div");
            divTitle2.AddCssClass("title-2");
            divTitle2.InnerHtml.AppendHtml(spanG);
            divTitle2.InnerHtml.AppendHtml("uilherme ");
            divTitle2.InnerHtml.AppendHtml(spanS);
            divTitle2.InnerHtml.AppendHtml("aldanha De ");
            divTitle2.InnerHtml.AppendHtml(spanS);
            divTitle2.InnerHtml.AppendHtml("ouza");

            var divTitle3 = new TagBuilder("div");
            divTitle3.AddCssClass("title-3");
            divTitle3.InnerHtml.AppendHtml("Eu sou um ");

            var spanChanged = new TagBuilder("span");
            spanChanged.AddCssClass("changed");

            var aCursoGratis = new TagBuilder("a");
            aCursoGratis.Attributes.Add("href", "/Login/Index");
            aCursoGratis.InnerHtml.AppendHtml("Acessar Plataforma de Cursos");

            sectionHome.InnerHtml.AppendHtml(divMaxWidth);
            divMaxWidth.InnerHtml.AppendHtml(divHomeContainer);
            divHomeContainer.InnerHtml.AppendHtml(divTitle1);
            divHomeContainer.InnerHtml.AppendHtml(divTitle2);
            divHomeContainer.InnerHtml.AppendHtml(divTitle3);
            divHomeContainer.InnerHtml.AppendHtml(aCursoGratis);
            divTitle3.InnerHtml.AppendHtml(spanChanged);

            output.Content.AppendHtml(sectionHome);
        }
    }
}