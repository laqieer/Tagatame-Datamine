// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckHasPermission
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001380")]
  [FlowNode.Pin(101, "不許可", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("Native/Permission/CheckHasPermission", 16750080)]
  [FlowNode.Pin(0, "判定", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "許可", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  public class FlowNode_CheckHasPermission : FlowNode
  {
    [Token(Token = "0x40047F8")]
    public const int INPUT_CHECK = 0;
    [Token(Token = "0x40047F9")]
    public const int OUTPUT_APPROVED = 100;
    [Token(Token = "0x40047FA")]
    public const int OUTPUT_REJECTED = 101;
    [Token(Token = "0x40047FB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ePermissionTypes m_CheckPermissionType;

    [Token(Token = "0x60051C9")]
    [Address(RVA = "0x126BCB0", Offset = "0x126AAB0", VA = "0x1126BCB0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60051CA")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckHasPermission()
    {
    }
  }
}
