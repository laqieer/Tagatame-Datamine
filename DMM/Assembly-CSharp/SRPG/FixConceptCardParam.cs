// Decompiled with JetBrains decompiler
// Type: SRPG.FixConceptCardParam
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
  [Token(Token = "0x2001A69")]
  [MessagePackObject(true)]
  [Serializable]
  public class FixConceptCardParam
  {
    [Token(Token = "0x400616E")]
    [FieldOffset(Offset = "0x8")]
    private int mExtraRarityNeedPoint;
    [Token(Token = "0x400616F")]
    [FieldOffset(Offset = "0xC")]
    private int mExtraRarityCost;
    [Token(Token = "0x4006170")]
    [FieldOffset(Offset = "0x10")]
    private int mCommonExtraRarityPoint;
    [Token(Token = "0x4006171")]
    [FieldOffset(Offset = "0x14")]
    private List<int> mSlot2DecRateExtra;

    [Token(Token = "0x17000BE6")]
    [IgnoreMember]
    public int ExtraRarityNeedPoint
    {
      [Token(Token = "0x6006C8E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000BE7")]
    [IgnoreMember]
    public int ExtraRarityCost
    {
      [Token(Token = "0x6006C8F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000BE8")]
    [IgnoreMember]
    public int CommonExtraRarityPoint
    {
      [Token(Token = "0x6006C90"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000BE9")]
    [IgnoreMember]
    public List<int> Slot2DecRateExtra
    {
      [Token(Token = "0x6006C91"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x6006C92")]
    [Address(RVA = "0x358B20", Offset = "0x357920", VA = "0x10358B20")]
    public bool Deserialize(JSON_FixConceptCardParam _json) => new bool();

    [Token(Token = "0x6006C93")]
    [Address(RVA = "0x358C50", Offset = "0x357A50", VA = "0x10358C50")]
    public static void Deserialize(ref FixConceptCardParam param, JSON_FixConceptCardParam[] _json)
    {
    }

    [Token(Token = "0x6006C94")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public FixConceptCardParam()
    {
    }
  }
}
