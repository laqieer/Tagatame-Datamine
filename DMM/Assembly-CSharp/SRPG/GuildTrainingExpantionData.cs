// Decompiled with JetBrains decompiler
// Type: SRPG.GuildTrainingExpantionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200253C")]
  public class GuildTrainingExpantionData
  {
    [Token(Token = "0x400AAA9")]
    [FieldOffset(Offset = "0x8")]
    private readonly long INDEFINITE_PERIOD;
    [Token(Token = "0x400AAAA")]
    [FieldOffset(Offset = "0x10")]
    private ExpansionPurchaseParam.eType mType;
    [Token(Token = "0x400AAAB")]
    [FieldOffset(Offset = "0x14")]
    private int mValueScale;
    [Token(Token = "0x400AAAC")]
    [FieldOffset(Offset = "0x18")]
    private int mValue;
    [Token(Token = "0x400AAAD")]
    [FieldOffset(Offset = "0x20")]
    private long mShortPeriod;
    [Token(Token = "0x400AAAE")]
    [FieldOffset(Offset = "0x28")]
    private long mLongPeriod;
    [Token(Token = "0x400AAAF")]
    [FieldOffset(Offset = "0x30")]
    private long mDefaultPeriod;
    [Token(Token = "0x400AAB0")]
    [FieldOffset(Offset = "0x38")]
    private DateTime mShortPeriodDate;
    [Token(Token = "0x400AAB1")]
    [FieldOffset(Offset = "0x40")]
    private DateTime mLongPeriodDate;
    [Token(Token = "0x400AAB2")]
    [FieldOffset(Offset = "0x48")]
    private bool mIsEnableExpantion;

    [Token(Token = "0x170016E4")]
    public ExpansionPurchaseParam.eType Type
    {
      [Token(Token = "0x600A425"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new ExpansionPurchaseParam.eType();
      }
    }

    [Token(Token = "0x170016E5")]
    public int ValueScale
    {
      [Token(Token = "0x600A426"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170016E6")]
    public int Value
    {
      [Token(Token = "0x600A427"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170016E7")]
    public long ShortPeriod
    {
      [Token(Token = "0x600A428"), Address(RVA = "0x34F490", Offset = "0x34E290", VA = "0x1034F490")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x170016E8")]
    public long LongPeriod
    {
      [Token(Token = "0x600A429"), Address(RVA = "0x3057C0", Offset = "0x3045C0", VA = "0x103057C0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x170016E9")]
    public long DefaultPeriod
    {
      [Token(Token = "0x600A42A"), Address(RVA = "0x3057D0", Offset = "0x3045D0", VA = "0x103057D0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x170016EA")]
    public DateTime ShortPeriodDate
    {
      [Token(Token = "0x600A42B"), Address(RVA = "0x370600", Offset = "0x36F400", VA = "0x10370600")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x170016EB")]
    public DateTime LongPeriodDate
    {
      [Token(Token = "0x600A42C"), Address(RVA = "0x3705E0", Offset = "0x36F3E0", VA = "0x103705E0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x170016EC")]
    public bool IsEnableExpantion
    {
      [Token(Token = "0x600A42D"), Address(RVA = "0x661B10", Offset = "0x660910", VA = "0x10661B10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600A42E")]
    [Address(RVA = "0x6619A0", Offset = "0x6607A0", VA = "0x106619A0")]
    public GuildTrainingExpantionData(ExpansionPurchaseParam.eType type, int valueScale)
    {
    }

    [Token(Token = "0x600A42F")]
    [Address(RVA = "0x661850", Offset = "0x660650", VA = "0x10661850")]
    public bool Setup() => new bool();

    [Token(Token = "0x600A430")]
    [Address(RVA = "0x661420", Offset = "0x660220", VA = "0x10661420")]
    public bool IsIndefinitePeriod() => new bool();

    [Token(Token = "0x600A431")]
    [Address(RVA = "0x661440", Offset = "0x660240", VA = "0x10661440")]
    private void SetupPeriod(List<ExpansionPurchaseData> list)
    {
    }

    [Token(Token = "0x600A432")]
    [Address(RVA = "0x661660", Offset = "0x660460", VA = "0x10661660")]
    private void SetupValue(List<ExpansionPurchaseType> list)
    {
    }
  }
}
