// Decompiled with JetBrains decompiler
// Type: SRPG.Json_Friends
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001024")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_Friends
  {
    [Token(Token = "0x4003973")]
    [FieldOffset(Offset = "0x8")]
    public int friendnum;
    [Token(Token = "0x4003974")]
    [FieldOffset(Offset = "0xC")]
    public string[] follower;

    [Token(Token = "0x6004289")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_Friends()
    {
    }
  }
}
