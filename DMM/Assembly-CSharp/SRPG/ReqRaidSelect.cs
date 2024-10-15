// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRaidSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FC7")]
  public class ReqRaidSelect : WebAPI
  {
    [Token(Token = "0x600DC1B")]
    [Address(RVA = "0xA79890", Offset = "0xA78690", VA = "0x10A79890")]
    public ReqRaidSelect(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002FC8")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EAD0")]
      [FieldOffset(Offset = "0x8")]
      public JSON_RaidBossData raidboss_current;

      [Token(Token = "0x600DC1C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
