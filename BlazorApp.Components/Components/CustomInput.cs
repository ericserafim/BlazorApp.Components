using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

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
    public object[] Items { get; set; }

    private async Task OnInputChange(ChangeEventArgs args)
    {
      Value = (string)args.Value;
      await ValueChanged.InvokeAsync(Value);
    }

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
