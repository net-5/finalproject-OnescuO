﻿using System;
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
    [HtmlTargetElement("editions")]
    public class EditionTagHelper : TagHelper
    {
        private readonly IEditionServices editionServices;
        private const string ForAttributeName = "asp-for";
        [HtmlAttributeName(ForAttributeName)]
        public ModelExpression For { get; set; }

        public EditionTagHelper(IEditionServices editionServices)
        {
            this.editionServices = editionServices;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var allEditions = editionServices.GetAllEditions();
            output.TagName = "select";
            output.Attributes.SetAttribute("id", For.Name);
            output.Attributes.SetAttribute("name", For.Name);
            output.Attributes.Add("class", "form-control");
            foreach (var edition in allEditions)
            {
                TagBuilder myOption = new TagBuilder("option")
                {
                    TagRenderMode = TagRenderMode.Normal
                };
                myOption.Attributes.Add("value", edition.Name);
                myOption.InnerHtml.Append(edition.Name);

                output.Content.AppendHtml(myOption);
            }
        }
    }
}
