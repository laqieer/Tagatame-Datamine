// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.UnitEquipRuneBulkReleaseWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034C9")]
  public class UnitEquipRuneBulkReleaseWindowExhibit : 
    BaseExhibit,
    IRenderModel<UnitEquipRuneBulkReleaseWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400FA7C")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (UnitEquipRuneBulkReleaseWindowExhibit.EKey), typeof (UnitEquipRuneBulkReleaseWindowExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600EA1D")]
    [Address(RVA = "0xAF9A70", Offset = "0xAF8870", VA = "0x10AF9A70", Slot = "8")]
    public void Render(UnitEquipRuneBulkReleaseWindowModel model)
    {
    }

    [Token(Token = "0x600EA1E")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public UnitEquipRuneBulkReleaseWindowExhibit()
    {
    }

    [Token(Token = "0x20034CA")]
    private enum EKey
    {
      [Token(Token = "0x400FA7E")] None,
      [Token(Token = "0x400FA7F")] Toggle,
      [Token(Token = "0x400FA80")] Button,
    }
  }
}
