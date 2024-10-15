// Decompiled with JetBrains decompiler
// Type: SRPG.GvGEndWindowRoot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025D0")]
  [FlowNode.Pin(1040, "シーズンの結果表示する必要なし", FlowNode.PinTypes.Output, 1040)]
  [AddComponentMenu("UI/GvG/GvGEndWindowRoot")]
  [FlowNode.Pin(1050, "シーズンの結果表示する", FlowNode.PinTypes.Output, 1050)]
  [FlowNode.Pin(1030, "本日の結果表示する必要なし", FlowNode.PinTypes.Output, 1030)]
  [FlowNode.Pin(1010, "初期化終了", FlowNode.PinTypes.Output, 1010)]
  [FlowNode.Pin(30, "シーズンの結果表示", FlowNode.PinTypes.Input, 30)]
  [FlowNode.Pin(20, "本日の結果表示", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(10, "初期化", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(1020, "本日の結果表示する", FlowNode.PinTypes.Output, 1020)]
  public class GvGEndWindowRoot : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400AF80")]
    private const int PIN_INPUT_INIT = 10;
    [Token(Token = "0x400AF81")]
    private const int PIN_INPUT_OPEN_DAILY = 20;
    [Token(Token = "0x400AF82")]
    private const int PIN_INPUT_OPEN_SEASON = 30;
    [Token(Token = "0x400AF83")]
    private const int PIN_INPUT_CLOSE = 100;
    [Token(Token = "0x400AF84")]
    private const int PIN_OUTPUT_INIT_END = 1010;
    [Token(Token = "0x400AF85")]
    private const int PIN_OUTPUT_OPEN_DAILY = 1020;
    [Token(Token = "0x400AF86")]
    private const int PIN_OUTPUT_NOT_OPEN_DAILY = 1030;
    [Token(Token = "0x400AF87")]
    private const int PIN_OUTPUT_NOT_OPEN_SEASON = 1040;
    [Token(Token = "0x400AF88")]
    private const int PIN_OUTPUT_OPEN_SEASON = 1050;

    [Token(Token = "0x600A80E")]
    [Address(RVA = "0x6B3190", Offset = "0x6B1F90", VA = "0x106B3190", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A80F")]
    [Address(RVA = "0x6B33C0", Offset = "0x6B21C0", VA = "0x106B33C0")]
    private void Init()
    {
    }

    [Token(Token = "0x600A810")]
    [Address(RVA = "0x6B3450", Offset = "0x6B2250", VA = "0x106B3450")]
    private void OpenResult_Daily()
    {
    }

    [Token(Token = "0x600A811")]
    [Address(RVA = "0x6B3520", Offset = "0x6B2320", VA = "0x106B3520")]
    private void OpenResult_Season()
    {
    }

    [Token(Token = "0x600A812")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GvGEndWindowRoot()
    {
    }
  }
}
