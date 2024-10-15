// Decompiled with JetBrains decompiler
// Type: SRPG.UnitAbilityListEx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002BA5")]
  [FlowNode.Pin(100, "アビリティ詳細画面の表示", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/UnitAbilityListEx")]
  public class UnitAbilityListEx : MonoBehaviour, IFlowInterface, IGameParameter
  {
    [Token(Token = "0x400D656")]
    private const int PIN_IN_ABILITY_DETAIL = 100;
    [Token(Token = "0x400D657")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400D658")]
    [FieldOffset(Offset = "0x10")]
    public UnitAbilityListEx.RefreshTypes RefreshOnStart;
    [Token(Token = "0x400D659")]
    [FieldOffset(Offset = "0x14")]
    private UnitAbilityListEx.RefreshTypes mLastDisplayMode;
    [Token(Token = "0x400D65A")]
    [FieldOffset(Offset = "0x18")]
    private EAbilitySlot mLastDisplaySlot;
    [Token(Token = "0x400D65B")]
    [FieldOffset(Offset = "0x1C")]
    public bool AutoRefresh;
    [Token(Token = "0x400D65C")]
    [FieldOffset(Offset = "0x20")]
    public UnitAbilityListEx.AbilityEvent OnAbilitySelect;
    [Token(Token = "0x400D65D")]
    [FieldOffset(Offset = "0x24")]
    public UnitAbilityListEx.AbilityEvent OnAbilityRankUp;
    [Token(Token = "0x400D65E")]
    [FieldOffset(Offset = "0x28")]
    public UnitAbilityListEx.AbilityEvent OnRankUpBtnPress;
    [Token(Token = "0x400D65F")]
    [FieldOffset(Offset = "0x2C")]
    public UnitAbilityListEx.AbilityEvent OnAbilityRankUpExec;
    [Token(Token = "0x400D660")]
    [FieldOffset(Offset = "0x30")]
    public UnitAbilityListEx.AbilitySlotEvent OnSlotSelect;
    [Token(Token = "0x400D661")]
    [FieldOffset(Offset = "0x34")]
    [Description("アビリティ詳細を表示するアンカー位置 (0.0 - 1.0)")]
    public Vector2 TooltipAnchorPos;
    [Token(Token = "0x400D662")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject AbilityTooltip;
    [Token(Token = "0x400D663")]
    [FieldOffset(Offset = "0x40")]
    public UnitAbilityListItemEvents mItemTemplate;
    [Token(Token = "0x400D664")]
    [FieldOffset(Offset = "0x44")]
    public GameObject mItemTemp;
    [Token(Token = "0x400D665")]
    [FieldOffset(Offset = "0x48")]
    [Description("固定アビリティを表示する")]
    public bool ShowFixedAbilities;
    [Token(Token = "0x400D666")]
    [FieldOffset(Offset = "0x49")]
    [Description("マスターアビリティを表示する")]
    public bool ShowMasterAbilities;
    [Token(Token = "0x400D667")]
    [FieldOffset(Offset = "0x4A")]
    public bool ShowLockedJobAbilities;
    [Token(Token = "0x400D668")]
    [FieldOffset(Offset = "0x4C")]
    public ScrollRect ScrollParent;
    [Token(Token = "0x400D669")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject EnableIfJobUnlock;
    [Token(Token = "0x400D66A")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private GameObject EnableIfJobLock;
    [Token(Token = "0x400D66B")]
    [FieldOffset(Offset = "0x58")]
    private UnitAbilityListExModel mModel;
    [Token(Token = "0x400D66C")]
    [FieldOffset(Offset = "0x5C")]
    private List<UnitAbilityListEx.UnitAbilityItem> mItems;
    [Token(Token = "0x400D66D")]
    [FieldOffset(Offset = "0x60")]
    private List<GameObject> mItemObjects;
    [Token(Token = "0x400D66E")]
    [FieldOffset(Offset = "0x64")]
    private float mDecelerationRate;

    [Token(Token = "0x17001A8F")]
    public UnitData Unit
    {
      [Token(Token = "0x600C880"), Address(RVA = "0x915D40", Offset = "0x914B40", VA = "0x10915D40")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x600C881")]
    [Address(RVA = "0x914E30", Offset = "0x913C30", VA = "0x10914E30")]
    private void Start()
    {
    }

    [Token(Token = "0x600C882")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C883")]
    [Address(RVA = "0x912E10", Offset = "0x911C10", VA = "0x10912E10")]
    public void Initialize(UnitData unitData, bool isEdit = true, bool isHide = false)
    {
    }

    [Token(Token = "0x600C884")]
    [Address(RVA = "0x914A10", Offset = "0x913810", VA = "0x10914A10")]
    public void SetModel(UnitData unitData, bool isEdit = true, bool isHide = false)
    {
    }

    [Token(Token = "0x600C885")]
    [Address(RVA = "0x914760", Offset = "0x913560", VA = "0x10914760")]
    public void SetItems(bool isEdit = true, bool isHide = false)
    {
    }

    [Token(Token = "0x600C886")]
    [Address(RVA = "0x914630", Offset = "0x913430", VA = "0x10914630")]
    public void SetItem(
      UnitAbilityListEx.UnitAbilityItem abilityItem,
      int index,
      bool isEdit = true,
      bool isHide = false)
    {
    }

    [Token(Token = "0x600C887")]
    [Address(RVA = "0x914AD0", Offset = "0x9138D0", VA = "0x10914AD0")]
    public void SetSlotItemEvent(
      UnitAbilityListItemEvents ItemEvent,
      AbilityData data,
      UnitAbilityPanelModel.Mode mode,
      bool isEdit = true,
      bool isHide = false)
    {
    }

    [Token(Token = "0x600C888")]
    [Address(RVA = "0x914580", Offset = "0x913380", VA = "0x10914580")]
    public void SetChildInitialize()
    {
    }

    [Token(Token = "0x600C889")]
    [Address(RVA = "0x9139E0", Offset = "0x9127E0", VA = "0x109139E0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600C88A")]
    [Address(RVA = "0x9139B0", Offset = "0x9127B0", VA = "0x109139B0")]
    public void Refresh(UnitData unitData)
    {
    }

    [Token(Token = "0x600C88B")]
    [Address(RVA = "0x912990", Offset = "0x911790", VA = "0x10912990")]
    public void DisplayAll()
    {
    }

    [Token(Token = "0x600C88C")]
    [Address(RVA = "0x912960", Offset = "0x911760", VA = "0x10912960")]
    public void DisplayAll_UnitInventory(bool isResetScrollPos)
    {
    }

    [Token(Token = "0x600C88D")]
    [Address(RVA = "0x912B20", Offset = "0x911920", VA = "0x10912B20")]
    public void DisplaySlots_UnitInventory(UnitData unitData)
    {
    }

    [Token(Token = "0x600C88E")]
    [Address(RVA = "0x912C90", Offset = "0x911A90", VA = "0x10912C90")]
    private AbilityParam GetAbilityParam(GameObject go) => (AbilityParam) null;

    [Token(Token = "0x600C88F")]
    [Address(RVA = "0x912C00", Offset = "0x911A00", VA = "0x10912C00")]
    private AbilityData GetAbilityData(GameObject go) => (AbilityData) null;

    [Token(Token = "0x600C890")]
    [Address(RVA = "0x915B50", Offset = "0x914950", VA = "0x10915B50")]
    private void _OnSlotSelect(GameObject go)
    {
    }

    [Token(Token = "0x600C891")]
    [Address(RVA = "0x915A30", Offset = "0x914830", VA = "0x10915A30")]
    private void _OnAbilitySelect(GameObject go)
    {
    }

    [Token(Token = "0x600C892")]
    [Address(RVA = "0x9159C0", Offset = "0x9147C0", VA = "0x109159C0")]
    private void _OnAbilityRankUp(GameObject go)
    {
    }

    [Token(Token = "0x600C893")]
    [Address(RVA = "0x9155A0", Offset = "0x9143A0", VA = "0x109155A0")]
    private void _OnAbilityDetail(GameObject go)
    {
    }

    [Token(Token = "0x600C894")]
    [Address(RVA = "0x915A70", Offset = "0x914870", VA = "0x10915A70")]
    private void _OnRankUpBtnPress(GameObject go)
    {
    }

    [Token(Token = "0x600C895")]
    [Address(RVA = "0x915AE0", Offset = "0x9148E0", VA = "0x10915AE0")]
    private void _OnRankUpBtnUp(GameObject go)
    {
    }

    [Token(Token = "0x600C896")]
    [Address(RVA = "0x912D20", Offset = "0x911B20", VA = "0x10912D20")]
    private bool GetAbilitySource(string abilityID, out JobData job, out int rank) => new bool();

    [Token(Token = "0x600C897")]
    [Address(RVA = "0x9129A0", Offset = "0x9117A0", VA = "0x109129A0")]
    public void DisplaySlotType(
      EAbilitySlot slotType,
      bool hideEquipped = false,
      bool showDerivedAbility = false,
      bool isResetScrollPos = true)
    {
    }

    [Token(Token = "0x600C898")]
    [Address(RVA = "0x913C20", Offset = "0x912A20", VA = "0x10913C20")]
    public void RememberedAbilityDisplaySlotType(
      EAbilitySlot slotType,
      List<AbilityData> abilityList,
      Transform myTransform,
      bool hideEquipped = false)
    {
    }

    [Token(Token = "0x600C899")]
    [Address(RVA = "0x914F60", Offset = "0x913D60", VA = "0x10914F60")]
    private void UnSelectAbilityDisplaySlotType(
      EAbilitySlot slotType,
      List<AbilityData> abilityList,
      Transform myTransform,
      bool hideEquipped = false)
    {
    }

    [Token(Token = "0x600C89A")]
    [Address(RVA = "0x912E50", Offset = "0x911C50", VA = "0x10912E50")]
    private void NotRememberedAbilityDisplaySlotType(
      UnitData unit,
      EAbilitySlot slotType,
      List<AbilityData> abilityList,
      Transform myTransform,
      bool hideEquipped = false)
    {
    }

    [Token(Token = "0x600C89B")]
    [Address(RVA = "0x913940", Offset = "0x912740", VA = "0x10913940")]
    private IEnumerator RefreshScrollRect() => (IEnumerator) null;

    [Token(Token = "0x600C89C")]
    [Address(RVA = "0x9154D0", Offset = "0x9142D0", VA = "0x109154D0")]
    public void UpdateItem(AbilityData ability)
    {
    }

    [Token(Token = "0x17001A90")]
    public bool IsEmpty
    {
      [Token(Token = "0x600C89D"), Address(RVA = "0x915D00", Offset = "0x914B00", VA = "0x10915D00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C89E")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x600C89F")]
    [Address(RVA = "0x914450", Offset = "0x913250", VA = "0x10914450")]
    public void ResetScrollPos()
    {
    }

    [Token(Token = "0x600C8A0")]
    [Address(RVA = "0x915C40", Offset = "0x914A40", VA = "0x10915C40")]
    public UnitAbilityListEx()
    {
    }

    [Token(Token = "0x2002BA6")]
    public struct UnitAbilityItem
    {
      [Token(Token = "0x400D66F")]
      [FieldOffset(Offset = "0x0")]
      public GameObject gameObject;
      [Token(Token = "0x400D670")]
      [FieldOffset(Offset = "0x4")]
      public UnitAbilityPanel Panel;
      [Token(Token = "0x400D671")]
      [FieldOffset(Offset = "0x8")]
      public UnitAbilityListItemEvents Event;
    }

    [Token(Token = "0x2002BA7")]
    public enum RefreshTypes
    {
      [Token(Token = "0x400D673")] None,
      [Token(Token = "0x400D674")] DisplayAll,
      [Token(Token = "0x400D675")] DisplaySlots,
    }

    [Token(Token = "0x2002BA8")]
    public delegate void AbilityEvent(AbilityData ability, GameObject itemGO);

    [Token(Token = "0x2002BA9")]
    public delegate void AbilitySlotEvent(int slotIndex);
  }
}
