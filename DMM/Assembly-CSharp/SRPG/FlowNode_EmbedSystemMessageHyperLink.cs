// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_EmbedSystemMessageHyperLink
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013CE")]
  [FlowNode.NodeType("UI/EmbedSystemMessageHyperLink", 32741)]
  [FlowNode.Pin(10, "Open", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Done", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(100, "Opened", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  public class FlowNode_EmbedSystemMessageHyperLink : FlowNode
  {
    [Token(Token = "0x4004954")]
    private const int PIN_IN_OPEN = 10;
    [Token(Token = "0x4004955")]
    private const int PIN_OUT_DONE = 1;
    [Token(Token = "0x4004956")]
    private const int PIN_OUT_OPENED = 100;
    [Token(Token = "0x4004957")]
    [FieldOffset(Offset = "0x18")]
    public string m_Msg;
    [Token(Token = "0x4004958")]
    [FieldOffset(Offset = "0x1C")]
    public bool dontDestroyOnLoad;

    [Token(Token = "0x60052E4")]
    [Address(RVA = "0x127A260", Offset = "0x1279060", VA = "0x1127A260", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60052E5")]
    [Address(RVA = "0x127A330", Offset = "0x1279130", VA = "0x1127A330")]
    private void OnSystemMessageEvent(bool yes)
    {
    }

    [Token(Token = "0x60052E6")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_EmbedSystemMessageHyperLink()
    {
    }
  }
}
