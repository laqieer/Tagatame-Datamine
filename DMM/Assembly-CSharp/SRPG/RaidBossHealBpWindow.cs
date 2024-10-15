// Decompiled with JetBrains decompiler
// Type: SRPG.RaidBossHealBpWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028E0")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(104, "幻結晶不足", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(103, "回復エラー", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(101, "回復実行", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(2, "回復実行確認", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(102, "BP最大", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(901, "エラー", FlowNode.PinTypes.Output, 901)]
  public class RaidBossHealBpWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C44B")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400C44C")]
    private const int PIN_INPUT_HEAL_EXE = 2;
    [Token(Token = "0x400C44D")]
    private const int PIN_OUTPUT_HEAL_REQUEST = 101;
    [Token(Token = "0x400C44E")]
    private const int PIN_OUTPUT_BP_MAX = 102;
    [Token(Token = "0x400C44F")]
    private const int PIN_OUTPUT_HEAL_ERROR = 103;
    [Token(Token = "0x400C450")]
    private const int PIN_OUTPUT_COIN_SHORTAGE = 104;
    [Token(Token = "0x400C451")]
    private const int PIN_OUTPUT_ERROR = 901;
    [Token(Token = "0x400C452")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400C453")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Slider mHealSlider;
    [Token(Token = "0x400C454")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button mHealSliderPlus;
    [Token(Token = "0x400C455")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button mHealSliderMinus;
    [Token(Token = "0x400C456")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button mHealExecuteBtn;
    [Token(Token = "0x400C457")]
    [FieldOffset(Offset = "0x20")]
    private RaidBossHealBpModel mModel;
    [Token(Token = "0x400C458")]
    [FieldOffset(Offset = "0x24")]
    private RaidManager mRaidManager;
    [Token(Token = "0x400C459")]
    [FieldOffset(Offset = "0x28")]
    private RaidPeriodParam mRaidPeriodParam;
    [Token(Token = "0x400C45A")]
    [FieldOffset(Offset = "0x2C")]
    private int mCurrentBp;
    [Token(Token = "0x400C45B")]
    [FieldOffset(Offset = "0x30")]
    private int mSelectNum;
    [Token(Token = "0x400C45C")]
    [FieldOffset(Offset = "0x0")]
    private static RaidBossHealBpWindow mInstance;

    [Token(Token = "0x1700193D")]
    public static RaidBossHealBpWindow Instance
    {
      [Token(Token = "0x600B8C7"), Address(RVA = "0x7F9FF0", Offset = "0x7F8DF0", VA = "0x107F9FF0")] get
      {
        return (RaidBossHealBpWindow) null;
      }
    }

    [Token(Token = "0x1700193E")]
    public int GetAddNum
    {
      [Token(Token = "0x600B8C8"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700193F")]
    public int GetStartBpNum
    {
      [Token(Token = "0x600B8C9"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600B8CA")]
    [Address(RVA = "0x7F9E10", Offset = "0x7F8C10", VA = "0x107F9E10")]
    private void Start()
    {
    }

    [Token(Token = "0x600B8CB")]
    [Address(RVA = "0x7F9680", Offset = "0x7F8480", VA = "0x107F9680")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600B8CC")]
    [Address(RVA = "0x7F92D0", Offset = "0x7F80D0", VA = "0x107F92D0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B8CD")]
    [Address(RVA = "0x7F94B0", Offset = "0x7F82B0", VA = "0x107F94B0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600B8CE")]
    [Address(RVA = "0x7F9860", Offset = "0x7F8660", VA = "0x107F9860")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600B8CF")]
    [Address(RVA = "0x7F9B10", Offset = "0x7F8910", VA = "0x107F9B10")]
    private void SetSilider()
    {
    }

    [Token(Token = "0x600B8D0")]
    [Address(RVA = "0x7F96C0", Offset = "0x7F84C0", VA = "0x107F96C0")]
    private void OnSelectUseNumChanged(float value)
    {
    }

    [Token(Token = "0x600B8D1")]
    [Address(RVA = "0x7F93D0", Offset = "0x7F81D0", VA = "0x107F93D0")]
    private void CheckExecuteHealBp()
    {
    }

    [Token(Token = "0x600B8D2")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RaidBossHealBpWindow()
    {
    }
  }
}
