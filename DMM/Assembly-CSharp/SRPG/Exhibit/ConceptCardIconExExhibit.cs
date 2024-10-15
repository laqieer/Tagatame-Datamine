// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.ConceptCardIconExExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20033F9")]
  public class ConceptCardIconExExhibit : 
    BaseExhibit,
    IRenderModel<ConceptCardIconExModel>,
    IRenderModel
  {
    [Token(Token = "0x400F66F")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (ConceptCardIconExExhibit.EKey), typeof (ConceptCardIconExExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E8DC")]
    [Address(RVA = "0xAD8480", Offset = "0xAD7280", VA = "0x10AD8480", Slot = "8")]
    public void Render(ConceptCardIconExModel model)
    {
    }

    [Token(Token = "0x600E8DD")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardIconExExhibit()
    {
    }

    [Token(Token = "0x20033FA")]
    private enum EKey
    {
      [Token(Token = "0x400F671")] None,
      [Token(Token = "0x400F672")] Icon,
      [Token(Token = "0x400F673")] Name,
      [Token(Token = "0x400F674")] LevelTitle,
      [Token(Token = "0x400F675")] Level,
      [Token(Token = "0x400F676")] LevelCap,
      [Token(Token = "0x400F677")] Rarity,
      [Token(Token = "0x400F678")] RarityFrame,
      [Token(Token = "0x400F679")] TrustText,
      [Token(Token = "0x400F67A")] Favorite,
      [Token(Token = "0x400F67B")] Owner,
      [Token(Token = "0x400F67C")] OwnerIcon,
      [Token(Token = "0x400F67D")] SameCardIcon,
      [Token(Token = "0x400F67E")] EquipTypeImage,
      [Token(Token = "0x400F67F")] ExistSwitchOn,
      [Token(Token = "0x400F680")] ExistSwitchOff,
      [Token(Token = "0x400F681")] CardNum,
      [Token(Token = "0x400F682")] NotSale,
      [Token(Token = "0x400F683")] Recommend,
      [Token(Token = "0x400F684")] DisableObject,
      [Token(Token = "0x400F685")] SelectObject,
      [Token(Token = "0x400F686")] AwakeIcon,
    }
  }
}
