// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_DestroyAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013BD")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/DestroyAsset", 32741)]
  [FlowNode.Pin(0, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  public class FlowNode_DestroyAsset : FlowNode
  {
    [Token(Token = "0x40048F9")]
    [FieldOffset(Offset = "0x18")]
    public AssetBundleFlags flags;

    [Token(Token = "0x600528B")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600528C")]
    [Address(RVA = "0x1274250", Offset = "0x1273050", VA = "0x11274250", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600528D")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_DestroyAsset()
    {
    }
  }
}
