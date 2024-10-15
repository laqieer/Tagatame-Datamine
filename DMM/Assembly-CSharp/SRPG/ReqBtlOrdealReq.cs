// Decompiled with JetBrains decompiler
// Type: SRPG.ReqBtlOrdealReq
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20030AA")]
  public class ReqBtlOrdealReq : WebAPI
  {
    [Token(Token = "0x600DD2A")]
    [Address(RVA = "0xA83BF0", Offset = "0xA829F0", VA = "0x10A83BF0")]
    public ReqBtlOrdealReq(
      string iname,
      List<SupportData> supports,
      Network.ResponseCallback response)
    {
    }
  }
}
