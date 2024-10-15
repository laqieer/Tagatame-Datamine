// Decompiled with JetBrains decompiler
// Type: SRPG.TwitterMessageParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DBE")]
  public class TwitterMessageParam
  {
    [Token(Token = "0x4007670")]
    [FieldOffset(Offset = "0x8")]
    private eTwitterMessageId id;
    [Token(Token = "0x4007671")]
    [FieldOffset(Offset = "0xC")]
    private TwitterMessageDetailParam[] detail;

    [Token(Token = "0x17001072")]
    public eTwitterMessageId Id
    {
      [Token(Token = "0x60079BB"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new eTwitterMessageId();
      }
    }

    [Token(Token = "0x17001073")]
    public TwitterMessageDetailParam[] Detail
    {
      [Token(Token = "0x60079BC"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (TwitterMessageDetailParam[]) null;
      }
    }

    [Token(Token = "0x60079BD")]
    [Address(RVA = "0x3C2580", Offset = "0x3C1380", VA = "0x103C2580")]
    public void Deserialize(JSON_TwitterMessageParam json)
    {
    }

    [Token(Token = "0x60079BE")]
    [Address(RVA = "0x3C2320", Offset = "0x3C1120", VA = "0x103C2320")]
    public static void Deserialize(ref TwitterMessageParam[] param, JSON_TwitterMessageParam[] json)
    {
    }

    [Token(Token = "0x60079BF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TwitterMessageParam()
    {
    }
  }
}
