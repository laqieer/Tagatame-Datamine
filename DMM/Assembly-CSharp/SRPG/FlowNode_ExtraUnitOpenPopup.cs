// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ExtraUnitOpenPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013E7")]
  [FlowNode.Pin(100, "Closed", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("Quest/ExtraUnitOpenPopup", 32741)]
  [FlowNode.Pin(0, "Open", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Clear", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  public class FlowNode_ExtraUnitOpenPopup : FlowNode
  {
    [Token(Token = "0x40049CB")]
    [FieldOffset(Offset = "0x0")]
    private static List<string> s_QuestIds;

    [Token(Token = "0x6005359")]
    [Address(RVA = "0x127F800", Offset = "0x127E600", VA = "0x1127F800", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600535A")]
    [Address(RVA = "0x127FD30", Offset = "0x127EB30", VA = "0x1127FD30")]
    public static void ReserveOpenExtraQuestPopup(string unit_id)
    {
    }

    [Token(Token = "0x600535B")]
    [Address(RVA = "0x127F900", Offset = "0x127E700", VA = "0x1127F900")]
    public static bool OpenPopup(UIUtility.DialogResultEvent on_close) => new bool();

    [Token(Token = "0x600535C")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ExtraUnitOpenPopup()
    {
    }

    [Token(Token = "0x600535D")]
    [Address(RVA = "0x127FE20", Offset = "0x127EC20", VA = "0x1127FE20")]
    static FlowNode_ExtraUnitOpenPopup()
    {
    }
  }
}
