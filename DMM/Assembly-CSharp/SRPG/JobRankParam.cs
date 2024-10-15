// Decompiled with JetBrains decompiler
// Type: SRPG.JobRankParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E0D")]
  [MessagePackObject(true)]
  public class JobRankParam
  {
    [Token(Token = "0x40079F3")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int MAX_RANKUP_EQUIPS;
    [Token(Token = "0x40079F4")]
    [FieldOffset(Offset = "0x8")]
    public int JobChangeCost;
    [Token(Token = "0x40079F5")]
    [FieldOffset(Offset = "0xC")]
    public string[] JobChangeItems;
    [Token(Token = "0x40079F6")]
    [FieldOffset(Offset = "0x10")]
    public int[] JobChangeItemNums;
    [Token(Token = "0x40079F7")]
    [FieldOffset(Offset = "0x14")]
    public int cost;
    [Token(Token = "0x40079F8")]
    [FieldOffset(Offset = "0x18")]
    public string[] equips;
    [Token(Token = "0x40079F9")]
    [FieldOffset(Offset = "0x1C")]
    public BuffEffect.BuffValues[] buff_list;
    [Token(Token = "0x40079FA")]
    [FieldOffset(Offset = "0x20")]
    public OString[] learnings;

    [Token(Token = "0x6007B59")]
    [Address(RVA = "0x3E1700", Offset = "0x3E0500", VA = "0x103E1700")]
    public bool Deserialize(JSON_JobRankParam json) => new bool();

    [Token(Token = "0x6007B5A")]
    [Address(RVA = "0x3E1C20", Offset = "0x3E0A20", VA = "0x103E1C20")]
    public JobRankParam()
    {
    }

    [Token(Token = "0x6007B5B")]
    [Address(RVA = "0x3E1BF0", Offset = "0x3E09F0", VA = "0x103E1BF0")]
    static JobRankParam()
    {
    }
  }
}
