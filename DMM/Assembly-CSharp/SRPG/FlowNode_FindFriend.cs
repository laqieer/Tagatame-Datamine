// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_FindFriend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013EE")]
  [FlowNode.Pin(200, "みつからなかった", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/Friend/FindFriend", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  public class FlowNode_FindFriend : FlowNode_Network
  {
    [Token(Token = "0x40049DE")]
    [FieldOffset(Offset = "0x20")]
    public InputField InputFieldFriendID;

    [Token(Token = "0x6005374")]
    [Address(RVA = "0x1280C30", Offset = "0x127FA30", VA = "0x11280C30")]
    private void Start()
    {
    }

    [Token(Token = "0x6005375")]
    [Address(RVA = "0x1280800", Offset = "0x127F600", VA = "0x11280800", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6005376")]
    [Address(RVA = "0x1084C30", Offset = "0x1083A30", VA = "0x11084C30")]
    private void OnEndEdit(InputField field)
    {
    }

    [Token(Token = "0x6005377")]
    [Address(RVA = "0x1280630", Offset = "0x127F430", VA = "0x11280630", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005378")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005379")]
    [Address(RVA = "0x1257E00", Offset = "0x1256C00", VA = "0x11257E00")]
    private void Failure()
    {
    }

    [Token(Token = "0x600537A")]
    [Address(RVA = "0x1280890", Offset = "0x127F690", VA = "0x11280890", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600537B")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_FindFriend()
    {
    }
  }
}
