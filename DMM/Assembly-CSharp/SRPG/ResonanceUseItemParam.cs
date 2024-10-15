// Decompiled with JetBrains decompiler
// Type: SRPG.ResonanceUseItemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CC1")]
  [MessagePackObject(true)]
  public class ResonanceUseItemParam
  {
    [Token(Token = "0x40070CD")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40070CE")]
    [FieldOffset(Offset = "0xC")]
    public int num;

    [Token(Token = "0x600764F")]
    [Address(RVA = "0x372170", Offset = "0x370F70", VA = "0x10372170")]
    public bool Deserialize(JSON_ResonanceUseItemParam json) => new bool();

    [Token(Token = "0x6007650")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ResonanceUseItemParam()
    {
    }
  }
}
