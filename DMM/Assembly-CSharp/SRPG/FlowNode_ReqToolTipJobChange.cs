// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqToolTipJobChange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200186F")]
  [FlowNode.NodeType("ToolTip/Req/JobChange", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqToolTipJobChange : FlowNode_Network
  {
    [Token(Token = "0x40057A7")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40057A8")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40057A9")]
    private const long EMPTY_UID = -1;
    [Token(Token = "0x40057AA")]
    private const long EMPTY_JID = -1;
    [Token(Token = "0x40057AB")]
    [FieldOffset(Offset = "0x20")]
    private SerializeValueList svl;

    [Token(Token = "0x600627B")]
    [Address(RVA = "0x30CC60", Offset = "0x30BA60", VA = "0x1030CC60", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600627C")]
    [Address(RVA = "0x30D590", Offset = "0x30C390", VA = "0x1030D590")]
    private void Success()
    {
    }

    [Token(Token = "0x600627D")]
    [Address(RVA = "0x30D000", Offset = "0x30BE00", VA = "0x1030D000", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600627E")]
    [Address(RVA = "0x30D3E0", Offset = "0x30C1E0", VA = "0x1030D3E0")]
    private void Success_Simple(WWWResult www)
    {
    }

    [Token(Token = "0x600627F")]
    [Address(RVA = "0x30D180", Offset = "0x30BF80", VA = "0x1030D180")]
    private void Success_OverWrite(WWWResult www)
    {
    }

    [Token(Token = "0x6006280")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqToolTipJobChange()
    {
    }

    [Token(Token = "0x2001870")]
    [MessagePackObject(true)]
    public class MP_UnitJob_OverWriteResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40057AC")]
      [FieldOffset(Offset = "0x28")]
      public ReqUnitJob_OverWrite.Response body;

      [Token(Token = "0x6006281")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_UnitJob_OverWriteResponse()
      {
      }
    }
  }
}
