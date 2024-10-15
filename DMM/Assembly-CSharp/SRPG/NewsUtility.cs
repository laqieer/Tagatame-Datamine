// Decompiled with JetBrains decompiler
// Type: SRPG.NewsUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FE2")]
  public class NewsUtility
  {
    [Token(Token = "0x6004217")]
    [Address(RVA = "0x119AB80", Offset = "0x1199980", VA = "0x1119AB80")]
    public static bool isNewsDisplay() => new bool();

    [Token(Token = "0x6004218")]
    [Address(RVA = "0x119AA80", Offset = "0x1199880", VA = "0x1119AA80")]
    public static void clearNewsType()
    {
    }

    [Token(Token = "0x6004219")]
    [Address(RVA = "0x119AC20", Offset = "0x1199A20", VA = "0x1119AC20")]
    public static void setNewsState(string pub_hash, string urgency_pub_hash, bool force_display)
    {
    }

    [Token(Token = "0x600421A")]
    [Address(RVA = "0x119AAF0", Offset = "0x11998F0", VA = "0x1119AAF0")]
    public static NewsUtility.NewsTypes getNewsTypes() => new NewsUtility.NewsTypes();

    [Token(Token = "0x600421B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public NewsUtility()
    {
    }

    [Token(Token = "0x2000FE3")]
    public enum NewsTypes
    {
      [Token(Token = "0x400382A")] None,
      [Token(Token = "0x400382B")] Normal,
      [Token(Token = "0x400382C")] Urgency,
    }
  }
}
