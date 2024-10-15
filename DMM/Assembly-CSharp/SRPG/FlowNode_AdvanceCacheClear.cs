// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_AdvanceCacheClear
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012C7")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Input", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Advance/CacheClear", 32741)]
  [FlowNode.Pin(101, "Output", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_AdvanceCacheClear : FlowNode
  {
    [Token(Token = "0x40045FD")]
    public const int PIN_IN = 1;
    [Token(Token = "0x40045FE")]
    public const int PIN_OUT = 101;
    [Token(Token = "0x40045FF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private bool GlobalVarsClear;
    [Token(Token = "0x4004600")]
    [FieldOffset(Offset = "0x19")]
    [SerializeField]
    private bool ClearChapterParamList;

    [Token(Token = "0x6004F97")]
    [Address(RVA = "0x12489D0", Offset = "0x12477D0", VA = "0x112489D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6004F98")]
    [Address(RVA = "0x1248B70", Offset = "0x1247970", VA = "0x11248B70")]
    public FlowNode_AdvanceCacheClear()
    {
    }
  }
}
