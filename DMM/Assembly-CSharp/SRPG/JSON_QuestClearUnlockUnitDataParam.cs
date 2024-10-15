// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_QuestClearUnlockUnitDataParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C33")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_QuestClearUnlockUnitDataParam
  {
    [Token(Token = "0x4006D69")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006D6A")]
    [FieldOffset(Offset = "0xC")]
    public string uid;
    [Token(Token = "0x4006D6B")]
    [FieldOffset(Offset = "0x10")]
    public int add;
    [Token(Token = "0x4006D6C")]
    [FieldOffset(Offset = "0x14")]
    public int type;
    [Token(Token = "0x4006D6D")]
    [FieldOffset(Offset = "0x18")]
    public string new_id;
    [Token(Token = "0x4006D6E")]
    [FieldOffset(Offset = "0x1C")]
    public string old_id;
    [Token(Token = "0x4006D6F")]
    [FieldOffset(Offset = "0x20")]
    public string parent_id;
    [Token(Token = "0x4006D70")]
    [FieldOffset(Offset = "0x24")]
    public int ulv;
    [Token(Token = "0x4006D71")]
    [FieldOffset(Offset = "0x28")]
    public string aid;
    [Token(Token = "0x4006D72")]
    [FieldOffset(Offset = "0x2C")]
    public int alv;
    [Token(Token = "0x4006D73")]
    [FieldOffset(Offset = "0x30")]
    public string[] qids;
    [Token(Token = "0x4006D74")]
    [FieldOffset(Offset = "0x34")]
    public int qcnd;

    [Token(Token = "0x60073FE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_QuestClearUnlockUnitDataParam()
    {
    }
  }
}
