// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_RequestPermission
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015CD")]
  [FlowNode.Pin(102, "不許可(今後は表示しない)", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(100, "許可", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "不許可", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("Native/Permission/RequestPermission", 16750080)]
  [FlowNode.Pin(0, "要求", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_RequestPermission : FlowNode
  {
    [Token(Token = "0x4004F4B")]
    public const int INPUT_REQUEST = 0;
    [Token(Token = "0x4004F4C")]
    public const int OUTPUT_APPROVED = 100;
    [Token(Token = "0x4004F4D")]
    public const int OUTPUT_REJECTED = 101;
    [Token(Token = "0x4004F4E")]
    public const int OUTPUT_REJECTED_HIDE_DIALOG = 102;
    [Token(Token = "0x4004F4F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ePermissionTypes m_RequestPermissionType;

    [Token(Token = "0x60059A3")]
    [Address(RVA = "0x12EA8C0", Offset = "0x12E96C0", VA = "0x112EA8C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60059A4")]
    [Address(RVA = "0x12EA960", Offset = "0x12E9760", VA = "0x112EA960")]
    public void OnRequestPermissionResult(PermissionResultData permissionResultData)
    {
    }

    [Token(Token = "0x60059A5")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_RequestPermission()
    {
    }
  }
}
