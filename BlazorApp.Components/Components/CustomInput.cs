using Microsoft.AspNetCore.Components;
using System;

namespace BlazorApp.Components.Components
{
  public enum InputType
  {
    Text,
    DateTime,
    Email,
    Combobox
  }

  public partial class CustomInput
  {
    [Parameter]
    public string Id { get; set; }

    [Parameter]
    public string Label { get; set; }

    [Parameter]
    public InputType Type { get; set; }

    [Parameter]
    public string Placeholder { get; set; }

    [Parameter]
    public string Value { get; set; }

    [Parameter]
    public EventCallback<string> ValueChanged { get; set; }

    [Parameter]
    public string[] Items { get; set; }


    private string TypeStr
    {
      get
      {
        var type = Enum.GetName(typeof(InputType), Type).ToLower();
        return type == "datetime" ? "datetime-local" : type;
      }
    }
  }
}
