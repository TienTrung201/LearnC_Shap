using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;


namespace RazorpageWebapp
{
  // thẻ sẽ là myul 
  [HtmlTargetElement("myul")]  
  public class MyULTagHelper : TagHelper
  {
    // Thuộc tính sẽ là list-title
    public string ListTitle { get; set; }
    // Thuộc tính sẽ là list-items
    public List<Product> ListItems {set; get;}


    // ProcessAsyn nếu bất đồng bộ
  
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "ul";    // ul sẽ thay cho myul
        output.Attributes.SetAttribute("class", "list-group");
        output.TagMode = TagMode.StartTagAndEndTag;  
        output.PreElement.AppendHtml($"<h2>{ListTitle}</h2>"+"\r\n");
        StringBuilder stringBuilder = new StringBuilder();
        foreach (var item in ListItems)
        {
            stringBuilder.Append($@"<li class=""list-group-item"">{item.Name}  {item.Price}</li>" + "\r\n");
        }
        output.Content.SetHtmlContent(stringBuilder.ToString());
    }
 
  }
}