// Decompiled with JetBrains decompiler
// Type: SRPG.RecentPartyPanel
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
  [Token(Token = "0x2002939")]
  [AddComponentMenu("UI/RecentPartyPanel")]
  public class RecentPartyPanel : MonoBehaviour
  {
    [Token(Token = "0x400C68A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GenericSlot UnitSlotTemplate;
    [Token(Token = "0x400C68B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GenericSlot NpcSlotTemplate;
    [Token(Token = "0x400C68C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform MembersHolder;
    [Token(Token = "0x400C68D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject[] ConditionItems;
    [Token(Token = "0x400C68E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject[] ConditionStars;
    [Token(Token = "0x400C68F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text UserName;
    [Token(Token = "0x400C690")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text Level;
    [Token(Token = "0x400C691")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text ClearDate;
    [Token(Token = "0x400C692")]
    [FieldOffset(Offset = "0x2C")]
    private QuestParam mCurrentQuest;
    [Token(Token = "0x400C693")]
    [FieldOffset(Offset = "0x30")]
    private UnitData[] mCurrentParty;
    [Token(Token = "0x400C694")]
    [FieldOffset(Offset = "0x34")]
    private SupportData mCurrentSupport;
    [Token(Token = "0x400C695")]
    [FieldOffset(Offset = "0x38")]
    private List<UnitData> mGuestUnits;
    [Token(Token = "0x400C696")]
    [FieldOffset(Offset = "0x3C")]
    private GenericSlot[] UnitSlots;
    [Token(Token = "0x400C697")]
    [FieldOffset(Offset = "0x40")]
    private GenericSlot[] SubUnitSlots;
    [Token(Token = "0x400C698")]
    [FieldOffset(Offset = "0x44")]
    private GenericSlot GuestUnitSlot;
    [Token(Token = "0x400C699")]
    [FieldOffset(Offset = "0x48")]
    private GenericSlot FriendSlot;
    [Token(Token = "0x400C69A")]
    [FieldOffset(Offset = "0x4C")]
    private List<PartySlotData> mSlotData;
    [Token(Token = "0x400C69B")]
    [FieldOffset(Offset = "0x50")]
    private List<SRPG_Button> allUnitButtons;

    [Token(Token = "0x600BA6F")]
    [Address(RVA = "0x81E710", Offset = "0x81D510", VA = "0x1081E710")]
    private void Start()
    {
    }

    [Token(Token = "0x600BA70")]
    [Address(RVA = "0x81E4E0", Offset = "0x81D2E0", VA = "0x1081E4E0")]
    public void SetUnitIconPressedCallback(SRPG_Button.ButtonClickEvent callback)
    {
    }

    [Token(Token = "0x600BA71")]
    [Address(RVA = "0x81E400", Offset = "0x81D200", VA = "0x1081E400")]
    public void SetPartyInfo(UnitData[] party, SupportData supportData, QuestParam questParam)
    {
    }

    [Token(Token = "0x600BA72")]
    [Address(RVA = "0x81E610", Offset = "0x81D410", VA = "0x1081E610")]
    public void SetUserName(string value)
    {
    }

    [Token(Token = "0x600BA73")]
    [Address(RVA = "0x81E690", Offset = "0x81D490", VA = "0x1081E690")]
    public void SetUserRank(string value)
    {
    }

    [Token(Token = "0x600BA74")]
    [Address(RVA = "0x81E300", Offset = "0x81D100", VA = "0x1081E300")]
    public void SetClearDate(string value)
    {
    }

    [Token(Token = "0x600BA75")]
    [Address(RVA = "0x81E3C0", Offset = "0x81D1C0", VA = "0x1081E3C0")]
    public void SetConditionStarActive(int index, bool active)
    {
    }

    [Token(Token = "0x600BA76")]
    [Address(RVA = "0x81E380", Offset = "0x81D180", VA = "0x1081E380")]
    public void SetConditionItemActive(int index, bool active)
    {
    }

    [Token(Token = "0x600BA77")]
    [Address(RVA = "0x81D660", Offset = "0x81C460", VA = "0x1081D660")]
    private GenericSlot CreateSlotObject(
      PartySlotData slotData,
      GenericSlot template,
      Transform parent)
    {
      return (GenericSlot) null;
    }

    [Token(Token = "0x600BA78")]
    [Address(RVA = "0x81DF10", Offset = "0x81CD10", VA = "0x1081DF10")]
    private void DestroyPartySlotObjects()
    {
    }

    [Token(Token = "0x600BA79")]
    [Address(RVA = "0x81D750", Offset = "0x81C550", VA = "0x1081D750")]
    private void CreateSlots()
    {
    }

    [Token(Token = "0x600BA7A")]
    [Address(RVA = "0x81DFD0", Offset = "0x81CDD0", VA = "0x1081DFD0")]
    private void ReflectionUnitSlot()
    {
    }

    [Token(Token = "0x600BA7B")]
    [Address(RVA = "0x81E770", Offset = "0x81D570", VA = "0x1081E770")]
    public RecentPartyPanel()
    {
    }
  }
}
