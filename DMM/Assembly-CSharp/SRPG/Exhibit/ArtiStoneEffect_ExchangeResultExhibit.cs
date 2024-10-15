// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.ArtiStoneEffect_ExchangeResultExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20033ED")]
  public class ArtiStoneEffect_ExchangeResultExhibit : 
    BaseExhibit,
    IRenderModel<ArtiStoneEffect_ExchangeResultModel>,
    IRenderModel
  {
    [Token(Token = "0x400F618")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (ArtiStoneEffect_ExchangeResultExhibit.EKey), typeof (ArtiStoneEffect_ExchangeResultExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600E8C3")]
    [Address(RVA = "0xAD5F50", Offset = "0xAD4D50", VA = "0x10AD5F50", Slot = "8")]
    public void Render(ArtiStoneEffect_ExchangeResultModel model)
    {
    }

    [Token(Token = "0x600E8C4")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArtiStoneEffect_ExchangeResultExhibit()
    {
    }

    [Token(Token = "0x20033EE")]
    private enum EKey
    {
      [Token(Token = "0x400F61A")] None,
      [Token(Token = "0x400F61B")] ItemIcon,
      [Token(Token = "0x400F61C")] ItemFrame,
      [Token(Token = "0x400F61D")] ItemName,
      [Token(Token = "0x400F61E")] ItemAddValue,
    }
  }
}
