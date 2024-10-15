// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.GalleryCrystalListExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200340F")]
  public class GalleryCrystalListExhibit : 
    BaseExhibit,
    IRenderModel<GalleryCrystalListModel>,
    IRenderModel
  {
    [Token(Token = "0x400F6E9")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (GalleryCrystalListExhibit.EKey), typeof (GalleryCrystalListExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E8F7")]
    [Address(RVA = "0xADD030", Offset = "0xADBE30", VA = "0x10ADD030", Slot = "8")]
    public void Render(GalleryCrystalListModel model)
    {
    }

    [Token(Token = "0x600E8F8")]
    [Address(RVA = "0xADD230", Offset = "0xADC030", VA = "0x10ADD230")]
    public void SetCrystalIcon(GalleryCrystalListModel model)
    {
    }

    [Token(Token = "0x600E8F9")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GalleryCrystalListExhibit()
    {
    }

    [Token(Token = "0x2003410")]
    private enum EKey
    {
      [Token(Token = "0x400F6EB")] None,
      [Token(Token = "0x400F6EC")] MaxPage,
      [Token(Token = "0x400F6ED")] CurrentPage,
      [Token(Token = "0x400F6EE")] NextBtn,
      [Token(Token = "0x400F6EF")] PrevBtn,
      [Token(Token = "0x400F6F0")] CrystalIcon,
    }
  }
}
