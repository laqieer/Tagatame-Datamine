// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_EmbedPermissionErrorWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013CB")]
  [FlowNode.Pin(10, "開く(誘導ボタン付)", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(0, "開く", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "閉じた", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("UI/EmbedPermissionErrorWindow", 32741)]
  public class FlowNode_EmbedPermissionErrorWindow : FlowNode
  {
    [Token(Token = "0x400494B")]
    private const int INPUT_OPEN = 0;
    [Token(Token = "0x400494C")]
    private const int INPUT_OPEN_ENABLE_NAVIGATION = 10;
    [Token(Token = "0x400494D")]
    private const int OUTPUT_CLOSE = 100;
    [Token(Token = "0x400494E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string m_MessageTextID;
    [Token(Token = "0x400494F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ePermissionTypes m_PermissionType;

    [Token(Token = "0x60052DA")]
    [Address(RVA = "0x1279E50", Offset = "0x1278C50", VA = "0x11279E50", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60052DB")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_EmbedPermissionErrorWindow()
    {
    }
  }
}
