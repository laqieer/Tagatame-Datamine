// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.ResonanceUnitConfirmWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200349B")]
  public class ResonanceUnitConfirmWindowExhibit : 
    BaseExhibit,
    IRenderModel<ResonanceUnitConfirmWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400F9C4")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (ResonanceUnitConfirmWindowExhibit.EKey), typeof (ResonanceUnitConfirmWindowExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E9D5")]
    [Address(RVA = "0xAEEB50", Offset = "0xAED950", VA = "0x10AEEB50", Slot = "8")]
    public void Render(ResonanceUnitConfirmWindowModel model)
    {
    }

    [Token(Token = "0x600E9D6")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public ResonanceUnitConfirmWindowExhibit()
    {
    }

    [Token(Token = "0x200349C")]
    private enum EKey
    {
      [Token(Token = "0x400F9C6")] None,
      [Token(Token = "0x400F9C7")] Description,
      [Token(Token = "0x400F9C8")] ButtonOK,
    }
  }
}
