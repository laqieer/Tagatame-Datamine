// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_JukeBoxParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AFA")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_JukeBoxParam
  {
    [Token(Token = "0x40066AF")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40066B0")]
    [FieldOffset(Offset = "0xC")]
    public string sheet;
    [Token(Token = "0x40066B1")]
    [FieldOffset(Offset = "0x10")]
    public string cue;
    [Token(Token = "0x40066B2")]
    [FieldOffset(Offset = "0x14")]
    public string section;
    [Token(Token = "0x40066B3")]
    [FieldOffset(Offset = "0x18")]
    public int default_unlock;
    [Token(Token = "0x40066B4")]
    [FieldOffset(Offset = "0x1C")]
    public int external_link;
    [Token(Token = "0x40066B5")]
    [FieldOffset(Offset = "0x20")]
    public int rate;
    [Token(Token = "0x40066B6")]
    [FieldOffset(Offset = "0x24")]
    public int range_unit;
    [Token(Token = "0x40066B7")]
    [FieldOffset(Offset = "0x28")]
    public string[] quests;
    [Token(Token = "0x40066B8")]
    [FieldOffset(Offset = "0x2C")]
    public string cond_quest;

    [Token(Token = "0x6006F52")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_JukeBoxParam()
    {
    }
  }
}
