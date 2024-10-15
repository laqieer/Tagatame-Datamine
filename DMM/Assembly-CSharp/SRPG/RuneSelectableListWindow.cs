// Decompiled with JetBrains decompiler
// Type: SRPG.RuneSelectableListWindow
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
  [Token(Token = "0x20029E7")]
  [FlowNode.Pin(10, "フィルタ１選択", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(13, "フィルタ４選択", FlowNode.PinTypes.Input, 13)]
  [FlowNode.Pin(14, "フィルタ５選択", FlowNode.PinTypes.Input, 14)]
  [FlowNode.Pin(15, "フィルタ６選択", FlowNode.PinTypes.Input, 15)]
  [FlowNode.Pin(20, "フィルタ「すべて」選択", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(100, "ルーンを選択", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(1000, "自身を閉じる", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(30, "フィルタウィンドウ OK", FlowNode.PinTypes.Input, 30)]
  [FlowNode.Pin(31, "ソートウィンドウ OK", FlowNode.PinTypes.Input, 31)]
  [FlowNode.Pin(32, "装備中を除くボタン", FlowNode.PinTypes.Input, 31)]
  [AddComponentMenu("UI/Rune/RuneSelectableListWindow")]
  [FlowNode.Pin(11, "フィルタ２選択", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(12, "フィルタ３選択", FlowNode.PinTypes.Input, 12)]
  public class RuneSelectableListWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CB90")]
    private const int INPUT_RUNE_SELECT_FILTER_1 = 10;
    [Token(Token = "0x400CB91")]
    private const int INPUT_RUNE_SELECT_FILTER_2 = 11;
    [Token(Token = "0x400CB92")]
    private const int INPUT_RUNE_SELECT_FILTER_3 = 12;
    [Token(Token = "0x400CB93")]
    private const int INPUT_RUNE_SELECT_FILTER_4 = 13;
    [Token(Token = "0x400CB94")]
    private const int INPUT_RUNE_SELECT_FILTER_5 = 14;
    [Token(Token = "0x400CB95")]
    private const int INPUT_RUNE_SELECT_FILTER_6 = 15;
    [Token(Token = "0x400CB96")]
    private const int INPUT_RUNE_SELECT_FILTER_ALL = 20;
    [Token(Token = "0x400CB97")]
    private const int INPUT_RUNE_SELECT_FILTER_WND_APPLY = 30;
    [Token(Token = "0x400CB98")]
    private const int INPUT_RUNE_SELECT_SORT_WND_APPLY = 31;
    [Token(Token = "0x400CB99")]
    private const int INPUT_RUNE_SELECT_EQUIP_HIDE_APPLY = 32;
    [Token(Token = "0x400CB9A")]
    private const int INPUT_RUNE_SELECTED = 100;
    [Token(Token = "0x400CB9B")]
    private const int OUTPUT_CLOSE_WINDOW = 1000;
    [Token(Token = "0x400CB9C")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RuneScrollList mRuneScrollList;
    [Token(Token = "0x400CB9D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RuneSlotNumberFilter mRuneSlotNumberFilter;
    [Token(Token = "0x400CB9E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ImageArray mRuneFilterMode;
    [Token(Token = "0x400CB9F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mRuneSortMode;
    [Token(Token = "0x400CBA0")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mRuneEquipHideObj;
    [Token(Token = "0x400CBA1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Toggle mRuneEquipHideToggle;
    [Token(Token = "0x400CBA2")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private List<Button> mDisableButtonList;
    [Token(Token = "0x400CBA3")]
    [FieldOffset(Offset = "0x28")]
    private RuneManager mRuneManager;
    [Token(Token = "0x400CBA4")]
    [FieldOffset(Offset = "0x2C")]
    private RuneSlotIndex mSelectedRuneSlotIndex;
    [Token(Token = "0x400CBA6")]
    [FieldOffset(Offset = "0x0")]
    private static RuneSelectableListWindow mInstance;

    [Token(Token = "0x14000012")]
    private event RuneSelectableListWindow.OnSelectedEvent mOnSelectedEvent
    {
      [Token(Token = "0x600BEEE"), Address(RVA = "0x8661A0", Offset = "0x864FA0", VA = "0x108661A0")] add
      {
      }
      [Token(Token = "0x600BEEF"), Address(RVA = "0x8662C0", Offset = "0x8650C0", VA = "0x108662C0")] remove
      {
      }
    }

    [Token(Token = "0x170019BA")]
    public static RuneSelectableListWindow Instance
    {
      [Token(Token = "0x600BEF0"), Address(RVA = "0x866290", Offset = "0x865090", VA = "0x10866290")] get
      {
        return (RuneSelectableListWindow) null;
      }
    }

    [Token(Token = "0x170019BB")]
    public RuneSlotIndex SelectedRuneSlotIndex
    {
      [Token(Token = "0x600BEF1"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
      {
        return new RuneSlotIndex();
      }
    }

    [Token(Token = "0x170019BC")]
    public UnitData CurrentUnit
    {
      [Token(Token = "0x600BEF2"), Address(RVA = "0x866220", Offset = "0x865020", VA = "0x10866220")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x600BEF3")]
    [Address(RVA = "0x34C010", Offset = "0x34AE10", VA = "0x1034C010")]
    public void SetOnSelectCallback(
      RuneSelectableListWindow.OnSelectedEvent selected_callback)
    {
    }

    [Token(Token = "0x600BEF4")]
    [Address(RVA = "0x865280", Offset = "0x864080", VA = "0x10865280")]
    public void Awake()
    {
    }

    [Token(Token = "0x600BEF5")]
    [Address(RVA = "0x865700", Offset = "0x864500", VA = "0x10865700")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600BEF6")]
    [Address(RVA = "0x864DE0", Offset = "0x863BE0", VA = "0x10864DE0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BEF7")]
    [Address(RVA = "0x865410", Offset = "0x864210", VA = "0x10865410")]
    public void Initialize(
      RuneManager manager,
      List<BindRuneData> rune_datas,
      bool is_equip_hide = false,
      bool _is_use_equip_button = false)
    {
    }

    [Token(Token = "0x600BEF8")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void SetLockDisable(bool is_lock_disable)
    {
    }

    [Token(Token = "0x600BEF9")]
    [Address(RVA = "0x865990", Offset = "0x864790", VA = "0x10865990")]
    public void Refresh(bool _is_equip = false)
    {
    }

    [Token(Token = "0x600BEFA")]
    [Address(RVA = "0x8658C0", Offset = "0x8646C0", VA = "0x108658C0")]
    private void RefreshSortButton()
    {
    }

    [Token(Token = "0x600BEFB")]
    [Address(RVA = "0x865830", Offset = "0x864630", VA = "0x10865830")]
    private void RefreshFilterButton()
    {
    }

    [Token(Token = "0x600BEFC")]
    [Address(RVA = "0x865310", Offset = "0x864110", VA = "0x10865310")]
    private bool CheckEquipHideState() => new bool();

    [Token(Token = "0x600BEFD")]
    [Address(RVA = "0x865740", Offset = "0x864540", VA = "0x10865740")]
    private void RefreshEquipHideButton(bool _is_use_button)
    {
    }

    [Token(Token = "0x600BEFE")]
    [Address(RVA = "0x865D70", Offset = "0x864B70", VA = "0x10865D70")]
    public void SelectedSlot()
    {
    }

    [Token(Token = "0x600BEFF")]
    [Address(RVA = "0x865D90", Offset = "0x864B90", VA = "0x10865D90")]
    public void SelectedSlot(RuneSlotIndex slot)
    {
    }

    [Token(Token = "0x600BF00")]
    [Address(RVA = "0x7AB9E0", Offset = "0x7AA7E0", VA = "0x107AB9E0")]
    public void CloseSelf()
    {
    }

    [Token(Token = "0x600BF01")]
    [Address(RVA = "0x865B60", Offset = "0x864960", VA = "0x10865B60")]
    private void SelectRune()
    {
    }

    [Token(Token = "0x600BF02")]
    [Address(RVA = "0x865370", Offset = "0x864170", VA = "0x10865370")]
    public List<BindRuneData> GetRunes() => (List<BindRuneData>) null;

    [Token(Token = "0x600BF03")]
    [Address(RVA = "0x865F10", Offset = "0x864D10", VA = "0x10865F10")]
    public RuneSelectableListWindow()
    {
    }

    [Token(Token = "0x20029E8")]
    public enum SelectableType
    {
      [Token(Token = "0x400CBA8")] Equip,
      [Token(Token = "0x400CBA9")] Disassembly,
    }

    [Token(Token = "0x20029E9")]
    public delegate void OnSelectedEvent(BindRuneData rune);
  }
}
