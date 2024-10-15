// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_PlayEventScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200145A")]
  [AddComponentMenu("")]
  [FlowNode.Pin(10, "Finished", FlowNode.PinTypes.Output, 10)]
  [FlowNode.NodeType("SRPG/Play Event Script", 32741)]
  [FlowNode.Pin(1, "Start", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_PlayEventScript : FlowNode
  {
    [Token(Token = "0x4004B47")]
    [FieldOffset(Offset = "0x18")]
    public string ScriptID;

    [Token(Token = "0x6005528")]
    [Address(RVA = "0x1298750", Offset = "0x1297550", VA = "0x11298750", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005529")]
    [Address(RVA = "0x12986E0", Offset = "0x12974E0", VA = "0x112986E0")]
    private IEnumerator LoadAndPlayAsync(string path) => (IEnumerator) null;

    [Token(Token = "0x600552A")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_PlayEventScript()
    {
    }
  }
}
