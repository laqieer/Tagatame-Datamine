// Decompiled with JetBrains decompiler
// Type: SRPG.UnitEnhancePanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002BD3")]
  [AddComponentMenu("UI/UnitEnhancePanel")]
  public class UnitEnhancePanel : MonoBehaviour
  {
    [Token(Token = "0x400D73E")]
    [FieldOffset(Offset = "0xC")]
    [HeaderBar("▼ジョブ関連")]
    public UnitEquipmentSlotEvents[] EquipmentSlots;
    [Token(Token = "0x400D73F")]
    [FieldOffset(Offset = "0x10")]
    public SRPG_Button JobRankUpButton;
    [Token(Token = "0x400D740")]
    [FieldOffset(Offset = "0x14")]
    public SRPG_Button JobUnlockButton;
    [Token(Token = "0x400D741")]
    [FieldOffset(Offset = "0x18")]
    public SRPG_Button EquipButton;
    [Token(Token = "0x400D742")]
    [FieldOffset(Offset = "0x1C")]
    public SRPG_Button AllEquipButton;
    [Token(Token = "0x400D743")]
    [FieldOffset(Offset = "0x20")]
    public GameObject JobRankCapCaution;
    [Token(Token = "0x400D744")]
    [FieldOffset(Offset = "0x24")]
    public SRPG_Button JobRankupAllIn;
    [Token(Token = "0x400D745")]
    [FieldOffset(Offset = "0x28")]
    [HeaderBar("▼ユニット強化関連（林檎）")]
    public RectTransform ExpItemList;
    [Token(Token = "0x400D746")]
    [FieldOffset(Offset = "0x2C")]
    public ListItemEvents ExpItemTemplate;
    [Token(Token = "0x400D747")]
    [FieldOffset(Offset = "0x30")]
    public SRPG_Button UnitLevelupButton;
    [Token(Token = "0x400D748")]
    [FieldOffset(Offset = "0x34")]
    [HeaderBar("▼アビリティ一覧関連")]
    public UnitAbilityList AbilityList;
    [Token(Token = "0x400D749")]
    [FieldOffset(Offset = "0x38")]
    [HeaderBar("▼アビリティセット関連")]
    public UnitAbilityList AbilitySlots;
    [Token(Token = "0x400D74A")]
    [FieldOffset(Offset = "0x3C")]
    [HeaderBar("▼武具スロット関連")]
    public GenericSlot ArtifactSlot;
    [Token(Token = "0x400D74B")]
    [FieldOffset(Offset = "0x40")]
    public GenericSlot ArtifactSlot2;
    [Token(Token = "0x400D74C")]
    [FieldOffset(Offset = "0x44")]
    public GenericSlot ArtifactSlot3;
    [Token(Token = "0x400D74D")]
    [FieldOffset(Offset = "0x48")]
    [HeaderBar("▼真理念装スロット関連")]
    public UnitEnhancePanel.ConceptCardSlotObjects[] mConceptCardSlots;
    [Token(Token = "0x400D74E")]
    [FieldOffset(Offset = "0x4C")]
    [HeaderBar("▼リーダースキル関連")]
    public GameObject mLeaderSkillInfo;
    [Token(Token = "0x400D74F")]
    [FieldOffset(Offset = "0x50")]
    [HeaderBar("▼水晶スロット関連")]
    public CrystalEquipSlot CrystalSlot;
    [Token(Token = "0x400D750")]
    [FieldOffset(Offset = "0x54")]
    public Transform CrystalLockDispTrans;

    [Token(Token = "0x600C98C")]
    [Address(RVA = "0x94DE50", Offset = "0x94CC50", VA = "0x1094DE50")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C98D")]
    [Address(RVA = "0x94E060", Offset = "0x94CE60", VA = "0x1094E060")]
    private void Start()
    {
    }

    [Token(Token = "0x600C98E")]
    [Address(RVA = "0x94DF70", Offset = "0x94CD70", VA = "0x1094DF70")]
    public void SetConceptCardOnSelect(GenericSlot.SelectEvent ev)
    {
    }

    [Token(Token = "0x600C98F")]
    [Address(RVA = "0x94DED0", Offset = "0x94CCD0", VA = "0x1094DED0")]
    public void BindUnitData(UnitData unitData)
    {
    }

    [Token(Token = "0x600C990")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitEnhancePanel()
    {
    }

    [Token(Token = "0x2002BD4")]
    [Serializable]
    public struct ConceptCardSlotObjects
    {
      [Token(Token = "0x400D751")]
      [FieldOffset(Offset = "0x0")]
      [LabelPropertyName("Slot")]
      public EquipConceptCardSlot m_ConceptCardSlot;
      [Token(Token = "0x400D752")]
      [FieldOffset(Offset = "0x4")]
      [LabelPropertyName("Icon")]
      public ConceptCardIcon m_EquipConceptCardIcon;
    }
  }
}
