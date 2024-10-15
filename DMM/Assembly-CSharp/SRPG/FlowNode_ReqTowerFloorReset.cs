// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqTowerFloorReset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015BB")]
  [FlowNode.Pin(1, "敵の引継ぎ情報リセット", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Request/Tower/Floor/Reset", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(100, "リセット完了", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_ReqTowerFloorReset : FlowNode_Network
  {
    [Token(Token = "0x4004F19")]
    private const int INPUT_REQUEST_RESET = 1;
    [Token(Token = "0x4004F1A")]
    private const int OUTPUT_REQUEST_RESET = 100;

    [Token(Token = "0x6005970")]
    [Address(RVA = "0x12E0B80", Offset = "0x12DF980", VA = "0x112E0B80", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005971")]
    [Address(RVA = "0x12E0CA0", Offset = "0x12DFAA0", VA = "0x112E0CA0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005972")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqTowerFloorReset()
    {
    }
  }
}
