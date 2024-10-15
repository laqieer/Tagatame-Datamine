// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RankingBaseData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003386")]
  public class RankingBaseData
  {
    [Token(Token = "0x400F3C8")]
    private const int OUT_OF_RANK_VALUE = -1;
    [Token(Token = "0x400F3C9")]
    private const int SIMPLE_RANK_TEXT_THRESHOLD = 4;

    [Token(Token = "0x600E547")]
    [Address(RVA = "0xABF900", Offset = "0xABE700", VA = "0x10ABF900")]
    public static string GetRankText(int _rank) => (string) null;

    [Token(Token = "0x600E548")]
    [Address(RVA = "0xABFA40", Offset = "0xABE840", VA = "0x10ABFA40")]
    public static bool IsRankTextDraw(int _rank) => new bool();

    [Token(Token = "0x600E549")]
    [Address(RVA = "0xABF8C0", Offset = "0xABE6C0", VA = "0x10ABF8C0")]
    public static int GetRankImage(int _rank) => new int();

    [Token(Token = "0x600E54A")]
    [Address(RVA = "0xABF810", Offset = "0xABE610", VA = "0x10ABF810")]
    public static int GetRankImageIndex(ImageArray _image, int _rank) => new int();

    [Token(Token = "0x600E54B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RankingBaseData()
    {
    }
  }
}
