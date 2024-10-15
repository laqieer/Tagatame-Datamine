// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGvGLeague
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200170F")]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("GvG/Req/GvGLeague", 32741)]
  public class FlowNode_ReqGvGLeague : FlowNode_Network
  {
    [Token(Token = "0x4005322")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005323")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005324")]
    [FieldOffset(Offset = "0x20")]
    private string mLeagueID;
    [Token(Token = "0x4005325")]
    [FieldOffset(Offset = "0x24")]
    private int mGuildID;
    [Token(Token = "0x4005326")]
    [FieldOffset(Offset = "0x28")]
    private int mStartRank;
    [Token(Token = "0x4005327")]
    [FieldOffset(Offset = "0x2C")]
    private int mLimit;

    [Token(Token = "0x170009AB")]
    private bool IsAllLeagueRequest
    {
      [Token(Token = "0x6005DF6"), Address(RVA = "0x1325EE0", Offset = "0x1324CE0", VA = "0x11325EE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6005DF7")]
    [Address(RVA = "0x1325CA0", Offset = "0x1324AA0", VA = "0x11325CA0")]
    public void SetRequestAllLeague(int startRank, int limit)
    {
    }

    [Token(Token = "0x6005DF8")]
    [Address(RVA = "0x1325D00", Offset = "0x1324B00", VA = "0x11325D00")]
    public void SetRequestMyLeague()
    {
    }

    [Token(Token = "0x6005DF9")]
    [Address(RVA = "0x1325D90", Offset = "0x1324B90", VA = "0x11325D90")]
    public void SetRequestMyLeague(int startRank, int limit)
    {
    }

    [Token(Token = "0x6005DFA")]
    [Address(RVA = "0x1325C70", Offset = "0x1324A70", VA = "0x11325C70")]
    public void SetRequesTargetLeague(string leagueID, int startRank, int limit)
    {
    }

    [Token(Token = "0x6005DFB")]
    [Address(RVA = "0x13254F0", Offset = "0x13242F0", VA = "0x113254F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005DFC")]
    [Address(RVA = "0x1325E40", Offset = "0x1324C40", VA = "0x11325E40")]
    private void Success()
    {
    }

    [Token(Token = "0x6005DFD")]
    [Address(RVA = "0x1325640", Offset = "0x1324440", VA = "0x11325640", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005DFE")]
    [Address(RVA = "0x1325EB0", Offset = "0x1324CB0", VA = "0x11325EB0")]
    public FlowNode_ReqGvGLeague()
    {
    }

    [Token(Token = "0x2001710")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005328")]
      [FieldOffset(Offset = "0x28")]
      public ReqGvGLeague.Response body;

      [Token(Token = "0x6005DFF")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
