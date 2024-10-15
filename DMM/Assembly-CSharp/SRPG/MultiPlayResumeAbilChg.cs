// Decompiled with JetBrains decompiler
// Type: SRPG.MultiPlayResumeAbilChg
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000D96")]
  [MessagePackObject(true)]
  [Serializable]
  public class MultiPlayResumeAbilChg
  {
    [Token(Token = "0x40026C3")]
    [FieldOffset(Offset = "0x8")]
    public MultiPlayResumeAbilChg.Data[] acd;

    [Token(Token = "0x6003733")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public MultiPlayResumeAbilChg()
    {
    }

    [Token(Token = "0x2000D97")]
    [MessagePackObject(true)]
    [Serializable]
    public class Data
    {
      [Token(Token = "0x40026C4")]
      [FieldOffset(Offset = "0x8")]
      public string fid;
      [Token(Token = "0x40026C5")]
      [FieldOffset(Offset = "0xC")]
      public string tid;
      [Token(Token = "0x40026C6")]
      [FieldOffset(Offset = "0x10")]
      public int tur;
      [Token(Token = "0x40026C7")]
      [FieldOffset(Offset = "0x14")]
      public int irs;
      [Token(Token = "0x40026C8")]
      [FieldOffset(Offset = "0x18")]
      public int exp;
      [Token(Token = "0x40026C9")]
      [FieldOffset(Offset = "0x1C")]
      public int iif;

      [Token(Token = "0x6003734")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Data()
      {
      }
    }
  }
}
