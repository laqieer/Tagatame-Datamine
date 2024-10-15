// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_StoryExChallengeCount
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C42")]
  [MessagePackObject(true)]
  public class JSON_StoryExChallengeCount
  {
    [Token(Token = "0x4006E58")]
    [FieldOffset(Offset = "0x8")]
    public int num;
    [Token(Token = "0x4006E59")]
    [FieldOffset(Offset = "0xC")]
    public int reset;

    [Token(Token = "0x6007414")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_StoryExChallengeCount()
    {
    }
  }
}
