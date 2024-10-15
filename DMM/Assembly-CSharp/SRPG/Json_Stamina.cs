// Decompiled with JetBrains decompiler
// Type: SRPG.Json_Stamina
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FF8")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_Stamina
  {
    [Token(Token = "0x40038BD")]
    [FieldOffset(Offset = "0x8")]
    public int pt;
    [Token(Token = "0x40038BE")]
    [FieldOffset(Offset = "0xC")]
    public int max;
    [Token(Token = "0x40038BF")]
    [FieldOffset(Offset = "0x10")]
    public long at;

    [Token(Token = "0x600425C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_Stamina()
    {
    }
  }
}
