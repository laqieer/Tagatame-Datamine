// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRaidNextArea
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FE3")]
  public class ReqRaidNextArea : WebAPI
  {
    [Token(Token = "0x600DC39")]
    [Address(RVA = "0xA78CE0", Offset = "0xA77AE0", VA = "0x10A78CE0")]
    public ReqRaidNextArea(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002FE4")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB1C")]
      [FieldOffset(Offset = "0x8")]
      public int area_id;

      [Token(Token = "0x600DC3A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
