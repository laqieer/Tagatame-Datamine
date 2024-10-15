// Decompiled with JetBrains decompiler
// Type: SRPG.Json_VersusCpuData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011DE")]
  public class Json_VersusCpuData
  {
    [Token(Token = "0x40040F4")]
    [FieldOffset(Offset = "0x8")]
    public string name;
    [Token(Token = "0x40040F5")]
    [FieldOffset(Offset = "0xC")]
    public int lv;
    [Token(Token = "0x40040F6")]
    [FieldOffset(Offset = "0x10")]
    public Json_Unit[] units;
    [Token(Token = "0x40040F7")]
    [FieldOffset(Offset = "0x14")]
    public int[] place;
    [Token(Token = "0x40040F8")]
    [FieldOffset(Offset = "0x18")]
    public int score;

    [Token(Token = "0x6004BC4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_VersusCpuData()
    {
    }
  }
}
