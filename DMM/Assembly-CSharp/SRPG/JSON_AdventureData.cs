// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_AdventureData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F80")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_AdventureData : JSON_AdventureDataBase
  {
    [Token(Token = "0x4008512")]
    [FieldOffset(Offset = "0x10")]
    public int end_time;
    [Token(Token = "0x4008513")]
    [FieldOffset(Offset = "0x14")]
    public int[] units;
    [Token(Token = "0x4008514")]
    [FieldOffset(Offset = "0x18")]
    public string[] unit_group;

    [Token(Token = "0x600816C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_AdventureData()
    {
    }
  }
}
