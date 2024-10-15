// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_DuelRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200230B")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_DuelRewardData
  {
    [Token(Token = "0x4009C5F")]
    [FieldOffset(Offset = "0x8")]
    public string item_iname;
    [Token(Token = "0x4009C60")]
    [FieldOffset(Offset = "0xC")]
    public int item_type;
    [Token(Token = "0x4009C61")]
    [FieldOffset(Offset = "0x10")]
    public int item_num;

    [Token(Token = "0x60096CD")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_DuelRewardData()
    {
    }
  }
}
