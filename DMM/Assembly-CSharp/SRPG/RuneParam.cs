// Decompiled with JetBrains decompiler
// Type: SRPG.RuneParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CD3")]
  [MessagePackObject(true)]
  [Serializable]
  public class RuneParam
  {
    [Token(Token = "0x40070FD")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40070FE")]
    [FieldOffset(Offset = "0xC")]
    public string item_iname;
    [Token(Token = "0x40070FF")]
    [FieldOffset(Offset = "0x10")]
    public RuneSlotIndex slot_index;
    [Token(Token = "0x4007100")]
    [FieldOffset(Offset = "0x14")]
    public int seteff_type;
    [Token(Token = "0x4007101")]
    [FieldOffset(Offset = "0x18")]
    public string base_state;
    [Token(Token = "0x4007102")]
    [FieldOffset(Offset = "0x1C")]
    public string evo_state;

    [Token(Token = "0x17000F74")]
    [IgnoreMember]
    public int SetEffTypeIconIndex
    {
      [Token(Token = "0x600768E"), Address(RVA = "0x39B010", Offset = "0x399E10", VA = "0x1039B010")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600768F")]
    [Address(RVA = "0x39AE80", Offset = "0x399C80", VA = "0x1039AE80")]
    public bool Deserialize(JSON_RuneParam json) => new bool();

    [Token(Token = "0x17000F75")]
    public ItemParam ItemParam
    {
      [Token(Token = "0x6007690"), Address(RVA = "0x39AF00", Offset = "0x399D00", VA = "0x1039AF00")] get
      {
        return (ItemParam) null;
      }
    }

    [Token(Token = "0x17000F76")]
    public RuneSetEff RuneSetEff
    {
      [Token(Token = "0x6007691"), Address(RVA = "0x39AFB0", Offset = "0x399DB0", VA = "0x1039AFB0")] get
      {
        return (RuneSetEff) null;
      }
    }

    [Token(Token = "0x17000F77")]
    public RuneLotteryEvoStatePack RuneEvoStatePack
    {
      [Token(Token = "0x6007692"), Address(RVA = "0x39AF50", Offset = "0x399D50", VA = "0x1039AF50")] get
      {
        return (RuneLotteryEvoStatePack) null;
      }
    }

    [Token(Token = "0x6007693")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneParam()
    {
    }
  }
}
