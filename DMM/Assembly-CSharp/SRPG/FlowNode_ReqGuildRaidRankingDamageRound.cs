// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildRaidRankingDamageRound
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016D5")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("GuildRaid/Req/GuildRaidRankingDamageRound", 32741)]
  public class FlowNode_ReqGuildRaidRankingDamageRound : FlowNode_Network
  {
    [Token(Token = "0x40052A2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool Overwrite;
    [Token(Token = "0x40052A3")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40052A4")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005D51")]
    [Address(RVA = "0x131C1A0", Offset = "0x131AFA0", VA = "0x1131C1A0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D52")]
    [Address(RVA = "0x131C870", Offset = "0x131B670", VA = "0x1131C870")]
    private void Success()
    {
    }

    [Token(Token = "0x6005D53")]
    [Address(RVA = "0x131C3D0", Offset = "0x131B1D0", VA = "0x1131C3D0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005D54")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildRaidRankingDamageRound()
    {
    }

    [Token(Token = "0x20016D6")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40052A5")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildRaidRankingDamageRound.Response body;

      [Token(Token = "0x6005D55")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
