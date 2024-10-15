// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqTrophyProgress
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015C3")]
  [FlowNode.NodeType("Trophy/ReqTrophyProgress", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  public class FlowNode_ReqTrophyProgress : FlowNode_Network
  {
    [Token(Token = "0x4004F2C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool is_daily;

    [Token(Token = "0x6005984")]
    [Address(RVA = "0x12E20C0", Offset = "0x12E0EC0", VA = "0x112E20C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005985")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005986")]
    [Address(RVA = "0x12E21E0", Offset = "0x12E0FE0", VA = "0x112E21E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005987")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqTrophyProgress()
    {
    }
  }
}
