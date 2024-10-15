// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckArtifactStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001379")]
  [FlowNode.NodeType("Tips/CheckArtifactStatus", 32741)]
  [FlowNode.Pin(1, "判定", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "True", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(3, "False", FlowNode.PinTypes.Output, 3)]
  [AddComponentMenu("")]
  public class FlowNode_CheckArtifactStatus : FlowNode
  {
    [Token(Token = "0x40047E1")]
    private const int PIN_ID_IN = 1;
    [Token(Token = "0x40047E2")]
    private const int PIN_ID_TRUE = 2;
    [Token(Token = "0x40047E3")]
    private const int PIN_ID_FALSE = 3;
    [Token(Token = "0x40047E4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private FlowNode_CheckArtifactStatus.Flag flag;

    [Token(Token = "0x60051B5")]
    [Address(RVA = "0x126B300", Offset = "0x126A100", VA = "0x1126B300")]
    private ArtifactData GetArtifactDataFromUniqueID(long uniqueId) => (ArtifactData) null;

    [Token(Token = "0x60051B6")]
    [Address(RVA = "0x126B3D0", Offset = "0x126A1D0", VA = "0x1126B3D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60051B7")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckArtifactStatus()
    {
    }

    [Token(Token = "0x200137A")]
    public enum Flag
    {
      [Token(Token = "0x40047E6")] ArmorCountLessThan3,
      [Token(Token = "0x40047E7")] SelectArmor,
      [Token(Token = "0x40047E8")] ArmorRarityReachedBy4,
    }
  }
}
