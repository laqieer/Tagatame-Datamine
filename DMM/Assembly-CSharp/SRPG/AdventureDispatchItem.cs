// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureDispatchItem
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
  [Token(Token = "0x2001F94")]
  [FlowNode.Pin(4, "アイテム使用ボタンタップ時", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(1, "派遣開始ボタンタップ時", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(3, "派遣中止ボタンタップ時", FlowNode.PinTypes.Input, 3)]
  [AddComponentMenu("UI/Adventure/AdventureDispatchItem")]
  [FlowNode.Pin(2, "派遣メニュー表示ボタンタップ時", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(105, "アイテム回収実行", FlowNode.PinTypes.Output, 105)]
  [FlowNode.Pin(103, "派遣中止実行", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(102, "派遣メニュー選択処理完了", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "派遣開始選択処理完了", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(5, "アイテム回収ボタンタップ時", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(104, "アイテム使用実行", FlowNode.PinTypes.Output, 104)]
  public class AdventureDispatchItem : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400855D")]
    private const int PIN_INPUT_ADVENTURE_START_BUTTON = 1;
    [Token(Token = "0x400855E")]
    private const int PIN_INPUT_ADVENTURE_MENU_BUTTON = 2;
    [Token(Token = "0x400855F")]
    private const int PIN_INPUT_ADVENTURE_STOP_BUTTON = 3;
    [Token(Token = "0x4008560")]
    private const int PIN_INPUT_ADVENTURE_ITEM_BUTTON = 4;
    [Token(Token = "0x4008561")]
    private const int PIN_INPUT_ADVENTURE_END_BUTTON = 5;
    [Token(Token = "0x4008562")]
    private const int PIN_OUTPUT_ADVENTURE_START_BUTTON = 101;
    [Token(Token = "0x4008563")]
    private const int PIN_OUTPUT_ADVENTURE_MENU_BUTTON = 102;
    [Token(Token = "0x4008564")]
    private const int PIN_OUTPUT_ADVENTURE_STOP_BUTTON = 103;
    [Token(Token = "0x4008565")]
    private const int PIN_OUTPUT_ADVENTURE_ITEM_BUTTON = 104;
    [Token(Token = "0x4008566")]
    private const int PIN_OUTPUT_ADVENTURE_END_BUTTON = 105;
    [Token(Token = "0x4008567")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text AdventureAreaNameText;
    [Token(Token = "0x4008568")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text AdventureAreaLevel;
    [Token(Token = "0x4008569")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private List<UnitIcon> UnitIconList;
    [Token(Token = "0x400856A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private AdventureCost CostItemTempleateObj;
    [Token(Token = "0x400856B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private AdventureCost CostApTempleateObj;
    [Token(Token = "0x400856C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text CombatPowerText;
    [Token(Token = "0x400856D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text AdventureDuringTimeText;
    [Token(Token = "0x400856E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text AdventureDoneTimeText;
    [Token(Token = "0x400856F")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Button AdventureStartButton;
    [Token(Token = "0x4008570")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject AdventureStartObj;
    [Token(Token = "0x4008571")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject AdventureDuringObj;
    [Token(Token = "0x4008572")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject AdventureDoneObj;
    [Token(Token = "0x4008573")]
    [FieldOffset(Offset = "0x3C")]
    private AdventureData mData;
    [Token(Token = "0x4008574")]
    [FieldOffset(Offset = "0x40")]
    private AdventureDispatchBundle mWindow;
    [Token(Token = "0x4008575")]
    [FieldOffset(Offset = "0x44")]
    private List<AdventureCost> mCostObjList;
    [Token(Token = "0x4008576")]
    [FieldOffset(Offset = "0x48")]
    private Coroutine mTimeUpdate;

    [Token(Token = "0x60081B9")]
    [Address(RVA = "0x421010", Offset = "0x41FE10", VA = "0x10421010", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60081BA")]
    [Address(RVA = "0x421B50", Offset = "0x420950", VA = "0x10421B50")]
    public void SetUp(AdventureData _data, AdventureDispatchBundle _window)
    {
    }

    [Token(Token = "0x60081BB")]
    [Address(RVA = "0x421960", Offset = "0x420760", VA = "0x10421960")]
    private void SetUnitData()
    {
    }

    [Token(Token = "0x60081BC")]
    [Address(RVA = "0x4213C0", Offset = "0x4201C0", VA = "0x104213C0")]
    private void SetCostData()
    {
    }

    [Token(Token = "0x60081BD")]
    [Address(RVA = "0x421100", Offset = "0x41FF00", VA = "0x10421100")]
    private void ChangeInteractableStartButton()
    {
    }

    [Token(Token = "0x60081BE")]
    [Address(RVA = "0x421350", Offset = "0x420150", VA = "0x10421350")]
    private IEnumerator RemainTimeUpdate() => (IEnumerator) null;

    [Token(Token = "0x60081BF")]
    [Address(RVA = "0x4212B0", Offset = "0x4200B0", VA = "0x104212B0")]
    private void OnClickSelectButton()
    {
    }

    [Token(Token = "0x60081C0")]
    [Address(RVA = "0x421330", Offset = "0x420130", VA = "0x10421330")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60081C1")]
    [Address(RVA = "0x421F10", Offset = "0x420D10", VA = "0x10421F10")]
    public AdventureDispatchItem()
    {
    }
  }
}
