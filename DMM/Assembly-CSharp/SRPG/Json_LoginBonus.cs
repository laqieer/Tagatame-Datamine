// Decompiled with JetBrains decompiler
// Type: SRPG.Json_LoginBonus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200101B")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_LoginBonus
  {
    [Token(Token = "0x4003950")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4003951")]
    [FieldOffset(Offset = "0xC")]
    public int num;
    [Token(Token = "0x4003952")]
    [FieldOffset(Offset = "0x10")]
    public int coin;
    [Token(Token = "0x4003953")]
    [FieldOffset(Offset = "0x14")]
    public Json_LoginBonusVip vip;

    [Token(Token = "0x600427F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_LoginBonus()
    {
    }
  }
}
