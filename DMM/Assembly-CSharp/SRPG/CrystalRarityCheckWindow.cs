// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalRarityCheckWindow
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
  [Token(Token = "0x20022C9")]
  [FlowNode.Pin(100, "ウィンドウを閉じる", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(2, "キャンセルを選択", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "売却を選択", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(0, "初期化", FlowNode.PinTypes.Input, 0)]
  public class CrystalRarityCheckWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009AF1")]
    private const int INPUT_INIT = 0;
    [Token(Token = "0x4009AF2")]
    private const int INPUT_SELL = 1;
    [Token(Token = "0x4009AF3")]
    private const int INPUT_CANCEL = 2;
    [Token(Token = "0x4009AF4")]
    private const int OUTPUT_CLOSE_ACTION = 100;
    [Token(Token = "0x4009AF5")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform Parent;
    [Token(Token = "0x4009AF6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private CrystalRarityCheckContent Content;
    [Token(Token = "0x4009AF7")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text SaleGoldTxt;
    [Token(Token = "0x4009AF8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text SaleCoinTxt;
    [Token(Token = "0x4009AF9")]
    [FieldOffset(Offset = "0x1C")]
    private List<CrystalData> mSelectCrystals;
    [Token(Token = "0x4009AFA")]
    [FieldOffset(Offset = "0x20")]
    private int mSaleGoldNum;
    [Token(Token = "0x4009AFB")]
    [FieldOffset(Offset = "0x24")]
    private int mSaleCoinNum;
    [Token(Token = "0x4009AFC")]
    [FieldOffset(Offset = "0x28")]
    public CrystalRarityCheckWindow.OnCrystalRarityCheckDecideEvent OnDecideEvent;
    [Token(Token = "0x4009AFD")]
    [FieldOffset(Offset = "0x2C")]
    public CrystalRarityCheckWindow.OnCrystalRarityCheckCancelEvent OnCancelEvent;

    [Token(Token = "0x6009569")]
    [Address(RVA = "0x583D60", Offset = "0x582B60", VA = "0x10583D60", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600956A")]
    [Address(RVA = "0x44A4A0", Offset = "0x4492A0", VA = "0x1044A4A0")]
    public void OnClosePin()
    {
    }

    [Token(Token = "0x600956B")]
    [Address(RVA = "0x583E70", Offset = "0x582C70", VA = "0x10583E70")]
    private void Awake()
    {
    }

    [Token(Token = "0x600956C")]
    [Address(RVA = "0x584450", Offset = "0x583250", VA = "0x10584450")]
    public void Setup(List<CrystalData> crystals, int sale_gold, int sale_coin)
    {
    }

    [Token(Token = "0x600956D")]
    [Address(RVA = "0x584310", Offset = "0x583110", VA = "0x10584310")]
    private void Init()
    {
    }

    [Token(Token = "0x600956E")]
    [Address(RVA = "0x583EC0", Offset = "0x582CC0", VA = "0x10583EC0")]
    private void CreateList()
    {
    }

    [Token(Token = "0x600956F")]
    [Address(RVA = "0x584420", Offset = "0x583220", VA = "0x10584420")]
    private void OnDecide()
    {
    }

    [Token(Token = "0x6009570")]
    [Address(RVA = "0x5843F0", Offset = "0x5831F0", VA = "0x105843F0")]
    private void OnCancel()
    {
    }

    [Token(Token = "0x6009571")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalRarityCheckWindow()
    {
    }

    [Token(Token = "0x20022CA")]
    public delegate void OnCrystalRarityCheckDecideEvent(GameObject go);

    [Token(Token = "0x20022CB")]
    public delegate void OnCrystalRarityCheckCancelEvent(GameObject go);
  }
}
