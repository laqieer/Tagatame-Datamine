// Decompiled with JetBrains decompiler
// Type: SRPG.Json_BtlInfo_Multi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003107")]
  public class Json_BtlInfo_Multi : BattleCore.Json_BtlInfo
  {
    [Token(Token = "0x400EC6F")]
    [FieldOffset(Offset = "0x98")]
    public string plid;
    [Token(Token = "0x400EC70")]
    [FieldOffset(Offset = "0x9C")]
    public string seat;
    [Token(Token = "0x400EC71")]
    [FieldOffset(Offset = "0xA0")]
    public int floor;

    [Token(Token = "0x600DD9A")]
    [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
    public Json_BtlInfo_Multi()
    {
    }
  }
}
