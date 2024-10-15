// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_IsEnableGuildExpulsion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200140C")]
  [FlowNode.NodeType("Guild/IsEnableGuildExpulsion", 32741)]
  [FlowNode.Pin(1001, "ギルド除名不可", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1000, "ギルド除名可能", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(10, "Start", FlowNode.PinTypes.Input, 10)]
  [AddComponentMenu("")]
  public class FlowNode_IsEnableGuildExpulsion : FlowNode
  {
    [Token(Token = "0x4004A41")]
    private const int INPUT_START = 10;
    [Token(Token = "0x4004A42")]
    private const int OUTPUT_EXPULSION = 1000;
    [Token(Token = "0x4004A43")]
    private const int OUTPUT_NOTEXPULSION = 1001;
    [Token(Token = "0x4004A44")]
    [FieldOffset(Offset = "0x18")]
    [HeaderBar("レイド開始時間を伸ばす(hour)")]
    [SerializeField]
    private int beginAddHour;
    [Token(Token = "0x4004A45")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    [HeaderBar("レイド終了時間を伸ばす(hour)")]
    private int endAddHour;
    [Token(Token = "0x4004A46")]
    [FieldOffset(Offset = "0x20")]
    [HeaderBar("レイドのチェックを行う")]
    [SerializeField]
    private bool IsRaid;
    [Token(Token = "0x4004A47")]
    [FieldOffset(Offset = "0x21")]
    [HeaderBar("ギルドレイドのチェックを行う")]
    [SerializeField]
    private bool IsGuildRaid;

    [Token(Token = "0x60053D2")]
    [Address(RVA = "0x1285960", Offset = "0x1284760", VA = "0x11285960", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60053D3")]
    [Address(RVA = "0x1285A20", Offset = "0x1284820", VA = "0x11285A20")]
    public FlowNode_IsEnableGuildExpulsion()
    {
    }
  }
}
