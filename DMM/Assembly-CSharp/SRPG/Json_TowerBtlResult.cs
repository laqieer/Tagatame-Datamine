// Decompiled with JetBrains decompiler
// Type: SRPG.Json_TowerBtlResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015B8")]
  public class Json_TowerBtlResult : Json_PlayerDataAll
  {
    [Token(Token = "0x4004F10")]
    [FieldOffset(Offset = "0xB0")]
    public JSON_ReqTowerResuponse.Json_TowerPlayerUnit[] pdeck;
    [Token(Token = "0x4004F11")]
    [FieldOffset(Offset = "0xB4")]
    public Json_Artifact[] artis;
    [Token(Token = "0x4004F12")]
    [FieldOffset(Offset = "0xB8")]
    public int arrived_num;
    [Token(Token = "0x4004F13")]
    [FieldOffset(Offset = "0xBC")]
    public int clear;
    [Token(Token = "0x4004F14")]
    [FieldOffset(Offset = "0xC0")]
    public Json_TowerBtlEndRank ranking;

    [Token(Token = "0x6005969")]
    [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
    public Json_TowerBtlResult()
    {
    }
  }
}
