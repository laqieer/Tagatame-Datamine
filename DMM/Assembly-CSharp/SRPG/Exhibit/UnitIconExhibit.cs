// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.UnitIconExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003501")]
  public class UnitIconExhibit : BaseExhibit, IRenderModel<UnitModel>, IRenderModel
  {
    [Token(Token = "0x400FB9B")]
    [FieldOffset(Offset = "0x34")]
    public Color DeadImgColor;
    [Token(Token = "0x400FB9C")]
    [FieldOffset(Offset = "0x44")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (UnitIconExhibit.EKey), typeof (UnitIconExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;
    [Token(Token = "0x400FB9D")]
    [FieldOffset(Offset = "0x48")]
    [CustomField("アイコンのマテリアル", CustomFieldAttribute.Type.Material)]
    [CustomGroup("ユニット死亡情報")]
    public Material DeadMaterial;

    [Token(Token = "0x600EA79")]
    [Address(RVA = "0xAF9D00", Offset = "0xAF8B00", VA = "0x10AF9D00", Slot = "8")]
    public void Render(UnitModel model)
    {
    }

    [Token(Token = "0x600EA7A")]
    [Address(RVA = "0xAF9C30", Offset = "0xAF8A30", VA = "0x10AF9C30")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600EA7B")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public UnitIconExhibit()
    {
    }

    [Token(Token = "0x2003502")]
    private enum EKey
    {
      [Token(Token = "0x400FB9F"), CustomEnumDesc("未設定")] None,
      [Token(Token = "0x400FBA0"), CustomEnumDesc("ユニットアイコン")] Icon,
      [Token(Token = "0x400FBA1"), CustomEnumDesc("ジョブアイコン")] JobIcon,
      [Token(Token = "0x400FBA2"), CustomEnumDesc("ジョブフレームアイコン")] JobFrame,
      [Token(Token = "0x400FBA3"), CustomEnumDesc("属性アイコン")] Element,
      [Token(Token = "0x400FBA4"), CustomEnumDesc("レアリティアイコン")] Rarity,
      [Token(Token = "0x400FBA5"), CustomEnumDesc("現レベル")] Level,
      [Token(Token = "0x400FBA6"), CustomEnumDesc("最大レベル")] LevelCap,
      [Token(Token = "0x400FBA7"), CustomEnumDesc("ユニット名")] UnitName,
      [Token(Token = "0x400FBA8"), CustomEnumDesc("共鳴・共鳴先のユニットアイコン")] ResonanceUnitIcon,
      [Token(Token = "0x400FBA9"), CustomEnumDesc("共鳴・共鳴先のジョブアイコン")] ResonanceUnitJobIcon,
      [Token(Token = "0x400FBAA"), CustomEnumDesc("共鳴・共鳴先のジョブフレームアイコン")] ResonanceUnitJobFrame,
      [Token(Token = "0x400FBAB"), CustomEnumDesc("共鳴・共鳴先の属性アイコン")] ResonanceUnitElement,
      [Token(Token = "0x400FBAC"), CustomEnumDesc("共鳴・共鳴先のレアリティアイコン")] ResonanceUnitRarity,
      [Token(Token = "0x400FBAD"), CustomEnumDesc("共鳴・共鳴前のレベルObject")] ResonanceBeforeUnitLevelObject,
      [Token(Token = "0x400FBAE"), CustomEnumDesc("共鳴・共鳴用のレベルObject")] ResonanceUnitLevelObject,
      [Token(Token = "0x400FBAF"), CustomEnumDesc("ユニットのイメージ画像2")] UnitImage2,
      [Token(Token = "0x400FBB0"), CustomEnumDesc("戦闘力(Text指定)")] CombatPower,
      [Token(Token = "0x400FBB1"), CustomEnumDesc("リーダー(表示するGameObject指定)")] Leader,
      [Token(Token = "0x400FBB2"), CustomEnumDesc("使用不可(表示するGameObject指定)")] NotUse,
      [Token(Token = "0x400FBB3"), CustomEnumDesc("ユニット未設定(非表示にするGameObject指定)")] EmptyUnit,
      [Token(Token = "0x400FBB4"), CustomEnumDesc("HPバーの指定(HPバーのSlider)")] HpBar,
      [Token(Token = "0x400FBB5"), CustomEnumDesc("パーティー編成フレーム(ImageArray)\n0:ui_PartyEditor_1_col_leader\n1:ui_PartyEditor_1_col_main")] PartyEditorFrame,
      [Token(Token = "0x400FBB6"), CustomEnumDesc("ユニットイメージ死亡表示")] DeadUnitImgColor,
    }
  }
}
