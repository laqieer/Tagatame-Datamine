// Decompiled with JetBrains decompiler
// Type: SRPG.ReqArtifactAddRare
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002E5F")]
  public class ReqArtifactAddRare : WebAPI
  {
    [Token(Token = "0x600DAA5")]
    [Address(RVA = "0xA6BBA0", Offset = "0xA6A9A0", VA = "0x10A6BBA0")]
    public ReqArtifactAddRare(
      ReqArtifactAddRare.Request requst,
      Network.ResponseCallback response,
      string trophyProgs,
      string bingoProgs)
    {
    }

    [Token(Token = "0x2002E60")]
    [Serializable]
    public class Materials
    {
      [Token(Token = "0x400E880")]
      [FieldOffset(Offset = "0x8")]
      public long iid;
      [Token(Token = "0x400E881")]
      [FieldOffset(Offset = "0x10")]
      public int num;

      [Token(Token = "0x600DAA6")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Materials()
      {
      }
    }

    [Token(Token = "0x2002E61")]
    [Serializable]
    public class Request
    {
      [Token(Token = "0x400E882")]
      [FieldOffset(Offset = "0x8")]
      public long iid;
      [Token(Token = "0x400E883")]
      [FieldOffset(Offset = "0x10")]
      public ReqArtifactAddRare.Materials[] mats;

      [Token(Token = "0x600DAA7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Request()
      {
      }
    }
  }
}
