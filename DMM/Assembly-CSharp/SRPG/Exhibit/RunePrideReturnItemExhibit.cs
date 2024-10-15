// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RunePrideReturnItemExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034E7")]
  public class RunePrideReturnItemExhibit : 
    BaseItemExhibit,
    IRenderModel<RunePrideReturnItemModel>,
    IRenderModel
  {
    [Token(Token = "0x400FB21")]
    [FieldOffset(Offset = "0x38")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RunePrideReturnItemExhibit.EKey), typeof (RunePrideReturnItemExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600EA4E")]
    [Address(RVA = "0xAF5340", Offset = "0xAF4140", VA = "0x10AF5340", Slot = "9")]
    public void Render(RunePrideReturnItemModel _model)
    {
    }

    [Token(Token = "0x600EA4F")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RunePrideReturnItemExhibit()
    {
    }

    [Token(Token = "0x20034E8")]
    private enum EKey
    {
      [Token(Token = "0x400FB23")] None,
      [Token(Token = "0x400FB24")] ReturnNum,
    }
  }
}
