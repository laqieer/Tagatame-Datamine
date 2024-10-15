// Decompiled with JetBrains decompiler
// Type: SRPG.PlayerCoinBuyUseBonusState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A53")]
  public class PlayerCoinBuyUseBonusState
  {
    [Token(Token = "0x400611D")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400611E")]
    [FieldOffset(Offset = "0xC")]
    public int total;

    [Token(Token = "0x6006C37")]
    [Address(RVA = "0x359F00", Offset = "0x358D00", VA = "0x10359F00")]
    public void Deserialize(JSON_PlayerCoinBuyUseBonusState bonus_state)
    {
    }

    [Token(Token = "0x6006C38")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PlayerCoinBuyUseBonusState()
    {
    }
  }
}
