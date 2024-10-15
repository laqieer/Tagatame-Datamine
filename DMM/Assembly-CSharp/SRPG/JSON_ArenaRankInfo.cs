// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ArenaRankInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E4F")]
  public class JSON_ArenaRankInfo
  {
    [Token(Token = "0x4002B91")]
    [FieldOffset(Offset = "0x8")]
    public int rank;
    [Token(Token = "0x4002B92")]
    [FieldOffset(Offset = "0xC")]
    public int up;
    [Token(Token = "0x4002B93")]
    [FieldOffset(Offset = "0x10")]
    public int is_best;

    [Token(Token = "0x6003B05")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ArenaRankInfo()
    {
    }
  }
}
