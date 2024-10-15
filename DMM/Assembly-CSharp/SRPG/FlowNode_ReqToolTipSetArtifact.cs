// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqToolTipSetArtifact
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001873")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("ToolTip/Req/SetArtifact", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqToolTipSetArtifact : FlowNode_Network
  {
    [Token(Token = "0x40057B3")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40057B4")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40057B5")]
    private const long EMPTY_UID = -1;
    [Token(Token = "0x40057B6")]
    private const long EMPTY_JID = -1;
    [Token(Token = "0x40057B7")]
    [FieldOffset(Offset = "0x20")]
    private SerializeValueList svl;

    [Token(Token = "0x6006289")]
    [Address(RVA = "0x30DEC0", Offset = "0x30CCC0", VA = "0x1030DEC0", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600628A")]
    [Address(RVA = "0x30E850", Offset = "0x30D650", VA = "0x1030E850")]
    private void Success()
    {
    }

    [Token(Token = "0x600628B")]
    [Address(RVA = "0x30E6D0", Offset = "0x30D4D0", VA = "0x1030E6D0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600628C")]
    [Address(RVA = "0x30E3F0", Offset = "0x30D1F0", VA = "0x1030E3F0")]
    private void OnArtifactSetResult_Simple(WWWResult www)
    {
    }

    [Token(Token = "0x600628D")]
    [Address(RVA = "0x30E180", Offset = "0x30CF80", VA = "0x1030E180")]
    private void OnArtifactSetResult_OverWrite(WWWResult www)
    {
    }

    [Token(Token = "0x600628E")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqToolTipSetArtifact()
    {
    }

    [Token(Token = "0x2001874")]
    [MessagePackObject(true)]
    public class MP_ArtifactSet_OverWriteResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40057B8")]
      [FieldOffset(Offset = "0x28")]
      public ReqArtifactSet_OverWrite.Response body;

      [Token(Token = "0x600628F")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_ArtifactSet_OverWriteResponse()
      {
      }
    }
  }
}
