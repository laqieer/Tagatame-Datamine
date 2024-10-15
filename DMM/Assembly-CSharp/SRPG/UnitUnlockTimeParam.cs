// Decompiled with JetBrains decompiler
// Type: SRPG.UnitUnlockTimeParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EAA")]
  public class UnitUnlockTimeParam
  {
    [Token(Token = "0x4008048")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4008049")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x400804A")]
    [FieldOffset(Offset = "0x10")]
    public DateTime begin_at;
    [Token(Token = "0x400804B")]
    [FieldOffset(Offset = "0x18")]
    public DateTime end_at;

    [Token(Token = "0x6007DC0")]
    [Address(RVA = "0x3F7A70", Offset = "0x3F6870", VA = "0x103F7A70")]
    public bool Deserialize(JSON_UnitUnlockTimeParam json) => new bool();

    [Token(Token = "0x6007DC1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitUnlockTimeParam()
    {
    }
  }
}
