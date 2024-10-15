// Decompiled with JetBrains decompiler
// Type: SRPG.GenesisParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B0E")]
  public class GenesisParam
  {
    [Token(Token = "0x400672B")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x400672C")]
    [FieldOffset(Offset = "0xC")]
    private bool mIsValid;
    [Token(Token = "0x400672D")]
    [FieldOffset(Offset = "0x10")]
    private DateTime mBeginAt;
    [Token(Token = "0x400672E")]
    [FieldOffset(Offset = "0x18")]
    private DateTime mEndAt;

    [Token(Token = "0x17000D06")]
    public string Iname
    {
      [Token(Token = "0x6006FB9"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D07")]
    public bool IsValid
    {
      [Token(Token = "0x6006FBA"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000D08")]
    public DateTime BeginAt
    {
      [Token(Token = "0x6006FBB"), Address(RVA = "0x31CBE0", Offset = "0x31B9E0", VA = "0x1031CBE0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000D09")]
    public DateTime EndAt
    {
      [Token(Token = "0x6006FBC"), Address(RVA = "0x31CBF0", Offset = "0x31B9F0", VA = "0x1031CBF0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x6006FBD")]
    [Address(RVA = "0x36D840", Offset = "0x36C640", VA = "0x1036D840")]
    public void Deserialize(JSON_GenesisParam json)
    {
    }

    [Token(Token = "0x6006FBE")]
    [Address(RVA = "0x36D960", Offset = "0x36C760", VA = "0x1036D960")]
    public bool IsWithinPeriod() => new bool();

    [Token(Token = "0x6006FBF")]
    [Address(RVA = "0x36D5F0", Offset = "0x36C3F0", VA = "0x1036D5F0")]
    public static void Deserialize(ref List<GenesisParam> list, JSON_GenesisParam[] json)
    {
    }

    [Token(Token = "0x6006FC0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GenesisParam()
    {
    }
  }
}
