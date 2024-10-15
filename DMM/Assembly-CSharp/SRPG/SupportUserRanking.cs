// Decompiled with JetBrains decompiler
// Type: SRPG.SupportUserRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B17")]
  public class SupportUserRanking
  {
    [Token(Token = "0x400D253")]
    [FieldOffset(Offset = "0x8")]
    public int rank;
    [Token(Token = "0x400D254")]
    [FieldOffset(Offset = "0xC")]
    public int score;
    [Token(Token = "0x400D255")]
    [FieldOffset(Offset = "0x10")]
    public UnitData unit;
    [Token(Token = "0x400D256")]
    [FieldOffset(Offset = "0x14")]
    public string uid;
    [Token(Token = "0x400D257")]
    [FieldOffset(Offset = "0x18")]
    public int lv;
    [Token(Token = "0x400D258")]
    [FieldOffset(Offset = "0x1C")]
    public string name;
    [Token(Token = "0x400D259")]
    [FieldOffset(Offset = "0x20")]
    public string award;
    [Token(Token = "0x400D25A")]
    [FieldOffset(Offset = "0x24")]
    public string guildName;
    [Token(Token = "0x400D25B")]
    [FieldOffset(Offset = "0x28")]
    public int guildId;

    [Token(Token = "0x600C53F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SupportUserRanking()
    {
    }
  }
}
