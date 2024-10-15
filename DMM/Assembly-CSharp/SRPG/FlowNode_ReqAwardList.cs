// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAwardList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200149D")]
  [FlowNode.NodeType("System/Award/ReqAwardList", 32741)]
  [FlowNode.Pin(0, "所持称号取得", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "Failure", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  public class FlowNode_ReqAwardList : FlowNode_Network
  {
    [Token(Token = "0x4004BEE")]
    [FieldOffset(Offset = "0x20")]
    [FlowNode.ShowInInfo]
    [FlowNode.DropTarget(typeof (GameObject), true)]
    public GameObject Target;
    [Token(Token = "0x4004BEF")]
    [FieldOffset(Offset = "0x24")]
    public FlowNode_ReqAwardList.MODE mMode;

    [Token(Token = "0x6005604")]
    [Address(RVA = "0x12BB470", Offset = "0x12BA270", VA = "0x112BB470", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005605")]
    [Address(RVA = "0x1292FD0", Offset = "0x1291DD0", VA = "0x11292FD0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005606")]
    [Address(RVA = "0x127E1B0", Offset = "0x127CFB0", VA = "0x1127E1B0")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005607")]
    [Address(RVA = "0x12BB520", Offset = "0x12BA320", VA = "0x112BB520", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005608")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAwardList()
    {
    }

    [Token(Token = "0x200149E")]
    public enum MODE
    {
      [Token(Token = "0x4004BF1")] SetAwardList,
      [Token(Token = "0x4004BF2")] SetPlayerAward,
    }
  }
}
