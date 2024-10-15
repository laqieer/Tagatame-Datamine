// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_TowerRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200164D")]
  [FlowNode.Pin(100, "Request", FlowNode.PinTypes.Input, 100)]
  [FlowNode.NodeType("Tower/TowerRank", 32741)]
  [FlowNode.Pin(201, "Error", FlowNode.PinTypes.Output, 201)]
  [AddComponentMenu("")]
  [FlowNode.Pin(200, "Finish", FlowNode.PinTypes.Output, 200)]
  public class FlowNode_TowerRanking : FlowNode_Network
  {
    [Token(Token = "0x6005BA1")]
    [Address(RVA = "0x130FC60", Offset = "0x130EA60", VA = "0x1130FC60", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005BA2")]
    [Address(RVA = "0x1257E00", Offset = "0x1256C00", VA = "0x11257E00")]
    private void Success()
    {
    }

    [Token(Token = "0x6005BA3")]
    [Address(RVA = "0x12908F0", Offset = "0x128F6F0", VA = "0x112908F0")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005BA4")]
    [Address(RVA = "0x130FD40", Offset = "0x130EB40", VA = "0x1130FD40", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005BA5")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_TowerRanking()
    {
    }
  }
}
