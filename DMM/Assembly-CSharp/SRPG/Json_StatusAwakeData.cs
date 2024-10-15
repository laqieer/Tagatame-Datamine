// Decompiled with JetBrains decompiler
// Type: SRPG.Json_StatusAwakeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011D7")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_StatusAwakeData
  {
    [Token(Token = "0x40040D8")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40040D9")]
    [FieldOffset(Offset = "0xC")]
    public int num;

    [Token(Token = "0x6004B82")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_StatusAwakeData()
    {
    }
  }
}
