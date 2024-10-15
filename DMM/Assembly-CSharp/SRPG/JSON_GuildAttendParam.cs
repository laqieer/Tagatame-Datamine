// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildAttendParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B20")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildAttendParam
  {
    [Token(Token = "0x4006765")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4006766")]
    [FieldOffset(Offset = "0xC")]
    public string start_at;
    [Token(Token = "0x4006767")]
    [FieldOffset(Offset = "0x10")]
    public string end_at;
    [Token(Token = "0x4006768")]
    [FieldOffset(Offset = "0x14")]
    public JSON_GuildAttendRewardDetail[] rewards;

    [Token(Token = "0x6006FDE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildAttendParam()
    {
    }
  }
}
