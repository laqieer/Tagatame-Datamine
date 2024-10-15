// Decompiled with JetBrains decompiler
// Type: SRPG.Json_DropInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F19")]
  [MessagePackObject(true)]
  public class Json_DropInfo
  {
    [Token(Token = "0x4002EE8")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4002EE9")]
    [FieldOffset(Offset = "0xC")]
    public int num;
    [Token(Token = "0x4002EEA")]
    [FieldOffset(Offset = "0x10")]
    public string iname_origin;
    [Token(Token = "0x4002EEB")]
    [FieldOffset(Offset = "0x14")]
    public string type;
    [Token(Token = "0x4002EEC")]
    [FieldOffset(Offset = "0x18")]
    public int is_new;
    [Token(Token = "0x4002EED")]
    [FieldOffset(Offset = "0x1C")]
    public int rare;
    [Token(Token = "0x4002EEE")]
    [FieldOffset(Offset = "0x20")]
    public string get_unit;
    [Token(Token = "0x4002EEF")]
    [FieldOffset(Offset = "0x24")]
    public int is_gift;
    [Token(Token = "0x4002EF0")]
    [FieldOffset(Offset = "0x28")]
    public int is_feature_item;
    [Token(Token = "0x4002EF1")]
    [FieldOffset(Offset = "0x2C")]
    public int ch_piece_coin_num;
    [Token(Token = "0x4002EF2")]
    [FieldOffset(Offset = "0x30")]
    public int is_pickup;
    [Token(Token = "0x4002EF3")]
    [FieldOffset(Offset = "0x34")]
    public int is_disassemble;
    [Token(Token = "0x4002EF4")]
    [FieldOffset(Offset = "0x38")]
    public int rank;

    [Token(Token = "0x6003F0A")]
    [Address(RVA = "0x1182B40", Offset = "0x1181940", VA = "0x11182B40")]
    public Json_DropInfo()
    {
    }
  }
}
