// Decompiled with JetBrains decompiler
// Type: SRPG.BondGroupParam
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
  [Token(Token = "0x20019AE")]
  [MessagePackObject(true)]
  [Serializable]
  public class BondGroupParam
  {
    [Token(Token = "0x4005E61")]
    [FieldOffset(Offset = "0x38")]
    private BondGroupBuffParam mBondGroupBuffParam;
    [Token(Token = "0x4005E62")]
    [FieldOffset(Offset = "0x3C")]
    private BondData mBondData;
    [Token(Token = "0x4005E63")]
    [FieldOffset(Offset = "0x40")]
    private bool mIsOpenchecked;
    [Token(Token = "0x4005E64")]
    [FieldOffset(Offset = "0x41")]
    private bool mIsOpen;

    [Token(Token = "0x17000B0C")]
    public string Iname
    {
      [Token(Token = "0x60068B6"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60068B7"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000B0D")]
    public string Name
    {
      [Token(Token = "0x60068B8"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60068B9"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17000B0E")]
    public string GroupName
    {
      [Token(Token = "0x60068BA"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60068BB"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17000B0F")]
    public string BannerImg
    {
      [Token(Token = "0x60068BC"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60068BD"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
      {
      }
    }

    [Token(Token = "0x17000B10")]
    public string BgImg
    {
      [Token(Token = "0x60068BE"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60068BF"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x17000B11")]
    public DateTime BeginAt
    {
      [Token(Token = "0x60068C0"), Address(RVA = "0x31F940", Offset = "0x31E740", VA = "0x1031F940")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x60068C1"), Address(RVA = "0x34D360", Offset = "0x34C160", VA = "0x1034D360")] private set
      {
      }
    }

    [Token(Token = "0x17000B12")]
    public DateTime EndAt
    {
      [Token(Token = "0x60068C2"), Address(RVA = "0x31F950", Offset = "0x31E750", VA = "0x1031F950")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x60068C3"), Address(RVA = "0x305820", Offset = "0x304620", VA = "0x10305820")] private set
      {
      }
    }

    [Token(Token = "0x17000B13")]
    public DateTime ModifiedAt
    {
      [Token(Token = "0x60068C4"), Address(RVA = "0x32ED20", Offset = "0x32DB20", VA = "0x1032ED20")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x60068C5"), Address(RVA = "0x305850", Offset = "0x304650", VA = "0x10305850")] private set
      {
      }
    }

    [Token(Token = "0x60068C6")]
    [Address(RVA = "0x34C910", Offset = "0x34B710", VA = "0x1034C910")]
    public bool Deserialize(Json_BondGroupParam json) => new bool();

    [Token(Token = "0x60068C7")]
    [Address(RVA = "0x34C6E0", Offset = "0x34B4E0", VA = "0x1034C6E0")]
    public static void Deserialize(ref List<BondGroupParam> param, Json_BondGroupParam[] json)
    {
    }

    [Token(Token = "0x60068C8")]
    [Address(RVA = "0x34CCC0", Offset = "0x34BAC0", VA = "0x1034CCC0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x17000B14")]
    public BondGroupBuffParam GetGroupBuffParam
    {
      [Token(Token = "0x60068C9"), Address(RVA = "0x34CE10", Offset = "0x34BC10", VA = "0x1034CE10")] get
      {
        return (BondGroupBuffParam) null;
      }
    }

    [Token(Token = "0x17000B15")]
    public bool IsOpenPropperTerm
    {
      [Token(Token = "0x60068CA"), Address(RVA = "0x34CF30", Offset = "0x34BD30", VA = "0x1034CF30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000B16")]
    public BondData GetBondData
    {
      [Token(Token = "0x60068CB"), Address(RVA = "0x34CCF0", Offset = "0x34BAF0", VA = "0x1034CCF0")] get
      {
        return (BondData) null;
      }
    }

    [Token(Token = "0x17000B17")]
    public bool IsOpen
    {
      [Token(Token = "0x60068CC"), Address(RVA = "0x34D000", Offset = "0x34BE00", VA = "0x1034D000")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60068CD")]
    [Address(RVA = "0x34CB80", Offset = "0x34B980", VA = "0x1034CB80")]
    public bool IsCanLvUpCheck(int target_lv = 0) => new bool();

    [Token(Token = "0x60068CE")]
    [Address(RVA = "0x34CA50", Offset = "0x34B850", VA = "0x1034CA50")]
    public bool IsCanLvUpButtonPress(int target_lv = 0) => new bool();

    [Token(Token = "0x60068CF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BondGroupParam()
    {
    }
  }
}
