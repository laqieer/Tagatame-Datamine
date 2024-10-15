// Decompiled with JetBrains decompiler
// Type: SRPG.UnitAbilityList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002BA0")]
  [FlowNode.Pin(100, "アビリティ詳細画面の表示", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/UnitAbilityList")]
  public class UnitAbilityList : MonoBehaviour, IFlowInterface, IGameParameter
  {
    [Token(Token = "0x400D635")]
    [FieldOffset(Offset = "0xC")]
    public UnitAbilityList.RefreshTypes RefreshOnStart;
    [Token(Token = "0x400D636")]
    [FieldOffset(Offset = "0x10")]
    private UnitAbilityList.RefreshTypes mLastDisplayMode;
    [Token(Token = "0x400D637")]
    [FieldOffset(Offset = "0x14")]
    private EAbilitySlot mLastDisplaySlot;
    [Token(Token = "0x400D638")]
    [FieldOffset(Offset = "0x18")]
    public bool AutoRefresh;
    [Token(Token = "0x400D639")]
    [FieldOffset(Offset = "0x1C")]
    public UnitAbilityList.AbilityEvent OnAbilitySelect;
    [Token(Token = "0x400D63A")]
    [FieldOffset(Offset = "0x20")]
    public UnitAbilityList.AbilityEvent OnAbilityRankUp;
    [Token(Token = "0x400D63B")]
    [FieldOffset(Offset = "0x24")]
    public UnitAbilityList.AbilityEvent OnRankUpBtnPress;
    [Token(Token = "0x400D63C")]
    [FieldOffset(Offset = "0x28")]
    public UnitAbilityList.AbilityEvent OnAbilityRankUpExec;
    [Token(Token = "0x400D63D")]
    [FieldOffset(Offset = "0x2C")]
    public UnitAbilityList.AbilitySlotEvent OnSlotSelect;
    [Token(Token = "0x400D63E")]
    [FieldOffset(Offset = "0x30")]
    public UnitData Unit;
    [Token(Token = "0x400D63F")]
    [FieldOffset(Offset = "0x34")]
    [Description("アビリティ詳細を表示するアンカー位置 (0.0 - 1.0)")]
    public Vector2 TooltipAnchorPos;
    [Token(Token = "0x400D640")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject AbilityTooltip;
    [Token(Token = "0x400D641")]
    [FieldOffset(Offset = "0x40")]
    [Description("通常状態のアイテムとして使用する雛形")]
    public UnitAbilityListItemEvents Item_Normal;
    [Token(Token = "0x400D642")]
    [FieldOffset(Offset = "0x44")]
    [Description("ロック状態のアイテムとして使用する雛形")]
    public UnitAbilityListItemEvents Item_Locked;
    [Token(Token = "0x400D643")]
    [FieldOffset(Offset = "0x48")]
    [Description("使用不可スロットの雛形")]
    public UnitAbilityListItemEvents Item_NoSlot;
    [Token(Token = "0x400D644")]
    [FieldOffset(Offset = "0x4C")]
    [Description("アビリティが割り当てられていないスロットの雛形")]
    public UnitAbilityListItemEvents Item_Empty;
    [Token(Token = "0x400D645")]
    [FieldOffset(Offset = "0x50")]
    [Description("スロットが違うアイテムの雛形")]
    public UnitAbilityListItemEvents Item_SlotMismatch;
    [Token(Token = "0x400D646")]
    [FieldOffset(Offset = "0x54")]
    [Description("変更できないアビリティのスロットの雛形")]
    public UnitAbilityListItemEvents Item_Fixed;
    [Token(Token = "0x400D647")]
    [FieldOffset(Offset = "0x58")]
    private List<UnitAbilityListItemEvents> mItems;
    [Token(Token = "0x400D648")]
    [FieldOffset(Offset = "0x5C")]
    [Description("固定アビリティを表示する")]
    public bool ShowFixedAbilities;
    [Token(Token = "0x400D649")]
    [FieldOffset(Offset = "0x5D")]
    [Description("マスターアビリティを表示する")]
    public bool ShowMasterAbilities;
    [Token(Token = "0x400D64A")]
    [FieldOffset(Offset = "0x5E")]
    public bool ShowLockedJobAbilities;
    [Token(Token = "0x400D64B")]
    [FieldOffset(Offset = "0x60")]
    public ScrollRect ScrollParent;
    [Token(Token = "0x400D64C")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private GameObject EnableIfJobUnlock;
    [Token(Token = "0x400D64D")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject EnableIfJobLock;
    [Token(Token = "0x400D64E")]
    [FieldOffset(Offset = "0x6C")]
    private float mDecelerationRate;

    [Token(Token = "0x600C85B")]
    [Address(RVA = "0x918A40", Offset = "0x917840", VA = "0x10918A40")]
    private void Start()
    {
    }

    [Token(Token = "0x600C85C")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C85D")]
    [Address(RVA = "0x9166B0", Offset = "0x9154B0", VA = "0x109166B0")]
    public void DisplayAll()
    {
    }

    [Token(Token = "0x600C85E")]
    [Address(RVA = "0x916690", Offset = "0x915490", VA = "0x10916690")]
    public void DisplayAll_UnitInventory(bool isResetScrollPos)
    {
    }

    [Token(Token = "0x600C85F")]
    [Address(RVA = "0x917E20", Offset = "0x916C20", VA = "0x10917E20")]
    public void DisplaySlots_UnitInventory(UnitData unitData)
    {
    }

    [Token(Token = "0x600C860")]
    [Address(RVA = "0x917EE0", Offset = "0x916CE0", VA = "0x10917EE0")]
    public void DisplaySlots()
    {
    }

    [Token(Token = "0x600C861")]
    [Address(RVA = "0x919410", Offset = "0x918210", VA = "0x10919410")]
    private void _OnSlotSelect(GameObject go)
    {
    }

    [Token(Token = "0x600C862")]
    [Address(RVA = "0x36C350", Offset = "0x36B150", VA = "0x1036C350")]
    private GameObject GetItemRoot(GameObject go) => (GameObject) null;

    [Token(Token = "0x600C863")]
    [Address(RVA = "0x9192B0", Offset = "0x9180B0", VA = "0x109192B0")]
    private void _OnAbilitySelect(GameObject go)
    {
    }

    [Token(Token = "0x600C864")]
    [Address(RVA = "0x919230", Offset = "0x918030", VA = "0x10919230")]
    private void _OnAbilityRankUp(GameObject go)
    {
    }

    [Token(Token = "0x600C865")]
    [Address(RVA = "0x918E60", Offset = "0x917C60", VA = "0x10918E60")]
    private void _OnAbilityDetail(GameObject go)
    {
    }

    [Token(Token = "0x600C866")]
    [Address(RVA = "0x919310", Offset = "0x918110", VA = "0x10919310")]
    private void _OnRankUpBtnPress(GameObject go)
    {
    }

    [Token(Token = "0x600C867")]
    [Address(RVA = "0x919390", Offset = "0x918190", VA = "0x10919390")]
    private void _OnRankUpBtnUp(GameObject go)
    {
    }

    [Token(Token = "0x600C868")]
    [Address(RVA = "0x9187B0", Offset = "0x9175B0", VA = "0x109187B0")]
    private bool GetAbilitySource(string abilityID, out JobData job, out int rank) => new bool();

    [Token(Token = "0x600C869")]
    [Address(RVA = "0x9166D0", Offset = "0x9154D0", VA = "0x109166D0")]
    public void DisplaySlotType(
      EAbilitySlot slotType,
      bool hideEquipped = false,
      bool showDerivedAbility = false,
      bool isResetScrollPos = true)
    {
    }

    [Token(Token = "0x600C86A")]
    [Address(RVA = "0x9188A0", Offset = "0x9176A0", VA = "0x109188A0")]
    private IEnumerator RefreshScrollRect() => (IEnumerator) null;

    [Token(Token = "0x600C86B")]
    [Address(RVA = "0x918D00", Offset = "0x917B00", VA = "0x10918D00")]
    public void UpdateItem(AbilityData ability)
    {
    }

    [Token(Token = "0x17001A8C")]
    public bool IsEmpty
    {
      [Token(Token = "0x600C86C"), Address(RVA = "0x919560", Offset = "0x918360", VA = "0x10919560")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C86D")]
    [Address(RVA = "0x918E00", Offset = "0x917C00", VA = "0x10918E00", Slot = "5")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x600C86E")]
    [Address(RVA = "0x918910", Offset = "0x917710", VA = "0x10918910")]
    public void ResetScrollPos()
    {
    }

    [Token(Token = "0x600C86F")]
    [Address(RVA = "0x9194E0", Offset = "0x9182E0", VA = "0x109194E0")]
    public UnitAbilityList()
    {
    }

    [Token(Token = "0x2002BA1")]
    public enum RefreshTypes
    {
      [Token(Token = "0x400D650")] None,
      [Token(Token = "0x400D651")] DisplayAll,
      [Token(Token = "0x400D652")] DisplaySlots,
    }

    [Token(Token = "0x2002BA2")]
    public delegate void AbilityEvent(AbilityData ability, GameObject itemGO);

    [Token(Token = "0x2002BA3")]
    public delegate void AbilitySlotEvent(int slotIndex);
  }
}
