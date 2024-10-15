// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_ReopenRoom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017E3")]
  [FlowNode.NodeType("MultiPlay/Room/ReopenRoom", 32741)]
  [FlowNode.Pin(1, "部屋オープン", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "完了", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  public class FlowNode_MP_ReopenRoom : FlowNode
  {
    [Token(Token = "0x4005609")]
    private const int PIN_IN_OPEN = 1;
    [Token(Token = "0x400560A")]
    private const int PIN_OUT_FINISH = 10;

    [Token(Token = "0x60060BE")]
    [Address(RVA = "0x1359C90", Offset = "0x1358A90", VA = "0x11359C90", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60060BF")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_ReopenRoom()
    {
    }
  }
}
