// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_GUIRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001400")]
  [FlowNode.NodeType("UI/GUIRanking", 32741)]
  [FlowNode.Pin(200, "CreateQuest", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(202, "CreateTowerMatch", FlowNode.PinTypes.Input, 202)]
  [AddComponentMenu("")]
  [FlowNode.Pin(201, "CreateArena", FlowNode.PinTypes.Input, 201)]
  public class FlowNode_GUIRanking : FlowNode_GUI
  {
    [Token(Token = "0x4004A0A")]
    [FieldOffset(Offset = "0x54")]
    private UsageRateRanking.ViewInfoType type;

    [Token(Token = "0x60053AC")]
    [Address(RVA = "0x1281100", Offset = "0x127FF00", VA = "0x11281100", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60053AD")]
    [Address(RVA = "0x1281150", Offset = "0x127FF50", VA = "0x11281150", Slot = "15")]
    protected override void OnInstanceCreate()
    {
    }

    [Token(Token = "0x60053AE")]
    [Address(RVA = "0x126B2F0", Offset = "0x126A0F0", VA = "0x1126B2F0")]
    public FlowNode_GUIRanking()
    {
    }
  }
}
