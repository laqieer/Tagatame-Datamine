// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ClearCache
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001397")]
  [FlowNode.NodeType("System/キャッシュクリア", 32741)]
  [FlowNode.Pin(0, "In", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "Out", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(101, "Finished", FlowNode.PinTypes.Output, 0)]
  [AddComponentMenu("")]
  public class FlowNode_ClearCache : FlowNode
  {
    [Token(Token = "0x400485D")]
    public const int PINID_CLEAR = 0;
    [Token(Token = "0x400485E")]
    public const int PINID_OUT = 100;
    [Token(Token = "0x400485F")]
    public const int PINID_FINISHED = 101;

    [Token(Token = "0x6005215")]
    [Address(RVA = "0x126E6F0", Offset = "0x126D4F0", VA = "0x1126E6F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005216")]
    [Address(RVA = "0x126E680", Offset = "0x126D480", VA = "0x1126E680")]
    private IEnumerator ClearCacheAsync() => (IEnumerator) null;

    [Token(Token = "0x6005217")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ClearCache()
    {
    }
  }
}
