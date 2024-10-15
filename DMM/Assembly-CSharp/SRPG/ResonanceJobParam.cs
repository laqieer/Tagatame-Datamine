// Decompiled with JetBrains decompiler
// Type: SRPG.ResonanceJobParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CB5")]
  [MessagePackObject(true)]
  public class ResonanceJobParam
  {
    [Token(Token = "0x40070AD")]
    [FieldOffset(Offset = "0x8")]
    public string iname;

    [Token(Token = "0x600762D")]
    [Address(RVA = "0x378CC0", Offset = "0x377AC0", VA = "0x10378CC0")]
    public bool Deserialize(JSON_ResonanceJobParam json) => new bool();

    [Token(Token = "0x600762E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ResonanceJobParam()
    {
    }
  }
}
