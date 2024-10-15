// Decompiled with JetBrains decompiler
// Type: SRPG.QuestClearedPartyViewer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002891")]
  [AddComponentMenu("UI/QuestClearedPartyViewer")]
  public class QuestClearedPartyViewer : MonoBehaviour
  {
    [Token(Token = "0x400C1FB")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GenericSlot UnitSlotTemplate;
    [Token(Token = "0x400C1FC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GenericSlot NpcSlotTemplate;
    [Token(Token = "0x400C1FD")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform MainMemberHolder;
    [Token(Token = "0x400C1FE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform SubMemberHolder;
    [Token(Token = "0x400C1FF")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject[] ConditionItems;
    [Token(Token = "0x400C200")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject[] ConditionStars;
    [Token(Token = "0x400C201")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GenericSlot[] ItemSlots;
    [Token(Token = "0x400C202")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject EmptyLabel;
    [Token(Token = "0x400C203")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text TotalCombatPower;
    [Token(Token = "0x400C204")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GenericSlot LeaderSkill;
    [Token(Token = "0x400C205")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private ImageArray LeaderSkillBGImageArray;
    [Token(Token = "0x400C206")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GenericSlot SupportSkill;
    [Token(Token = "0x400C207")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject ConceptCardBonus;
    [Token(Token = "0x400C208")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text ConceptCardBonusRate;
    [Token(Token = "0x400C209")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GameObject[] EnableUploadObjects;
    [Token(Token = "0x400C20A")]
    [FieldOffset(Offset = "0x48")]
    private QuestParam mCurrentQuest;
    [Token(Token = "0x400C20B")]
    [FieldOffset(Offset = "0x4C")]
    private UnitData[] mCurrentParty;
    [Token(Token = "0x400C20C")]
    [FieldOffset(Offset = "0x50")]
    private SupportData mCurrentSupport;
    [Token(Token = "0x400C20D")]
    [FieldOffset(Offset = "0x54")]
    private List<UnitData> mGuestUnits;
    [Token(Token = "0x400C20E")]
    [FieldOffset(Offset = "0x58")]
    private GenericSlot[] UnitSlots;
    [Token(Token = "0x400C20F")]
    [FieldOffset(Offset = "0x5C")]
    private GenericSlot[] SubUnitSlots;
    [Token(Token = "0x400C210")]
    [FieldOffset(Offset = "0x60")]
    private GenericSlot GuestUnitSlot;
    [Token(Token = "0x400C211")]
    [FieldOffset(Offset = "0x64")]
    private GenericSlot FriendSlot;
    [Token(Token = "0x400C212")]
    [FieldOffset(Offset = "0x68")]
    private List<PartySlotData> mSlotData;
    [Token(Token = "0x400C213")]
    [FieldOffset(Offset = "0x6C")]
    private bool mIsHeloOnly;
    [Token(Token = "0x400C214")]
    [FieldOffset(Offset = "0x70")]
    private UnitData[] mUserSelectionParty;
    [Token(Token = "0x400C215")]
    [FieldOffset(Offset = "0x74")]
    private int[] mUserSelectionAchievement;
    [Token(Token = "0x400C216")]
    [FieldOffset(Offset = "0x78")]
    private ItemData[] mUsedItems;
    [Token(Token = "0x400C217")]
    [FieldOffset(Offset = "0x7C")]
    private bool mIsUserOwnUnits;

    [Token(Token = "0x600B752")]
    [Address(RVA = "0x7E21E0", Offset = "0x7E0FE0", VA = "0x107E21E0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B753")]
    [Address(RVA = "0x7E1CD0", Offset = "0x7E0AD0", VA = "0x107E1CD0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600B754")]
    [Address(RVA = "0x7E1670", Offset = "0x7E0470", VA = "0x107E1670")]
    private void LoadInventory()
    {
    }

    [Token(Token = "0x600B755")]
    [Address(RVA = "0x7E1450", Offset = "0x7E0250", VA = "0x107E1450")]
    private void LoadConditions()
    {
    }

    [Token(Token = "0x600B756")]
    [Address(RVA = "0x7E1290", Offset = "0x7E0090", VA = "0x107E1290")]
    private void LoadConditionStarsFromBattle()
    {
    }

    [Token(Token = "0x600B757")]
    [Address(RVA = "0x7E13D0", Offset = "0x7E01D0", VA = "0x107E13D0")]
    private void LoadConditionStarsFromUserSelection()
    {
    }

    [Token(Token = "0x600B758")]
    [Address(RVA = "0x7E19F0", Offset = "0x7E07F0", VA = "0x107E19F0")]
    private void LoadParty()
    {
    }

    [Token(Token = "0x600B759")]
    [Address(RVA = "0x7E0AA0", Offset = "0x7DF8A0", VA = "0x107E0AA0")]
    private GenericSlot CreateSlotObject(
      PartySlotData slotData,
      GenericSlot template,
      Transform parent)
    {
      return (GenericSlot) null;
    }

    [Token(Token = "0x600B75A")]
    [Address(RVA = "0x7E11D0", Offset = "0x7DFFD0", VA = "0x107E11D0")]
    private void DestroyPartySlotObjects()
    {
    }

    [Token(Token = "0x600B75B")]
    [Address(RVA = "0x7E0B90", Offset = "0x7DF990", VA = "0x107E0B90")]
    private void CreateSlots()
    {
    }

    [Token(Token = "0x600B75C")]
    [Address(RVA = "0x7E1D30", Offset = "0x7E0B30", VA = "0x107E1D30")]
    private void ReflectionUnitSlot()
    {
    }

    [Token(Token = "0x600B75D")]
    [Address(RVA = "0x7E09F0", Offset = "0x7DF7F0", VA = "0x107E09F0")]
    private void CalcTotalCombatPower()
    {
    }

    [Token(Token = "0x600B75E")]
    [Address(RVA = "0x7E2590", Offset = "0x7E1390", VA = "0x107E2590")]
    private void UpdateLeaderSkills()
    {
    }

    [Token(Token = "0x600B75F")]
    [Address(RVA = "0x7E2CE0", Offset = "0x7E1AE0", VA = "0x107E2CE0")]
    public QuestClearedPartyViewer()
    {
    }
  }
}
