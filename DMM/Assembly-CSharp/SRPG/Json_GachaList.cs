// Decompiled with JetBrains decompiler
// Type: SRPG.Json_GachaList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018BB")]
  public class Json_GachaList
  {
    [Token(Token = "0x400590D")]
    [FieldOffset(Offset = "0x8")]
    public Json_GachaParam[] gachas;
    [Token(Token = "0x400590E")]
    [FieldOffset(Offset = "0xC")]
    public Json_GachaOption options;

    [Token(Token = "0x600636B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_GachaList()
    {
    }
  }
}
