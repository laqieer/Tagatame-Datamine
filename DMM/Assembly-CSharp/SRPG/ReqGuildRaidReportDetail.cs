// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRaidReportDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002F41")]
  public class ReqGuildRaidReportDetail : WebAPI
  {
    [Token(Token = "0x600DB92")]
    [Address(RVA = "0xA73060", Offset = "0xA71E60", VA = "0x10A73060")]
    public ReqGuildRaidReportDetail(
      int gid,
      int report_id,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002F42")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E9EE")]
      [FieldOffset(Offset = "0x8")]
      public int gid;
      [Token(Token = "0x400E9EF")]
      [FieldOffset(Offset = "0xC")]
      public int report_id;

      [Token(Token = "0x600DB93")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
