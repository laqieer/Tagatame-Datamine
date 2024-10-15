// Decompiled with JetBrains decompiler
// Type: SRPG.DragonGodParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BFF")]
  public class DragonGodParam
  {
    [Token(Token = "0x4006C61")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4006C62")]
    [FieldOffset(Offset = "0xC")]
    private bool mIsValid;
    [Token(Token = "0x4006C63")]
    [FieldOffset(Offset = "0x10")]
    private DateTime mBeginAt;
    [Token(Token = "0x4006C64")]
    [FieldOffset(Offset = "0x18")]
    private DateTime mEndAt;
    [Token(Token = "0x4006C65")]
    [FieldOffset(Offset = "0x20")]
    private DateTime mExitAt;

    [Token(Token = "0x17000E49")]
    public string Iname
    {
      [Token(Token = "0x6007342"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E4A")]
    public bool IsValid
    {
      [Token(Token = "0x6007343"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000E4B")]
    public DateTime BeginAt
    {
      [Token(Token = "0x6007344"), Address(RVA = "0x31CBE0", Offset = "0x31B9E0", VA = "0x1031CBE0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000E4C")]
    public DateTime EndAt
    {
      [Token(Token = "0x6007345"), Address(RVA = "0x31CBF0", Offset = "0x31B9F0", VA = "0x1031CBF0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000E4D")]
    public DateTime ExitAt
    {
      [Token(Token = "0x6007346"), Address(RVA = "0x31F940", Offset = "0x31E740", VA = "0x1031F940")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x6007347")]
    [Address(RVA = "0x36C580", Offset = "0x36B380", VA = "0x1036C580")]
    public void Deserialize(JSON_DragonGodParam json)
    {
    }

    [Token(Token = "0x6007348")]
    [Address(RVA = "0x36C700", Offset = "0x36B500", VA = "0x1036C700")]
    public static void Deserialize(
      ref ParamDictionary<string, DragonGodParam> ref_params,
      JSON_DragonGodParam[] jsons)
    {
    }

    [Token(Token = "0x6007349")]
    [Address(RVA = "0x36C9B0", Offset = "0x36B7B0", VA = "0x1036C9B0")]
    public static DragonGodParam GetChallengePeriod() => (DragonGodParam) null;

    [Token(Token = "0x600734A")]
    [Address(RVA = "0x36D010", Offset = "0x36BE10", VA = "0x1036D010")]
    public static bool IsChallengePeriod() => new bool();

    [Token(Token = "0x600734B")]
    [Address(RVA = "0x36CCE0", Offset = "0x36BAE0", VA = "0x1036CCE0")]
    public static DragonGodParam GetOpenDragonGod() => (DragonGodParam) null;

    [Token(Token = "0x600734C")]
    [Address(RVA = "0x36D020", Offset = "0x36BE20", VA = "0x1036D020")]
    public static bool IsOpenDragonGod() => new bool();

    [Token(Token = "0x600734D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public DragonGodParam()
    {
    }
  }
}
