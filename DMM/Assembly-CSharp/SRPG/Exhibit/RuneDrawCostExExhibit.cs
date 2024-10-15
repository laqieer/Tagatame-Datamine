// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RuneDrawCostExExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034B7")]
  public class RuneDrawCostExExhibit : BaseExhibit, IRenderModel<RuneDrawCostExModel>, IRenderModel
  {
    [Token(Token = "0x400FA3F")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RuneDrawCostExExhibit.EKey), typeof (RuneDrawCostExExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600EA05")]
    [Address(RVA = "0xAF1D60", Offset = "0xAF0B60", VA = "0x10AF1D60", Slot = "8")]
    public void Render(RuneDrawCostExModel model)
    {
    }

    [Token(Token = "0x600EA06")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RuneDrawCostExExhibit()
    {
    }

    [Token(Token = "0x20034B8")]
    private enum EKey
    {
      [Token(Token = "0x400FA41")] None,
      [Token(Token = "0x400FA42")] Button,
      [Token(Token = "0x400FA43")] ChangeButton,
    }
  }
}
