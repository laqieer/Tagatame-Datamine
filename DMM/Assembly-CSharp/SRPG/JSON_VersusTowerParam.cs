// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_VersusTowerParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EC9")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_VersusTowerParam
  {
    [Token(Token = "0x4008135")]
    [FieldOffset(Offset = "0x8")]
    public string vstower_id;
    [Token(Token = "0x4008136")]
    [FieldOffset(Offset = "0xC")]
    public string iname;
    [Token(Token = "0x4008137")]
    [FieldOffset(Offset = "0x10")]
    public int floor;
    [Token(Token = "0x4008138")]
    [FieldOffset(Offset = "0x14")]
    public int rankup_num;
    [Token(Token = "0x4008139")]
    [FieldOffset(Offset = "0x18")]
    public int win_num;
    [Token(Token = "0x400813A")]
    [FieldOffset(Offset = "0x1C")]
    public int lose_num;
    [Token(Token = "0x400813B")]
    [FieldOffset(Offset = "0x20")]
    public int bonus_num;
    [Token(Token = "0x400813C")]
    [FieldOffset(Offset = "0x24")]
    public int downfloor;
    [Token(Token = "0x400813D")]
    [FieldOffset(Offset = "0x28")]
    public int resetfloor;
    [Token(Token = "0x400813E")]
    [FieldOffset(Offset = "0x2C")]
    public string[] winitem;
    [Token(Token = "0x400813F")]
    [FieldOffset(Offset = "0x30")]
    public int[] win_itemnum;
    [Token(Token = "0x4008140")]
    [FieldOffset(Offset = "0x34")]
    public string[] joinitem;
    [Token(Token = "0x4008141")]
    [FieldOffset(Offset = "0x38")]
    public int[] join_itemnum;
    [Token(Token = "0x4008142")]
    [FieldOffset(Offset = "0x3C")]
    public string arrival_item;
    [Token(Token = "0x4008143")]
    [FieldOffset(Offset = "0x40")]
    public string arrival_type;
    [Token(Token = "0x4008144")]
    [FieldOffset(Offset = "0x44")]
    public int arrival_num;
    [Token(Token = "0x4008145")]
    [FieldOffset(Offset = "0x48")]
    public string[] spbtl_item;
    [Token(Token = "0x4008146")]
    [FieldOffset(Offset = "0x4C")]
    public int[] spbtl_itemnum;
    [Token(Token = "0x4008147")]
    [FieldOffset(Offset = "0x50")]
    public string[] season_item;
    [Token(Token = "0x4008148")]
    [FieldOffset(Offset = "0x54")]
    public string[] season_itype;
    [Token(Token = "0x4008149")]
    [FieldOffset(Offset = "0x58")]
    public int[] season_itemnum;

    [Token(Token = "0x6007E04")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_VersusTowerParam()
    {
    }
  }
}
