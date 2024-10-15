// Decompiled with JetBrains decompiler
// Type: SRPG.StoryExChallengeCountResetRoot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002868")]
  [FlowNode.Pin(100, "アイテムで挑戦回数リセット", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(200, "幻晶石で挑戦回数リセット", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(300, "エラー", FlowNode.PinTypes.Output, 300)]
  [AddComponentMenu("UI/Quest/StoryExChallengeCountResetRoot")]
  [FlowNode.Pin(10, "開始", FlowNode.PinTypes.Input, 10)]
  public class StoryExChallengeCountResetRoot : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C10D")]
    private const int PIN_INPUT_START = 10;
    [Token(Token = "0x400C10E")]
    private const int PIN_OUTPUT_RESET_ITEM = 100;
    [Token(Token = "0x400C10F")]
    private const int PIN_OUTPUT_RESET_COIN = 200;
    [Token(Token = "0x400C110")]
    private const int PIN_OUTPUT_ERROR = 300;

    [Token(Token = "0x600B69C")]
    [Address(RVA = "0x7DD6E0", Offset = "0x7DC4E0", VA = "0x107DD6E0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B69D")]
    [Address(RVA = "0x7DD700", Offset = "0x7DC500", VA = "0x107DD700")]
    private void SendOutputPin()
    {
    }

    [Token(Token = "0x600B69E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public StoryExChallengeCountResetRoot()
    {
    }
  }
}
