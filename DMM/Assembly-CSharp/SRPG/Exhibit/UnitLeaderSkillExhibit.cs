// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.UnitLeaderSkillExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003503")]
  public class UnitLeaderSkillExhibit : BaseExhibit, IRenderModel<UnitLeaderSkillModel>, IRenderModel
  {
    [Token(Token = "0x400FBB7")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (UnitLeaderSkillExhibit.EKey), typeof (UnitLeaderSkillExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600EA7C")]
    [Address(RVA = "0xAFAB70", Offset = "0xAF9970", VA = "0x10AFAB70", Slot = "8")]
    public void Render(UnitLeaderSkillModel model)
    {
    }

    [Token(Token = "0x600EA7D")]
    [Address(RVA = "0xAFAAA0", Offset = "0xAF98A0", VA = "0x10AFAAA0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600EA7E")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public UnitLeaderSkillExhibit()
    {
    }

    [Token(Token = "0x2003504")]
    private enum EKey
    {
      [Token(Token = "0x400FBB9"), CustomEnumDesc("未設定")] None,
      [Token(Token = "0x400FBBA"), CustomEnumDesc("リーダースキル名(テキスト設定)")] Name,
      [Token(Token = "0x400FBBB"), CustomEnumDesc("リーダースキル説明(テキスト設定)")] Expr,
      [Token(Token = "0x400FBBC"), CustomEnumDesc("リーダースキル変更ボタン(ボタン設定)")] LeaderSkillButton,
      [Token(Token = "0x400FBBD"), CustomEnumDesc("リーダースキル枠（ImageArray設定）")] BGImage,
    }
  }
}
