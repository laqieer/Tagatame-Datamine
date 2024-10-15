// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_Map
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000BFE")]
  public class JSON_Map
  {
    [Token(Token = "0x4001E9D")]
    [FieldOffset(Offset = "0x8")]
    public int w;
    [Token(Token = "0x4001E9E")]
    [FieldOffset(Offset = "0xC")]
    public int h;
    [Token(Token = "0x4001E9F")]
    [FieldOffset(Offset = "0x10")]
    public JSON_MapGrid[] grid;
    [Token(Token = "0x4001EA0")]
    [FieldOffset(Offset = "0x14")]
    public string description;

    [Token(Token = "0x6003004")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_Map()
    {
    }
  }
}
