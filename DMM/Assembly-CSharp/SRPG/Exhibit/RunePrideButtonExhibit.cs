// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RunePrideButtonExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034D3")]
  public class RunePrideButtonExhibit : BaseExhibit, IRenderModel<RunePrideButtonModel>, IRenderModel
  {
    [Token(Token = "0x400FAAD")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RunePrideButtonExhibit.EKey), typeof (RunePrideButtonExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600EA29")]
    [Address(RVA = "0xAF2B40", Offset = "0xAF1940", VA = "0x10AF2B40", Slot = "8")]
    public void Render(RunePrideButtonModel _model)
    {
    }

    [Token(Token = "0x600EA2A")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RunePrideButtonExhibit()
    {
    }

    [Token(Token = "0x20034D4")]
    private enum EKey
    {
      [Token(Token = "0x400FAAF")] None,
      [Token(Token = "0x400FAB0")] DispObj,
      [Token(Token = "0x400FAB1")] DispLock,
      [Token(Token = "0x400FAB2")] DispTimeObj,
    }
  }
}
