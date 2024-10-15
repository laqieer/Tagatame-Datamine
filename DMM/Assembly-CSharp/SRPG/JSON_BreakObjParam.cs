// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_BreakObjParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DD6")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_BreakObjParam
  {
    [Token(Token = "0x4007790")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007791")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4007792")]
    [FieldOffset(Offset = "0x10")]
    public string expr;
    [Token(Token = "0x4007793")]
    [FieldOffset(Offset = "0x14")]
    public string unit_id;
    [Token(Token = "0x4007794")]
    [FieldOffset(Offset = "0x18")]
    public int clash_type;
    [Token(Token = "0x4007795")]
    [FieldOffset(Offset = "0x1C")]
    public int ai_type;
    [Token(Token = "0x4007796")]
    [FieldOffset(Offset = "0x20")]
    public int side_type;
    [Token(Token = "0x4007797")]
    [FieldOffset(Offset = "0x24")]
    public int ray_type;
    [Token(Token = "0x4007798")]
    [FieldOffset(Offset = "0x28")]
    public int is_ui;
    [Token(Token = "0x4007799")]
    [FieldOffset(Offset = "0x2C")]
    public string rest_hps;
    [Token(Token = "0x400779A")]
    [FieldOffset(Offset = "0x30")]
    public int clock;
    [Token(Token = "0x400779B")]
    [FieldOffset(Offset = "0x34")]
    public int appear_dir;

    [Token(Token = "0x6007A1D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_BreakObjParam()
    {
    }
  }
}
