// Decompiled with JetBrains decompiler
// Type: SRPG.StoryExTotalChallengeCountResetRoot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200286A")]
  [AddComponentMenu("UI/Quest/StoryExTotalChallengeCountResetRoot")]
  [FlowNode.Pin(10, "開始", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(200, "幻晶石で挑戦回数リセット", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(300, "エラー", FlowNode.PinTypes.Output, 300)]
  [FlowNode.Pin(100, "アイテムで挑戦回数リセット", FlowNode.PinTypes.Output, 100)]
  public class StoryExTotalChallengeCountResetRoot : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C119")]
    private const int PIN_INPUT_START = 10;
    [Token(Token = "0x400C11A")]
    private const int PIN_OUTPUT_RESET_ITEM = 100;
    [Token(Token = "0x400C11B")]
    private const int PIN_OUTPUT_RESET_COIN = 200;
    [Token(Token = "0x400C11C")]
    private const int PIN_OUTPUT_ERROR = 300;

    [Token(Token = "0x600B6A4")]
    [Address(RVA = "0x7DDFC0", Offset = "0x7DCDC0", VA = "0x107DDFC0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B6A5")]
    [Address(RVA = "0x7DDFE0", Offset = "0x7DCDE0", VA = "0x107DDFE0")]
    private void SendOutputPin()
    {
    }

    [Token(Token = "0x600B6A6")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public StoryExTotalChallengeCountResetRoot()
    {
    }
  }
}
