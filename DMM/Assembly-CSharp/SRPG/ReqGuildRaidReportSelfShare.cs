// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRaidReportSelfShare
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002F3F")]
  public class ReqGuildRaidReportSelfShare : WebAPI
  {
    [Token(Token = "0x600DB90")]
    [Address(RVA = "0xA73170", Offset = "0xA71F70", VA = "0x10A73170")]
    public ReqGuildRaidReportSelfShare(
      int gid,
      int report_id,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002F40")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E9EC")]
      [FieldOffset(Offset = "0x8")]
      public int gid;
      [Token(Token = "0x400E9ED")]
      [FieldOffset(Offset = "0xC")]
      public int report_id;

      [Token(Token = "0x600DB91")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
