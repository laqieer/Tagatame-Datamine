// Decompiled with JetBrains decompiler
// Type: SRPG.TowerScoreParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D80")]
  public class TowerScoreParam
  {
    [Token(Token = "0x4007495")]
    [FieldOffset(Offset = "0x8")]
    public string Rank;
    [Token(Token = "0x4007496")]
    [FieldOffset(Offset = "0xC")]
    public OInt Score;
    [Token(Token = "0x4007497")]
    [FieldOffset(Offset = "0x20")]
    public OInt TurnCnt;
    [Token(Token = "0x4007498")]
    [FieldOffset(Offset = "0x34")]
    public OInt DiedCnt;
    [Token(Token = "0x4007499")]
    [FieldOffset(Offset = "0x48")]
    public OInt RetireCnt;
    [Token(Token = "0x400749A")]
    [FieldOffset(Offset = "0x5C")]
    public OInt RecoverCnt;

    [Token(Token = "0x60078A6")]
    [Address(RVA = "0x3A5FD0", Offset = "0x3A4DD0", VA = "0x103A5FD0")]
    public bool Deserialize(JSON_TowerScoreThreshold json) => new bool();

    [Token(Token = "0x60078A7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TowerScoreParam()
    {
    }
  }
}
