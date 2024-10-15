// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.InspirationSkillResetExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20033E1")]
  public class InspirationSkillResetExhibit : 
    BaseExhibit,
    IRenderModel<InspirationSkillResetModel>,
    IRenderModel
  {
    [Token(Token = "0x400F5D7")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (InspirationSkillResetExhibit.EKey), typeof (InspirationSkillResetExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400F5D8")]
    [FieldOffset(Offset = "0x38")]
    [CustomField("mAnimator:AbilityTpe", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("InspirationSkillResetExhibit - 専用追加")]
    public GameObject mAnimatorObj;
    [Token(Token = "0x400F5D9")]
    [FieldOffset(Offset = "0x3C")]
    [CustomField("ImageArray:AbilityTpe", CustomFieldAttribute.Type.ImageArray)]
    [CustomGroup("InspirationSkillResetExhibit - 専用追加")]
    public ImageArray mAblityTypeImageArray;

    [Token(Token = "0x600E8B3")]
    [Address(RVA = "0xAC53C0", Offset = "0xAC41C0", VA = "0x10AC53C0", Slot = "8")]
    public void Render(InspirationSkillResetModel model)
    {
    }

    [Token(Token = "0x600E8B4")]
    [Address(RVA = "0xAC5640", Offset = "0xAC4440", VA = "0x10AC5640")]
    private void SetAbilityAnimatorInt(string name, int value, AbilityParam ap)
    {
    }

    [Token(Token = "0x600E8B5")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public InspirationSkillResetExhibit()
    {
    }

    [Token(Token = "0x20033E2")]
    private enum EKey
    {
      [Token(Token = "0x400F5DB")] None,
      [Token(Token = "0x400F5DC")] NEW_ABILITY_TYPE,
      [Token(Token = "0x400F5DD")] NEW_ABILITY_LV,
      [Token(Token = "0x400F5DE")] NEW_ABILITY_NAME,
      [Token(Token = "0x400F5DF")] NEW_ABILITY_DESC,
      [Token(Token = "0x400F5E0")] PARENT_ABILITY_TYPE,
      [Token(Token = "0x400F5E1")] PARENT_ABILITY_LV,
      [Token(Token = "0x400F5E2")] PARENT_ABILITY_NAME,
      [Token(Token = "0x400F5E3")] PARENT_ABILITY_DESC,
      [Token(Token = "0x400F5E4")] TITLE_TEXT,
      [Token(Token = "0x400F5E5")] EXPLAIN_TEXT,
    }
  }
}
