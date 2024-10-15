// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ExtraQuestClearElementProgress
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C44")]
  [MessagePackObject(true)]
  public class JSON_ExtraQuestClearElementProgress
  {
    [Token(Token = "0x4006E5C")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006E5D")]
    [FieldOffset(Offset = "0xC")]
    public int[] types;

    [Token(Token = "0x6007416")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ExtraQuestClearElementProgress()
    {
    }
  }
}
