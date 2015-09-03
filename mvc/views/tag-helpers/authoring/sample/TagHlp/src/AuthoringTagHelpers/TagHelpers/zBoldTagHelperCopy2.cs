﻿using Microsoft.AspNet.Razor.Runtime.TagHelpers;

namespace AuthoringTagHelpers.TagHelpers2
{
   [TargetElement("bold", Attributes = "bold")]
   public class BoldTagHelper : TagHelper
   {
      public override void Process(TagHelperContext context, TagHelperOutput output)
      {
         output.Attributes.RemoveAll("bold");
         output.PreContent.SetContent("<strong>");
         output.PostContent.SetContent("</strong>");
      }
   }
}

