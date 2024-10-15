// Decompiled with JetBrains decompiler
// Type: SRPG.RunePridePotentialBonusWindow
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
  [Token(Token = "0x2002A3C")]
  [FlowNode.Pin(200, "更新", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(2, "詳細ウィンドウデータ作成", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "抽選確認ウィンドウデータ作成", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(1000, "詳細ウィンドウ作成", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10000, "ゲージのアニメ開始", FlowNode.PinTypes.Input, 10000)]
  [FlowNode.Pin(1001, "詳細ウィンドウ表示", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(2000, "抽選確認ウィンドウ作成", FlowNode.PinTypes.Output, 2000)]
  [FlowNode.Pin(4, "欠片選択ウィンドウデータ作成", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(2001, "抽選確認ウィンドウ表示", FlowNode.PinTypes.Output, 2001)]
  [FlowNode.Pin(3000, "素材選択ウィンドウ作成", FlowNode.PinTypes.Output, 3000)]
  [FlowNode.Pin(3001, "素材選択ウィンドウ表示", FlowNode.PinTypes.Output, 3001)]
  public class RunePridePotentialBonusWindow : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400CD3E")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400CD3F")]
    private const int PIN_INPUT_DETAIL_DATA_SET = 2;
    [Token(Token = "0x400CD40")]
    private const int PIN_INPUT_CONFIRM_DATA_SET = 3;
    [Token(Token = "0x400CD41")]
    private const int PIN_INPUT_SELECTOR_DATA_SET = 4;
    [Token(Token = "0x400CD42")]
    private const int PIN_INPUT_REFRESH = 200;
    [Token(Token = "0x400CD43")]
    private const int PIN_INPUT_START_ANIMATION = 10000;
    [Token(Token = "0x400CD44")]
    private const int PIN_OUTPUT_CREATE_DETAIL = 1000;
    [Token(Token = "0x400CD45")]
    private const int PIN_OUTPUT_SHOW_DETAIL = 1001;
    [Token(Token = "0x400CD46")]
    private const int PIN_OUTPUT_CREATE_CONFIRM = 2000;
    [Token(Token = "0x400CD47")]
    private const int PIN_OUTPUT_SHOW_CONFIRM = 2001;
    [Token(Token = "0x400CD48")]
    private const int PIN_OUTPUT_CREATE_SELECTOR = 3000;
    [Token(Token = "0x400CD49")]
    private const int PIN_OUTPUT_SHOW_SELECTOR = 3001;
    [Token(Token = "0x400CD4A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform trParent;
    [Token(Token = "0x400CD4B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject itemTemplate;
    [Token(Token = "0x400CD4C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button releaseButton;
    [Token(Token = "0x400CD4D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button relotteryButton;
    [Token(Token = "0x400CD4E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button relotStopButton;
    [Token(Token = "0x400CD4F")]
    [FieldOffset(Offset = "0x20")]
    private List<GameObject> itemList;
    [Token(Token = "0x400CD50")]
    [FieldOffset(Offset = "0x24")]
    private UnitData currentUnit;
    [Token(Token = "0x400CD51")]
    [FieldOffset(Offset = "0x28")]
    private string bonusIname;
    [Token(Token = "0x400CD52")]
    [FieldOffset(Offset = "0x2C")]
    private string detailKeyString;
    [Token(Token = "0x400CD53")]
    [FieldOffset(Offset = "0x30")]
    private int slotKeyIndex;
    [Token(Token = "0x400CD54")]
    [FieldOffset(Offset = "0x34")]
    private RunePridePotentialParam potentialParam;
    [Token(Token = "0x400CD55")]
    [FieldOffset(Offset = "0x38")]
    private List<RunePridePotentialBonusWindow.SlotStatus> slotStatusList;
    [Token(Token = "0x400CD56")]
    [FieldOffset(Offset = "0x3C")]
    private RunePrideItemListParam itemListParam;

    [Token(Token = "0x600C08A")]
    [Address(RVA = "0x88F110", Offset = "0x88DF10", VA = "0x1088F110", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C08B")]
    [Address(RVA = "0x88F130", Offset = "0x88DF30", VA = "0x1088F130", Slot = "5")]
    public void Activated(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600C08C")]
    [Address(RVA = "0x88FD90", Offset = "0x88EB90", VA = "0x1088FD90")]
    public void Initialize(SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600C08D")]
    [Address(RVA = "0x88F510", Offset = "0x88E310", VA = "0x1088F510")]
    private void CreateSlot(SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600C08E")]
    [Address(RVA = "0x8900E0", Offset = "0x88EEE0", VA = "0x108900E0")]
    private void SelectItem(
      int index_self,
      RunePridePotentialBonusWindow.SlotStatus slot_status,
      bool isSelect)
    {
    }

    [Token(Token = "0x600C08F")]
    [Address(RVA = "0x890520", Offset = "0x88F320", VA = "0x10890520")]
    private void StartGaugeAnim()
    {
    }

    [Token(Token = "0x600C090")]
    [Address(RVA = "0x8905D0", Offset = "0x88F3D0", VA = "0x108905D0")]
    private void SwitchButtonState(
      RunePridePotentialBonusWindow.SlotStatus slot_status,
      bool isSelect)
    {
    }

    [Token(Token = "0x600C091")]
    [Address(RVA = "0x88FDB0", Offset = "0x88EBB0", VA = "0x1088FDB0")]
    public void OnClickDetailButton(string iname)
    {
    }

    [Token(Token = "0x600C092")]
    [Address(RVA = "0x890220", Offset = "0x88F020", VA = "0x10890220")]
    private void ShowDetailButton()
    {
    }

    [Token(Token = "0x600C093")]
    [Address(RVA = "0x88FDF0", Offset = "0x88EBF0", VA = "0x1088FDF0")]
    public void OnClickRelotteryButton()
    {
    }

    [Token(Token = "0x600C094")]
    [Address(RVA = "0x8902A0", Offset = "0x88F0A0", VA = "0x108902A0")]
    private void ShowRelotteryButton()
    {
    }

    [Token(Token = "0x600C095")]
    [Address(RVA = "0x8903E0", Offset = "0x88F1E0", VA = "0x108903E0")]
    private void ShowSelectorWindow()
    {
    }

    [Token(Token = "0x600C096")]
    [Address(RVA = "0x8906B0", Offset = "0x88F4B0", VA = "0x108906B0")]
    public RunePridePotentialBonusWindow()
    {
    }

    [Token(Token = "0x2002A3D")]
    public enum SlotStatus
    {
      [Token(Token = "0x400CD58")] None,
      [Token(Token = "0x400CD59")] Opened,
      [Token(Token = "0x400CD5A")] CanOpen,
      [Token(Token = "0x400CD5B")] CannotOpen,
    }
  }
}
