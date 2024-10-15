// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_WaitAssets
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200166C")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/アセットを待つ", 32741)]
  [FlowNode.Pin(0, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Finished", FlowNode.PinTypes.Output, 0)]
  public class FlowNode_WaitAssets : FlowNode
  {
    [Token(Token = "0x4005170")]
    public const int PINID_START = 0;
    [Token(Token = "0x4005171")]
    public const int PINID_FINISHED = 10;
    [Token(Token = "0x4005172")]
    private const float MIN_WAIT_TIME = 0.1f;
    [Token(Token = "0x4005173")]
    [FieldOffset(Offset = "0x18")]
    private float mWaitTime;

    [Token(Token = "0x6005C15")]
    [Address(RVA = "0x1315A80", Offset = "0x1314880", VA = "0x11315A80", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C16")]
    [Address(RVA = "0x1315AB0", Offset = "0x13148B0", VA = "0x11315AB0")]
    private void Update()
    {
    }

    [Token(Token = "0x6005C17")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_WaitAssets()
    {
    }
  }
}
