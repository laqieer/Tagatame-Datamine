// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_VersusSchedule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EDE")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_VersusSchedule
  {
    [Token(Token = "0x40081CD")]
    [FieldOffset(Offset = "0x8")]
    public string tower_iname;
    [Token(Token = "0x40081CE")]
    [FieldOffset(Offset = "0xC")]
    public string iname;
    [Token(Token = "0x40081CF")]
    [FieldOffset(Offset = "0x10")]
    public string begin_at;
    [Token(Token = "0x40081D0")]
    [FieldOffset(Offset = "0x14")]
    public string end_at;
    [Token(Token = "0x40081D1")]
    [FieldOffset(Offset = "0x18")]
    public string gift_begin_at;
    [Token(Token = "0x40081D2")]
    [FieldOffset(Offset = "0x1C")]
    public string gift_end_at;

    [Token(Token = "0x6007E43")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_VersusSchedule()
    {
    }
  }
}
