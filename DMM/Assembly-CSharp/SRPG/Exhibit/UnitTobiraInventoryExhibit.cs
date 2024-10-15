// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.UnitTobiraInventoryExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034F1")]
  public class UnitTobiraInventoryExhibit : 
    BaseExhibit,
    IRenderModel<UnitTobiraInventoryModel>,
    IRenderModel
  {
    [Token(Token = "0x400FB54")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (UnitTobiraInventoryExhibit.EKey), typeof (UnitTobiraInventoryExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400FB55")]
    [FieldOffset(Offset = "0x38")]
    public ExhibitList resonanceUnitIconExhibitList;

    [Token(Token = "0x600EA63")]
    [Address(RVA = "0xAFBE90", Offset = "0xAFAC90", VA = "0x10AFBE90", Slot = "8")]
    public void Render(UnitTobiraInventoryModel model)
    {
    }

    [Token(Token = "0x600EA64")]
    [Address(RVA = "0xAFC1D0", Offset = "0xAFAFD0", VA = "0x10AFC1D0")]
    private void SetAllResonance(UnitTobiraInventoryModel model)
    {
    }

    [Token(Token = "0x600EA65")]
    [Address(RVA = "0xAFC250", Offset = "0xAFB050", VA = "0x10AFC250")]
    private void SetResonanceUnitIcon(UnitTobiraInventoryModel model)
    {
    }

    [Token(Token = "0x600EA66")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public UnitTobiraInventoryExhibit()
    {
    }

    [Token(Token = "0x20034F2")]
    private enum EKey
    {
      [Token(Token = "0x400FB57")] None,
      [Token(Token = "0x400FB58")] ResonanceUnitIcon,
      [Token(Token = "0x400FB59")] ResonanceBlocking,
      [Token(Token = "0x400FB5A")] AllResonance,
      [Token(Token = "0x400FB5B")] ResonanceLink,
      [Token(Token = "0x400FB5C")] ResonanceLock,
    }
  }
}
