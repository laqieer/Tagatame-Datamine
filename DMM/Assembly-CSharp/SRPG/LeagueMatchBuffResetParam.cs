// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchBuffResetParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BB7")]
  [MessagePackObject(true)]
  public class LeagueMatchBuffResetParam
  {
    [Token(Token = "0x4006A09")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;

    [Token(Token = "0x17000DF8")]
    public string Iname
    {
      [Token(Token = "0x600726C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600726D")]
    [Address(RVA = "0x378CC0", Offset = "0x377AC0", VA = "0x10378CC0")]
    public bool Deserialize(JSON_LeagueMatchBuffResetParam json) => new bool();

    [Token(Token = "0x600726E")]
    [Address(RVA = "0x378B70", Offset = "0x377970", VA = "0x10378B70")]
    public static bool Deserialize(
      ref List<LeagueMatchBuffResetParam> paramList,
      JSON_LeagueMatchBuffResetParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x600726F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchBuffResetParam()
    {
    }
  }
}
