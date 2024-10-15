// Decompiled with JetBrains decompiler
// Type: SRPG.VersusStatusData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011E0")]
  public class VersusStatusData
  {
    [Token(Token = "0x4004101")]
    [FieldOffset(Offset = "0x8")]
    public int Hp;
    [Token(Token = "0x4004102")]
    [FieldOffset(Offset = "0xC")]
    public int Atk;
    [Token(Token = "0x4004103")]
    [FieldOffset(Offset = "0x10")]
    public int Def;
    [Token(Token = "0x4004104")]
    [FieldOffset(Offset = "0x14")]
    public int Matk;
    [Token(Token = "0x4004105")]
    [FieldOffset(Offset = "0x18")]
    public int Mdef;
    [Token(Token = "0x4004106")]
    [FieldOffset(Offset = "0x1C")]
    public int Dex;
    [Token(Token = "0x4004107")]
    [FieldOffset(Offset = "0x20")]
    public int Spd;
    [Token(Token = "0x4004108")]
    [FieldOffset(Offset = "0x24")]
    public int Cri;
    [Token(Token = "0x4004109")]
    [FieldOffset(Offset = "0x28")]
    public int Luck;
    [Token(Token = "0x400410A")]
    [FieldOffset(Offset = "0x2C")]
    public int Cmb;
    [Token(Token = "0x400410B")]
    [FieldOffset(Offset = "0x30")]
    public int Move;
    [Token(Token = "0x400410C")]
    [FieldOffset(Offset = "0x34")]
    public int Jmp;

    [Token(Token = "0x6004BC8")]
    [Address(RVA = "0x1221AF0", Offset = "0x12208F0", VA = "0x11221AF0")]
    public void Add(StatusParam status, int comb)
    {
    }

    [Token(Token = "0x6004BC9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusStatusData()
    {
    }
  }
}
