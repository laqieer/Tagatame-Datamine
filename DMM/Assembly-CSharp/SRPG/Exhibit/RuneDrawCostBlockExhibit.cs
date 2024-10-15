// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RuneDrawCostBlockExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034B5")]
  public class RuneDrawCostBlockExhibit : 
    BaseExhibit,
    IRenderModel<RuneDrawCostBlockModel>,
    IRenderModel
  {
    [Token(Token = "0x400FA37")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RuneDrawCostBlockExhibit.EKey), typeof (RuneDrawCostBlockExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600EA03")]
    [Address(RVA = "0xAF1AF0", Offset = "0xAF08F0", VA = "0x10AF1AF0", Slot = "8")]
    public void Render(RuneDrawCostBlockModel model)
    {
    }

    [Token(Token = "0x600EA04")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RuneDrawCostBlockExhibit()
    {
    }

    [Token(Token = "0x20034B6")]
    private enum EKey
    {
      [Token(Token = "0x400FA39")] None,
      [Token(Token = "0x400FA3A")] Visible,
      [Token(Token = "0x400FA3B")] Image,
      [Token(Token = "0x400FA3C")] Value,
      [Token(Token = "0x400FA3D")] HaveValue,
      [Token(Token = "0x400FA3E")] ValuePerHave,
    }
  }
}
