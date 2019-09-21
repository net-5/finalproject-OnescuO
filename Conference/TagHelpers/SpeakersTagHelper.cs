using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Conference.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("speakerId", Attributes = ForAttributeName)]
    public class SpeakersTagHelper : TagHelper
    {
        private readonly ISpeakersServices speakersServices;
        private const string ForAttributeName = "asp-for";
        [HtmlAttributeName(ForAttributeName)]
        public ModelExpression For { get; set; }
        public SpeakersTagHelper(ISpeakersServices speakersServices)
        {
            this.speakersServices = speakersServices;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var allSpeakers = speakersServices.GetAllSpeakers();
            output.TagName = "select";
            output.Attributes.SetAttribute("id", For.Name);
            output.Attributes.SetAttribute("name", For.Name);
            output.Attributes.Add("class", "form-control");
            foreach (var speaker in allSpeakers)
            {
                TagBuilder myOption = new TagBuilder("option")
                {
                    TagRenderMode = TagRenderMode.Normal
                };
                myOption.Attributes.Add("value", speaker.Id.ToString());
                myOption.InnerHtml.Append(speaker.Id.ToString());

                output.Content.AppendHtml(myOption);
            }
        }
    }
}
