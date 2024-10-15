// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_PointQuestRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002819")]
  [MessagePackObject(true)]
  public class JSON_PointQuestRewardData
  {
    [Token(Token = "0x400BF15")]
    [FieldOffset(Offset = "0x8")]
    public int item_itype;
    [Token(Token = "0x400BF16")]
    [FieldOffset(Offset = "0xC")]
    public string item_iname;
    [Token(Token = "0x400BF17")]
    [FieldOffset(Offset = "0x10")]
    public int item_num;

    [Token(Token = "0x600B510")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_PointQuestRewardData()
    {
    }
  }
}
