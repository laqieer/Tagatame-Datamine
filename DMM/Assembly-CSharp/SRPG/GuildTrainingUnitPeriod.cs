// Decompiled with JetBrains decompiler
// Type: SRPG.GuildTrainingUnitPeriod
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B33")]
  public class GuildTrainingUnitPeriod
  {
    [Token(Token = "0x400679B")]
    [FieldOffset(Offset = "0x8")]
    private DateTime mBeginAt;
    [Token(Token = "0x400679C")]
    [FieldOffset(Offset = "0x10")]
    private DateTime mEndAt;

    [Token(Token = "0x17000D28")]
    public DateTime BeginAt
    {
      [Token(Token = "0x6007019"), Address(RVA = "0x2ECBB0", Offset = "0x2EB9B0", VA = "0x102ECBB0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000D29")]
    public DateTime EndAt
    {
      [Token(Token = "0x600701A"), Address(RVA = "0x31CBE0", Offset = "0x31B9E0", VA = "0x1031CBE0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x600701B")]
    [Address(RVA = "0x3722E0", Offset = "0x3710E0", VA = "0x103722E0")]
    public bool Deserialize(JSON_GuildTrainingUnitPeriod json) => new bool();

    [Token(Token = "0x600701C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildTrainingUnitPeriod()
    {
    }
  }
}
