// Decompiled with JetBrains decompiler
// Type: SRPG.TowerParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D73")]
  public class TowerParam
  {
    [Token(Token = "0x4007448")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007449")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x400744A")]
    [FieldOffset(Offset = "0x10")]
    public string expr;
    [Token(Token = "0x400744B")]
    [FieldOffset(Offset = "0x14")]
    public string banr;
    [Token(Token = "0x400744C")]
    [FieldOffset(Offset = "0x18")]
    public string bg;
    [Token(Token = "0x400744D")]
    [FieldOffset(Offset = "0x1C")]
    public string floor_bg_open;
    [Token(Token = "0x400744E")]
    [FieldOffset(Offset = "0x20")]
    public string floor_bg_close;
    [Token(Token = "0x400744F")]
    [FieldOffset(Offset = "0x24")]
    public short unit_recover_minute;
    [Token(Token = "0x4007450")]
    [FieldOffset(Offset = "0x26")]
    public short unit_recover_coin;
    [Token(Token = "0x4007451")]
    [FieldOffset(Offset = "0x28")]
    public string prefabPath;
    [Token(Token = "0x4007452")]
    [FieldOffset(Offset = "0x2C")]
    public string eventURL;
    [Token(Token = "0x4007453")]
    [FieldOffset(Offset = "0x30")]
    public bool can_unit_recover;
    [Token(Token = "0x4007454")]
    [FieldOffset(Offset = "0x31")]
    public bool is_down;
    [Token(Token = "0x4007455")]
    [FieldOffset(Offset = "0x32")]
    public bool is_view_ranking;
    [Token(Token = "0x4007456")]
    [FieldOffset(Offset = "0x34")]
    public short unlock_level;
    [Token(Token = "0x4007457")]
    [FieldOffset(Offset = "0x38")]
    public string unlock_quest;
    [Token(Token = "0x4007458")]
    [FieldOffset(Offset = "0x3C")]
    public bool is_unlock;
    [Token(Token = "0x4007459")]
    [FieldOffset(Offset = "0x40")]
    public string URL;
    [Token(Token = "0x400745A")]
    [FieldOffset(Offset = "0x44")]
    public short floor_reset_coin;
    [Token(Token = "0x400745B")]
    [FieldOffset(Offset = "0x48")]
    public string score_iname;

    [Token(Token = "0x6007895")]
    [Address(RVA = "0x3A5870", Offset = "0x3A4670", VA = "0x103A5870")]
    public void Deserialize(JSON_TowerParam json)
    {
    }

    [Token(Token = "0x6007896")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TowerParam()
    {
    }
  }
}
