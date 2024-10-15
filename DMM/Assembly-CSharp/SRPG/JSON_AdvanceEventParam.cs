// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_AdvanceEventParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001957")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_AdvanceEventParam
  {
    [Token(Token = "0x4005C2B")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4005C2C")]
    [FieldOffset(Offset = "0xC")]
    public int trans_type;
    [Token(Token = "0x4005C2D")]
    [FieldOffset(Offset = "0x10")]
    public int priority;
    [Token(Token = "0x4005C2E")]
    [FieldOffset(Offset = "0x14")]
    public string area_id;
    [Token(Token = "0x4005C2F")]
    [FieldOffset(Offset = "0x18")]
    public string name;
    [Token(Token = "0x4005C30")]
    [FieldOffset(Offset = "0x1C")]
    public string box_iname;
    [Token(Token = "0x4005C31")]
    [FieldOffset(Offset = "0x20")]
    public int event_ui_index;
    [Token(Token = "0x4005C32")]
    [FieldOffset(Offset = "0x24")]
    public string event_banner;
    [Token(Token = "0x4005C33")]
    [FieldOffset(Offset = "0x28")]
    public string event_detail_url;
    [Token(Token = "0x4005C34")]
    [FieldOffset(Offset = "0x2C")]
    public string boss_hint_url;
    [Token(Token = "0x4005C35")]
    [FieldOffset(Offset = "0x30")]
    public JSON_AdvanceEventModeInfoParam[] mode_info;

    [Token(Token = "0x6006743")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_AdvanceEventParam()
    {
    }
  }
}
