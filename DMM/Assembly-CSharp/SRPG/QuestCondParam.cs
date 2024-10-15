// Decompiled with JetBrains decompiler
// Type: SRPG.QuestCondParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C39")]
  public class QuestCondParam
  {
    [Token(Token = "0x4006DAD")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006DAE")]
    [FieldOffset(Offset = "0xC")]
    public int plvmax;
    [Token(Token = "0x4006DAF")]
    [FieldOffset(Offset = "0x10")]
    public int plvmin;
    [Token(Token = "0x4006DB0")]
    [FieldOffset(Offset = "0x14")]
    public int ulvmax;
    [Token(Token = "0x4006DB1")]
    [FieldOffset(Offset = "0x18")]
    public int ulvmin;
    [Token(Token = "0x4006DB2")]
    [FieldOffset(Offset = "0x1C")]
    public int[] elem;
    [Token(Token = "0x4006DB3")]
    [FieldOffset(Offset = "0x20")]
    public bool isElemLimit;
    [Token(Token = "0x4006DB4")]
    [FieldOffset(Offset = "0x24")]
    public string[] job;
    [Token(Token = "0x4006DB5")]
    [FieldOffset(Offset = "0x28")]
    public PartyCondType party_type;
    [Token(Token = "0x4006DB6")]
    [FieldOffset(Offset = "0x2C")]
    public string[] unit;
    [Token(Token = "0x4006DB7")]
    [FieldOffset(Offset = "0x30")]
    public ESex sex;
    [Token(Token = "0x4006DB8")]
    [FieldOffset(Offset = "0x34")]
    public int rmax;
    [Token(Token = "0x4006DB9")]
    [FieldOffset(Offset = "0x38")]
    public int rmin;
    [Token(Token = "0x4006DBA")]
    [FieldOffset(Offset = "0x3C")]
    public int rmax_ini;
    [Token(Token = "0x4006DBB")]
    [FieldOffset(Offset = "0x40")]
    public int rmin_ini;
    [Token(Token = "0x4006DBC")]
    [FieldOffset(Offset = "0x44")]
    public int hmax;
    [Token(Token = "0x4006DBD")]
    [FieldOffset(Offset = "0x48")]
    public int hmin;
    [Token(Token = "0x4006DBE")]
    [FieldOffset(Offset = "0x4C")]
    public int wmax;
    [Token(Token = "0x4006DBF")]
    [FieldOffset(Offset = "0x50")]
    public int wmin;
    [Token(Token = "0x4006DC0")]
    [FieldOffset(Offset = "0x54")]
    public int[] jobset;
    [Token(Token = "0x4006DC1")]
    [FieldOffset(Offset = "0x58")]
    public string[] birth;
    [Token(Token = "0x4006DC2")]
    [FieldOffset(Offset = "0x5C")]
    public bool is_not_solo;

    [Token(Token = "0x600740F")]
    [Address(RVA = "0x382B60", Offset = "0x381960", VA = "0x10382B60")]
    public bool Deserialize(JSON_QuestCondParam json) => new bool();

    [Token(Token = "0x6007410")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public QuestCondParam()
    {
    }
  }
}
