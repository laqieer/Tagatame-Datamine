// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalSaleResultWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20022AA")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "ウィンドウを閉じる", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(2, "閉じる", FlowNode.PinTypes.Input, 2)]
  public class CrystalSaleResultWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009A10")]
    private const int INPUT_INIT = 1;
    [Token(Token = "0x4009A11")]
    private const int INPUT_ON_CLOSE = 2;
    [Token(Token = "0x4009A12")]
    private const int OUTPUT_CLOSE_ACTION = 100;
    [Token(Token = "0x4009A13")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mSelectNumTxt;
    [Token(Token = "0x4009A14")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mSelectMaxTxt;
    [Token(Token = "0x4009A15")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mSaleGoldTxt;
    [Token(Token = "0x4009A16")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mSaleCoinTxt;
    [Token(Token = "0x4009A17")]
    [FieldOffset(Offset = "0x1C")]
    private int mSelectCrystalNum;
    [Token(Token = "0x4009A18")]
    [FieldOffset(Offset = "0x20")]
    private int mSelectCrystalMax;
    [Token(Token = "0x4009A19")]
    [FieldOffset(Offset = "0x24")]
    private int mSaleGoldTotalNum;
    [Token(Token = "0x4009A1A")]
    [FieldOffset(Offset = "0x28")]
    private int mSaleCoinTotalNum;
    [Token(Token = "0x4009A1B")]
    [FieldOffset(Offset = "0x2C")]
    public CrystalSaleResultWindow.OnCrystalSaleResultDecideEvent OnDecideEvent;

    [Token(Token = "0x6009480")]
    [Address(RVA = "0x570040", Offset = "0x56EE40", VA = "0x10570040", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009481")]
    [Address(RVA = "0x570290", Offset = "0x56F090", VA = "0x10570290")]
    public void Setup(int select_count, int select_max, int sale_gold, int sale_coin)
    {
    }

    [Token(Token = "0x6009482")]
    [Address(RVA = "0x5700A0", Offset = "0x56EEA0", VA = "0x105700A0")]
    private void Init()
    {
    }

    [Token(Token = "0x6009483")]
    [Address(RVA = "0x570250", Offset = "0x56F050", VA = "0x10570250")]
    private void OnDecide()
    {
    }

    [Token(Token = "0x6009484")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalSaleResultWindow()
    {
    }

    [Token(Token = "0x20022AB")]
    public delegate void OnCrystalSaleResultDecideEvent(GameObject go);
  }
}
