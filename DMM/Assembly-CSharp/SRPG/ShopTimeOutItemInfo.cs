// Decompiled with JetBrains decompiler
// Type: SRPG.ShopTimeOutItemInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001126")]
  [Serializable]
  public class ShopTimeOutItemInfo
  {
    [Token(Token = "0x4003E48")]
    [FieldOffset(Offset = "0x8")]
    public string ShopId;
    [Token(Token = "0x4003E49")]
    [FieldOffset(Offset = "0xC")]
    public int ItemId;
    [Token(Token = "0x4003E4A")]
    [FieldOffset(Offset = "0x10")]
    public long End;

    [Token(Token = "0x600488C")]
    [Address(RVA = "0x11F7F10", Offset = "0x11F6D10", VA = "0x111F7F10")]
    public ShopTimeOutItemInfo(string shopId, int itemId, long end)
    {
    }
  }
}
