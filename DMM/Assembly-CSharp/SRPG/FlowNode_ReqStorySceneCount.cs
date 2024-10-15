// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqStorySceneCount
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200158D")]
  [AddComponentMenu("")]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(0, "Requesst", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/ReqStorySceneCount", 32741)]
  public class FlowNode_ReqStorySceneCount : FlowNode_Network
  {
    [Token(Token = "0x60058D4")]
    [Address(RVA = "0x12DB2D0", Offset = "0x12DA0D0", VA = "0x112DB2D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60058D5")]
    [Address(RVA = "0x1292FD0", Offset = "0x1291DD0", VA = "0x11292FD0")]
    private void Success()
    {
    }

    [Token(Token = "0x60058D6")]
    [Address(RVA = "0x12DB3C0", Offset = "0x12DA1C0", VA = "0x112DB3C0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60058D7")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqStorySceneCount()
    {
    }
  }
}
