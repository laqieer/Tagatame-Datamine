// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_DrawCardCharacterMessageWait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001347")]
  [FlowNode.Pin(1, "Start", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("DrawCard/Character/MessageWait", 32741)]
  [FlowNode.Pin(10, "Output", FlowNode.PinTypes.Output, 10)]
  public class FlowNode_DrawCardCharacterMessageWait : FlowNode
  {
    [Token(Token = "0x4004765")]
    private const int PIN_IN_START = 1;
    [Token(Token = "0x4004766")]
    private const int PIN_OUT_END = 10;

    [Token(Token = "0x6005113")]
    [Address(RVA = "0x8AA8F0", Offset = "0x8A96F0", VA = "0x108AA8F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005114")]
    [Address(RVA = "0x124F500", Offset = "0x124E300", VA = "0x1124F500")]
    private void Update()
    {
    }

    [Token(Token = "0x6005115")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_DrawCardCharacterMessageWait()
    {
    }
  }
}
