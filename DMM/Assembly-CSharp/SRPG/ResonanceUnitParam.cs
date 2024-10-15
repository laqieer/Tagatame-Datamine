// Decompiled with JetBrains decompiler
// Type: SRPG.ResonanceUnitParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CBD")]
  [MessagePackObject(true)]
  public class ResonanceUnitParam
  {
    [Token(Token = "0x40070C2")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40070C3")]
    [FieldOffset(Offset = "0xC")]
    public string condIname;
    [Token(Token = "0x40070C4")]
    [FieldOffset(Offset = "0x10")]
    private DateTime mBeginAt;

    [Token(Token = "0x6007643")]
    [Address(RVA = "0x398490", Offset = "0x397290", VA = "0x10398490")]
    public bool Deserialize(JSON_ResonanceUnitParam json) => new bool();

    [Token(Token = "0x6007644")]
    [Address(RVA = "0x398560", Offset = "0x397360", VA = "0x10398560")]
    public bool IsWithinPeriod() => new bool();

    [Token(Token = "0x6007645")]
    [Address(RVA = "0x3985F0", Offset = "0x3973F0", VA = "0x103985F0")]
    public ResonanceUnitParam()
    {
    }
  }
}
