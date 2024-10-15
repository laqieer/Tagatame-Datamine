// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_FixArtifactParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AE4")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_FixArtifactParam
  {
    [Token(Token = "0x40063C8")]
    [FieldOffset(Offset = "0x8")]
    public int stone_open_min_rare;
    [Token(Token = "0x40063C9")]
    [FieldOffset(Offset = "0xC")]
    public int stone_open_min_lv;
    [Token(Token = "0x40063CA")]
    [FieldOffset(Offset = "0x10")]
    public int stone_mat_min_rare;
    [Token(Token = "0x40063CB")]
    [FieldOffset(Offset = "0x14")]
    public int stone_mat_min_lv;
    [Token(Token = "0x40063CC")]
    [FieldOffset(Offset = "0x18")]
    public int stone_open_gold;
    [Token(Token = "0x40063CD")]
    [FieldOffset(Offset = "0x1C")]
    public int stone_open_need_num;
    [Token(Token = "0x40063CE")]
    [FieldOffset(Offset = "0x20")]
    public int stone_open_common_need_num;
    [Token(Token = "0x40063CF")]
    [FieldOffset(Offset = "0x24")]
    public string stone_common_item;
    [Token(Token = "0x40063D0")]
    [FieldOffset(Offset = "0x28")]
    public int stone_drawing_gold;
    [Token(Token = "0x40063D1")]
    [FieldOffset(Offset = "0x2C")]
    public int stone_drawing_cost;
    [Token(Token = "0x40063D2")]
    [FieldOffset(Offset = "0x30")]
    public int stone_drawing_common_cost;
    [Token(Token = "0x40063D3")]
    [FieldOffset(Offset = "0x34")]
    public string stone_conversion_item;
    [Token(Token = "0x40063D4")]
    [FieldOffset(Offset = "0x38")]
    public int[] stone_conversion_item_counts;

    [Token(Token = "0x6006EC1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_FixArtifactParam()
    {
    }
  }
}
