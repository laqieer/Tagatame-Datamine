// Decompiled with JetBrains decompiler
// Type: SRPG.GvGResultReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002611")]
  [FlowNode.Pin(100, "結果あり", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(1, "報酬はあるか？", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "結果なし", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/GvG/GvGResultReward")]
  public class GvGResultReward : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B142")]
    public const int PIN_INPUT_ISREWARD = 1;
    [Token(Token = "0x400B143")]
    public const int PIN_OUTPUT_REWARD = 100;
    [Token(Token = "0x400B144")]
    public const int PIN_OUTPUT_EMPTY = 101;

    [Token(Token = "0x600A9BE")]
    [Address(RVA = "0x6CFDA0", Offset = "0x6CEBA0", VA = "0x106CFDA0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A9BF")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GvGResultReward()
    {
    }
  }
}
