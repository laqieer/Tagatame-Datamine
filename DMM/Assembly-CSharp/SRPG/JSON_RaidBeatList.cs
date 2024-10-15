// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RaidBeatList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010CF")]
  [Serializable]
  public class JSON_RaidBeatList
  {
    [Token(Token = "0x4003CA8")]
    [FieldOffset(Offset = "0x8")]
    public int area_id;
    [Token(Token = "0x4003CA9")]
    [FieldOffset(Offset = "0xC")]
    public int round;
    [Token(Token = "0x4003CAA")]
    [FieldOffset(Offset = "0x10")]
    public string[] beat_boss_unit_iname;

    [Token(Token = "0x600471E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RaidBeatList()
    {
    }
  }
}
