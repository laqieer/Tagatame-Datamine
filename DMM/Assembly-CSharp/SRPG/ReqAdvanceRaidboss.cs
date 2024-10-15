// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAdvanceRaidboss
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003215")]
  public class ReqAdvanceRaidboss : WebAPI
  {
    [Token(Token = "0x600DEB1")]
    [Address(RVA = "0xA931D0", Offset = "0xA91FD0", VA = "0x10A931D0")]
    public ReqAdvanceRaidboss(
      string area_id,
      QuestDifficulties difficulty,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003216")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EE03")]
      [FieldOffset(Offset = "0x8")]
      public string area_id;
      [Token(Token = "0x400EE04")]
      [FieldOffset(Offset = "0xC")]
      public int difficulty;

      [Token(Token = "0x600DEB2")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003217")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EE05")]
      [FieldOffset(Offset = "0x8")]
      public int hp;
      [Token(Token = "0x400EE06")]
      [FieldOffset(Offset = "0xC")]
      public int round;

      [Token(Token = "0x600DEB3")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
