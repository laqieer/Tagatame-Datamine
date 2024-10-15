// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GenesisChapterParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B05")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GenesisChapterParam
  {
    [Token(Token = "0x40066F4")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40066F5")]
    [FieldOffset(Offset = "0xC")]
    public int priority;
    [Token(Token = "0x40066F6")]
    [FieldOffset(Offset = "0x10")]
    public string area_id;
    [Token(Token = "0x40066F7")]
    [FieldOffset(Offset = "0x14")]
    public string name;
    [Token(Token = "0x40066F8")]
    [FieldOffset(Offset = "0x18")]
    public string box_iname;
    [Token(Token = "0x40066F9")]
    [FieldOffset(Offset = "0x1C")]
    public int chapter_ui_index;
    [Token(Token = "0x40066FA")]
    [FieldOffset(Offset = "0x20")]
    public string chapter_banner;
    [Token(Token = "0x40066FB")]
    [FieldOffset(Offset = "0x24")]
    public string chapter_detail_url;
    [Token(Token = "0x40066FC")]
    [FieldOffset(Offset = "0x28")]
    public string boss_hint_url;
    [Token(Token = "0x40066FD")]
    [FieldOffset(Offset = "0x2C")]
    public JSON_GenesisChapterModeInfoParam[] mode_info;

    [Token(Token = "0x6006F7F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GenesisChapterParam()
    {
    }
  }
}
