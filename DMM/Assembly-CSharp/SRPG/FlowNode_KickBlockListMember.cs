// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_KickBlockListMember
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001415")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Multi/KickBlockListMember", 32741)]
  [FlowNode.Pin(10, "ブロックリストをキック", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(1010, "完了", FlowNode.PinTypes.Output, 1010)]
  public class FlowNode_KickBlockListMember : FlowNode
  {
    [Token(Token = "0x4004A54")]
    private const int PIN_INPUT_START = 10;
    [Token(Token = "0x4004A55")]
    private const int PIN_OUTPUT_FINISH = 1010;

    [Token(Token = "0x60053E9")]
    [Address(RVA = "0x1286910", Offset = "0x1285710", VA = "0x11286910", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60053EA")]
    [Address(RVA = "0x1286730", Offset = "0x1285530", VA = "0x11286730")]
    private void KickBlockListMember()
    {
    }

    [Token(Token = "0x60053EB")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_KickBlockListMember()
    {
    }
  }
}
