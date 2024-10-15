// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_IsImmediatelyAfterLoginHotDeal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001312")]
  [AddComponentMenu("")]
  [FlowNode.Pin(0, "Input", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "DrawDialog", FlowNode.PinTypes.Output, 10)]
  [FlowNode.NodeType("HotDeal/IsImmediatelyAfterLoginHotDeal", 32741)]
  [FlowNode.Pin(11, "DoNothing", FlowNode.PinTypes.Output, 11)]
  public class FlowNode_IsImmediatelyAfterLoginHotDeal : FlowNode
  {
    [Token(Token = "0x40046CC")]
    private const int PIN_INPUT = 0;
    [Token(Token = "0x40046CD")]
    private const int PIN_OUTPUT_DRAW_DIALOG = 10;
    [Token(Token = "0x40046CE")]
    private const int PIN_OUTPUT_DO_NOTHING = 11;
    [Token(Token = "0x40046CF")]
    [FieldOffset(Offset = "0x0")]
    private static bool m_IsImmediatelyAfterLogin;

    [Token(Token = "0x6005077")]
    [Address(RVA = "0x124FC70", Offset = "0x124EA70", VA = "0x1124FC70")]
    public static bool IsImmediatelyAfterLogin() => new bool();

    [Token(Token = "0x6005078")]
    [Address(RVA = "0x124FD00", Offset = "0x124EB00", VA = "0x1124FD00")]
    public static void SetImmediatelyAfterLogin(bool is_after_login)
    {
    }

    [Token(Token = "0x6005079")]
    [Address(RVA = "0x124FCA0", Offset = "0x124EAA0", VA = "0x1124FCA0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600507A")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_IsImmediatelyAfterLoginHotDeal()
    {
    }
  }
}
