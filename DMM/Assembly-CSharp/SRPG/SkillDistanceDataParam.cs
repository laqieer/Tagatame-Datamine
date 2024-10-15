// Decompiled with JetBrains decompiler
// Type: SRPG.SkillDistanceDataParam
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
  [Token(Token = "0x2001E3B")]
  [MessagePackObject(true)]
  [Serializable]
  public class SkillDistanceDataParam
  {
    [Token(Token = "0x4007B13")]
    [FieldOffset(Offset = "0x8")]
    private int mDistanceMin;
    [Token(Token = "0x4007B14")]
    [FieldOffset(Offset = "0xC")]
    private int mDistanceMax;
    [Token(Token = "0x4007B15")]
    [FieldOffset(Offset = "0x10")]
    private int mValue;
    [Token(Token = "0x4007B16")]
    [FieldOffset(Offset = "0x14")]
    private List<AttackTypes> mAtkTypes;
    [Token(Token = "0x4007B17")]
    [FieldOffset(Offset = "0x18")]
    private List<AttackDetailTypes> mAtkDetails;
    [Token(Token = "0x4007B18")]
    [FieldOffset(Offset = "0x1C")]
    private List<EElement> mAtkElements;

    [Token(Token = "0x17001127")]
    public int DistanceMin
    {
      [Token(Token = "0x6007C03"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001128")]
    public int DistanceMax
    {
      [Token(Token = "0x6007C04"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001129")]
    public int Value
    {
      [Token(Token = "0x6007C05"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700112A")]
    public List<AttackTypes> AtkTypes
    {
      [Token(Token = "0x6007C06"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<AttackTypes>) null;
      }
    }

    [Token(Token = "0x1700112B")]
    public List<AttackDetailTypes> AtkDetails
    {
      [Token(Token = "0x6007C07"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<AttackDetailTypes>) null;
      }
    }

    [Token(Token = "0x1700112C")]
    public List<EElement> AtkElements
    {
      [Token(Token = "0x6007C08"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (List<EElement>) null;
      }
    }

    [Token(Token = "0x1700112D")]
    public bool IsAttackTypeNone
    {
      [Token(Token = "0x6007C09"), Address(RVA = "0x3E69C0", Offset = "0x3E57C0", VA = "0x103E69C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700112E")]
    public bool IsAttackDetailTypesNone
    {
      [Token(Token = "0x6007C0A"), Address(RVA = "0x3E6980", Offset = "0x3E5780", VA = "0x103E6980")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700112F")]
    public bool IsElementsNone
    {
      [Token(Token = "0x6007C0B"), Address(RVA = "0x3E6A00", Offset = "0x3E5800", VA = "0x103E6A00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007C0C")]
    [Address(RVA = "0x3E6680", Offset = "0x3E5480", VA = "0x103E6680")]
    public bool Deserialize(JSON_SkillDistanceDataParam json) => new bool();

    [Token(Token = "0x6007C0D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SkillDistanceDataParam()
    {
    }
  }
}
