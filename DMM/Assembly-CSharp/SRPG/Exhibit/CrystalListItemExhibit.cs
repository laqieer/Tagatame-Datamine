// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.CrystalListItemExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003405")]
  public class CrystalListItemExhibit : BaseExhibit, IRenderModel<CrystalListItemModel>, IRenderModel
  {
    [Token(Token = "0x400F6A6")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (CrystalListItemExhibit.EKey), typeof (CrystalListItemExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400F6A7")]
    [FieldOffset(Offset = "0x38")]
    [CustomGroup("バッチ切り替え")]
    [CustomField("対象", CustomFieldAttribute.Type.Component, typeof (SwitchingBadge), null)]
    public SwitchingBadge m_SwitchingBadge;
    [Token(Token = "0x400F6A8")]
    [FieldOffset(Offset = "0x3C")]
    [CustomField("既存前回使用テキスト", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("Leaguematch")]
    public GameObject m_GvGUsed;

    [Token(Token = "0x600E8E8")]
    [Address(RVA = "0xADA7B0", Offset = "0xAD95B0", VA = "0x10ADA7B0", Slot = "6")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x600E8E9")]
    [Address(RVA = "0xADA820", Offset = "0xAD9620", VA = "0x10ADA820", Slot = "8")]
    public void Render(CrystalListItemModel _model)
    {
    }

    [Token(Token = "0x600E8EA")]
    [Address(RVA = "0xADB070", Offset = "0xAD9E70", VA = "0x10ADB070")]
    private void SetImageSprite(Sprite _sprite)
    {
    }

    [Token(Token = "0x600E8EB")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalListItemExhibit()
    {
    }

    [Token(Token = "0x2003406")]
    private enum EKey
    {
      [Token(Token = "0x400F6AA")] None,
      [Token(Token = "0x400F6AB")] EquipUnitSprite,
      [Token(Token = "0x400F6AC")] EquipArenaUnitSprite,
      [Token(Token = "0x400F6AD")] EquipSupportUnitSprite,
      [Token(Token = "0x400F6AE")] EquipGvGUnitSprite,
      [Token(Token = "0x400F6AF")] EquipLeaguematchUnitSprite,
      [Token(Token = "0x400F6B0")] EquipUnitObj,
      [Token(Token = "0x400F6B1")] EquipArenaObj,
      [Token(Token = "0x400F6B2")] EquipSupportObj,
      [Token(Token = "0x400F6B3")] GvGEquipUnitObj,
      [Token(Token = "0x400F6B4")] LeaguematchEquipUnitObj,
      [Token(Token = "0x400F6B5")] DispSortRank,
      [Token(Token = "0x400F6B6")] DispSortParam,
      [Token(Token = "0x400F6B7")] IsMask,
      [Token(Token = "0x400F6B8")] IsSelect,
      [Token(Token = "0x400F6B9")] IsRecommend,
      [Token(Token = "0x400F6BA")] IsFavorite,
      [Token(Token = "0x400F6BB")] IsItemDisp,
      [Token(Token = "0x400F6BC")] IsRemoveDisp,
      [Token(Token = "0x400F6BD")] DispRank,
      [Token(Token = "0x400F6BE")] DispCrystalName,
      [Token(Token = "0x400F6BF")] IsGvGUsed,
      [Token(Token = "0x400F6C0")] IsUsedBattle,
      [Token(Token = "0x400F6C1")] IsSameInameMask,
      [Token(Token = "0x400F6C2")] IsEquipList,
      [Token(Token = "0x400F6C3")] IsAllList,
      [Token(Token = "0x400F6C4")] IsGradeupList,
      [Token(Token = "0x400F6C5")] EquipImageIndex,
      [Token(Token = "0x400F6C6")] IsSaleSelectMask,
      [Token(Token = "0x400F6C7")] IsOrganizationObj,
      [Token(Token = "0x400F6C8")] IsBeforeUsedObj,
      [Token(Token = "0x400F6C9")] HaveAmountTxt,
    }
  }
}
