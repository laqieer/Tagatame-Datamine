// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGenesisRaidboss
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20031E9")]
  public class ReqGenesisRaidboss : WebAPI
  {
    [Token(Token = "0x600DE85")]
    [Address(RVA = "0xA98A20", Offset = "0xA97820", VA = "0x10A98A20")]
    public ReqGenesisRaidboss(
      string area_id,
      QuestDifficulties difficulty,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x20031EA")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EDA6")]
      [FieldOffset(Offset = "0x8")]
      public string area_id;
      [Token(Token = "0x400EDA7")]
      [FieldOffset(Offset = "0xC")]
      public int difficulty;

      [Token(Token = "0x600DE86")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x20031EB")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EDA8")]
      [FieldOffset(Offset = "0x8")]
      public int hp;
      [Token(Token = "0x400EDA9")]
      [FieldOffset(Offset = "0xC")]
      public int round;

      [Token(Token = "0x600DE87")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
