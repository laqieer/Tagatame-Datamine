// Decompiled with JetBrains decompiler
// Type: SRPG.ReqPublicInfoCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200308F")]
  public class ReqPublicInfoCheck : WebAPI
  {
    [Token(Token = "0x600DD0F")]
    [Address(RVA = "0xA8A160", Offset = "0xA88F60", VA = "0x10A8A160")]
    public ReqPublicInfoCheck(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003090")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EC18")]
      [FieldOffset(Offset = "0x8")]
      public int is_new_pubinfo;

      [Token(Token = "0x600DD10")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
