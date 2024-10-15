// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_MapPartyUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C06")]
  public class JSON_MapPartyUnit
  {
    [Token(Token = "0x4001EC3")]
    [FieldOffset(Offset = "0x8")]
    public string name;
    [Token(Token = "0x4001EC4")]
    [FieldOffset(Offset = "0xC")]
    public string ai;
    [Token(Token = "0x4001EC5")]
    [FieldOffset(Offset = "0x10")]
    public int x;
    [Token(Token = "0x4001EC6")]
    [FieldOffset(Offset = "0x14")]
    public int y;
    [Token(Token = "0x4001EC7")]
    [FieldOffset(Offset = "0x18")]
    public int dir;
    [Token(Token = "0x4001EC8")]
    [FieldOffset(Offset = "0x1C")]
    public int wait_e;
    [Token(Token = "0x4001EC9")]
    [FieldOffset(Offset = "0x20")]
    public int wait_m;
    [Token(Token = "0x4001ECA")]
    [FieldOffset(Offset = "0x24")]
    public int wait_exit;
    [Token(Token = "0x4001ECB")]
    [FieldOffset(Offset = "0x28")]
    public int ct_calc;
    [Token(Token = "0x4001ECC")]
    [FieldOffset(Offset = "0x2C")]
    public int ct_val;
    [Token(Token = "0x4001ECD")]
    [FieldOffset(Offset = "0x30")]
    public int fvoff;
    [Token(Token = "0x4001ECE")]
    [FieldOffset(Offset = "0x34")]
    public int ai_type;
    [Token(Token = "0x4001ECF")]
    [FieldOffset(Offset = "0x38")]
    public int ai_x;
    [Token(Token = "0x4001ED0")]
    [FieldOffset(Offset = "0x3C")]
    public int ai_y;
    [Token(Token = "0x4001ED1")]
    [FieldOffset(Offset = "0x40")]
    public int ai_len;
    [Token(Token = "0x4001ED2")]
    [FieldOffset(Offset = "0x44")]
    public string parent;
    [Token(Token = "0x4001ED3")]
    [FieldOffset(Offset = "0x48")]
    public JSON_EventTrigger trg;
    [Token(Token = "0x4001ED4")]
    [FieldOffset(Offset = "0x4C")]
    public UnitEntryTrigger[] entries;
    [Token(Token = "0x4001ED5")]
    [FieldOffset(Offset = "0x50")]
    public int entries_and;

    [Token(Token = "0x6003013")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_MapPartyUnit()
    {
    }
  }
}
