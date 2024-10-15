// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_EmbedSystemMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013CD")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Done", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(100, "Opened", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("UI/EmbedSystemMessage", 32741)]
  [FlowNode.Pin(10, "Open", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_EmbedSystemMessage : FlowNode
  {
    [Token(Token = "0x4004952")]
    [FieldOffset(Offset = "0x18")]
    public string m_Msg;
    [Token(Token = "0x4004953")]
    [FieldOffset(Offset = "0x1C")]
    public bool dontDestroyOnLoad;

    [Token(Token = "0x60052E1")]
    [Address(RVA = "0x127A350", Offset = "0x1279150", VA = "0x1127A350", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60052E2")]
    [Address(RVA = "0x12703D0", Offset = "0x126F1D0", VA = "0x112703D0")]
    private void OnSystemMessageEvent(bool yes)
    {
    }

    [Token(Token = "0x60052E3")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_EmbedSystemMessage()
    {
    }
  }
}
