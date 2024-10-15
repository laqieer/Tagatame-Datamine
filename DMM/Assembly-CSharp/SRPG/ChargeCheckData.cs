// Decompiled with JetBrains decompiler
// Type: SRPG.ChargeCheckData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E82")]
  public class ChargeCheckData
  {
    [Token(Token = "0x4002C86")]
    [FieldOffset(Offset = "0x8")]
    public int Age;
    [Token(Token = "0x4002C87")]
    [FieldOffset(Offset = "0xC")]
    public string[] AcceptIds;
    [Token(Token = "0x4002C88")]
    [FieldOffset(Offset = "0x10")]
    public string[] RejectIds;

    [Token(Token = "0x6003C2B")]
    [Address(RVA = "0x10EAAC0", Offset = "0x10E98C0", VA = "0x110EAAC0")]
    public bool Deserialize(JSON_ChargeCheckResponse json) => new bool();

    [Token(Token = "0x6003C2C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ChargeCheckData()
    {
    }
  }
}
