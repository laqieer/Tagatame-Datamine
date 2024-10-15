// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.CrystalEquipSelectWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003419")]
  public class CrystalEquipSelectWindowExhibit : 
    BaseExhibit,
    IRenderModel<CrystalEquipSelectWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400F725")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (CrystalEquipSelectWindowExhibit.EKey), typeof (CrystalEquipSelectWindowExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E903")]
    [Address(RVA = "0xAD9EA0", Offset = "0xAD8CA0", VA = "0x10AD9EA0", Slot = "8")]
    public void Render(CrystalEquipSelectWindowModel _model)
    {
    }

    [Token(Token = "0x600E904")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalEquipSelectWindowExhibit()
    {
    }

    [Token(Token = "0x200341A")]
    private enum EKey
    {
      [Token(Token = "0x400F727")] None,
      [Token(Token = "0x400F728")] EmptyDisp,
      [Token(Token = "0x400F729")] SelectDisp,
      [Token(Token = "0x400F72A")] CrystalName,
      [Token(Token = "0x400F72B")] CrystalSubObj,
      [Token(Token = "0x400F72C")] CrystalSubParam,
    }
  }
}
