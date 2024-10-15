// Decompiled with JetBrains decompiler
// Type: SRPG.Json_RuneBuffData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010ED")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_RuneBuffData
  {
    [Token(Token = "0x4003D2D")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4003D2E")]
    [FieldOffset(Offset = "0xC")]
    public int val;
    [Token(Token = "0x4003D2F")]
    [FieldOffset(Offset = "0x10")]
    public int slot;

    [Token(Token = "0x6004785")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_RuneBuffData()
    {
    }
  }
}
