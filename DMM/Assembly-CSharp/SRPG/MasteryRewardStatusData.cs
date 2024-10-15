// Decompiled with JetBrains decompiler
// Type: SRPG.MasteryRewardStatusData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BE6")]
  public class MasteryRewardStatusData
  {
    [Token(Token = "0x4006BE3")]
    [FieldOffset(Offset = "0x8")]
    public string Iname;
    [Token(Token = "0x4006BE4")]
    [FieldOffset(Offset = "0xC")]
    public MasteryRewardStatus Status;

    [Token(Token = "0x6007317")]
    [Address(RVA = "0x372170", Offset = "0x370F70", VA = "0x10372170")]
    public bool Deserialize(JSON_MasteryRewardStatusData json) => new bool();

    [Token(Token = "0x6007318")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public MasteryRewardStatusData()
    {
    }
  }
}
