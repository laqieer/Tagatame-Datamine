// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_CheckBlackListInRoom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017D2")]
  [FlowNode.Pin(102, "Not Exist", FlowNode.PinTypes.Output, 102)]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Is Exist", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("MultiPlay/Room/CheckBlackList", 32741)]
  [FlowNode.Pin(1, "Check Black List", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_MP_CheckBlackListInRoom : FlowNode
  {
    [Token(Token = "0x40055B0")]
    private const int PIN_IN_CHECK_START = 1;
    [Token(Token = "0x40055B1")]
    private const int PIN_OUT_EXIST = 101;
    [Token(Token = "0x40055B2")]
    private const int PIN_OUT_NOT_EXIST = 102;

    [Token(Token = "0x6006076")]
    [Address(RVA = "0x134B380", Offset = "0x134A180", VA = "0x1134B380", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006077")]
    [Address(RVA = "0x134B180", Offset = "0x1349F80", VA = "0x1134B180")]
    private void CheckBlockList()
    {
    }

    [Token(Token = "0x6006078")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_CheckBlackListInRoom()
    {
    }
  }
}
