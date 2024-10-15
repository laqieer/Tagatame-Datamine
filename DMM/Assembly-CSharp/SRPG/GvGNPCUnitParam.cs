// Decompiled with JetBrains decompiler
// Type: SRPG.GvGNPCUnitParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B80")]
  public class GvGNPCUnitParam : VersusDraftUnitParam
  {
    [Token(Token = "0x6007194")]
    [Address(RVA = "0x373220", Offset = "0x372020", VA = "0x10373220")]
    public bool Deserialize(JSON_GvGNPCUnitParam json) => new bool();

    [Token(Token = "0x6007195")]
    [Address(RVA = "0x3731B0", Offset = "0x371FB0", VA = "0x103731B0")]
    public GvGPartyUnit CreateUnitData() => (GvGPartyUnit) null;

    [Token(Token = "0x6007196")]
    [Address(RVA = "0x372FB0", Offset = "0x371DB0", VA = "0x10372FB0")]
    public static GvGPartyUnit CreateNPCUnitData(int id) => (GvGPartyUnit) null;

    [Token(Token = "0x6007197")]
    [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
    public GvGNPCUnitParam()
    {
    }
  }
}
