// Decompiled with JetBrains decompiler
// Type: SRPG.VersusCoinParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EB1")]
  public class VersusCoinParam
  {
    [Token(Token = "0x400808E")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400808F")]
    [FieldOffset(Offset = "0xC")]
    public string coin_iname;
    [Token(Token = "0x4008090")]
    [FieldOffset(Offset = "0x10")]
    public int win_cnt;
    [Token(Token = "0x4008091")]
    [FieldOffset(Offset = "0x14")]
    public int lose_cnt;
    [Token(Token = "0x4008092")]
    [FieldOffset(Offset = "0x18")]
    public int draw_cnt;

    [Token(Token = "0x6007DCA")]
    [Address(RVA = "0x3F8050", Offset = "0x3F6E50", VA = "0x103F8050")]
    public void Deserialize(JSON_VersusCoin json)
    {
    }

    [Token(Token = "0x6007DCB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusCoinParam()
    {
    }
  }
}
