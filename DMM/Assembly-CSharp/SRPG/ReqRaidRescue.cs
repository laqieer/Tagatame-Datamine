// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRaidRescue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FD3")]
  public class ReqRaidRescue : WebAPI
  {
    [Token(Token = "0x600DC27")]
    [Address(RVA = "0xA79330", Offset = "0xA78130", VA = "0x10A79330")]
    public ReqRaidRescue(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002FD4")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EAFE")]
      [FieldOffset(Offset = "0x8")]
      public JSON_RaidRescueMember[] sos;
      [Token(Token = "0x400EAFF")]
      [FieldOffset(Offset = "0xC")]
      public int refresh_wait_sec;

      [Token(Token = "0x600DC28")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
