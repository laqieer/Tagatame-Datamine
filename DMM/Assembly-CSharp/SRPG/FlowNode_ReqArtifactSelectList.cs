// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqArtifactSelectList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200148B")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/ReqArtifact/ReqArtifactSelectList", 32741)]
  public class FlowNode_ReqArtifactSelectList : FlowNode_Network
  {
    [Token(Token = "0x4004BCE")]
    [FieldOffset(Offset = "0x20")]
    public ArtifactSelectListData mArtifactSelectListData;
    [Token(Token = "0x4004BCF")]
    [FieldOffset(Offset = "0x24")]
    public GetArtifactWindow mGetArtifactWindow;

    [Token(Token = "0x60055D2")]
    [Address(RVA = "0x12B7AD0", Offset = "0x12B68D0", VA = "0x112B7AD0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60055D3")]
    [Address(RVA = "0x12B78A0", Offset = "0x12B66A0", VA = "0x112B78A0")]
    private Json_ArtifactSelectResponse DummyResponse() => (Json_ArtifactSelectResponse) null;

    [Token(Token = "0x60055D4")]
    [Address(RVA = "0x12B77F0", Offset = "0x12B65F0", VA = "0x112B77F0")]
    private void Deserialize(Json_ArtifactSelectResponse json)
    {
    }

    [Token(Token = "0x60055D5")]
    [Address(RVA = "0x12B7C90", Offset = "0x12B6A90", VA = "0x112B7C90", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60055D6")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x60055D7")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqArtifactSelectList()
    {
    }
  }
}
