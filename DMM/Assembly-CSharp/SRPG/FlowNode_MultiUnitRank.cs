// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MultiUnitRank
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001439")]
  [AddComponentMenu("")]
  [FlowNode.Pin(201, "Error", FlowNode.PinTypes.Output, 201)]
  [FlowNode.NodeType("Multi/Ranking", 32741)]
  [FlowNode.Pin(100, "Request", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(200, "Finish", FlowNode.PinTypes.Output, 200)]
  public class FlowNode_MultiUnitRank : FlowNode_Network
  {
    [Token(Token = "0x6005467")]
    [Address(RVA = "0x1290920", Offset = "0x128F720", VA = "0x11290920", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005468")]
    [Address(RVA = "0x12908F0", Offset = "0x128F6F0", VA = "0x112908F0")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005469")]
    [Address(RVA = "0x1257E00", Offset = "0x1256C00", VA = "0x11257E00")]
    private void Success()
    {
    }

    [Token(Token = "0x600546A")]
    [Address(RVA = "0x1290A00", Offset = "0x128F800", VA = "0x11290A00", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600546B")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MultiUnitRank()
    {
    }
  }
}
