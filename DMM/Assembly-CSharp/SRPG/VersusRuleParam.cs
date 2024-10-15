// Decompiled with JetBrains decompiler
// Type: SRPG.VersusRuleParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EDD")]
  public class VersusRuleParam
  {
    [Token(Token = "0x40081C5")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int THREE_ON_THREE;
    [Token(Token = "0x40081C6")]
    [FieldOffset(Offset = "0x4")]
    public static readonly int FIVE_ON_FIVE;
    [Token(Token = "0x40081C7")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x40081C8")]
    [FieldOffset(Offset = "0xC")]
    public int coin;
    [Token(Token = "0x40081C9")]
    [FieldOffset(Offset = "0x10")]
    public int coinrate;
    [Token(Token = "0x40081CA")]
    [FieldOffset(Offset = "0x18")]
    public DateTime begin_at;
    [Token(Token = "0x40081CB")]
    [FieldOffset(Offset = "0x20")]
    public DateTime end_at;
    [Token(Token = "0x40081CC")]
    [FieldOffset(Offset = "0x28")]
    public VS_MODE mode;

    [Token(Token = "0x6007E40")]
    [Address(RVA = "0x3FB670", Offset = "0x3FA470", VA = "0x103FB670")]
    public bool Deserialize(JSON_VersusRule json) => new bool();

    [Token(Token = "0x6007E41")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusRuleParam()
    {
    }

    [Token(Token = "0x6007E42")]
    [Address(RVA = "0x3FB7F0", Offset = "0x3FA5F0", VA = "0x103FB7F0")]
    static VersusRuleParam()
    {
    }
  }
}
