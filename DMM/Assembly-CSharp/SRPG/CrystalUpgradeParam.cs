// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalUpgradeParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AA8")]
  [MessagePackObject(true)]
  [Serializable]
  public class CrystalUpgradeParam
  {
    [Token(Token = "0x17000C4E")]
    public string Iname
    {
      [Token(Token = "0x6006DE7"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006DE8"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000C4F")]
    public string NextIname
    {
      [Token(Token = "0x6006DE9"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006DEA"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17000C50")]
    public int Rank
    {
      [Token(Token = "0x6006DEB"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x6006DEC"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x17000C51")]
    public int MaterialNum
    {
      [Token(Token = "0x6006DED"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
      [Token(Token = "0x6006DEE"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x6006DEF")]
    [Address(RVA = "0x35CBE0", Offset = "0x35B9E0", VA = "0x1035CBE0")]
    public bool Deserialize(JSON_CrystalUpgradeParam json) => new bool();

    [Token(Token = "0x6006DF0")]
    [Address(RVA = "0x35CC40", Offset = "0x35BA40", VA = "0x1035CC40")]
    public static void Deserialize(
      ref List<CrystalUpgradeParam> param,
      JSON_CrystalUpgradeParam[] json)
    {
    }

    [Token(Token = "0x6006DF1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalUpgradeParam()
    {
    }
  }
}
