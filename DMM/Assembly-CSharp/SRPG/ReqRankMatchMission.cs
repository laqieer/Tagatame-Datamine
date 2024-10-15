// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRankMatchMission
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003134")]
  public class ReqRankMatchMission : WebAPI
  {
    [Token(Token = "0x600DDC9")]
    [Address(RVA = "0xA8ABA0", Offset = "0xA899A0", VA = "0x10A8ABA0")]
    public ReqRankMatchMission(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003135")]
    [Serializable]
    public class MissionProgress
    {
      [Token(Token = "0x400ECDA")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x400ECDB")]
      [FieldOffset(Offset = "0xC")]
      public int prog;
      [Token(Token = "0x400ECDC")]
      [FieldOffset(Offset = "0x10")]
      public string rewarded_at;

      [Token(Token = "0x600DDCA")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public MissionProgress()
      {
      }
    }

    [Token(Token = "0x2003136")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400ECDD")]
      [FieldOffset(Offset = "0x8")]
      public ReqRankMatchMission.MissionProgress[] missionprogs;

      [Token(Token = "0x600DDCB")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
