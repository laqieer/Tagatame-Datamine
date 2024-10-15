// Decompiled with JetBrains decompiler
// Type: SRPG.AbilityUnlockInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B9F")]
  public class AbilityUnlockInfo
  {
    [Token(Token = "0x400D633")]
    [FieldOffset(Offset = "0x8")]
    public string JobName;
    [Token(Token = "0x400D634")]
    [FieldOffset(Offset = "0xC")]
    public int Rank;

    [Token(Token = "0x600C85A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AbilityUnlockInfo()
    {
    }
  }
}
