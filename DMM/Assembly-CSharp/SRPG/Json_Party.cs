// Decompiled with JetBrains decompiler
// Type: SRPG.Json_Party
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200100E")]
  [MessagePackObject(true)]
  public class Json_Party
  {
    [Token(Token = "0x4003913")]
    [FieldOffset(Offset = "0x8")]
    public string ptype;
    [Token(Token = "0x4003914")]
    [FieldOffset(Offset = "0xC")]
    public long[] units;
    [Token(Token = "0x4003915")]
    [FieldOffset(Offset = "0x10")]
    public int flg_sel;
    [Token(Token = "0x4003916")]
    [FieldOffset(Offset = "0x14")]
    public int flg_seldef;

    [Token(Token = "0x6004272")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_Party()
    {
    }
  }
}
